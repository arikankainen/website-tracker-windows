﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WebsiteTracker
{
    public partial class Form1 : Form
    {
        private Settings settings = new Settings();

        private string listFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "list.lst");
        private char listFileSeparator = '|';
        private string separatorString = "!#PIPE#CHARACTER#!";

        private const int ITEM_NAME = 0;
        private const int ITEM_ENABLED = 1;
        private const int ITEM_ADDRESS = 2;
        private const int ITEM_INTERVAL = 3;
        private const int ITEM_START = 4;
        private const int ITEM_STOP = 5;
        private const int ITEM_CHECKSUM = 6;
        private const int ITEM_LAST = 7;
        private const int ITEM_CHANGED = 8;

        private const string TEXT_CHECKING = "Checking...";

        private int width;
        private int height;
        private int left;
        private int top;
        private bool maximized;
        private bool sizeLoaded = false;

        private bool formClosing = false;

        private const int DEFAULT_WIDTH = 1192;
        private const int DEFAULT_HEIGHT = 400;
        private const int MIN_WIDTH = 500;
        private const int MIN_HEIGHT = 200;

        private Color setUpdatedItemColor;
        private Font setUpdatedItemFont;
        private Color setNormalItemColor;
        private Font setNormalItemFont;

        private string setCustomBrowser;
        private bool setUseCustomBrowser;

        private string appRegistryName = "ak_websitetracker";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (rk.GetValue(appRegistryName, "").ToString() != "") menuItem_StartAutomatically.Checked = true;
                else menuItem_StartAutomatically.Checked = false;
            }

            catch { }

            menuItem_RememberWindowSize.Checked = settings.LoadSetting("RememberSize", "bool", "true");
            menuItem_RememberWindowPosition.Checked = settings.LoadSetting("RememberPosition", "bool", "true");
            menuItem_RememberColumnSizes.Checked = settings.LoadSetting("RememberColumnWidth", "bool", "true");
            menuItem_ShowNotifications.Checked = settings.LoadSetting("ShowNotifications", "bool", "true");
            menuItem_StartAutomatically.Checked = settings.LoadSetting("StartAutomatically", "bool", "false");
            menuItem_StartMinimized.Checked = settings.LoadSetting("StartMinimized", "bool", "false");
            menuItem_MinimizeToTray.Checked = settings.LoadSetting("MinimizeToTray", "bool", "false");
            setCustomBrowser = settings.LoadSetting("CustomBrowser");
            setUseCustomBrowser = settings.LoadSetting("UseCustomBrowser", "bool", "false");

            setUpdatedItemColor = ColorTranslator.FromHtml("#457edd");
            setUpdatedItemFont = new Font(lstItems.Font, FontStyle.Bold);

            setNormalItemColor = SystemColors.ControlText;
            setNormalItemFont = new Font(lstItems.Font, FontStyle.Regular);
        }

        private void LoadScreenSettings()
        {
            Screen screen = Screen.FromPoint(Cursor.Position);

            if (menuItem_RememberWindowSize.Checked)
            {
                width = settings.LoadSetting("Width", "int", DEFAULT_WIDTH.ToString());
                height = settings.LoadSetting("Height", "int", DEFAULT_HEIGHT.ToString());

                if (width < MIN_WIDTH || height < MIN_HEIGHT)
                {
                    width = MIN_WIDTH;
                    height = MIN_HEIGHT;
                }

                if (width > screen.WorkingArea.Size.Width) width = screen.WorkingArea.Size.Width;
                if (height > screen.WorkingArea.Size.Height) height = screen.WorkingArea.Size.Height;

                this.Width = width;
                this.Height = height;
            }

            else
            {
                width = DEFAULT_WIDTH;
                height = DEFAULT_HEIGHT;
            }

            if (menuItem_RememberWindowPosition.Checked)
            {
                left = settings.LoadSetting("Left", "int", "99999");
                top = settings.LoadSetting("Top", "int", "99999");

                if (left < 99999 && top < 99999)
                {
                    this.Left = left;
                    this.Top = top;
                }

                else CenterScreen();
            }

            else CenterScreen();

            maximized = settings.LoadSetting("Maximized", "bool", "false");
            if (maximized) this.WindowState = FormWindowState.Maximized;

            if (menuItem_RememberColumnSizes.Checked)
            {
                clmName.Width = settings.LoadSetting("WidthColumnName", "int", "165");
                clmEnabled.Width = settings.LoadSetting("WidthColumnEnabled", "int", "55");
                clmAddress.Width = settings.LoadSetting("WidthColumnAddress", "int", "200");
                clmInterval.Width = settings.LoadSetting("WidthColumnInterval", "int", "80");
                clmContentStart.Width = settings.LoadSetting("WidthColumnContentStart", "int", "125");
                clmContentStop.Width = settings.LoadSetting("WidthColumnContentStop", "int", "125");
                clmChecksum.Width = settings.LoadSetting("WidthColumnChecksum", "int", "256");
                clmLastChecked.Width = settings.LoadSetting("WidthColumnLastChecked", "int", "140");
            }

            settings.SaveSetting("WidthColumnName", clmName.Width.ToString());
            settings.SaveSetting("WidthColumnEnabled", clmEnabled.Width.ToString());
            settings.SaveSetting("WidthColumnAddress", clmAddress.Width.ToString());
            settings.SaveSetting("WidthColumnInterval", clmInterval.Width.ToString());
            settings.SaveSetting("WidthColumnContentStart", clmContentStart.Width.ToString());
            settings.SaveSetting("WidthColumnContentStop", clmContentStop.Width.ToString());
            settings.SaveSetting("WidthColumnChecksum", clmChecksum.Width.ToString());
            settings.SaveSetting("WidthColumnLastChecked", clmLastChecked.Width.ToString());

        }

        private void CenterScreen()
        {
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2);
        }

        private void SaveSettings()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (menuItem_StartAutomatically.Checked) rk.SetValue(appRegistryName, "\"" + Application.ExecutablePath.ToString().Replace("/", "\\") + "\"");
                else rk.DeleteValue(appRegistryName, false);
            }

            catch { }

            settings.SaveSetting("RememberSize", menuItem_RememberWindowSize.Checked.ToString());
            settings.SaveSetting("RememberPosition", menuItem_RememberWindowPosition.Checked.ToString());
            settings.SaveSetting("RememberColumnWidth", menuItem_RememberColumnSizes.Checked.ToString());
            settings.SaveSetting("ShowNotifications", menuItem_ShowNotifications.Checked.ToString());
            settings.SaveSetting("StartAutomatically", menuItem_StartAutomatically.Checked.ToString());
            settings.SaveSetting("StartMinimized", menuItem_StartMinimized.Checked.ToString());
            settings.SaveSetting("MinimizeToTray", menuItem_MinimizeToTray.Checked.ToString());
            settings.SaveSetting("CustomBrowser", setCustomBrowser);
            settings.SaveSetting("UseCustomBrowser", setUseCustomBrowser.ToString());

            settings.SaveSetting("Top", top.ToString());
            settings.SaveSetting("Left", left.ToString());
            settings.SaveSetting("Width", width.ToString());
            settings.SaveSetting("Height", height.ToString());

            settings.SaveSetting("WidthColumnName", clmName.Width.ToString());
            settings.SaveSetting("WidthColumnEnabled", clmEnabled.Width.ToString());
            settings.SaveSetting("WidthColumnAddress", clmAddress.Width.ToString());
            settings.SaveSetting("WidthColumnInterval", clmInterval.Width.ToString());
            settings.SaveSetting("WidthColumnContentStart", clmContentStart.Width.ToString());
            settings.SaveSetting("WidthColumnContentStop", clmContentStop.Width.ToString());
            settings.SaveSetting("WidthColumnChecksum", clmChecksum.Width.ToString());
            settings.SaveSetting("WidthColumnLastChecked", clmLastChecked.Width.ToString());

            if (this.WindowState == FormWindowState.Maximized) settings.SaveSetting("Maximized", "True");
            else settings.SaveSetting("Maximized", "False");
        }

        private void CheckWindowSizeAndLocation()
        {
            if (this.WindowState == FormWindowState.Normal && sizeLoaded)
            {
                if (this.Width > 0) width = this.Width;
                if (this.Height > 0) height = this.Height;

                if (this.Top > -5000) top = this.Top;
                if (this.Left > -5000) left = this.Left;
            }
        }
        
        private void LoadList()
        {
            try
            {
                lstItems.Items.Clear();

                if (File.Exists(listFile))
                {
                    using (StreamReader reader = File.OpenText(listFile))
                    {
                        lstItems.BeginUpdate();

                        while (reader.Peek() >= 0)
                        {
                            string line = reader.ReadLine();
                            List<string> list = line.Split(listFileSeparator).ToList<string>();

                            ListViewItem item = new ListViewItem(list[ITEM_NAME]);
                            item.SubItems.Add(list[ITEM_ENABLED]);
                            item.SubItems.Add(list[ITEM_ADDRESS]);
                            item.SubItems.Add(list[ITEM_INTERVAL]);
                            item.SubItems.Add(list[ITEM_START].Replace(separatorString, listFileSeparator.ToString()));
                            item.SubItems.Add(list[ITEM_STOP].Replace(separatorString, listFileSeparator.ToString()));
                            item.SubItems.Add(list[ITEM_CHECKSUM]);
                            item.SubItems.Add(list[ITEM_LAST]);

                            if (list[ITEM_CHANGED] != "")
                            {
                                item.ForeColor = setUpdatedItemColor;
                                item.Font = setUpdatedItemFont;
                            }

                            lstItems.Items.Add(item);
                        }

                        lstItems.EndUpdate();
                    }

                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveList()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(listFile))
                {
                    foreach (ListViewItem item in lstItems.Items)
                    {
                        if (item.SubItems[ITEM_LAST].Text == TEXT_CHECKING) item.SubItems[ITEM_LAST].Text = "-";

                        string name = item.SubItems[ITEM_NAME].Text;
                        string enabled = item.SubItems[ITEM_ENABLED].Text;
                        string address = item.SubItems[ITEM_ADDRESS].Text;
                        string interval = item.SubItems[ITEM_INTERVAL].Text;
                        string start = item.SubItems[ITEM_START].Text.Replace(listFileSeparator.ToString(), separatorString);
                        string stop = item.SubItems[ITEM_STOP].Text.Replace(listFileSeparator.ToString(), separatorString);
                        string checksum = item.SubItems[ITEM_CHECKSUM].Text;
                        string last = item.SubItems[ITEM_LAST].Text;

                        string changed = "";
                        if (item.Font == setUpdatedItemFont || item.ForeColor == setUpdatedItemColor) changed = "X";

                        sw.WriteLine(name + listFileSeparator + enabled + listFileSeparator + address + listFileSeparator + interval + listFileSeparator + start + listFileSeparator + stop + listFileSeparator + checksum + listFileSeparator + last + listFileSeparator + changed);
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CheckSelectedActions()
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                if (lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
                {
                    menuItem_List_Delete.Enabled = true;
                    menuItem_List_Modify.Enabled = true;
                    menuItem_CheckSelected.Enabled = true;
                    menuItem_C_List_Delete.Enabled = true;
                    menuItem_C_List_Modify.Enabled = true;
                    menuItem_C_CheckSelected.Enabled = true;

                    if (lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text != "")
                    {
                        menuItem_List_Enable.Enabled = false;
                        menuItem_List_Disable.Enabled = true;
                        menuItem_C_List_Enable.Enabled = false;
                        menuItem_C_List_Disable.Enabled = true;
                    }

                    else
                    {
                        menuItem_List_Enable.Enabled = true;
                        menuItem_List_Disable.Enabled = false;
                        menuItem_C_List_Enable.Enabled = true;
                        menuItem_C_List_Disable.Enabled = false;
                    }

                    if (lstItems.SelectedItems[0].Font == setUpdatedItemFont || lstItems.SelectedItems[0].ForeColor == setUpdatedItemColor)
                    {
                        menuItem_Clear_Changed.Enabled = true;
                        menuItem_C_Clear_Changed.Enabled = true;
                    }

                    else
                    {
                        menuItem_Clear_Changed.Enabled = false;
                        menuItem_C_Clear_Changed.Enabled = false;
                    }
                }

                else
                {
                    menuItem_List_Delete.Enabled = false;
                    menuItem_List_Modify.Enabled = false;
                    menuItem_List_Enable.Enabled = false;
                    menuItem_List_Disable.Enabled = false;
                    menuItem_CheckSelected.Enabled = false;
                    menuItem_C_List_Delete.Enabled = false;
                    menuItem_C_List_Modify.Enabled = false;
                    menuItem_C_List_Enable.Enabled = false;
                    menuItem_C_List_Disable.Enabled = false;
                    menuItem_C_CheckSelected.Enabled = false;
                }
            }

            else
            {
                menuItem_List_Delete.Enabled = false;
                menuItem_List_Modify.Enabled = false;
                menuItem_List_Enable.Enabled = false;
                menuItem_List_Disable.Enabled = false;
                menuItem_CheckSelected.Enabled = false;
                menuItem_C_List_Delete.Enabled = false;
                menuItem_C_List_Modify.Enabled = false;
                menuItem_C_List_Enable.Enabled = false;
                menuItem_C_List_Disable.Enabled = false;
                menuItem_C_CheckSelected.Enabled = false;
            }

            bool updated = false;
            foreach (ListViewItem item in lstItems.Items)
            {
                if (item.Font == setUpdatedItemFont || item.ForeColor == setUpdatedItemColor) updated = true;
            }

            if (updated) notifyIcon1.Icon = Properties.Resources.wt_color;
            else notifyIcon1.Icon = Properties.Resources.wt_bw;
        }

        private void HideWindow()
        {
            this.Hide();
        }

        private void ShowWindow()
        {
            this.Show();
            if (maximized) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        /*************************************************************************/
        // EVENTS
        /*************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LoadScreenSettings();
            LoadList();
            CheckSelectedActions();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sizeLoaded = true;
            if (menuItem_StartMinimized.Checked) this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosing = true;
            timerCheckList.Stop();
            CheckWindowSizeAndLocation();
            SaveList();
            SaveSettings();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            CheckWindowSizeAndLocation();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CheckWindowSizeAndLocation();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && menuItem_MinimizeToTray.Checked) HideWindow();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedActions();
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                lstItems.SelectedItems[0].ForeColor = setNormalItemColor;
                lstItems.SelectedItems[0].Font = setNormalItemFont;
                CheckSelectedActions();

                OpenWebPage(lstItems.SelectedItems[0].SubItems[ITEM_ADDRESS].Text);
            }
        }

        private void OpenWebPage(string address)
        {
            if (setUseCustomBrowser && File.Exists(setCustomBrowser))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = setCustomBrowser;
                startInfo.Arguments = address;

                Process process = Process.Start(startInfo);
            }

            else
            {
                Process.Start(address);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
            ShowWindow();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowWindow();
            ShowWindow();
        }

        private void lstItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu1.Show(lstItems, new Point(e.X, e.Y));
            }
        }

        /*************************************************************************/
        // MENUITEMS : FILE
        /*************************************************************************/

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*************************************************************************/
        // MENUITEMS : LIST
        /*************************************************************************/

        private void menuItem_CheckAll_Click(object sender, EventArgs e)
        {
            WatchList(true);
        }

        private void menuItem_CheckSelected_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                WatchItem(lstItems.SelectedItems[0], true);
            }
        }

        private void menuItem_List_New_Click(object sender, EventArgs e)
        {
            FormItem form = new FormItem();
            form.ShowDialog();

            if (!form.Cancelled)
            {
                ListViewItem item = new ListViewItem(form.ItemName);
                item.SubItems.Add(form.ItemEnabled);
                item.SubItems.Add(form.ItemAddress);
                item.SubItems.Add(form.ItemInterval);
                item.SubItems.Add(form.ItemStart);
                item.SubItems.Add(form.ItemStop);
                item.SubItems.Add(form.ItemChecksum);
                item.SubItems.Add("-");

                lstItems.Items.Add(item);
            }
        }

        private void menuItem_List_Modify_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0 && lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                string enabled = lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text;
                lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = "";

                FormItem form = new FormItem();
                form.ItemName = lstItems.SelectedItems[0].SubItems[ITEM_NAME].Text;
                form.ItemEnabled = enabled;
                form.ItemAddress = lstItems.SelectedItems[0].SubItems[ITEM_ADDRESS].Text;
                form.ItemInterval = lstItems.SelectedItems[0].SubItems[ITEM_INTERVAL].Text;
                form.ItemStart = lstItems.SelectedItems[0].SubItems[ITEM_START].Text;
                form.ItemStop = lstItems.SelectedItems[0].SubItems[ITEM_STOP].Text;

                form.ShowDialog();

                if (!form.Cancelled)
                {
                    lstItems.SelectedItems[0].SubItems[ITEM_NAME].Text = form.ItemName;
                    lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = form.ItemEnabled;
                    lstItems.SelectedItems[0].SubItems[ITEM_ADDRESS].Text = form.ItemAddress;
                    lstItems.SelectedItems[0].SubItems[ITEM_INTERVAL].Text = form.ItemInterval;
                    lstItems.SelectedItems[0].SubItems[ITEM_START].Text = form.ItemStart;
                    lstItems.SelectedItems[0].SubItems[ITEM_STOP].Text = form.ItemStop;
                    lstItems.SelectedItems[0].SubItems[ITEM_CHECKSUM].Text = form.ItemChecksum;
                    lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text = "-";
                }

                else lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = enabled;
            }
        }

        private void menuItem_List_Delete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0 && lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                string enabled = lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text;
                lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = "";

                var result = MessageBox.Show("Are you sure you want to delete \"" + lstItems.SelectedItems[0].SubItems[ITEM_NAME].Text + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes) lstItems.SelectedItems[0].Remove();
                else lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = enabled;
            }
        }

        private void menuItem_List_Enable_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0 && lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = "X";
            }

            CheckSelectedActions();
        }

        private void menuItem_List_Disable_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0 && lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                lstItems.SelectedItems[0].SubItems[ITEM_ENABLED].Text = "";
            }

            CheckSelectedActions();
        }

        private void menuItem_Clear_Changed_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0 && lstItems.SelectedItems[0].SubItems[ITEM_LAST].Text != TEXT_CHECKING)
            {
                lstItems.SelectedItems[0].ForeColor = setNormalItemColor;
                lstItems.SelectedItems[0].Font = setNormalItemFont;
            }

            CheckSelectedActions();
        }

        /*************************************************************************/
        // MENUITEMS : SETTINGS
        /*************************************************************************/

        private void menuItem_RememberWindowSize_Click(object sender, EventArgs e)
        {
            if (menuItem_RememberWindowSize.Checked) menuItem_RememberWindowSize.Checked = false;
            else menuItem_RememberWindowSize.Checked = true;
        }

        private void menuItem_RememberWindowPosition_Click(object sender, EventArgs e)
        {
            if (menuItem_RememberWindowPosition.Checked) menuItem_RememberWindowPosition.Checked = false;
            else menuItem_RememberWindowPosition.Checked = true;
        }

        private void menuItem_RememberColumnSizes_Click(object sender, EventArgs e)
        {
            if (menuItem_RememberColumnSizes.Checked) menuItem_RememberColumnSizes.Checked = false;
            else menuItem_RememberColumnSizes.Checked = true;
        }

        private void menuItem_ShowNotifications_Click(object sender, EventArgs e)
        {
            if (menuItem_ShowNotifications.Checked) menuItem_ShowNotifications.Checked = false;
            else menuItem_ShowNotifications.Checked = true;
        }

        private void menuItem_StartAutomatically_Click(object sender, EventArgs e)
        {
            if (menuItem_StartAutomatically.Checked) menuItem_StartAutomatically.Checked = false;
            else menuItem_StartAutomatically.Checked = true;
        }

        private void menuItem_StartMinimized_Click(object sender, EventArgs e)
        {
            if (menuItem_StartMinimized.Checked) menuItem_StartMinimized.Checked = false;
            else menuItem_StartMinimized.Checked = true;
        }

        private void menuItem_MinimizeToTray_Click(object sender, EventArgs e)
        {
            if (menuItem_MinimizeToTray.Checked) menuItem_MinimizeToTray.Checked = false;
            else menuItem_MinimizeToTray.Checked = true;
        }

        private void menuItem_SelectWebBrowser_Click(object sender, EventArgs e)
        {
            FormSelectBrowser form = new FormSelectBrowser();
            form.UseCustom = setUseCustomBrowser;
            form.SelectedBrowser = setCustomBrowser;
            form.ShowDialog();
            
            if (!form.Cancelled)
            {
                setUseCustomBrowser = form.UseCustom;
                setCustomBrowser = form.SelectedBrowser;
            }
        }

        /*************************************************************************/
        // MENUITEMS : HELP
        /*************************************************************************/

        private void menuItem_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help not available yet!", "Error");
        }

    }
}
