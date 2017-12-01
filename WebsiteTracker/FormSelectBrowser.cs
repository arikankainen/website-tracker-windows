using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteTracker
{
    public partial class FormSelectBrowser : Form
    {
        private bool cancelled = true;
        public bool Cancelled
        {
            get { return cancelled; }
        }

        public bool UseCustom
        {
            get { return radioButton2.Checked; }

            set
            {
                if (value) radioButton2.Checked = true;
                else radioButton1.Checked = true;
            }
        }

        public string SelectedBrowser
        {
            get { return txtBrowserPath.Text; }
            set { txtBrowserPath.Text = value; }
        }

        public FormSelectBrowser()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectBrowser.Enabled = false;
            txtBrowserPath.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectBrowser.Enabled = true;
            txtBrowserPath.Enabled = true;
        }

        private void btnSelectBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            dlg.Multiselect = false;
            if (File.Exists(txtBrowserPath.Text)) dlg.InitialDirectory = Path.GetDirectoryName(txtBrowserPath.Text);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dlg.FileName)) txtBrowserPath.Text = dlg.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cancelled = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
