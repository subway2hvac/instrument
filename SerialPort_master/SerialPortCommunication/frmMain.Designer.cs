namespace PCComm
{
    partial class frmMain
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.chkBoxEOL = new System.Windows.Forms.CheckBox();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(197, 136);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(164, 35);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "CLOSE PORT";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(197, 136);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(164, 35);
            this.cmdOpen.TabIndex = 3;
            this.cmdOpen.Text = "OPEN PORT";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // chkBoxEOL
            // 
            this.chkBoxEOL.AutoSize = true;
            this.chkBoxEOL.Checked = true;
            this.chkBoxEOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxEOL.Location = new System.Drawing.Point(52, 735);
            this.chkBoxEOL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkBoxEOL.Name = "chkBoxEOL";
            this.chkBoxEOL.Size = new System.Drawing.Size(112, 29);
            this.chkBoxEOL.TabIndex = 9;
            this.chkBoxEOL.Text = "Add EOL";
            this.chkBoxEOL.UseVisualStyleBackColor = true;
            this.chkBoxEOL.CheckedChanged += new System.EventHandler(this.chkBoxEOL_CheckedChanged);
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaud.Location = new System.Drawing.Point(33, 197);
            this.cboBaud.Margin = new System.Windows.Forms.Padding(0);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(134, 33);
            this.cboBaud.TabIndex = 11;
            this.cboBaud.SelectedIndexChanged += new System.EventHandler(this.cboBaud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "BAUD RATE";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(26, 111);
            this.Label1.Margin = new System.Windows.Forms.Padding(0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 25);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "PORT";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(34, 136);
            this.cboPort.Margin = new System.Windows.Forms.Padding(0);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(133, 33);
            this.cboPort.TabIndex = 10;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // txtSend
            // 
            this.txtSend.Enabled = false;
            this.txtSend.Location = new System.Drawing.Point(52, 680);
            this.txtSend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(262, 31);
            this.txtSend.TabIndex = 4;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(417, 665);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(140, 46);
            this.cmdSend.TabIndex = 5;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "PM2.5";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(208, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "PM10";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("¸¼Àº °íµñ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox2.Location = new System.Drawing.Point(267, 293);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(124, 65);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Font = new System.Drawing.Font("¸¼Àº °íµñ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtbDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbDisplay.Location = new System.Drawing.Point(76, 295);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(123, 63);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            this.rtbDisplay.TextChanged += new System.EventHandler(this.rtbDisplay_TextChanged);
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(484, 565);
            this.cboParity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(96, 33);
            this.cboParity.TabIndex = 12;
            this.cboParity.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(475, 532);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parity";
            this.label3.Visible = false;
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(484, 646);
            this.cboStop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(96, 33);
            this.cboStop.TabIndex = 13;
            this.cboStop.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 614);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stop Bits";
            this.label4.Visible = false;
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(484, 724);
            this.cboData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(96, 33);
            this.cboData.TabIndex = 14;
            this.cboData.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 694);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Bits";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "¿Âµµ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(76, 398);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(123, 63);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(268, 398);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(123, 63);
            this.richTextBox3.TabIndex = 28;
            this.richTextBox3.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(211, 413);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "¿Âµµ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(453, 398);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(123, 63);
            this.richTextBox4.TabIndex = 30;
            this.richTextBox4.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(399, 413);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "¿Âµµ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PCComm.Properties.Resources.nstek;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 823);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.chkBoxEOL);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBaud);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboParity);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("¸¼Àº °íµñ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.CheckBox chkBoxEOL;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label10;
    }
}