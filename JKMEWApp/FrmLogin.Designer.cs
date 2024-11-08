namespace JKMEWApp
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginErr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPwdErr = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblNameErr = new System.Windows.Forms.Label();
            this.txtUPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(161, 234);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 10;
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.Text = "登录";
            this.btnLogin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(91, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "账号：";
            this.label1.UseWaitCursor = true;
            // 
            // lblLoginErr
            // 
            this.lblLoginErr.AutoSize = true;
            this.lblLoginErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLoginErr.Location = new System.Drawing.Point(266, 245);
            this.lblLoginErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginErr.Name = "lblLoginErr";
            this.lblLoginErr.Size = new System.Drawing.Size(62, 16);
            this.lblLoginErr.TabIndex = 37;
            this.lblLoginErr.Text = "登录有误！";
            this.lblLoginErr.UseWaitCursor = true;
            this.lblLoginErr.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(91, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "密码：";
            this.label2.UseWaitCursor = true;
            // 
            // lblPwdErr
            // 
            this.lblPwdErr.AutoSize = true;
            this.lblPwdErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwdErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPwdErr.Location = new System.Drawing.Point(151, 190);
            this.lblPwdErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwdErr.Name = "lblPwdErr";
            this.lblPwdErr.Size = new System.Drawing.Size(84, 16);
            this.lblPwdErr.TabIndex = 36;
            this.lblPwdErr.Text = "密码不能为空！";
            this.lblPwdErr.UseWaitCursor = true;
            this.lblPwdErr.Visible = false;
            // 
            // txtUName
            // 
            this.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUName.Location = new System.Drawing.Point(147, 92);
            this.txtUName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(174, 27);
            this.txtUName.TabIndex = 33;
            this.txtUName.Text = "admin";
            this.txtUName.UseWaitCursor = true;
            // 
            // lblNameErr
            // 
            this.lblNameErr.AutoSize = true;
            this.lblNameErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNameErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameErr.Location = new System.Drawing.Point(151, 123);
            this.lblNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameErr.Name = "lblNameErr";
            this.lblNameErr.Size = new System.Drawing.Size(95, 16);
            this.lblNameErr.TabIndex = 35;
            this.lblNameErr.Text = "用户名不能为空！";
            this.lblNameErr.UseWaitCursor = true;
            this.lblNameErr.Visible = false;
            // 
            // txtUPwd
            // 
            this.txtUPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUPwd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUPwd.Location = new System.Drawing.Point(147, 156);
            this.txtUPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtUPwd.Name = "txtUPwd";
            this.txtUPwd.PasswordChar = '*';
            this.txtUPwd.Size = new System.Drawing.Size(174, 27);
            this.txtUPwd.TabIndex = 34;
            this.txtUPwd.Text = "admin";
            this.txtUPwd.UseWaitCursor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(438, 344);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginErr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPwdErr);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.lblNameErr);
            this.Controls.Add(this.txtUPwd);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "极客智能监控系统登录";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnLogin;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginErr;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPwdErr;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblNameErr;
        private System.Windows.Forms.TextBox txtUPwd;
    }
}

