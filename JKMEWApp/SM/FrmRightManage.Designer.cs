namespace JKMEWApp.SM
{
    partial class FrmRightManage
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cboRoles = new Sunny.UI.UIComboBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.tvRolePermission = new JKMEWApp.CstControls.TreeViewEx();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cboRoles);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(100, 67);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(301, 124);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "角色列表";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(24, 54);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(97, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "选择角色：";
            // 
            // cboRoles
            // 
            this.cboRoles.DataSource = null;
            this.cboRoles.FillColor = System.Drawing.Color.White;
            this.cboRoles.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRoles.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboRoles.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboRoles.Location = new System.Drawing.Point(128, 54);
            this.cboRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRoles.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboRoles.Size = new System.Drawing.Size(150, 29);
            this.cboRoles.SymbolSize = 24;
            this.cboRoles.TabIndex = 1;
            this.cboRoles.Text = "uiComboBox1";
            this.cboRoles.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboRoles.Watermark = "";
            this.cboRoles.SelectedIndexChanged += new System.EventHandler(this.cboRoles_SelectedIndexChanged);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.Controls.Add(this.tvRolePermission);
            this.uiGroupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(529, 67);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(347, 438);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "角色权限";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(183, 226);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存修改";
            this.btnSave.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvRolePermission
            // 
            this.tvRolePermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tvRolePermission.CheckBoxes = true;
            this.tvRolePermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRolePermission.FullRowSelect = true;
            this.tvRolePermission.LineColor = System.Drawing.Color.SeaGreen;
            this.tvRolePermission.Location = new System.Drawing.Point(0, 32);
            this.tvRolePermission.Name = "tvRolePermission";
            this.tvRolePermission.Size = new System.Drawing.Size(347, 406);
            this.tvRolePermission.TabIndex = 0;
            this.tvRolePermission.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRolePermission_AfterCheck);
            // 
            // FrmRightManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1073, 542);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "FrmRightManage";
            this.Text = "权限设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmRightManage_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cboRoles;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private CstControls.TreeViewEx tvRolePermission;
        private Sunny.UI.UISymbolButton btnSave;
    }
}