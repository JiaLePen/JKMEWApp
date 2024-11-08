namespace JKMEWApp.CstControls
{
    partial class UCWTower
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
            this.lblState = new System.Windows.Forms.Label();
            this.lblTowerName = new System.Windows.Forms.Label();
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
            this.btnSwitch.Location = new System.Drawing.Point(3, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(51, 27);
            this.btnSwitch.TabIndex = 20;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitch.UseVisualStyleBackColor = false;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Blue;
            this.lblState.Location = new System.Drawing.Point(129, 7);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 17);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "已停止";
            // 
            // lblTowerName
            // 
            this.lblTowerName.AutoSize = true;
            this.lblTowerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTowerName.Location = new System.Drawing.Point(58, 7);
            this.lblTowerName.Name = "lblTowerName";
            this.lblTowerName.Size = new System.Drawing.Size(59, 17);
            this.lblTowerName.TabIndex = 18;
            this.lblTowerName.Text = "1#冷却塔";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::JKMEWApp.Properties.Resources.lqt;
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCWTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTowerName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCWTower";
            this.Size = new System.Drawing.Size(191, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTowerName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
