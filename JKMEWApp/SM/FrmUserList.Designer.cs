namespace JKMEWApp.SM
{
    partial class FrmUserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLoginTime = new System.Windows.Forms.Panel();
            this.txtLastLoginTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLoginIp = new System.Windows.Forms.Panel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnOK = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.btnRightAssign = new Sunny.UI.UIButton();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnRecover = new Sunny.UI.UIButton();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnRemove = new Sunny.UI.UIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDel = new Sunny.UI.UICheckBox();
            this.btnDelete = new Sunny.UI.UIButton();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.uUserPager = new JKMEWApp.CstControls.UPager();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditState = new System.Windows.Forms.DataGridViewLinkColumn();
            this.chkFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLoginTime.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelLoginIp.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panelLoginTime);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panelLoginIp);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 157);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 35);
            this.panel2.TabIndex = 15;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(68, 4);
            this.txtUName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(121, 26);
            this.txtUName.TabIndex = 3;
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
            this.label1.Text = "用户名：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUPwd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(208, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 35);
            this.panel3.TabIndex = 21;
            // 
            // txtUPwd
            // 
            this.txtUPwd.Location = new System.Drawing.Point(49, 4);
            this.txtUPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtUPwd.Name = "txtUPwd";
            this.txtUPwd.PasswordChar = '*';
            this.txtUPwd.Size = new System.Drawing.Size(133, 26);
            this.txtUPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // panelLoginTime
            // 
            this.panelLoginTime.Controls.Add(this.txtLastLoginTime);
            this.panelLoginTime.Controls.Add(this.label3);
            this.panelLoginTime.Location = new System.Drawing.Point(414, 2);
            this.panelLoginTime.Margin = new System.Windows.Forms.Padding(2);
            this.panelLoginTime.Name = "panelLoginTime";
            this.panelLoginTime.Size = new System.Drawing.Size(284, 35);
            this.panelLoginTime.TabIndex = 25;
            // 
            // txtLastLoginTime
            // 
            this.txtLastLoginTime.Location = new System.Drawing.Point(98, 1);
            this.txtLastLoginTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastLoginTime.Name = "txtLastLoginTime";
            this.txtLastLoginTime.ReadOnly = true;
            this.txtLastLoginTime.Size = new System.Drawing.Size(186, 26);
            this.txtLastLoginTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "最后登录时间：";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPhone);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(702, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 35);
            this.panel8.TabIndex = 28;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(68, 2);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "电话：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkNormal);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(908, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 35);
            this.panel5.TabIndex = 29;
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(52, 6);
            this.chkNormal.Margin = new System.Windows.Forms.Padding(2);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(58, 20);
            this.chkNormal.TabIndex = 5;
            this.chkNormal.Text = "正常";
            this.chkNormal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "状态：";
            // 
            // panelLoginIp
            // 
            this.panelLoginIp.Controls.Add(this.txtIP);
            this.panelLoginIp.Controls.Add(this.label6);
            this.panelLoginIp.Location = new System.Drawing.Point(2, 41);
            this.panelLoginIp.Margin = new System.Windows.Forms.Padding(2);
            this.panelLoginIp.Name = "panelLoginIp";
            this.panelLoginIp.Size = new System.Drawing.Size(202, 32);
            this.panelLoginIp.TabIndex = 30;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(76, 3);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(121, 26);
            this.txtIP.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(2, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "最后登录IP：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkFlow);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(208, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 32);
            this.panel4.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "角色：";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.FillColor2 = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(116, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(30, 15, 3, 3);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.DarkGray;
            this.btnClear.Size = new System.Drawing.Size(53, 21);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "清空";
            this.btnClear.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(30, 8);
            this.btnOK.Margin = new System.Windows.Forms.Padding(30, 15, 3, 3);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 21);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "新增";
            this.btnOK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(3, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 39);
            this.panel1.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnEdit);
            this.panel6.Controls.Add(this.btnRightAssign);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Controls.Add(this.btnRecover);
            this.panel6.Controls.Add(this.txtKeywords);
            this.panel6.Controls.Add(this.btnRemove);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.chkDel);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1202, 52);
            this.panel6.TabIndex = 97;
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
            this.btnEdit.Location = new System.Drawing.Point(877, 13);
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
            // btnRightAssign
            // 
            this.btnRightAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightAssign.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRightAssign.Location = new System.Drawing.Point(796, 13);
            this.btnRightAssign.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRightAssign.Name = "btnRightAssign";
            this.btnRightAssign.ShowFocusLine = true;
            this.btnRightAssign.ShowTips = true;
            this.btnRightAssign.Size = new System.Drawing.Size(71, 28);
            this.btnRightAssign.Style = Sunny.UI.UIStyle.Custom;
            this.btnRightAssign.StyleCustomMode = true;
            this.btnRightAssign.TabIndex = 82;
            this.btnRightAssign.Text = "权限分配";
            this.btnRightAssign.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btnRecover.Location = new System.Drawing.Point(1037, 13);
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
            this.btnRemove.Location = new System.Drawing.Point(1116, 13);
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
            this.chkDel.Location = new System.Drawing.Point(711, 10);
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
            this.btnDelete.Location = new System.Drawing.Point(960, 13);
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
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUserList.ColumnHeadersHeight = 30;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.Id,
            this.UName,
            this.UState,
            this.UPhone,
            this.LoginIp,
            this.LoginTime,
            this.LoginCount,
            this.colEditState});
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvUserList.Location = new System.Drawing.Point(0, 269);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUserList.RowTemplate.DividerHeight = 1;
            this.dgvUserList.RowTemplate.Height = 30;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(1202, 273);
            this.dgvUserList.TabIndex = 98;
            // 
            // uUserPager
            // 
            this.uUserPager.CurrentPage = 1;
            this.uUserPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uUserPager.Location = new System.Drawing.Point(0, 498);
            this.uUserPager.Name = "uUserPager";
            this.uUserPager.PageSize = 5;
            this.uUserPager.Record = 0;
            this.uUserPager.Size = new System.Drawing.Size(1202, 44);
            this.uUserPager.TabIndex = 99;
            // 
            // colChk
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = false;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colChk.DefaultCellStyle = dataGridViewCellStyle10;
            this.colChk.FillWeight = 44.84541F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "UserId";
            this.Id.FillWeight = 44.84541F;
            this.Id.HeaderText = "编号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UName
            // 
            this.UName.DataPropertyName = "UserName";
            this.UName.FillWeight = 121.8274F;
            this.UName.HeaderText = "用户名";
            this.UName.MinimumWidth = 6;
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            // 
            // UState
            // 
            this.UState.DataPropertyName = "UserState";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.NullValue = false;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UState.DefaultCellStyle = dataGridViewCellStyle11;
            this.UState.FalseValue = "";
            this.UState.FillWeight = 44.84541F;
            this.UState.HeaderText = "状态";
            this.UState.MinimumWidth = 6;
            this.UState.Name = "UState";
            this.UState.ReadOnly = true;
            this.UState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UPhone
            // 
            this.UPhone.DataPropertyName = "UserPhone";
            this.UPhone.FillWeight = 134.5363F;
            this.UPhone.HeaderText = "电话";
            this.UPhone.MinimumWidth = 6;
            this.UPhone.Name = "UPhone";
            this.UPhone.ReadOnly = true;
            // 
            // LoginIp
            // 
            this.LoginIp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LoginIp.DataPropertyName = "LastLoginIP";
            this.LoginIp.FillWeight = 112.7849F;
            this.LoginIp.HeaderText = "最后登录IP";
            this.LoginIp.MinimumWidth = 6;
            this.LoginIp.Name = "LoginIp";
            this.LoginIp.ReadOnly = true;
            // 
            // LoginTime
            // 
            this.LoginTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LoginTime.DataPropertyName = "LastLoginTime";
            this.LoginTime.FillWeight = 134.5363F;
            this.LoginTime.HeaderText = "最后登录时间";
            this.LoginTime.MinimumWidth = 6;
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.ReadOnly = true;
            this.LoginTime.Width = 120;
            // 
            // LoginCount
            // 
            this.LoginCount.DataPropertyName = "LoginCount";
            this.LoginCount.FillWeight = 116.9335F;
            this.LoginCount.HeaderText = "登录次数";
            this.LoginCount.MinimumWidth = 6;
            this.LoginCount.Name = "LoginCount";
            this.LoginCount.ReadOnly = true;
            // 
            // colEditState
            // 
            this.colEditState.FillWeight = 44.84541F;
            this.colEditState.HeaderText = "启停";
            this.colEditState.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEditState.LinkColor = System.Drawing.Color.Crimson;
            this.colEditState.MinimumWidth = 6;
            this.colEditState.Name = "colEditState";
            this.colEditState.Text = "";
            this.colEditState.TrackVisitedState = false;
            // 
            // chkFlow
            // 
            this.chkFlow.Location = new System.Drawing.Point(49, 4);
            this.chkFlow.Name = "chkFlow";
            this.chkFlow.Size = new System.Drawing.Size(771, 28);
            this.chkFlow.TabIndex = 4;
            // 
            // FrmUserList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 542);
            this.Controls.Add(this.uUserPager);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUserList";
            this.Text = "用户管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelLoginTime.ResumeLayout(false);
            this.panelLoginTime.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelLoginIp.ResumeLayout(false);
            this.panelLoginIp.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLoginTime;
        private System.Windows.Forms.TextBox txtLastLoginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLoginIp;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnRightAssign;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnRecover;
        private System.Windows.Forms.TextBox txtKeywords;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UICheckBox chkDel;
        private Sunny.UI.UIButton btnDelete;
        private System.Windows.Forms.DataGridView dgvUserList;
        private CstControls.UPager uUserPager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UState;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginCount;
        private System.Windows.Forms.DataGridViewLinkColumn colEditState;
        private System.Windows.Forms.FlowLayoutPanel chkFlow;
    }
}