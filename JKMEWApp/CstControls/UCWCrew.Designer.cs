namespace JKMEWApp.CstControls
{
    partial class UCWCrew
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
            this.lblCrewName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Gray;
            this.btnSwitch.Enabled = false;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(5, 1);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(53, 27);
            this.btnSwitch.TabIndex = 15;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitch.UseVisualStyleBackColor = false;
            // 
            // lblCrewName
            // 
            this.lblCrewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrewName.AutoSize = true;
            this.lblCrewName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCrewName.Location = new System.Drawing.Point(94, 4);
            this.lblCrewName.Name = "lblCrewName";
            this.lblCrewName.Size = new System.Drawing.Size(71, 17);
            this.lblCrewName.TabIndex = 14;
            this.lblCrewName.Text = "1#冷水机组";
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.Location = new System.Drawing.Point(190, 4);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 17);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "运行中";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::JKMEWApp.Properties.Resources.lsjz;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(218, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UCWCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblCrewName);
            this.Controls.Add(this.lblState);
            this.Name = "UCWCrew";
            this.Size = new System.Drawing.Size(257, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblCrewName;
        private System.Windows.Forms.Label lblState;
    }
}
