using System;
using System.Drawing;
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
                if (checkAutomatic.Checked) return "Yes";
                else return "";
            }

            set
            {
                if (value != "") checkAutomatic.Checked = true;
                else checkAutomatic.Checked = false;
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
        private Color errorColor = Color.FromArgb(255, 200, 200);

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
            richTextBox1.Text = txtContent.Text = source;
            btnUpdateContent.Enabled = true;

            if (txtName.Text == "") txtName.Text = ParseTitle();

            UpdateRTB();
        }

        private string ParseTitle()
        {
            Match m = Regex.Match(txtContent.Text, "<title>" + "(.*?)" + "</title>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            return m.Groups[1].Value.Trim();
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
                if (!txtAddress.Text.Contains(@"://")) txtAddress.Text = "http://" + txtAddress.Text;
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

            UpdateRTB();
        }

        private void UpdateRTB()
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.TextLength;
            richTextBox1.SelectionColor = System.Drawing.Color.Black;

            int selectionStart, selectionStartLen;

            selectionStart = richTextBox1.Text.IndexOf(txtStart.Text);

            if (selectionStart > -1)
            {
                selectionStartLen = txtStart.TextLength;
                richTextBox1.SelectionStart = selectionStart;
                richTextBox1.SelectionLength = selectionStartLen;
                richTextBox1.SelectionColor = System.Drawing.Color.Red;
            }

            int selectionEnd, selectionEndLen;
            int endBegin = 0;

            if (selectionStart > -1) endBegin = selectionStart + txtStart.TextLength;

            selectionEnd = richTextBox1.Text.IndexOf(txtStop.Text, endBegin);
            if (selectionEnd == endBegin) selectionEnd = -1;

            if (selectionEnd > -1)
            {
                selectionEndLen = txtStop.TextLength;
                richTextBox1.SelectionStart = selectionEnd;
                richTextBox1.SelectionLength = selectionEndLen;
                richTextBox1.SelectionColor = System.Drawing.Color.Red;
            }

            bool error = false;

            if (txtStart.Text != "" && selectionStart == -1)
            {
                error = true;
                txtStart.BackColor = errorColor;
            }

            else txtStart.BackColor = Color.White;

            if (txtStop.Text != "" && selectionEnd == -1)
            {
                error = true;
                txtStop.BackColor = errorColor;
            }
            else txtStop.BackColor = Color.White;

            if (!error)
            {

                int selection = 0, selectionLen = 0;

                if (selectionStart > -1) selection = selectionStart + txtStart.TextLength;

                if (selectionEnd > -1) selectionLen = selectionEnd - selection;
                else selectionLen = richTextBox1.TextLength - selection;

                richTextBox1.SelectionStart = selection;
                richTextBox1.SelectionLength = selectionLen;
                richTextBox1.SelectionColor = System.Drawing.Color.Blue;
            }

            richTextBox1.DeselectAll();
        }

        private void btnUseStart_Click(object sender, EventArgs e)
        {
            txtStart.Text = richTextBox1.SelectedText;
        }

        private void btnUseStop_Click(object sender, EventArgs e)
        {
            txtStop.Text = richTextBox1.SelectedText;
        }

        private void txtContent_SelectionChanged(object sender, EventArgs e)
        {
            if (txtContent.SelectedText.Length > 0) btnUseStart.Enabled = btnUseStop.Enabled = true;
            else btnUseStart.Enabled = btnUseStop.Enabled = false;
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnUpdateContent.PerformClick();
        }
    }
}
