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

                if (source == "" || source.Substring(0, 7) == "[ERROR]")
                {
                    Action action = () => CheckItemError(item, source.Substring(7), logString);
                    this.Invoke(action);
                }

                else
                {
                    Action action = () => CheckItemCompleted(item, checksum, logString);
                    this.Invoke(action);
                }
            }

            catch { }
        }

        private void CheckItemCompleted(ListViewItem item, string checksum, string logString)
        {
            try
            {
                if (!formClosing)
                {
                    item.SubItems[ITEM_LAST].Text = lastUpdated = DateTime.Now.ToString(dateString);
                    item.SubItems[ITEM_STATUS].Text = "OK";

                    if (item.SubItems[ITEM_CHECKSUM].Text != "-")
                    {
                        if (item.SubItems[ITEM_CHECKSUM].Text != checksum)
                        {
                            item.SubItems[ITEM_CHECKSUM].Text = checksum;
                            item.Tag = Status.Updated;

                            CheckSelectedActions();
                            SaveList();
                            CreateNotification("Web page updated!", item.SubItems[ITEM_NAME].Text, item.SubItems[ITEM_ADDRESS].Text);

                            if (menuItem_SaveLog.Checked) File.AppendAllText(logFile, "Page updated      " + logString);
                        }

                        else
                        {
                            if (item.Tag.ToString() == Status.Error.ToString()) item.Tag = Status.NotUpdated;
                            if (menuItem_SaveLog.Checked) File.AppendAllText(logFile, "Page not updated  " + logString);
                        }
                    }

                    CheckSelectedActions();
                }
            }

            catch { }
        }

        private void CheckItemError(ListViewItem item, string error, string logString)
        {
            try
            {
                if (!formClosing)
                {
                    item.SubItems[ITEM_LAST].Text = lastUpdated = DateTime.Now.ToString(dateString);
                    item.SubItems[ITEM_STATUS].Text = "ERROR - " + error;
                    item.Tag = Status.Error;

                    if (menuItem_SaveLog.Checked) File.AppendAllText(logFile, "Failed to connect " + logString);
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
