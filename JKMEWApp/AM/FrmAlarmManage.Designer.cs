namespace JKMEWApp.AM
{
    partial class FrmAlarmManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvAlarmList = new System.Windows.Forms.DataGridView();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtPageSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colATypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAlarmPager = new JKMEWApp.CstControls.UPager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 55);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "开始时间：";
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEnd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(405, 14);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(186, 27);
            this.dtEnd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(321, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "结束时间：";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStart.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(120, 14);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(182, 27);
            this.dtStart.TabIndex = 10;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(659, 10);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 34);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvAlarmList
            // 
            this.dgvAlarmList.AllowUserToAddRows = false;
            this.dgvAlarmList.AllowUserToDeleteRows = false;
            this.dgvAlarmList.AllowUserToResizeColumns = false;
            this.dgvAlarmList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlarmList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarmList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlarmList.ColumnHeadersHeight = 40;
            this.dgvAlarmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlarmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colId,
            this.colAlarmTime,
            this.colATypeName,
            this.colAlarmState,
            this.colCurrentVal,
            this.colAlarmValue,
            this.colLoginUser,
            this.colAlarmNote});
            this.dgvAlarmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarmList.EnableHeadersVisualStyles = false;
            this.dgvAlarmList.Location = new System.Drawing.Point(0, 90);
            this.dgvAlarmList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlarmList.Name = "dgvAlarmList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarmList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlarmList.RowHeadersWidth = 30;
            this.dgvAlarmList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvAlarmList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAlarmList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvAlarmList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvAlarmList.RowTemplate.Height = 30;
            this.dgvAlarmList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarmList.Size = new System.Drawing.Size(966, 480);
            this.dgvAlarmList.TabIndex = 15;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(467, 537);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(42, 26);
            this.btnSet.TabIndex = 100;
            this.btnSet.Text = "确定";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtPageSize
            // 
            this.txtPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageSize.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPageSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPageSize.Location = new System.Drawing.Point(391, 537);
            this.txtPageSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPageSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(62, 27);
            this.txtPageSize.TabIndex = 101;
            this.txtPageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(307, 537);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "显示条数：";
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "AlarmLogId";
            this.colId.FillWeight = 50F;
            this.colId.HeaderText = "编号";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colAlarmTime
            // 
            this.colAlarmTime.DataPropertyName = "AlarmTime";
            this.colAlarmTime.FillWeight = 150F;
            this.colAlarmTime.HeaderText = "报警时间";
            this.colAlarmTime.MinimumWidth = 6;
            this.colAlarmTime.Name = "colAlarmTime";
            this.colAlarmTime.ReadOnly = true;
            // 
            // colATypeName
            // 
            this.colATypeName.DataPropertyName = "ATypeName";
            this.colATypeName.FillWeight = 80F;
            this.colATypeName.HeaderText = "报警类型";
            this.colATypeName.MinimumWidth = 6;
            this.colATypeName.Name = "colATypeName";
            this.colATypeName.ReadOnly = true;
            // 
            // colAlarmState
            // 
            this.colAlarmState.DataPropertyName = "AlarmState";
            this.colAlarmState.FillWeight = 80F;
            this.colAlarmState.HeaderText = "报警状态";
            this.colAlarmState.MinimumWidth = 6;
            this.colAlarmState.Name = "colAlarmState";
            this.colAlarmState.ReadOnly = true;
            // 
            // colCurrentVal
            // 
            this.colCurrentVal.DataPropertyName = "Value";
            this.colCurrentVal.FillWeight = 50F;
            this.colCurrentVal.HeaderText = "当前值";
            this.colCurrentVal.MinimumWidth = 6;
            this.colCurrentVal.Name = "colCurrentVal";
            this.colCurrentVal.ReadOnly = true;
            // 
            // colAlarmValue
            // 
            this.colAlarmValue.DataPropertyName = "AlarmValue";
            this.colAlarmValue.FillWeight = 50F;
            this.colAlarmValue.HeaderText = "报警值";
            this.colAlarmValue.MinimumWidth = 6;
            this.colAlarmValue.Name = "colAlarmValue";
            this.colAlarmValue.ReadOnly = true;
            // 
            // colLoginUser
            // 
            this.colLoginUser.DataPropertyName = "LoginUser";
            this.colLoginUser.HeaderText = "登录用户";
            this.colLoginUser.MinimumWidth = 6;
            this.colLoginUser.Name = "colLoginUser";
            this.colLoginUser.ReadOnly = true;
            this.colLoginUser.Visible = false;
            // 
            // colAlarmNote
            // 
            this.colAlarmNote.DataPropertyName = "AlarmNote";
            this.colAlarmNote.FillWeight = 150F;
            this.colAlarmNote.HeaderText = "报警描述";
            this.colAlarmNote.MinimumWidth = 6;
            this.colAlarmNote.Name = "colAlarmNote";
            this.colAlarmNote.ReadOnly = true;
            // 
            // uAlarmPager
            // 
            this.uAlarmPager.CurrentPage = 1;
            this.uAlarmPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uAlarmPager.Location = new System.Drawing.Point(0, 526);
            this.uAlarmPager.Name = "uAlarmPager";
            this.uAlarmPager.PageSize = 5;
            this.uAlarmPager.Record = 0;
            this.uAlarmPager.Size = new System.Drawing.Size(966, 44);
            this.uAlarmPager.TabIndex = 98;
            // 
            // FrmAlarmManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uAlarmPager);
            this.Controls.Add(this.dgvAlarmList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAlarmManage";
            this.Text = "报警管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmAlarmManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvAlarmList;
        private CstControls.UPager uAlarmPager;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown txtPageSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmNote;
    }
}