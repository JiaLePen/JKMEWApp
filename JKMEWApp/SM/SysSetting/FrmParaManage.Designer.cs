namespace JKMEWApp.SM.SysSetting
{
    partial class FrmParaManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnDel = new Sunny.UI.UIButton();
            this.dgvParaList = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ParaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecimalPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlaveAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 54);
            this.panel1.TabIndex = 76;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEdit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnEdit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEdit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEdit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnEdit.Location = new System.Drawing.Point(80, 17);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEdit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnEdit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEdit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEdit.ShowFocusLine = true;
            this.btnEdit.Size = new System.Drawing.Size(84, 25);
            this.btnEdit.Style = Sunny.UI.UIStyle.Custom;
            this.btnEdit.StyleCustomMode = true;
            this.btnEdit.TabIndex = 71;
            this.btnEdit.Text = "修改";
            this.btnEdit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnDel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnDel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnDel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnDel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnDel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDel.Location = new System.Drawing.Point(228, 17);
            this.btnDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnDel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnDel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnDel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnDel.ShowFocusLine = true;
            this.btnDel.Size = new System.Drawing.Size(84, 25);
            this.btnDel.Style = Sunny.UI.UIStyle.Custom;
            this.btnDel.StyleCustomMode = true;
            this.btnDel.TabIndex = 72;
            this.btnDel.Text = "删除";
            this.btnDel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // dgvParaList
            // 
            this.dgvParaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParaList.BackgroundColor = System.Drawing.Color.White;
            this.dgvParaList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParaList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvParaList.ColumnHeadersHeight = 30;
            this.dgvParaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.ParaName,
            this.DataType,
            this.DecimalPlaces,
            this.StoreFunction,
            this.SlaveAddress,
            this.Address,
            this.IsAlarm,
            this.IsReport,
            this.Note});
            this.dgvParaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParaList.EnableHeadersVisualStyles = false;
            this.dgvParaList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvParaList.Location = new System.Drawing.Point(0, 89);
            this.dgvParaList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvParaList.Name = "dgvParaList";
            this.dgvParaList.RowHeadersWidth = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParaList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvParaList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParaList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvParaList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvParaList.RowTemplate.DividerHeight = 1;
            this.dgvParaList.RowTemplate.Height = 30;
            this.dgvParaList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParaList.Size = new System.Drawing.Size(1012, 439);
            this.dgvParaList.TabIndex = 77;
            // 
            // colChk
            // 
            this.colChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = false;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colChk.DefaultCellStyle = dataGridViewCellStyle12;
            this.colChk.FillWeight = 40F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            this.colChk.Width = 50;
            // 
            // ParaName
            // 
            this.ParaName.DataPropertyName = "ParaName";
            this.ParaName.FillWeight = 50F;
            this.ParaName.HeaderText = "参数名";
            this.ParaName.MinimumWidth = 6;
            this.ParaName.Name = "ParaName";
            this.ParaName.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataType.DataPropertyName = "DataType";
            this.DataType.FillWeight = 80F;
            this.DataType.HeaderText = "数据类型";
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.Width = 86;
            // 
            // DecimalPlaces
            // 
            this.DecimalPlaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DecimalPlaces.DataPropertyName = "DecimalPlaces";
            this.DecimalPlaces.FillWeight = 80F;
            this.DecimalPlaces.HeaderText = "小数位数";
            this.DecimalPlaces.MinimumWidth = 6;
            this.DecimalPlaces.Name = "DecimalPlaces";
            this.DecimalPlaces.ReadOnly = true;
            this.DecimalPlaces.Width = 87;
            // 
            // StoreFunction
            // 
            this.StoreFunction.DataPropertyName = "StoreFunction";
            this.StoreFunction.FillWeight = 150F;
            this.StoreFunction.HeaderText = "存储功能区";
            this.StoreFunction.MinimumWidth = 6;
            this.StoreFunction.Name = "StoreFunction";
            this.StoreFunction.ReadOnly = true;
            // 
            // SlaveAddress
            // 
            this.SlaveAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SlaveAddress.DataPropertyName = "SlaveAddress";
            this.SlaveAddress.FillWeight = 80F;
            this.SlaveAddress.HeaderText = "从站地址";
            this.SlaveAddress.MinimumWidth = 6;
            this.SlaveAddress.Name = "SlaveAddress";
            this.SlaveAddress.ReadOnly = true;
            this.SlaveAddress.Width = 86;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 50F;
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 54;
            // 
            // IsAlarm
            // 
            this.IsAlarm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsAlarm.DataPropertyName = "IsAlarm";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = false;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.IsAlarm.DefaultCellStyle = dataGridViewCellStyle13;
            this.IsAlarm.FalseValue = "0";
            this.IsAlarm.FillWeight = 40F;
            this.IsAlarm.HeaderText = "报警";
            this.IsAlarm.MinimumWidth = 6;
            this.IsAlarm.Name = "IsAlarm";
            this.IsAlarm.ReadOnly = true;
            this.IsAlarm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAlarm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsAlarm.TrueValue = "1";
            this.IsAlarm.Width = 50;
            // 
            // IsReport
            // 
            this.IsReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsReport.DataPropertyName = "IsReport";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = false;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.IsReport.DefaultCellStyle = dataGridViewCellStyle14;
            this.IsReport.FalseValue = "0";
            this.IsReport.FillWeight = 40F;
            this.IsReport.HeaderText = "报表";
            this.IsReport.MinimumWidth = 6;
            this.IsReport.Name = "IsReport";
            this.IsReport.ReadOnly = true;
            this.IsReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsReport.TrueValue = "1";
            this.IsReport.Width = 50;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 200F;
            this.Note.HeaderText = "描述";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // FrmParaManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 528);
            this.Controls.Add(this.dgvParaList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmParaManage";
            this.Text = "参数配置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmParaManage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDel;
        private System.Windows.Forms.DataGridView dgvParaList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecimalPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlaveAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAlarm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}