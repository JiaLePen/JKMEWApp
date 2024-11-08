namespace JKMEWApp.SM.SysSetting
{
    partial class FrmModbusSet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.rbtnRTU = new System.Windows.Forms.RadioButton();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBauds = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboConnection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new Sunny.UI.UIButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbtnASCII);
            this.groupBox1.Controls.Add(this.rbtnRTU);
            this.groupBox1.Controls.Add(this.cboParity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboStopBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboDataBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboBauds);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboConnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(83, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(568, 244);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnASCII.Location = new System.Drawing.Point(171, 206);
            this.rbtnASCII.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(61, 23);
            this.rbtnASCII.TabIndex = 34;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            // 
            // rbtnRTU
            // 
            this.rbtnRTU.AutoSize = true;
            this.rbtnRTU.Checked = true;
            this.rbtnRTU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRTU.Location = new System.Drawing.Point(94, 208);
            this.rbtnRTU.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnRTU.Name = "rbtnRTU";
            this.rbtnRTU.Size = new System.Drawing.Size(54, 23);
            this.rbtnRTU.TabIndex = 35;
            this.rbtnRTU.TabStop = true;
            this.rbtnRTU.Text = "RTU";
            this.rbtnRTU.UseVisualStyleBackColor = true;
            // 
            // cboParity
            // 
            this.cboParity.BackColor = System.Drawing.Color.Gray;
            this.cboParity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboParity.ForeColor = System.Drawing.Color.White;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cboParity.Location = new System.Drawing.Point(364, 145);
            this.cboParity.Margin = new System.Windows.Forms.Padding(2);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(140, 25);
            this.cboParity.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(294, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "校验位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "模式：";
            // 
            // cboStopBits
            // 
            this.cboStopBits.BackColor = System.Drawing.Color.Gray;
            this.cboStopBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStopBits.ForeColor = System.Drawing.Color.White;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(94, 143);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(140, 25);
            this.cboStopBits.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "停止位：";
            // 
            // cboDataBits
            // 
            this.cboDataBits.BackColor = System.Drawing.Color.Gray;
            this.cboDataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDataBits.ForeColor = System.Drawing.Color.White;
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cboDataBits.Location = new System.Drawing.Point(364, 86);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(140, 25);
            this.cboDataBits.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(294, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "数据位：";
            // 
            // cboBauds
            // 
            this.cboBauds.BackColor = System.Drawing.Color.Gray;
            this.cboBauds.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBauds.ForeColor = System.Drawing.Color.White;
            this.cboBauds.FormattingEnabled = true;
            this.cboBauds.Items.AddRange(new object[] {
            "9600",
            "4800",
            "14400",
            "19200",
            "38400"});
            this.cboBauds.Location = new System.Drawing.Point(94, 85);
            this.cboBauds.Margin = new System.Windows.Forms.Padding(2);
            this.cboBauds.Name = "cboBauds";
            this.cboBauds.Size = new System.Drawing.Size(140, 25);
            this.cboBauds.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "波特率：";
            // 
            // cboPorts
            // 
            this.cboPorts.BackColor = System.Drawing.Color.Gray;
            this.cboPorts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPorts.ForeColor = System.Drawing.Color.White;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(364, 36);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(140, 25);
            this.cboPorts.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(308, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "端口：";
            // 
            // cboConnection
            // 
            this.cboConnection.BackColor = System.Drawing.Color.Gray;
            this.cboConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboConnection.ForeColor = System.Drawing.Color.White;
            this.cboConnection.FormattingEnabled = true;
            this.cboConnection.Items.AddRange(new object[] {
            "串口"});
            this.cboConnection.Location = new System.Drawing.Point(94, 36);
            this.cboConnection.Margin = new System.Windows.Forms.Padding(2);
            this.cboConnection.Name = "cboConnection";
            this.cboConnection.Size = new System.Drawing.Size(140, 25);
            this.cboConnection.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(23, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modbus参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "连接：";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnOK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOK.Location = new System.Drawing.Point(316, 338);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnOK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.ShowFocusLine = true;
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.Style = Sunny.UI.UIStyle.Custom;
            this.btnOK.StyleCustomMode = true;
            this.btnOK.TabIndex = 68;
            this.btnOK.Text = "提交";
            this.btnOK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmModbusSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(730, 402);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmModbusSet";
            this.Text = "Modbus参数设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmModbusSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.RadioButton rbtnRTU;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBauds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnOK;
    }
}