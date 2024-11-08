namespace JKMEWApp.CstControls
{
    partial class UPump
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwitch = new System.Windows.Forms.Button();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.picPump = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSwitch.Enabled = false;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(40, 8);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(47, 26);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.UseVisualStyleBackColor = false;
            // 
            // picLight
            // 
            this.picLight.Image = global::JKMEWApp.Properties.Resources.light_off;
            this.picLight.Location = new System.Drawing.Point(12, 7);
            this.picLight.Margin = new System.Windows.Forms.Padding(2);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(23, 26);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLight.TabIndex = 8;
            this.picLight.TabStop = false;
            // 
            // picPump
            // 
            this.picPump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPump.Image = global::JKMEWApp.Properties.Resources.jdb;
            this.picPump.Location = new System.Drawing.Point(9, 36);
            this.picPump.Margin = new System.Windows.Forms.Padding(2);
            this.picPump.Name = "picPump";
            this.picPump.Size = new System.Drawing.Size(80, 73);
            this.picPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPump.TabIndex = 9;
            this.picPump.TabStop = false;
            // 
            // UPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.picPump);
            this.Name = "UPump";
            this.Size = new System.Drawing.Size(99, 117);
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.PictureBox picLight;
        private System.Windows.Forms.PictureBox picPump;
    }
}
