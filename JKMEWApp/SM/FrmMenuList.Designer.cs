namespace JKMEWApp.SM
{
    partial class FrmMenuList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnOK = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboParentList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkEmbedded = new System.Windows.Forms.RadioButton();
            this.chkTop = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtOrder = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFrm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnRecover = new Sunny.UI.UIButton();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnRemove = new Sunny.UI.UIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDel = new Sunny.UI.UICheckBox();
            this.btnDelete = new Sunny.UI.UIButton();
            this.dgvMenuList = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTop = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMenuPager = new JKMEWApp.CstControls.UPager();
            this.gbInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnClear);
            this.gbInfo.Controls.Add(this.btnOK);
            this.gbInfo.Controls.Add(this.flowLayoutPanel1);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbInfo.Location = new System.Drawing.Point(0, 35);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfo.Size = new System.Drawing.Size(1073, 120);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.FillColor2 = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(135, 92);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.DarkGray;
            this.btnClear.Size = new System.Drawing.Size(53, 21);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清空";
            this.btnClear.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(39, 92);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 21);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "新增";
            this.btnOK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 65);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMenuName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 29);
            this.panel2.TabIndex = 14;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(68, 4);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(121, 23);
            this.txtMenuName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "菜单名：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboParentList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(208, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 30);
            this.panel3.TabIndex = 20;
            // 
            // cboParentList
            // 
            this.cboParentList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboParentList.FormattingEnabled = true;
            this.cboParentList.Location = new System.Drawing.Point(78, 5);
            this.cboParentList.Margin = new System.Windows.Forms.Padding(2);
            this.cboParentList.Name = "cboParentList";
            this.cboParentList.Size = new System.Drawing.Size(104, 25);
            this.cboParentList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "父级菜单：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkEmbedded);
            this.panel5.Controls.Add(this.chkTop);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(414, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 30);
            this.panel5.TabIndex = 22;
            // 
            // chkEmbedded
            // 
            this.chkEmbedded.AutoSize = true;
            this.chkEmbedded.Location = new System.Drawing.Point(128, 6);
            this.chkEmbedded.Margin = new System.Windows.Forms.Padding(2);
            this.chkEmbedded.Name = "chkEmbedded";
            this.chkEmbedded.Size = new System.Drawing.Size(50, 21);
            this.chkEmbedded.TabIndex = 5;
            this.chkEmbedded.Text = "内嵌";
            this.chkEmbedded.UseVisualStyleBackColor = true;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Checked = true;
            this.chkTop.Location = new System.Drawing.Point(73, 5);
            this.chkTop.Margin = new System.Windows.Forms.Padding(2);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(50, 21);
            this.chkTop.TabIndex = 5;
            this.chkTop.TabStop = true;
            this.chkTop.Text = "顶级";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "顶级窗体：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtOrder);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(620, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 29);
            this.panel6.TabIndex = 23;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(68, 2);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(120, 23);
            this.txtOrder.TabIndex = 6;
            this.txtOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "排序号：";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMCode);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(826, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 29);
            this.panel7.TabIndex = 24;
            // 
            // txtMCode
            // 
            this.txtMCode.Location = new System.Drawing.Point(80, 2);
            this.txtMCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtMCode.Name = "txtMCode";
            this.txtMCode.Size = new System.Drawing.Size(102, 23);
            this.txtMCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "菜单代号：";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFrm);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(2, 36);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 29);
            this.panel8.TabIndex = 15;
            // 
            // txtFrm
            // 
            this.txtFrm.Location = new System.Drawing.Point(68, 4);
            this.txtFrm.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrm.Name = "txtFrm";
            this.txtFrm.Size = new System.Drawing.Size(121, 23);
            this.txtFrm.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "页面名字：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "菜单信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnRecover);
            this.panel1.Controls.Add(this.txtKeywords);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chkDel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 52);
            this.panel1.TabIndex = 95;
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
            this.btnAdd.Location = new System.Drawing.Point(18, 9);
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
            this.btnAdd.TabIndex = 88;
            this.btnAdd.Text = "新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(748, 13);
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
            this.btnEdit.TabIndex = 83;
            this.btnEdit.Text = "修改";
            this.btnEdit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSearch.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSearch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSearch.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSearch.Location = new System.Drawing.Point(320, 9);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSearch.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSearch.ShowFocusLine = true;
            this.btnSearch.Size = new System.Drawing.Size(71, 28);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.StyleCustomMode = true;
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = "查询";
            this.btnSearch.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRecover.Location = new System.Drawing.Point(908, 13);
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
            this.btnRecover.TabIndex = 85;
            this.btnRecover.Text = "恢复";
            this.btnRecover.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(189, 10);
            this.txtKeywords.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(114, 26);
            this.txtKeywords.TabIndex = 90;
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
            this.btnRemove.Location = new System.Drawing.Point(987, 13);
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
            this.btnRemove.TabIndex = 86;
            this.btnRemove.Text = "移除";
            this.btnRemove.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(110, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "查询关键词：";
            // 
            // chkDel
            // 
            this.chkDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.chkDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkDel.Location = new System.Drawing.Point(665, 10);
            this.chkDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkDel.Name = "chkDel";
            this.chkDel.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chkDel.Size = new System.Drawing.Size(79, 35);
            this.chkDel.TabIndex = 87;
            this.chkDel.Text = "已删除";
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
            this.btnDelete.Location = new System.Drawing.Point(831, 13);
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
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "删除";
            this.btnDelete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // dgvMenuList
            // 
            this.dgvMenuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenuList.ColumnHeadersHeight = 30;
            this.dgvMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.Id,
            this.MName,
            this.PName,
            this.FrmName,
            this.IsTop,
            this.MOrder,
            this.MCode});
            this.dgvMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuList.EnableHeadersVisualStyles = false;
            this.dgvMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvMenuList.Location = new System.Drawing.Point(0, 207);
            this.dgvMenuList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMenuList.Name = "dgvMenuList";
            this.dgvMenuList.RowHeadersWidth = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dgvMenuList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMenuList.RowTemplate.DividerHeight = 1;
            this.dgvMenuList.RowTemplate.Height = 30;
            this.dgvMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuList.Size = new System.Drawing.Size(1073, 335);
            this.dgvMenuList.TabIndex = 96;
            // 
            // colChk
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colChk.DefaultCellStyle = dataGridViewCellStyle6;
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "MenuId";
            this.Id.HeaderText = "编号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "MenuName";
            this.MName.HeaderText = "菜单名";
            this.MName.MinimumWidth = 6;
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PMenuName";
            this.PName.HeaderText = "父菜单";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // FrmName
            // 
            this.FrmName.DataPropertyName = "FrmName";
            this.FrmName.FillWeight = 200F;
            this.FrmName.HeaderText = "页面名称";
            this.FrmName.MinimumWidth = 6;
            this.FrmName.Name = "FrmName";
            this.FrmName.ReadOnly = true;
            // 
            // IsTop
            // 
            this.IsTop.DataPropertyName = "IsTop";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IsTop.DefaultCellStyle = dataGridViewCellStyle7;
            this.IsTop.FillWeight = 50F;
            this.IsTop.HeaderText = "顶级";
            this.IsTop.MinimumWidth = 6;
            this.IsTop.Name = "IsTop";
            this.IsTop.ReadOnly = true;
            this.IsTop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsTop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MOrder
            // 
            this.MOrder.DataPropertyName = "MOrder";
            this.MOrder.HeaderText = "排序号";
            this.MOrder.MinimumWidth = 6;
            this.MOrder.Name = "MOrder";
            this.MOrder.ReadOnly = true;
            // 
            // MCode
            // 
            this.MCode.DataPropertyName = "MenuCode";
            this.MCode.HeaderText = "菜单代号";
            this.MCode.MinimumWidth = 6;
            this.MCode.Name = "MCode";
            this.MCode.ReadOnly = true;
            // 
            // uMenuPager
            // 
            this.uMenuPager.CurrentPage = 1;
            this.uMenuPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uMenuPager.Location = new System.Drawing.Point(0, 498);
            this.uMenuPager.Name = "uMenuPager";
            this.uMenuPager.PageSize = 5;
            this.uMenuPager.Record = 0;
            this.uMenuPager.Size = new System.Drawing.Size(1073, 44);
            this.uMenuPager.TabIndex = 97;
            // 
            // FrmMenuList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1073, 542);
            this.Controls.Add(this.uMenuPager);
            this.Controls.Add(this.dgvMenuList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInfo);
            this.Name = "FrmMenuList";
            this.Text = "菜单管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmMenuList_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboParentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton chkEmbedded;
        private System.Windows.Forms.RadioButton chkTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown txtOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtFrm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnRecover;
        private System.Windows.Forms.TextBox txtKeywords;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UICheckBox chkDel;
        private Sunny.UI.UIButton btnDelete;
        private System.Windows.Forms.DataGridView dgvMenuList;
        private CstControls.UPager uMenuPager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrmName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCode;
    }
}