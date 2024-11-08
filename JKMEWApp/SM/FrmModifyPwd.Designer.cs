namespace JKMEWApp.SM
{
    partial class FrmModifyPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Sunny.UI.UIButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new Sunny.UI.UIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.renewPwd = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPwd = new Sunny.UI.UITextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.origialPwd = new Sunny.UI.UITextBox();
            this.lblOPwdErr = new System.Windows.Forms.Label();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.lblNPwdErr = new System.Windows.Forms.Label();
            this.lblConPwdErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(303, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "登录账号：";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(428, 327);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 28);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "关闭";
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(303, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "原始密码：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(318, 327);
            this.btnSubmit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 28);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(315, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "新密码：";
            // 
            // renewPwd
            // 
            this.renewPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.renewPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.renewPwd.Location = new System.Drawing.Point(376, 248);
            this.renewPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renewPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.renewPwd.Name = "renewPwd";
            this.renewPwd.Padding = new System.Windows.Forms.Padding(5);
            this.renewPwd.PasswordChar = '*';
            this.renewPwd.ShowText = false;
            this.renewPwd.Size = new System.Drawing.Size(129, 24);
            this.renewPwd.TabIndex = 42;
            this.renewPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.renewPwd.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(303, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "确认密码：";
            // 
            // newPwd
            // 
            this.newPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwd.Location = new System.Drawing.Point(375, 192);
            this.newPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.newPwd.Name = "newPwd";
            this.newPwd.Padding = new System.Windows.Forms.Padding(5);
            this.newPwd.PasswordChar = '*';
            this.newPwd.ShowText = false;
            this.newPwd.Size = new System.Drawing.Size(129, 24);
            this.newPwd.TabIndex = 43;
            this.newPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPwd.Watermark = "";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUserName.Location = new System.Drawing.Point(371, 85);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 19);
            this.lblUserName.TabIndex = 32;
            this.lblUserName.Text = "admin";
            // 
            // origialPwd
            // 
            this.origialPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.origialPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.origialPwd.Location = new System.Drawing.Point(375, 134);
            this.origialPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.origialPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.origialPwd.Name = "origialPwd";
            this.origialPwd.Padding = new System.Windows.Forms.Padding(5);
            this.origialPwd.PasswordChar = '*';
            this.origialPwd.ShowText = false;
            this.origialPwd.Size = new System.Drawing.Size(129, 24);
            this.origialPwd.TabIndex = 40;
            this.origialPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.origialPwd.Watermark = "";
            // 
            // lblOPwdErr
            // 
            this.lblOPwdErr.AutoSize = true;
            this.lblOPwdErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOPwdErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOPwdErr.Location = new System.Drawing.Point(372, 163);
            this.lblOPwdErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOPwdErr.Name = "lblOPwdErr";
            this.lblOPwdErr.Size = new System.Drawing.Size(95, 16);
            this.lblOPwdErr.TabIndex = 39;
            this.lblOPwdErr.Text = "请输入原始密码！";
            this.lblOPwdErr.Visible = false;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(375, 134);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(129, 24);
            this.uiTextBox1.TabIndex = 41;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // lblNPwdErr
            // 
            this.lblNPwdErr.AutoSize = true;
            this.lblNPwdErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNPwdErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNPwdErr.Location = new System.Drawing.Point(373, 221);
            this.lblNPwdErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNPwdErr.Name = "lblNPwdErr";
            this.lblNPwdErr.Size = new System.Drawing.Size(84, 16);
            this.lblNPwdErr.TabIndex = 38;
            this.lblNPwdErr.Text = "请输入新密码！";
            this.lblNPwdErr.Visible = false;
            // 
            // lblConPwdErr
            // 
            this.lblConPwdErr.AutoSize = true;
            this.lblConPwdErr.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConPwdErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConPwdErr.Location = new System.Drawing.Point(372, 281);
            this.lblConPwdErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConPwdErr.Name = "lblConPwdErr";
            this.lblConPwdErr.Size = new System.Drawing.Size(95, 16);
            this.lblConPwdErr.TabIndex = 37;
            this.lblConPwdErr.Text = "请输入确认密码！";
            this.lblConPwdErr.Visible = false;
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.renewPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.origialPwd);
            this.Controls.Add(this.lblOPwdErr);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.lblNPwdErr);
            this.Controls.Add(this.lblConPwdErr);
            this.Name = "FrmModifyPwd";
            this.Text = "修改密码";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmModifyPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton btnSubmit;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UITextBox renewPwd;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox newPwd;
        private System.Windows.Forms.Label lblUserName;
        private Sunny.UI.UITextBox origialPwd;
        private System.Windows.Forms.Label lblOPwdErr;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Label lblNPwdErr;
        private System.Windows.Forms.Label lblConPwdErr;
    }
}