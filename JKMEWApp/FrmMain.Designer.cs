namespace JKMEWApp
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.topMenu = new Sunny.UI.UINavBar();
            this.btnClosePage = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tabContrl = new Sunny.UI.UITabControl();
            this.panel1.SuspendLayout();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.topMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 55);
            this.panel1.TabIndex = 0;
            // 
            // topMenu
            // 
            this.topMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.topMenu.Controls.Add(this.btnClosePage);
            this.topMenu.DropMenuFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topMenu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.topMenu.Location = new System.Drawing.Point(55, 3);
            this.topMenu.MenuHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.topMenu.MenuSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.topMenu.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.topMenu.Name = "topMenu";
            this.topMenu.NodeAlignment = System.Drawing.StringAlignment.Near;
            this.topMenu.NodeInterval = 1;
            this.topMenu.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.topMenu.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.topMenu.Size = new System.Drawing.Size(1318, 51);
            this.topMenu.Style = Sunny.UI.UIStyle.Custom;
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "uiNavBar1";
            this.topMenu.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.topMenu_MenuItemClick);
            // 
            // btnClosePage
            // 
            this.btnClosePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClosePage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosePage.Location = new System.Drawing.Point(1230, 8);
            this.btnClosePage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(72, 35);
            this.btnClosePage.Symbol = 61453;
            this.btnClosePage.TabIndex = 0;
            this.btnClosePage.Text = "关闭";
            this.btnClosePage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::JKMEWApp.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.lblCopy);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.uiLabel3);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 923);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 37);
            this.panel2.TabIndex = 1;
            // 
            // lblCopy
            // 
            this.lblCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lblCopy.Location = new System.Drawing.Point(1166, 12);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(55, 14);
            this.lblCopy.TabIndex = 5;
            this.lblCopy.Text = "label3";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(328, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 14);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label2";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(91, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 14);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "label1";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(805, 12);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(49, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "版权:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(254, 12);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(82, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "登录时间:";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(30, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(67, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "用户名:";
            // 
            // tabContrl
            // 
            this.tabContrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabContrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabContrl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabContrl.Location = new System.Drawing.Point(0, 90);
            this.tabContrl.MainPage = "";
            this.tabContrl.Name = "tabContrl";
            this.tabContrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabContrl.SelectedIndex = 0;
            this.tabContrl.ShowActiveCloseButton = true;
            this.tabContrl.Size = new System.Drawing.Size(1371, 833);
            this.tabContrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContrl.TabIndex = 3;
            this.tabContrl.TabVisible = false;
            this.tabContrl.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1371, 960);
            this.Controls.Add(this.tabContrl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "主界面";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.topMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UINavBar topMenu;
        private Sunny.UI.UISymbolButton btnClosePage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITabControl tabContrl;
    }
}