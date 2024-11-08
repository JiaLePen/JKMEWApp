namespace JKMEWApp.SM
{
    partial class FrmRoleList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnOK = new Sunny.UI.UIButton();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Sunny.UI.UIButton();
            this.chkDel = new Sunny.UI.UICheckBox();
            this.btnRemove = new Sunny.UI.UIButton();
            this.btnRecover = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnRightAssign = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uiGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnClear);
            this.uiGroupBox1.Controls.Add(this.btnOK);
            this.uiGroupBox1.Controls.Add(this.txtRemark);
            this.uiGroupBox1.Controls.Add(this.txtRoleName);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 35);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1073, 112);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "角色信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.FillColor2 = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(110, 79);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.DarkGray;
            this.btnClear.Size = new System.Drawing.Size(53, 21);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清空";
            this.btnClear.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(40, 79);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 21);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "新增";
            this.btnOK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(316, 29);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(462, 62);
            this.txtRemark.TabIndex = 20;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(79, 34);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(121, 26);
            this.txtRoleName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(249, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "角色描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "角色名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAdd.Location = new System.Drawing.Point(8, 8);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnAdd.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnAdd.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnAdd.ShowFocusLine = true;
            this.btnAdd.Size = new System.Drawing.Size(71, 28);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.StyleCustomMode = true;
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkDel
            // 
            this.chkDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.chkDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkDel.Location = new System.Drawing.Point(565, 8);
            this.chkDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkDel.Name = "chkDel";
            this.chkDel.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chkDel.Size = new System.Drawing.Size(79, 35);
            this.chkDel.TabIndex = 77;
            this.chkDel.Text = "已删除";
            this.chkDel.CheckedChanged += new System.EventHandler(this.chkDel_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRemove.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRemove.Location = new System.Drawing.Point(972, 8);
            this.btnRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRemove.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.ShowFocusLine = true;
            this.btnRemove.Size = new System.Drawing.Size(71, 28);
            this.btnRemove.Style = Sunny.UI.UIStyle.Custom;
            this.btnRemove.StyleCustomMode = true;
            this.btnRemove.TabIndex = 76;
            this.btnRemove.Text = "移除";
            this.btnRemove.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnRecover.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnRecover.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnRecover.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnRecover.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnRecover.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRecover.Location = new System.Drawing.Point(891, 8);
            this.btnRecover.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnRecover.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnRecover.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnRecover.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnRecover.ShowFocusLine = true;
            this.btnRecover.Size = new System.Drawing.Size(71, 28);
            this.btnRecover.Style = Sunny.UI.UIStyle.Custom;
            this.btnRecover.StyleCustomMode = true;
            this.btnRecover.TabIndex = 75;
            this.btnRecover.Text = "恢复";
            this.btnRecover.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnDelete.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDelete.Location = new System.Drawing.Point(811, 8);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnDelete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnDelete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnDelete.ShowFocusLine = true;
            this.btnDelete.Size = new System.Drawing.Size(71, 28);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.StyleCustomMode = true;
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "删除";
            this.btnDelete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnEdit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnEdit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnEdit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnEdit.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEdit.Location = new System.Drawing.Point(731, 8);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnEdit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnEdit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnEdit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnEdit.ShowFocusLine = true;
            this.btnEdit.Size = new System.Drawing.Size(71, 28);
            this.btnEdit.Style = Sunny.UI.UIStyle.Custom;
            this.btnEdit.StyleCustomMode = true;
            this.btnEdit.TabIndex = 73;
            this.btnEdit.Text = "修改";
            this.btnEdit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRightAssign
            // 
            this.btnRightAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightAssign.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRightAssign.Location = new System.Drawing.Point(650, 8);
            this.btnRightAssign.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRightAssign.Name = "btnRightAssign";
            this.btnRightAssign.ShowFocusLine = true;
            this.btnRightAssign.ShowTips = true;
            this.btnRightAssign.Size = new System.Drawing.Size(71, 28);
            this.btnRightAssign.Style = Sunny.UI.UIStyle.Custom;
            this.btnRightAssign.StyleCustomMode = true;
            this.btnRightAssign.TabIndex = 72;
            this.btnRightAssign.Text = "权限分配";
            this.btnRightAssign.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRightAssign);
            this.panel1.Controls.Add(this.chkDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRecover);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 47);
            this.panel1.TabIndex = 79;
            // 
            // dgvRole
            // 
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.BackgroundColor = System.Drawing.Color.White;
            this.dgvRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvRole.ColumnHeadersHeight = 30;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewLinkColumn1});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.EnableHeadersVisualStyles = false;
            this.dgvRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvRole.Location = new System.Drawing.Point(0, 194);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 30;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvRole.RowTemplate.DividerHeight = 1;
            this.dgvRole.RowTemplate.Height = 30;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(1073, 348);
            this.dgvRole.TabIndex = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.NullValue = false;
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "选择";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoleId";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoleName";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "角色名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsAdmin";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.NullValue = false;
            dataGridViewCellStyle40.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridViewCheckBoxColumn2.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewCheckBoxColumn2.FillWeight = 40F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "是否管理员";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "角色描述";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewLinkColumn1
            // 
            dataGridViewCellStyle41.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle41.NullValue = "分配权限";
            dataGridViewCellStyle41.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.dataGridViewLinkColumn1.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewLinkColumn1.FillWeight = 40F;
            this.dataGridViewLinkColumn1.HeaderText = "权限分配";
            this.dataGridViewLinkColumn1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.dataGridViewLinkColumn1.LinkColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewLinkColumn1.MinimumWidth = 6;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmRoleList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1073, 542);
            this.Controls.Add(this.dgvRole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "FrmRoleList";
            this.Text = "角色管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmRoleList_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UICheckBox chkDel;
        private Sunny.UI.UIButton btnRemove;
        private Sunny.UI.UIButton btnRecover;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnRightAssign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
    }
}