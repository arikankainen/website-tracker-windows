using System;
using System.Windows.Forms;

namespace WebsiteTracker
{
    class VisualStylesListView : ListView
    {

        // The ListView control has a flicker issue. The problem appears to be that the control's Update overload is improperly
        // implemented such that it acts like a Refresh. An Update should cause the control to redraw only its invalid regions
        // whereas a Refresh redraws the control’s entire client area. So if you were to change, say, the background color of one
        // item in the list then only that particular item should need to be repainted. Unfortunately, the ListView control seems
        // to be of a different opinion and wants to repaint its entire surface whenever you mess with a single item… even if the
        // item is not currently being displayed. So, anyways, you can easily suppress the flicker by rolling your own as follows:
        public VisualStylesListView()
        {
            //Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            // Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        // this is for flicker issue too
        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

        // enable visual styles
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!this.DesignMode && Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
                NativeMethods.SetWindowTheme(this.Handle, "explorer", null);
        }
    }

    class VisualStylesTreeView : TreeView
    {

        // The ListView control has a flicker issue. The problem appears to be that the control's Update overload is improperly
        // implemented such that it acts like a Refresh. An Update should cause the control to redraw only its invalid regions
        // whereas a Refresh redraws the control’s entire client area. So if you were to change, say, the background color of one
        // item in the list then only that particular item should need to be repainted. Unfortunately, the ListView control seems
        // to be of a different opinion and wants to repaint its entire surface whenever you mess with a single item… even if the
        // item is not currently being displayed. So, anyways, you can easily suppress the flicker by rolling your own as follows:
        public VisualStylesTreeView()
        {
            //Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            // Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        // this is for flicker issue too
        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

        // enable visual styles
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!this.DesignMode && Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
                NativeMethods.SetWindowTheme(this.Handle, "explorer", null);
        }
    }
}
