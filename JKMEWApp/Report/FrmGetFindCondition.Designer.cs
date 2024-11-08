namespace JKMEWApp.Report
{
    partial class FrmGetFindCondition
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
            this.cboRegions = new System.Windows.Forms.ComboBox();
            this.btnCustReport = new System.Windows.Forms.Button();
            this.rbtnReportConfig = new System.Windows.Forms.RadioButton();
            this.rbtnDefaultSet = new System.Windows.Forms.RadioButton();
            this.rbtnRegionSet = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboRegions);
            this.groupBox1.Controls.Add(this.btnCustReport);
            this.groupBox1.Controls.Add(this.rbtnReportConfig);
            this.groupBox1.Controls.Add(this.rbtnDefaultSet);
            this.groupBox1.Controls.Add(this.rbtnRegionSet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cboRegions
            // 
            this.cboRegions.Enabled = false;
            this.cboRegions.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRegions.FormattingEnabled = true;
            this.cboRegions.Items.AddRange(new object[] {
            "冷却水系统",
            "冷冻水系统"});
            this.cboRegions.Location = new System.Drawing.Point(136, 46);
            this.cboRegions.Margin = new System.Windows.Forms.Padding(2);
            this.cboRegions.Name = "cboRegions";
            this.cboRegions.Size = new System.Drawing.Size(119, 28);
            this.cboRegions.TabIndex = 3;
            this.cboRegions.SelectedIndexChanged += new System.EventHandler(this.cboRegions_SelectedIndexChanged);
            // 
            // btnCustReport
            // 
            this.btnCustReport.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnCustReport.BackColor = System.Drawing.Color.Olive;
            this.btnCustReport.Enabled = false;
            this.btnCustReport.FlatAppearance.BorderSize = 0;
            this.btnCustReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustReport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCustReport.ForeColor = System.Drawing.Color.White;
            this.btnCustReport.Location = new System.Drawing.Point(166, 129);
            this.btnCustReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustReport.Name = "btnCustReport";
            this.btnCustReport.Size = new System.Drawing.Size(78, 26);
            this.btnCustReport.TabIndex = 2;
            this.btnCustReport.Text = "自定义报表";
            this.btnCustReport.UseVisualStyleBackColor = false;
            this.btnCustReport.Click += new System.EventHandler(this.btnCustReport_Click);
            // 
            // rbtnReportConfig
            // 
            this.rbtnReportConfig.AutoSize = true;
            this.rbtnReportConfig.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnReportConfig.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnReportConfig.Location = new System.Drawing.Point(50, 131);
            this.rbtnReportConfig.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnReportConfig.Name = "rbtnReportConfig";
            this.rbtnReportConfig.Size = new System.Drawing.Size(87, 23);
            this.rbtnReportConfig.TabIndex = 1;
            this.rbtnReportConfig.TabStop = true;
            this.rbtnReportConfig.Text = "报表配置";
            this.rbtnReportConfig.UseVisualStyleBackColor = true;
            this.rbtnReportConfig.CheckedChanged += new System.EventHandler(this.rbtnReportConfig_CheckedChanged);
            // 
            // rbtnDefaultSet
            // 
            this.rbtnDefaultSet.AutoSize = true;
            this.rbtnDefaultSet.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnDefaultSet.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnDefaultSet.Location = new System.Drawing.Point(50, 89);
            this.rbtnDefaultSet.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDefaultSet.Name = "rbtnDefaultSet";
            this.rbtnDefaultSet.Size = new System.Drawing.Size(117, 23);
            this.rbtnDefaultSet.TabIndex = 1;
            this.rbtnDefaultSet.TabStop = true;
            this.rbtnDefaultSet.Text = "默认参数设置";
            this.rbtnDefaultSet.UseVisualStyleBackColor = true;
            this.rbtnDefaultSet.CheckedChanged += new System.EventHandler(this.rbtnDefaultSet_CheckedChanged);
            // 
            // rbtnRegionSet
            // 
            this.rbtnRegionSet.AutoSize = true;
            this.rbtnRegionSet.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnRegionSet.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnRegionSet.Location = new System.Drawing.Point(50, 48);
            this.rbtnRegionSet.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnRegionSet.Name = "rbtnRegionSet";
            this.rbtnRegionSet.Size = new System.Drawing.Size(87, 23);
            this.rbtnRegionSet.TabIndex = 1;
            this.rbtnRegionSet.TabStop = true;
            this.rbtnRegionSet.Text = "按区域：";
            this.rbtnRegionSet.UseVisualStyleBackColor = true;
            this.rbtnRegionSet.CheckedChanged += new System.EventHandler(this.rbtnRegionSet_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件设置：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(233, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(106, 315);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(50, 26);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmGetFindCondition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(415, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmGetFindCondition";
            this.Text = "报表查询条件";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmGetFindCondition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboRegions;
        private System.Windows.Forms.Button btnCustReport;
        private System.Windows.Forms.RadioButton rbtnReportConfig;
        private System.Windows.Forms.RadioButton rbtnDefaultSet;
        private System.Windows.Forms.RadioButton rbtnRegionSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}