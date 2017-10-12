namespace WebsiteTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_CheckSelected = new System.Windows.Forms.MenuItem();
            this.menuItem_CheckAll = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem_List_New = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Modify = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Delete = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Enable = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Disable = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_Clear_Changed = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem_Open_Selected = new System.Windows.Forms.MenuItem();
            this.menuItem_Open_All = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberWindowSize = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberWindowPosition = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberColumnSizes = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem_ShowNotifications = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem_StartAutomatically = new System.Windows.Forms.MenuItem();
            this.menuItem_StartMinimized = new System.Windows.Forms.MenuItem();
            this.menuItem_MinimizeToTray = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem_SaveLog = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectWebBrowser = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem_Help = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.timerCheckList = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lstItems = new WebsiteTracker.VisualStylesListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContentStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContentStop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChecksum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem_C_CheckSelected = new System.Windows.Forms.MenuItem();
            this.menuItem_C_CheckAll = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_New = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Modify = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Delete = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Enable = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Disable = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Clear_Changed = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Open_Selected = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Open_All = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem2,
            this.menuItem3,
            this.menuItem6});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Exit});
            this.menuItem4.Text = "File";
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Index = 0;
            this.menuItem_Exit.Text = "Exit";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_CheckSelected,
            this.menuItem_CheckAll,
            this.menuItem5,
            this.menuItem_List_New,
            this.menuItem_List_Modify,
            this.menuItem_List_Delete,
            this.menuItem7,
            this.menuItem_List_Enable,
            this.menuItem_List_Disable,
            this.menuItem1,
            this.menuItem_Clear_Changed,
            this.menuItem14,
            this.menuItem_Open_Selected,
            this.menuItem_Open_All});
            this.menuItem2.Text = "List";
            // 
            // menuItem_CheckSelected
            // 
            this.menuItem_CheckSelected.Enabled = false;
            this.menuItem_CheckSelected.Index = 0;
            this.menuItem_CheckSelected.Text = "Check selected now";
            this.menuItem_CheckSelected.Click += new System.EventHandler(this.menuItem_CheckSelected_Click);
            // 
            // menuItem_CheckAll
            // 
            this.menuItem_CheckAll.Index = 1;
            this.menuItem_CheckAll.Text = "Check all now";
            this.menuItem_CheckAll.Click += new System.EventHandler(this.menuItem_CheckAll_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // menuItem_List_New
            // 
            this.menuItem_List_New.Index = 3;
            this.menuItem_List_New.Text = "New...";
            this.menuItem_List_New.Click += new System.EventHandler(this.menuItem_List_New_Click);
            // 
            // menuItem_List_Modify
            // 
            this.menuItem_List_Modify.Enabled = false;
            this.menuItem_List_Modify.Index = 4;
            this.menuItem_List_Modify.Text = "Modify...";
            this.menuItem_List_Modify.Click += new System.EventHandler(this.menuItem_List_Modify_Click);
            // 
            // menuItem_List_Delete
            // 
            this.menuItem_List_Delete.Enabled = false;
            this.menuItem_List_Delete.Index = 5;
            this.menuItem_List_Delete.Text = "Delete...";
            this.menuItem_List_Delete.Click += new System.EventHandler(this.menuItem_List_Delete_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.Text = "-";
            // 
            // menuItem_List_Enable
            // 
            this.menuItem_List_Enable.Enabled = false;
            this.menuItem_List_Enable.Index = 7;
            this.menuItem_List_Enable.Text = "Enable";
            this.menuItem_List_Enable.Click += new System.EventHandler(this.menuItem_List_Enable_Click);
            // 
            // menuItem_List_Disable
            // 
            this.menuItem_List_Disable.Enabled = false;
            this.menuItem_List_Disable.Index = 8;
            this.menuItem_List_Disable.Text = "Disable";
            this.menuItem_List_Disable.Click += new System.EventHandler(this.menuItem_List_Disable_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 9;
            this.menuItem1.Text = "-";
            // 
            // menuItem_Clear_Changed
            // 
            this.menuItem_Clear_Changed.Enabled = false;
            this.menuItem_Clear_Changed.Index = 10;
            this.menuItem_Clear_Changed.Text = "Clear \"updated\" status";
            this.menuItem_Clear_Changed.Click += new System.EventHandler(this.menuItem_Clear_Changed_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 11;
            this.menuItem14.Text = "-";
            // 
            // menuItem_Open_Selected
            // 
            this.menuItem_Open_Selected.Enabled = false;
            this.menuItem_Open_Selected.Index = 12;
            this.menuItem_Open_Selected.Text = "Open selected page";
            this.menuItem_Open_Selected.Click += new System.EventHandler(this.menuItem_Open_Selected_Click);
            // 
            // menuItem_Open_All
            // 
            this.menuItem_Open_All.Enabled = false;
            this.menuItem_Open_All.Index = 13;
            this.menuItem_Open_All.Text = "Open all updated pages";
            this.menuItem_Open_All.Click += new System.EventHandler(this.menuItem_Open_All_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_RememberWindowSize,
            this.menuItem_RememberWindowPosition,
            this.menuItem_RememberColumnSizes,
            this.menuItem12,
            this.menuItem_ShowNotifications,
            this.menuItem8,
            this.menuItem_StartAutomatically,
            this.menuItem_StartMinimized,
            this.menuItem_MinimizeToTray,
            this.menuItem11,
            this.menuItem_SaveLog,
            this.menuItem15,
            this.menuItem_SelectWebBrowser});
            this.menuItem3.Text = "Settings";
            // 
            // menuItem_RememberWindowSize
            // 
            this.menuItem_RememberWindowSize.Index = 0;
            this.menuItem_RememberWindowSize.Text = "Remember window size";
            this.menuItem_RememberWindowSize.Click += new System.EventHandler(this.menuItem_RememberWindowSize_Click);
            // 
            // menuItem_RememberWindowPosition
            // 
            this.menuItem_RememberWindowPosition.Index = 1;
            this.menuItem_RememberWindowPosition.Text = "Remember window position";
            this.menuItem_RememberWindowPosition.Click += new System.EventHandler(this.menuItem_RememberWindowPosition_Click);
            // 
            // menuItem_RememberColumnSizes
            // 
            this.menuItem_RememberColumnSizes.Index = 2;
            this.menuItem_RememberColumnSizes.Text = "Remember column sizes";
            this.menuItem_RememberColumnSizes.Click += new System.EventHandler(this.menuItem_RememberColumnSizes_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.Text = "-";
            // 
            // menuItem_ShowNotifications
            // 
            this.menuItem_ShowNotifications.Index = 4;
            this.menuItem_ShowNotifications.Text = "Show notifications";
            this.menuItem_ShowNotifications.Click += new System.EventHandler(this.menuItem_ShowNotifications_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "-";
            // 
            // menuItem_StartAutomatically
            // 
            this.menuItem_StartAutomatically.Index = 6;
            this.menuItem_StartAutomatically.Text = "Start automatically with Windows";
            this.menuItem_StartAutomatically.Click += new System.EventHandler(this.menuItem_StartAutomatically_Click);
            // 
            // menuItem_StartMinimized
            // 
            this.menuItem_StartMinimized.Index = 7;
            this.menuItem_StartMinimized.Text = "Start minimized";
            this.menuItem_StartMinimized.Click += new System.EventHandler(this.menuItem_StartMinimized_Click);
            // 
            // menuItem_MinimizeToTray
            // 
            this.menuItem_MinimizeToTray.Index = 8;
            this.menuItem_MinimizeToTray.Text = "Minimize to tray";
            this.menuItem_MinimizeToTray.Click += new System.EventHandler(this.menuItem_MinimizeToTray_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 9;
            this.menuItem11.Text = "-";
            // 
            // menuItem_SaveLog
            // 
            this.menuItem_SaveLog.Index = 10;
            this.menuItem_SaveLog.Text = "Save log file";
            this.menuItem_SaveLog.Click += new System.EventHandler(this.menuItem_SaveLog_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 11;
            this.menuItem15.Text = "-";
            // 
            // menuItem_SelectWebBrowser
            // 
            this.menuItem_SelectWebBrowser.Index = 12;
            this.menuItem_SelectWebBrowser.Text = "Select web browser...";
            this.menuItem_SelectWebBrowser.Click += new System.EventHandler(this.menuItem_SelectWebBrowser_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Help});
            this.menuItem6.Text = "Help";
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Index = 0;
            this.menuItem_Help.Text = "Help";
            this.menuItem_Help.Click += new System.EventHandler(this.menuItem_Help_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 276);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1104, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // timerCheckList
            // 
            this.timerCheckList.Enabled = true;
            this.timerCheckList.Interval = 10000;
            this.timerCheckList.Tick += new System.EventHandler(this.timerCheckList_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Website Tracker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmEnabled,
            this.clmAddress,
            this.clmInterval,
            this.clmContentStart,
            this.clmContentStop,
            this.clmChecksum,
            this.clmLastChecked});
            this.lstItems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FullRowSelect = true;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(1080, 252);
            this.lstItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstItems.TabIndex = 0;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.DoubleClick += new System.EventHandler(this.lstItems_DoubleClick);
            this.lstItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseUp);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 165;
            // 
            // clmEnabled
            // 
            this.clmEnabled.Text = "Enabled";
            this.clmEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmEnabled.Width = 52;
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            this.clmAddress.Width = 248;
            // 
            // clmInterval
            // 
            this.clmInterval.Text = "Interval";
            this.clmInterval.Width = 107;
            // 
            // clmContentStart
            // 
            this.clmContentStart.Text = "Content start";
            this.clmContentStart.Width = 125;
            // 
            // clmContentStop
            // 
            this.clmContentStop.Text = "Content stop";
            this.clmContentStop.Width = 114;
            // 
            // clmChecksum
            // 
            this.clmChecksum.Text = "Checksum";
            this.clmChecksum.Width = 111;
            // 
            // clmLastChecked
            // 
            this.clmLastChecked.Text = "Last checked";
            this.clmLastChecked.Width = 126;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_C_CheckSelected,
            this.menuItem_C_CheckAll,
            this.menuItem13,
            this.menuItem_C_List_New,
            this.menuItem_C_List_Modify,
            this.menuItem_C_List_Delete,
            this.menuItem17,
            this.menuItem_C_List_Enable,
            this.menuItem_C_List_Disable,
            this.menuItem20,
            this.menuItem_C_Clear_Changed,
            this.menuItem9,
            this.menuItem_C_Open_Selected,
            this.menuItem_C_Open_All});
            // 
            // menuItem_C_CheckSelected
            // 
            this.menuItem_C_CheckSelected.Enabled = false;
            this.menuItem_C_CheckSelected.Index = 0;
            this.menuItem_C_CheckSelected.Text = "Check selected now";
            this.menuItem_C_CheckSelected.Click += new System.EventHandler(this.menuItem_CheckSelected_Click);
            // 
            // menuItem_C_CheckAll
            // 
            this.menuItem_C_CheckAll.Index = 1;
            this.menuItem_C_CheckAll.Text = "Check all now";
            this.menuItem_C_CheckAll.Click += new System.EventHandler(this.menuItem_CheckAll_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "-";
            // 
            // menuItem_C_List_New
            // 
            this.menuItem_C_List_New.Index = 3;
            this.menuItem_C_List_New.Text = "New...";
            this.menuItem_C_List_New.Click += new System.EventHandler(this.menuItem_List_New_Click);
            // 
            // menuItem_C_List_Modify
            // 
            this.menuItem_C_List_Modify.Enabled = false;
            this.menuItem_C_List_Modify.Index = 4;
            this.menuItem_C_List_Modify.Text = "Modify...";
            this.menuItem_C_List_Modify.Click += new System.EventHandler(this.menuItem_List_Modify_Click);
            // 
            // menuItem_C_List_Delete
            // 
            this.menuItem_C_List_Delete.Enabled = false;
            this.menuItem_C_List_Delete.Index = 5;
            this.menuItem_C_List_Delete.Text = "Delete...";
            this.menuItem_C_List_Delete.Click += new System.EventHandler(this.menuItem_List_Delete_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 6;
            this.menuItem17.Text = "-";
            // 
            // menuItem_C_List_Enable
            // 
            this.menuItem_C_List_Enable.Enabled = false;
            this.menuItem_C_List_Enable.Index = 7;
            this.menuItem_C_List_Enable.Text = "Enable";
            this.menuItem_C_List_Enable.Click += new System.EventHandler(this.menuItem_List_Enable_Click);
            // 
            // menuItem_C_List_Disable
            // 
            this.menuItem_C_List_Disable.Enabled = false;
            this.menuItem_C_List_Disable.Index = 8;
            this.menuItem_C_List_Disable.Text = "Disable";
            this.menuItem_C_List_Disable.Click += new System.EventHandler(this.menuItem_List_Disable_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 9;
            this.menuItem20.Text = "-";
            // 
            // menuItem_C_Clear_Changed
            // 
            this.menuItem_C_Clear_Changed.Enabled = false;
            this.menuItem_C_Clear_Changed.Index = 10;
            this.menuItem_C_Clear_Changed.Text = "Clear \"updated\" status";
            this.menuItem_C_Clear_Changed.Click += new System.EventHandler(this.menuItem_Clear_Changed_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 11;
            this.menuItem9.Text = "-";
            // 
            // menuItem_C_Open_Selected
            // 
            this.menuItem_C_Open_Selected.Enabled = false;
            this.menuItem_C_Open_Selected.Index = 12;
            this.menuItem_C_Open_Selected.Text = "Open selected page";
            this.menuItem_C_Open_Selected.Click += new System.EventHandler(this.menuItem_Open_Selected_Click);
            // 
            // menuItem_C_Open_All
            // 
            this.menuItem_C_Open_All.Enabled = false;
            this.menuItem_C_Open_All.Index = 13;
            this.menuItem_C_Open_All.Text = "Open all updated pages";
            this.menuItem_C_Open_All.Click += new System.EventHandler(this.menuItem_Open_All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 298);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lstItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStylesListView lstItems;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.ColumnHeader clmLastChecked;
        private System.Windows.Forms.ColumnHeader clmInterval;
        private System.Windows.Forms.ColumnHeader clmChecksum;
        private System.Windows.Forms.ColumnHeader clmContentStart;
        private System.Windows.Forms.ColumnHeader clmContentStop;
        private System.Windows.Forms.MenuItem menuItem_List_New;
        private System.Windows.Forms.MenuItem menuItem_List_Modify;
        private System.Windows.Forms.MenuItem menuItem_List_Delete;
        private System.Windows.Forms.ColumnHeader clmEnabled;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem_List_Enable;
        private System.Windows.Forms.MenuItem menuItem_List_Disable;
        private System.Windows.Forms.Timer timerCheckList;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem_Clear_Changed;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem_RememberWindowSize;
        private System.Windows.Forms.MenuItem menuItem_RememberWindowPosition;
        private System.Windows.Forms.MenuItem menuItem_RememberColumnSizes;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem_MinimizeToTray;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem_SelectWebBrowser;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem_Help;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem_Exit;
        private System.Windows.Forms.MenuItem menuItem_ShowNotifications;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem_StartAutomatically;
        private System.Windows.Forms.MenuItem menuItem_StartMinimized;
        private System.Windows.Forms.MenuItem menuItem_CheckAll;
        private System.Windows.Forms.MenuItem menuItem_CheckSelected;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem_C_CheckAll;
        private System.Windows.Forms.MenuItem menuItem_C_CheckSelected;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem_C_List_New;
        private System.Windows.Forms.MenuItem menuItem_C_List_Modify;
        private System.Windows.Forms.MenuItem menuItem_C_List_Delete;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem_C_List_Enable;
        private System.Windows.Forms.MenuItem menuItem_C_List_Disable;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem menuItem_C_Clear_Changed;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem_Open_Selected;
        private System.Windows.Forms.MenuItem menuItem_Open_All;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem_C_Open_Selected;
        private System.Windows.Forms.MenuItem menuItem_C_Open_All;
        private System.Windows.Forms.MenuItem menuItem_SaveLog;
        private System.Windows.Forms.MenuItem menuItem15;
    }
}

