using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WebsiteTracker
{
    public partial class FormItem : Form
    {
        private bool cancelled = true;
        public bool Cancelled
        {
            get { return cancelled; }
        }

        public string ItemName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string ItemEnabled
        {
            get
            {
                if (checkAutomatic.Checked) return "X";
                else return "";
            }

            set
            {
                if (value != "") checkAutomatic.Checked = true;
            }
        }

        public string ItemAddress
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public string ItemInterval
        {
            get { return GetInterval(); }
            set { SetInterval(value); }
        }

        public string ItemStart
        {
            get { return txtStart.Text; }
            set { txtStart.Text = value; }
        }

        public string ItemStop
        {
            get { return txtStop.Text; }
            set { txtStop.Text = value; }
        }

        public string ItemChecksum
        {
            get { return CheckChanges.GetChecksum(txtContent.Text, txtStart.Text, txtStop.Text); }
        }

        private Thread thread;

        public FormItem()
        {
            InitializeComponent();
        }

        private void UpdateContentAsync(string address)
        {
            string source = CheckChanges.GetSource(address);

            Action action = () => UpdateContent(source);
            this.Invoke(action);
        }

        private void UpdateContent(string source)
        {
            txtContent.Text = source;
            btnUpdateContent.Enabled = true;
        }

        private void SetInterval(string text)
        {
            Match m = Regex.Match(text, @"(\d+)d (\d+)h (\d+)m");

            numericDays.Value = Convert.ToInt32(m.Groups[1].Value);
            numericHours.Value = Convert.ToInt32(m.Groups[2].Value);
            numericMinutes.Value = Convert.ToInt32(m.Groups[3].Value);
        }

        private string GetInterval()
        {
            string days = numericDays.Value.ToString();
            string hours = numericHours.Value.ToString();
            string minutes = numericMinutes.Value.ToString();

            return days + "d " + hours + "h " + minutes + "m";
        }

        /*************************************************************************/
        // EVENTS
        /*************************************************************************/

        private void FormItem_Load(object sender, EventArgs e)
        {
            btnUpdateContent.PerformClick();
        }

        private void btnUpdateContent_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                btnUpdateContent.Enabled = false;
                txtContent.Text = "Updating content...";

                thread = new Thread(() => UpdateContentAsync(txtAddress.Text));
                thread.IsBackground = true;
                thread.Start();
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

        private void control_ValueChanged(object sender, EventArgs e)
        {
            labelChecksum.Text = "Checksum: " + CheckChanges.GetChecksum(txtContent.Text, txtStart.Text, txtStop.Text);
            txtResult.Text = CheckChanges.GetResult(txtContent.Text, txtStart.Text, txtStop.Text);

            if (txtAddress.Text != "") btnUpdateContent.Enabled = true;
            else btnUpdateContent.Enabled = false;

            if (txtName.Text != "" && txtAddress.Text != "" && txtContent.Text != "" && txtResult.Text != "" && (numericDays.Value > 0 || numericHours.Value > 0 || numericMinutes.Value > 0)) btnOk.Enabled = true;
            else btnOk.Enabled = false;
        }

        private void btnUseStart_Click(object sender, EventArgs e)
        {
            txtStart.Text = txtContent.SelectedText;
        }

        private void btnUseStop_Click(object sender, EventArgs e)
        {
            txtStop.Text = txtContent.SelectedText;
        }

        private void txtContent_SelectionChanged(object sender, EventArgs e)
        {
            if (txtContent.SelectedText.Length > 0) btnUseStart.Enabled = btnUseStop.Enabled = true;
            else btnUseStart.Enabled = btnUseStop.Enabled = false;
        }
    }
}
