namespace WebsiteTracker
{
    partial class FormItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItem));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateContent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAllowEmptyChecksum = new System.Windows.Forms.CheckBox();
            this.btnScrollToHit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnUseStop = new System.Windows.Forms.Button();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUseStart = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkAutomatic = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.numericDays = new System.Windows.Forms.NumericUpDown();
            this.labelChecksum = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(73, 28);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(543, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.control_ValueChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(588, 725);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(684, 725);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnUpdateContent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic info";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(73, 81);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(669, 49);
            this.txtNotes.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Notes:";
            // 
            // btnUpdateContent
            // 
            this.btnUpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateContent.Enabled = false;
            this.btnUpdateContent.Location = new System.Drawing.Point(622, 26);
            this.btnUpdateContent.Name = "btnUpdateContent";
            this.btnUpdateContent.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateContent.TabIndex = 1;
            this.btnUpdateContent.Text = "Update content";
            this.btnUpdateContent.UseVisualStyleBackColor = true;
            this.btnUpdateContent.Click += new System.EventHandler(this.btnUpdateContent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(73, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(669, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkAllowEmptyChecksum);
            this.groupBox1.Controls.Add(this.btnScrollToHit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnUseStop);
            this.groupBox1.Controls.Add(this.txtStop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnUseStart);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 446);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // checkAllowEmptyChecksum
            // 
            this.checkAllowEmptyChecksum.AutoSize = true;
            this.checkAllowEmptyChecksum.Checked = true;
            this.checkAllowEmptyChecksum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllowEmptyChecksum.Location = new System.Drawing.Point(201, 84);
            this.checkAllowEmptyChecksum.Name = "checkAllowEmptyChecksum";
            this.checkAllowEmptyChecksum.Size = new System.Drawing.Size(110, 17);
            this.checkAllowEmptyChecksum.TabIndex = 7;
            this.checkAllowEmptyChecksum.Text = "Allow empty result";
            this.checkAllowEmptyChecksum.UseVisualStyleBackColor = true;
            // 
            // btnScrollToHit
            // 
            this.btnScrollToHit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScrollToHit.Location = new System.Drawing.Point(622, 80);
            this.btnScrollToHit.Name = "btnScrollToHit";
            this.btnScrollToHit.Size = new System.Drawing.Size(120, 23);
            this.btnScrollToHit.TabIndex = 6;
            this.btnScrollToHit.Text = "Scroll to result";
            this.btnScrollToHit.UseVisualStyleBackColor = true;
            this.btnScrollToHit.Click += new System.EventHandler(this.BtnScrollToHit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Page source:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(22, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(720, 309);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnUseStop
            // 
            this.btnUseStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseStop.Location = new System.Drawing.Point(622, 54);
            this.btnUseStop.Name = "btnUseStop";
            this.btnUseStop.Size = new System.Drawing.Size(120, 23);
            this.btnUseStop.TabIndex = 3;
            this.btnUseStop.Text = "Use selected text";
            this.btnUseStop.UseVisualStyleBackColor = true;
            this.btnUseStop.Click += new System.EventHandler(this.btnUseStop_Click);
            // 
            // txtStop
            // 
            this.txtStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStop.Location = new System.Drawing.Point(201, 56);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(415, 20);
            this.txtStop.TabIndex = 2;
            this.txtStop.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To the following text:";
            // 
            // btnUseStart
            // 
            this.btnUseStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseStart.Location = new System.Drawing.Point(622, 28);
            this.btnUseStart.Name = "btnUseStart";
            this.btnUseStart.Size = new System.Drawing.Size(120, 23);
            this.btnUseStart.TabIndex = 1;
            this.btnUseStart.Text = "Use selected text";
            this.btnUseStart.UseVisualStyleBackColor = true;
            this.btnUseStart.Click += new System.EventHandler(this.btnUseStart_Click);
            // 
            // txtStart
            // 
            this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart.Location = new System.Drawing.Point(201, 30);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(415, 20);
            this.txtStart.TabIndex = 0;
            this.txtStart.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filter content from the following text:";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(463, 19);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(213, 57);
            this.txtContent.TabIndex = 0;
            this.txtContent.Visible = false;
            this.txtContent.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtResult.Location = new System.Drawing.Point(704, 31);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(52, 29);
            this.txtResult.TabIndex = 0;
            this.txtResult.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkAutomatic);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.txtContent);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericMinutes);
            this.groupBox3.Controls.Add(this.numericHours);
            this.groupBox3.Controls.Add(this.numericDays);
            this.groupBox3.Location = new System.Drawing.Point(12, 624);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check interval";
            // 
            // checkAutomatic
            // 
            this.checkAutomatic.AutoSize = true;
            this.checkAutomatic.Checked = true;
            this.checkAutomatic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutomatic.Location = new System.Drawing.Point(22, 41);
            this.checkAutomatic.Name = "checkAutomatic";
            this.checkAutomatic.Size = new System.Drawing.Size(155, 17);
            this.checkAutomatic.TabIndex = 0;
            this.checkAutomatic.Text = "Enable automatic checking";
            this.checkAutomatic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Days";
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(382, 40);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(60, 20);
            this.numericMinutes.TabIndex = 3;
            this.numericMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMinutes.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(306, 40);
            this.numericHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(60, 20);
            this.numericHours.TabIndex = 2;
            this.numericHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericHours.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // numericDays
            // 
            this.numericDays.Location = new System.Drawing.Point(230, 40);
            this.numericDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericDays.Name = "numericDays";
            this.numericDays.Size = new System.Drawing.Size(60, 20);
            this.numericDays.TabIndex = 1;
            this.numericDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericDays.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // labelChecksum
            // 
            this.labelChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChecksum.AutoSize = true;
            this.labelChecksum.Location = new System.Drawing.Point(31, 730);
            this.labelChecksum.Name = "labelChecksum";
            this.labelChecksum.Size = new System.Drawing.Size(60, 13);
            this.labelChecksum.TabIndex = 1;
            this.labelChecksum.Text = "Checksum:";
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 760);
            this.Controls.Add(this.labelChecksum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.Load += new System.EventHandler(this.FormItem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUseStop;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUseStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.NumericUpDown numericDays;
        private System.Windows.Forms.CheckBox checkAutomatic;
        private System.Windows.Forms.Label labelChecksum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnScrollToHit;
        private System.Windows.Forms.CheckBox checkAllowEmptyChecksum;
    }
}