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
            this.menuItem_File = new System.Windows.Forms.MenuItem();
            this.menuItem_BackupList = new System.Windows.Forms.MenuItem();
            this.menuItem_RestoreList = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem_List = new System.Windows.Forms.MenuItem();
            this.menuItem_CheckSelected = new System.Windows.Forms.MenuItem();
            this.menuItem_CheckAll = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem_List_New = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Modify = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Delete = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem_List_Enable = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_Clear_Changed = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem_Open_Selected = new System.Windows.Forms.MenuItem();
            this.menuItem_Open_All = new System.Windows.Forms.MenuItem();
            this.menuItem_Settings = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberWindowSize = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberWindowPosition = new System.Windows.Forms.MenuItem();
            this.menuItem_RememberColumnSizes = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem_ShowNotifications = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem_StartAutomatically = new System.Windows.Forms.MenuItem();
            this.menuItem_StartMinimized = new System.Windows.Forms.MenuItem();
            this.menuItem_MinimizeToTray = new System.Windows.Forms.MenuItem();
            this.menuItem_CloseToTray = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem_SaveLog = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectWebBrowser = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_Font_Normal = new System.Windows.Forms.MenuItem();
            this.menuItem_Font_Updated = new System.Windows.Forms.MenuItem();
            this.menuItem_Font_Error = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem_Color_Normal = new System.Windows.Forms.MenuItem();
            this.menuItem_Color_Updated = new System.Windows.Forms.MenuItem();
            this.menuItem_Color_Error = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem_Help = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusUpdatedItems = new System.Windows.Forms.StatusBarPanel();
            this.statusErrorItems = new System.Windows.Forms.StatusBarPanel();
            this.statusEnabledItems = new System.Windows.Forms.StatusBarPanel();
            this.statusDisabledItems = new System.Windows.Forms.StatusBarPanel();
            this.statusDummy = new System.Windows.Forms.StatusBarPanel();
            this.statusLastChecked = new System.Windows.Forms.StatusBarPanel();
            this.timerCheckList = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageListGlobe = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem_C_CheckSelected = new System.Windows.Forms.MenuItem();
            this.menuItem_C_CheckAll = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_New = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Modify = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Delete = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_List_Enable = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Clear_Changed = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Open_Selected = new System.Windows.Forms.MenuItem();
            this.menuItem_C_Open_All = new System.Windows.Forms.MenuItem();
            this.contextMenuTray = new System.Windows.Forms.ContextMenu();
            this.menuItem_T_Show = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem_T_CheckAll = new System.Windows.Forms.MenuItem();
            this.menuItem_T_Open_All = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem_T_Exit = new System.Windows.Forms.MenuItem();
            this.timerCheckQueue = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCheckSelected = new System.Windows.Forms.ToolStripButton();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnEnable = new System.Windows.Forms.ToolStripButton();
            this.btnClearUpdated = new System.Windows.Forms.ToolStripButton();
            this.btnOpenSelected = new System.Windows.Forms.ToolStripButton();
            this.btnOpenAllUpdatedPages = new System.Windows.Forms.ToolStripButton();
            this.lstItems = new WebsiteTracker.VisualStylesListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContentStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContentStop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChecksum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAllowEmptyChecksum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.statusUpdatedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusErrorItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusEnabledItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDisabledItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLastChecked)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_File,
            this.menuItem_List,
            this.menuItem_Settings,
            this.menuItem6});
            // 
            // menuItem_File
            // 
            this.menuItem_File.Index = 0;
            this.menuItem_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_BackupList,
            this.menuItem_RestoreList,
            this.menuItem18,
            this.menuItem_Exit});
            this.menuItem_File.Text = "File";
            // 
            // menuItem_BackupList
            // 
            this.menuItem_BackupList.Index = 0;
            this.menuItem_BackupList.Text = "Backup...";
            this.menuItem_BackupList.Click += new System.EventHandler(this.menuItem_BackupList_Click);
            // 
            // menuItem_RestoreList
            // 
            this.menuItem_RestoreList.Index = 1;
            this.menuItem_RestoreList.Text = "Restore...";
            this.menuItem_RestoreList.Click += new System.EventHandler(this.menuItem_RestoreList_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 2;
            this.menuItem18.Text = "-";
            // 
            // menuItem_Exit
            // 
            this.menuItem_Exit.Index = 3;
            this.menuItem_Exit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItem_Exit.Text = "Exit";
            this.menuItem_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // menuItem_List
            // 
            this.menuItem_List.Index = 1;
            this.menuItem_List.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_CheckSelected,
            this.menuItem_CheckAll,
            this.menuItem5,
            this.menuItem_List_New,
            this.menuItem_List_Modify,
            this.menuItem_List_Delete,
            this.menuItem7,
            this.menuItem_List_Enable,
            this.menuItem1,
            this.menuItem_Clear_Changed,
            this.menuItem14,
            this.menuItem_Open_Selected,
            this.menuItem_Open_All});
            this.menuItem_List.Text = "List";
            // 
            // menuItem_CheckSelected
            // 
            this.menuItem_CheckSelected.Enabled = false;
            this.menuItem_CheckSelected.Index = 0;
            this.menuItem_CheckSelected.Shortcut = System.Windows.Forms.Shortcut.CtrlF5;
            this.menuItem_CheckSelected.Text = "Check selected";
            this.menuItem_CheckSelected.Click += new System.EventHandler(this.menuItem_CheckSelected_Click);
            // 
            // menuItem_CheckAll
            // 
            this.menuItem_CheckAll.Index = 1;
            this.menuItem_CheckAll.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItem_CheckAll.Text = "Check all";
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
            this.menuItem_List_New.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItem_List_New.Text = "New...";
            this.menuItem_List_New.Click += new System.EventHandler(this.menuItem_List_New_Click);
            // 
            // menuItem_List_Modify
            // 
            this.menuItem_List_Modify.Enabled = false;
            this.menuItem_List_Modify.Index = 4;
            this.menuItem_List_Modify.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
            this.menuItem_List_Modify.Text = "Modify...";
            this.menuItem_List_Modify.Click += new System.EventHandler(this.menuItem_List_Modify_Click);
            // 
            // menuItem_List_Delete
            // 
            this.menuItem_List_Delete.Enabled = false;
            this.menuItem_List_Delete.Index = 5;
            this.menuItem_List_Delete.Shortcut = System.Windows.Forms.Shortcut.Del;
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
            this.menuItem_List_Enable.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItem_List_Enable.Text = "Enabled";
            this.menuItem_List_Enable.Click += new System.EventHandler(this.menuItem_List_Enable_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 8;
            this.menuItem1.Text = "-";
            // 
            // menuItem_Clear_Changed
            // 
            this.menuItem_Clear_Changed.Enabled = false;
            this.menuItem_Clear_Changed.Index = 9;
            this.menuItem_Clear_Changed.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem_Clear_Changed.Text = "Clear \"updated\" status";
            this.menuItem_Clear_Changed.Click += new System.EventHandler(this.menuItem_Clear_Changed_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 10;
            this.menuItem14.Text = "-";
            // 
            // menuItem_Open_Selected
            // 
            this.menuItem_Open_Selected.Enabled = false;
            this.menuItem_Open_Selected.Index = 11;
            this.menuItem_Open_Selected.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItem_Open_Selected.Text = "Open selected page";
            this.menuItem_Open_Selected.Click += new System.EventHandler(this.menuItem_Open_Selected_Click);
            // 
            // menuItem_Open_All
            // 
            this.menuItem_Open_All.Enabled = false;
            this.menuItem_Open_All.Index = 12;
            this.menuItem_Open_All.Text = "Open all updated pages";
            this.menuItem_Open_All.Click += new System.EventHandler(this.menuItem_Open_All_Click);
            // 
            // menuItem_Settings
            // 
            this.menuItem_Settings.Index = 2;
            this.menuItem_Settings.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_RememberWindowSize,
            this.menuItem_RememberWindowPosition,
            this.menuItem_RememberColumnSizes,
            this.menuItem12,
            this.menuItem_ShowNotifications,
            this.menuItem8,
            this.menuItem_StartAutomatically,
            this.menuItem_StartMinimized,
            this.menuItem_MinimizeToTray,
            this.menuItem_CloseToTray,
            this.menuItem11,
            this.menuItem_SaveLog,
            this.menuItem15,
            this.menuItem_SelectWebBrowser,
            this.menuItem3,
            this.menuItem4,
            this.menuItem21});
            this.menuItem_Settings.Text = "Settings";
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
            // menuItem_CloseToTray
            // 
            this.menuItem_CloseToTray.Index = 9;
            this.menuItem_CloseToTray.Text = "Close to tray";
            this.menuItem_CloseToTray.Click += new System.EventHandler(this.menuItem_CloseToTray_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 10;
            this.menuItem11.Text = "-";
            // 
            // menuItem_SaveLog
            // 
            this.menuItem_SaveLog.Index = 11;
            this.menuItem_SaveLog.Text = "Save log file";
            this.menuItem_SaveLog.Click += new System.EventHandler(this.menuItem_SaveLog_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 12;
            this.menuItem15.Text = "-";
            // 
            // menuItem_SelectWebBrowser
            // 
            this.menuItem_SelectWebBrowser.Index = 13;
            this.menuItem_SelectWebBrowser.Text = "Select web browser...";
            this.menuItem_SelectWebBrowser.Click += new System.EventHandler(this.menuItem_SelectWebBrowser_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 14;
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 15;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Font_Normal,
            this.menuItem_Font_Updated,
            this.menuItem_Font_Error});
            this.menuItem4.Text = "Set font";
            // 
            // menuItem_Font_Normal
            // 
            this.menuItem_Font_Normal.Index = 0;
            this.menuItem_Font_Normal.Text = "Not updated items...";
            this.menuItem_Font_Normal.Click += new System.EventHandler(this.menuItem_Font_Normal_Click);
            // 
            // menuItem_Font_Updated
            // 
            this.menuItem_Font_Updated.Index = 1;
            this.menuItem_Font_Updated.Text = "Updated items...";
            this.menuItem_Font_Updated.Click += new System.EventHandler(this.menuItem_Font_Updated_Click);
            // 
            // menuItem_Font_Error
            // 
            this.menuItem_Font_Error.Index = 2;
            this.menuItem_Font_Error.Text = "Errors...";
            this.menuItem_Font_Error.Click += new System.EventHandler(this.menuItem_Font_Error_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 16;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Color_Normal,
            this.menuItem_Color_Updated,
            this.menuItem_Color_Error});
            this.menuItem21.Text = "Set color";
            // 
            // menuItem_Color_Normal
            // 
            this.menuItem_Color_Normal.Index = 0;
            this.menuItem_Color_Normal.Text = "Not updated items...";
            this.menuItem_Color_Normal.Click += new System.EventHandler(this.menuItem_Color_Normal_Click);
            // 
            // menuItem_Color_Updated
            // 
            this.menuItem_Color_Updated.Index = 1;
            this.menuItem_Color_Updated.Text = "Updated items...";
            this.menuItem_Color_Updated.Click += new System.EventHandler(this.menuItem_Color_Updated_Click);
            // 
            // menuItem_Color_Error
            // 
            this.menuItem_Color_Error.Index = 2;
            this.menuItem_Color_Error.Text = "Errors...";
            this.menuItem_Color_Error.Click += new System.EventHandler(this.menuItem_Color_Error_Click);
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
            this.menuItem_Help.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItem_Help.Text = "Help";
            this.menuItem_Help.Click += new System.EventHandler(this.menuItem_Help_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 139);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusUpdatedItems,
            this.statusErrorItems,
            this.statusEnabledItems,
            this.statusDisabledItems,
            this.statusDummy,
            this.statusLastChecked});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1262, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // statusUpdatedItems
            // 
            this.statusUpdatedItems.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusUpdatedItems.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusUpdatedItems.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusUpdatedItems.Name = "statusUpdatedItems";
            this.statusUpdatedItems.Text = "Updated: 0";
            this.statusUpdatedItems.Width = 69;
            // 
            // statusErrorItems
            // 
            this.statusErrorItems.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusErrorItems.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusErrorItems.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusErrorItems.Name = "statusErrorItems";
            this.statusErrorItems.Text = "Errors: 0";
            this.statusErrorItems.Width = 57;
            // 
            // statusEnabledItems
            // 
            this.statusEnabledItems.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusEnabledItems.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusEnabledItems.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusEnabledItems.Name = "statusEnabledItems";
            this.statusEnabledItems.Text = "Enabled: 0";
            this.statusEnabledItems.Width = 68;
            // 
            // statusDisabledItems
            // 
            this.statusDisabledItems.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusDisabledItems.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusDisabledItems.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusDisabledItems.Name = "statusDisabledItems";
            this.statusDisabledItems.Text = "Disabled: 0";
            this.statusDisabledItems.Width = 71;
            // 
            // statusDummy
            // 
            this.statusDummy.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusDummy.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusDummy.Name = "statusDummy";
            this.statusDummy.Width = 889;
            // 
            // statusLastChecked
            // 
            this.statusLastChecked.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusLastChecked.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusLastChecked.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusLastChecked.Name = "statusLastChecked";
            this.statusLastChecked.Text = "Last checked: -";
            this.statusLastChecked.Width = 91;
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
            // imageListGlobe
            // 
            this.imageListGlobe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGlobe.ImageStream")));
            this.imageListGlobe.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGlobe.Images.SetKeyName(0, "updated_bw_light");
            this.imageListGlobe.Images.SetKeyName(1, "updated_bw");
            this.imageListGlobe.Images.SetKeyName(2, "updated_color");
            this.imageListGlobe.Images.SetKeyName(3, "updated_red");
            this.imageListGlobe.Images.SetKeyName(4, "normal");
            this.imageListGlobe.Images.SetKeyName(5, "updated");
            this.imageListGlobe.Images.SetKeyName(6, "error");
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
            this.menuItem_C_CheckSelected.Text = "Check selected";
            this.menuItem_C_CheckSelected.Click += new System.EventHandler(this.menuItem_CheckSelected_Click);
            // 
            // menuItem_C_CheckAll
            // 
            this.menuItem_C_CheckAll.Index = 1;
            this.menuItem_C_CheckAll.Text = "Check all";
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
            this.menuItem_C_List_Enable.Text = "Enabled";
            this.menuItem_C_List_Enable.Click += new System.EventHandler(this.menuItem_List_Enable_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 8;
            this.menuItem20.Text = "-";
            // 
            // menuItem_C_Clear_Changed
            // 
            this.menuItem_C_Clear_Changed.Enabled = false;
            this.menuItem_C_Clear_Changed.Index = 9;
            this.menuItem_C_Clear_Changed.Text = "Clear \"updated\" status";
            this.menuItem_C_Clear_Changed.Click += new System.EventHandler(this.menuItem_Clear_Changed_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 10;
            this.menuItem9.Text = "-";
            // 
            // menuItem_C_Open_Selected
            // 
            this.menuItem_C_Open_Selected.Enabled = false;
            this.menuItem_C_Open_Selected.Index = 11;
            this.menuItem_C_Open_Selected.Text = "Open selected page";
            this.menuItem_C_Open_Selected.Click += new System.EventHandler(this.menuItem_Open_Selected_Click);
            // 
            // menuItem_C_Open_All
            // 
            this.menuItem_C_Open_All.Enabled = false;
            this.menuItem_C_Open_All.Index = 12;
            this.menuItem_C_Open_All.Text = "Open all updated pages";
            this.menuItem_C_Open_All.Click += new System.EventHandler(this.menuItem_Open_All_Click);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_T_Show,
            this.menuItem16,
            this.menuItem_T_CheckAll,
            this.menuItem_T_Open_All,
            this.menuItem19,
            this.menuItem_T_Exit});
            // 
            // menuItem_T_Show
            // 
            this.menuItem_T_Show.Index = 0;
            this.menuItem_T_Show.Text = "Show Website Tracker";
            this.menuItem_T_Show.Click += new System.EventHandler(this.menuItem_Show);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            this.menuItem16.Text = "-";
            // 
            // menuItem_T_CheckAll
            // 
            this.menuItem_T_CheckAll.Index = 2;
            this.menuItem_T_CheckAll.Text = "Check all now";
            this.menuItem_T_CheckAll.Click += new System.EventHandler(this.menuItem_CheckAll_Click);
            // 
            // menuItem_T_Open_All
            // 
            this.menuItem_T_Open_All.Index = 3;
            this.menuItem_T_Open_All.Text = "Open all updated pages";
            this.menuItem_T_Open_All.Click += new System.EventHandler(this.menuItem_Open_All_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 4;
            this.menuItem19.Text = "-";
            // 
            // menuItem_T_Exit
            // 
            this.menuItem_T_Exit.Index = 5;
            this.menuItem_T_Exit.Text = "Exit";
            this.menuItem_T_Exit.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // timerCheckQueue
            // 
            this.timerCheckQueue.Tick += new System.EventHandler(this.timerCheckQueue_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheckSelected,
            this.btnCheckAll,
            this.btnNew,
            this.btnModify,
            this.btnDelete,
            this.btnEnable,
            this.btnClearUpdated,
            this.btnOpenSelected,
            this.btnOpenAllUpdatedPages});
            this.toolStrip1.Location = new System.Drawing.Point(12, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1238, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCheckSelected
            // 
            this.btnCheckSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheckSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckSelected.Image")));
            this.btnCheckSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckSelected.Name = "btnCheckSelected";
            this.btnCheckSelected.Size = new System.Drawing.Size(23, 22);
            this.btnCheckSelected.Text = "Check selected";
            this.btnCheckSelected.Click += new System.EventHandler(this.btnCheckSelected_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(23, 22);
            this.btnCheckAll.Text = "Check all";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New...";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(23, 22);
            this.btnModify.Text = "Modify...";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete...";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnable.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(23, 22);
            this.btnEnable.Text = "Enable";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnClearUpdated
            // 
            this.btnClearUpdated.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearUpdated.Image = ((System.Drawing.Image)(resources.GetObject("btnClearUpdated.Image")));
            this.btnClearUpdated.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearUpdated.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnClearUpdated.Name = "btnClearUpdated";
            this.btnClearUpdated.Size = new System.Drawing.Size(23, 22);
            this.btnClearUpdated.Text = "Clear \"updated\" status";
            this.btnClearUpdated.Click += new System.EventHandler(this.btnClearUpdated_Click);
            // 
            // btnOpenSelected
            // 
            this.btnOpenSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSelected.Image")));
            this.btnOpenSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSelected.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnOpenSelected.Name = "btnOpenSelected";
            this.btnOpenSelected.Size = new System.Drawing.Size(23, 22);
            this.btnOpenSelected.Text = "Open selected page";
            this.btnOpenSelected.Click += new System.EventHandler(this.btnOpenSelected_Click);
            // 
            // btnOpenAllUpdatedPages
            // 
            this.btnOpenAllUpdatedPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenAllUpdatedPages.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAllUpdatedPages.Image")));
            this.btnOpenAllUpdatedPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenAllUpdatedPages.Name = "btnOpenAllUpdatedPages";
            this.btnOpenAllUpdatedPages.Size = new System.Drawing.Size(23, 22);
            this.btnOpenAllUpdatedPages.Text = "Open all updated pages";
            this.btnOpenAllUpdatedPages.Click += new System.EventHandler(this.btnOpenAllUpdatedPages_Click);
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
            this.clmNotes,
            this.clmInterval,
            this.clmContentStart,
            this.clmContentStop,
            this.clmChecksum,
            this.clmLastChecked,
            this.clmLastUpdated,
            this.clmStatus,
            this.clmAllowEmptyChecksum});
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstItems.FullRowSelect = true;
            this.lstItems.Location = new System.Drawing.Point(12, 33);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.ShowItemToolTips = true;
            this.lstItems.Size = new System.Drawing.Size(1238, 94);
            this.lstItems.SmallImageList = this.imageListGlobe;
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
            this.clmAddress.Width = 221;
            // 
            // clmNotes
            // 
            this.clmNotes.Text = "Notes";
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
            // clmLastUpdated
            // 
            this.clmLastUpdated.Text = "Last updated";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 153;
            // 
            // clmAllowEmptyChecksum
            // 
            this.clmAllowEmptyChecksum.Text = "Allow empty result";
            this.clmAllowEmptyChecksum.Width = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 161);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lstItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.statusUpdatedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusErrorItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusEnabledItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDisabledItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLastChecked)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStylesListView lstItems;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem_List;
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
        private System.Windows.Forms.Timer timerCheckList;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem_Clear_Changed;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuItem menuItem_Settings;
        private System.Windows.Forms.MenuItem menuItem_RememberWindowSize;
        private System.Windows.Forms.MenuItem menuItem_RememberWindowPosition;
        private System.Windows.Forms.MenuItem menuItem_RememberColumnSizes;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem_MinimizeToTray;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem_SelectWebBrowser;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem_Help;
        private System.Windows.Forms.MenuItem menuItem_File;
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
        private System.Windows.Forms.MenuItem menuItem_CloseToTray;
        private System.Windows.Forms.ContextMenu contextMenuTray;
        private System.Windows.Forms.MenuItem menuItem_T_Exit;
        private System.Windows.Forms.MenuItem menuItem_T_CheckAll;
        private System.Windows.Forms.MenuItem menuItem_T_Open_All;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem_T_Show;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.StatusBarPanel statusEnabledItems;
        private System.Windows.Forms.StatusBarPanel statusUpdatedItems;
        private System.Windows.Forms.StatusBarPanel statusDisabledItems;
        private System.Windows.Forms.StatusBarPanel statusDummy;
        private System.Windows.Forms.StatusBarPanel statusLastChecked;
        private System.Windows.Forms.ImageList imageListGlobe;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem_Font_Normal;
        private System.Windows.Forms.MenuItem menuItem_Font_Updated;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem menuItem_Color_Normal;
        private System.Windows.Forms.MenuItem menuItem_Color_Updated;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.MenuItem menuItem_Font_Error;
        private System.Windows.Forms.MenuItem menuItem_Color_Error;
        private System.Windows.Forms.StatusBarPanel statusErrorItems;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem_BackupList;
        private System.Windows.Forms.MenuItem menuItem_RestoreList;
        private System.Windows.Forms.ColumnHeader clmLastUpdated;
        private System.Windows.Forms.Timer timerCheckQueue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnEnable;
        private System.Windows.Forms.ToolStripButton btnCheckSelected;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton btnClearUpdated;
        private System.Windows.Forms.ToolStripButton btnOpenSelected;
        private System.Windows.Forms.ToolStripButton btnOpenAllUpdatedPages;
        private System.Windows.Forms.ColumnHeader clmNotes;
        private System.Windows.Forms.ColumnHeader clmAllowEmptyChecksum;
    }
}

