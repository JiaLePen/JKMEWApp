namespace JKMEWApp.SM.SysSetting
{
    partial class FrmParaInfo
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
            this.btnOK = new Sunny.UI.UIButton();
            this.label12 = new System.Windows.Forms.Label();
            this.gbAlarm = new System.Windows.Forms.GroupBox();
            this.chk_High = new System.Windows.Forms.CheckBox();
            this.txt_Note_High = new System.Windows.Forms.TextBox();
            this.txt_Alarm_High = new System.Windows.Forms.TextBox();
            this.chk_Low = new System.Windows.Forms.CheckBox();
            this.txt_Note_Low = new System.Windows.Forms.TextBox();
            this.txt_Alarm_Low = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIsReport = new System.Windows.Forms.CheckBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtDecimalPlaces = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkIsAlarm = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStoreArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnOK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Font = new System.Drawing.Font("宋体", 10F);
            this.btnOK.Location = new System.Drawing.Point(643, 171);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 26;
            this.btnOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnOK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Size = new System.Drawing.Size(70, 26);
            this.btnOK.Style = Sunny.UI.UIStyle.Custom;
            this.btnOK.StyleCustomMode = true;
            this.btnOK.TabIndex = 267;
            this.btnOK.Text = "确定";
            this.btnOK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(65, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(660, 3);
            this.label12.TabIndex = 266;
            // 
            // gbAlarm
            // 
            this.gbAlarm.Controls.Add(this.chk_High);
            this.gbAlarm.Controls.Add(this.txt_Note_High);
            this.gbAlarm.Controls.Add(this.txt_Alarm_High);
            this.gbAlarm.Controls.Add(this.chk_Low);
            this.gbAlarm.Controls.Add(this.txt_Note_Low);
            this.gbAlarm.Controls.Add(this.txt_Alarm_Low);
            this.gbAlarm.Controls.Add(this.label7);
            this.gbAlarm.Controls.Add(this.label5);
            this.gbAlarm.Enabled = false;
            this.gbAlarm.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbAlarm.Location = new System.Drawing.Point(82, 243);
            this.gbAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.gbAlarm.Name = "gbAlarm";
            this.gbAlarm.Padding = new System.Windows.Forms.Padding(2);
            this.gbAlarm.Size = new System.Drawing.Size(608, 178);
            this.gbAlarm.TabIndex = 265;
            this.gbAlarm.TabStop = false;
            this.gbAlarm.Text = "报警设置";
            // 
            // chk_High
            // 
            this.chk_High.AutoSize = true;
            this.chk_High.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_High.Location = new System.Drawing.Point(19, 124);
            this.chk_High.Name = "chk_High";
            this.chk_High.Size = new System.Drawing.Size(61, 24);
            this.chk_High.TabIndex = 216;
            this.chk_High.Tag = "2";
            this.chk_High.Text = "High";
            this.chk_High.UseVisualStyleBackColor = true;
            this.chk_High.CheckedChanged += new System.EventHandler(this.chk_High_CheckedChanged);
            // 
            // txt_Note_High
            // 
            this.txt_Note_High.Enabled = false;
            this.txt_Note_High.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Note_High.Location = new System.Drawing.Point(342, 122);
            this.txt_Note_High.Name = "txt_Note_High";
            this.txt_Note_High.Size = new System.Drawing.Size(235, 26);
            this.txt_Note_High.TabIndex = 215;
            // 
            // txt_Alarm_High
            // 
            this.txt_Alarm_High.Enabled = false;
            this.txt_Alarm_High.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Alarm_High.Location = new System.Drawing.Point(100, 122);
            this.txt_Alarm_High.Name = "txt_Alarm_High";
            this.txt_Alarm_High.Size = new System.Drawing.Size(106, 26);
            this.txt_Alarm_High.TabIndex = 213;
            // 
            // chk_Low
            // 
            this.chk_Low.AutoSize = true;
            this.chk_Low.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_Low.Location = new System.Drawing.Point(19, 73);
            this.chk_Low.Name = "chk_Low";
            this.chk_Low.Size = new System.Drawing.Size(55, 24);
            this.chk_Low.TabIndex = 212;
            this.chk_Low.Tag = "1";
            this.chk_Low.Text = "Low";
            this.chk_Low.UseVisualStyleBackColor = true;
            this.chk_Low.CheckedChanged += new System.EventHandler(this.chk_Low_CheckedChanged);
            // 
            // txt_Note_Low
            // 
            this.txt_Note_Low.Enabled = false;
            this.txt_Note_Low.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Note_Low.Location = new System.Drawing.Point(342, 70);
            this.txt_Note_Low.Name = "txt_Note_Low";
            this.txt_Note_Low.Size = new System.Drawing.Size(235, 26);
            this.txt_Note_Low.TabIndex = 211;
            // 
            // txt_Alarm_Low
            // 
            this.txt_Alarm_Low.Enabled = false;
            this.txt_Alarm_Low.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Alarm_Low.Location = new System.Drawing.Point(100, 71);
            this.txt_Alarm_Low.Name = "txt_Alarm_Low";
            this.txt_Alarm_Low.Size = new System.Drawing.Size(106, 26);
            this.txt_Alarm_Low.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(355, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 208;
            this.label7.Text = "注释";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(116, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 206;
            this.label5.Text = "报警值";
            // 
            // chkIsReport
            // 
            this.chkIsReport.AutoSize = true;
            this.chkIsReport.Enabled = false;
            this.chkIsReport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIsReport.Location = new System.Drawing.Point(576, 119);
            this.chkIsReport.Name = "chkIsReport";
            this.chkIsReport.Size = new System.Drawing.Size(56, 24);
            this.chkIsReport.TabIndex = 264;
            this.chkIsReport.Text = "报表";
            this.chkIsReport.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNote.Location = new System.Drawing.Point(125, 169);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(207, 26);
            this.txtNote.TabIndex = 263;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(64, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 262;
            this.label8.Text = "注释：";
            // 
            // txtSAddress
            // 
            this.txtSAddress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSAddress.Location = new System.Drawing.Point(441, 169);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(99, 26);
            this.txtSAddress.TabIndex = 259;
            // 
            // txtDecimalPlaces
            // 
            this.txtDecimalPlaces.Enabled = false;
            this.txtDecimalPlaces.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDecimalPlaces.Location = new System.Drawing.Point(633, 65);
            this.txtDecimalPlaces.Name = "txtDecimalPlaces";
            this.txtDecimalPlaces.Size = new System.Drawing.Size(96, 26);
            this.txtDecimalPlaces.TabIndex = 260;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(441, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(99, 26);
            this.txtAddress.TabIndex = 261;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(360, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 255;
            this.label6.Text = "从站地址：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(552, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 256;
            this.label9.Text = "小数位数：";
            // 
            // chkIsAlarm
            // 
            this.chkIsAlarm.AutoSize = true;
            this.chkIsAlarm.Enabled = false;
            this.chkIsAlarm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIsAlarm.Location = new System.Drawing.Point(660, 118);
            this.chkIsAlarm.Name = "chkIsAlarm";
            this.chkIsAlarm.Size = new System.Drawing.Size(56, 24);
            this.chkIsAlarm.TabIndex = 258;
            this.chkIsAlarm.Text = "报警";
            this.chkIsAlarm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(387, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 257;
            this.label4.Text = "地址：";
            // 
            // cboStoreArea
            // 
            this.cboStoreArea.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStoreArea.FormattingEnabled = true;
            this.cboStoreArea.Location = new System.Drawing.Point(125, 116);
            this.cboStoreArea.Name = "cboStoreArea";
            this.cboStoreArea.Size = new System.Drawing.Size(207, 28);
            this.cboStoreArea.TabIndex = 254;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 253;
            this.label3.Text = "存储区：";
            // 
            // cboDataType
            // 
            this.cboDataType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Location = new System.Drawing.Point(441, 65);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(99, 28);
            this.cboDataType.TabIndex = 252;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(360, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 251;
            this.label2.Text = "数据类型：";
            // 
            // txtVarName
            // 
            this.txtVarName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVarName.Location = new System.Drawing.Point(124, 65);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(208, 26);
            this.txtVarName.TabIndex = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 249;
            this.label1.Text = "参数名：";
            // 
            // FrmParaInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbAlarm);
            this.Controls.Add(this.chkIsReport);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtDecimalPlaces);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkIsAlarm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboStoreArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVarName);
            this.Controls.Add(this.label1);
            this.Name = "FrmParaInfo";
            this.Text = "参数变量";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmParaInfo_Load);
            this.gbAlarm.ResumeLayout(false);
            this.gbAlarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbAlarm;
        private System.Windows.Forms.CheckBox chk_High;
        private System.Windows.Forms.TextBox txt_Note_High;
        private System.Windows.Forms.TextBox txt_Alarm_High;
        private System.Windows.Forms.CheckBox chk_Low;
        private System.Windows.Forms.TextBox txt_Note_Low;
        private System.Windows.Forms.TextBox txt_Alarm_Low;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsReport;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtDecimalPlaces;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkIsAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStoreArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.Label label1;
    }
}