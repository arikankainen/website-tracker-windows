using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteTracker
{
    public partial class Form1
    {
        private string logFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "check.log");
        private string dateString = @"dd.MM.yyyy HH:mm:ss";

        private void WatchList(bool forceCheck)
        {
            try
            {
                foreach (ListViewItem item in lstItems.Items)
                {
                    WatchItem(item, forceCheck);
                }
            }

            catch { }
        }

        private void WatchItem(ListViewItem item, bool forceCheck)
        {
            if (item.SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                if (forceCheck || item.SubItems[ITEM_ENABLED].Text != "")
                {
                    DateTime now = DateTime.Now;
                    DateTime lastCheck = DateTime.MinValue;
                    DateTime.TryParse(item.SubItems[ITEM_LAST].Text, out lastCheck);

                    Match m = Regex.Match(item.SubItems[ITEM_INTERVAL].Text, @"(\d+)d (\d+)h (\d+)m");
                    int days = Convert.ToInt32(m.Groups[1].Value);
                    int hours = Convert.ToInt32(m.Groups[2].Value);
                    int minutes = Convert.ToInt32(m.Groups[3].Value);

                    DateTime nextCheck = lastCheck.AddDays(days).AddHours(hours).AddMinutes(minutes);

                    if (now >= nextCheck || forceCheck)
                    {
                        item.SubItems[ITEM_LAST].Text = TEXT_CHECKING;
                        CheckSelectedActions();

                        Thread thread = new Thread(() => CheckItem(item));
                        thread.IsBackground = true;
                        thread.Start();
                    }
                }
            }
        }

        private void CheckItem(ListViewItem item)
        {
            try
            {
                string logString = "[" + DateTime.Now.ToString(dateString) + "] " + item.SubItems[ITEM_ADDRESS].Text + Environment.NewLine;

                string source = CheckChanges.GetSource(item.SubItems[ITEM_ADDRESS].Text);
                string start = item.SubItems[ITEM_START].Text;
                string stop = item.SubItems[ITEM_STOP].Text;
                string checksum = CheckChanges.GetChecksum(source, start, stop);

                Action action = () => CheckItemCompleted(item, checksum, logString);
                this.Invoke(action);
            }

            catch { }
        }

        private void CheckItemCompleted(ListViewItem item, string checksum, string logString)
        {
            try
            {
                if (!formClosing)
                {
                    File.AppendAllText(logFile, logString);
                    item.SubItems[ITEM_LAST].Text = DateTime.Now.ToString(dateString);

                    if (item.SubItems[ITEM_CHECKSUM].Text != "-")
                    {
                        if (item.SubItems[ITEM_CHECKSUM].Text != checksum)
                        {
                            item.SubItems[ITEM_CHECKSUM].Text = checksum;
                            item.ForeColor = setUpdatedItemColor;
                            item.Font = setUpdatedItemFont;

                            CheckSelectedActions();
                            CreateNotification("Web page updated!", item.SubItems[ITEM_NAME].Text, item.SubItems[ITEM_ADDRESS].Text);
                        }
                    }

                    CheckSelectedActions();
                }
            }

            catch { }
        }

        private void CreateNotification(string title, string text, string address)
        {
            if (menuItem_ShowNotifications.Checked)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipTitle = title;
                notifyIcon1.BalloonTipText = text + Environment.NewLine + address;
                notifyIcon1.ShowBalloonTip(4000);
            }
        }

        /*************************************************************************/
        // EVENTS
        /*************************************************************************/

        private void timerCheckList_Tick(object sender, EventArgs e)
        {
            WatchList(false);
        }
    }
}
