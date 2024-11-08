namespace JKMEWApp.CstControls
{
    partial class UWPMatchine
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
            this.lblDevName = new System.Windows.Forms.Label();
            this.lblRunState = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTemper = new JKMEWApp.CstControls.ParaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDevName
            // 
            this.lblDevName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevName.AutoSize = true;
            this.lblDevName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDevName.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDevName.Location = new System.Drawing.Point(169, 93);
            this.lblDevName.Name = "lblDevName";
            this.lblDevName.Size = new System.Drawing.Size(57, 19);
            this.lblDevName.TabIndex = 30;
            this.lblDevName.Text = "风机01";
            // 
            // lblRunState
            // 
            this.lblRunState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRunState.AutoSize = true;
            this.lblRunState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRunState.Location = new System.Drawing.Point(177, 62);
            this.lblRunState.Name = "lblRunState";
            this.lblRunState.Size = new System.Drawing.Size(44, 17);
            this.lblRunState.TabIndex = 29;
            this.lblRunState.Text = "运行中";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackColor = System.Drawing.Color.Black;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(198, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(22, 24);
            this.btnDown.TabIndex = 27;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(172, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(22, 24);
            this.btnUp.TabIndex = 28;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMode.Location = new System.Drawing.Point(53, 13);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(32, 17);
            this.lblMode.TabIndex = 26;
            this.lblMode.Text = "制冷";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 24);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::JKMEWApp.Properties.Resources.fgj;
            this.pictureBox1.Location = new System.Drawing.Point(5, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtTemper
            // 
            this.txtTemper.DataVal = "15";
            this.txtTemper.Location = new System.Drawing.Point(92, 13);
            this.txtTemper.Name = "txtTemper";
            this.txtTemper.Size = new System.Drawing.Size(65, 19);
            this.txtTemper.TabIndex = 31;
            this.txtTemper.Unit = "℃";
            this.txtTemper.VarName = null;
            // 
            // UWPMatchine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtTemper);
            this.Controls.Add(this.lblDevName);
            this.Controls.Add(this.lblRunState);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UWPMatchine";
            this.Size = new System.Drawing.Size(231, 134);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevName;
        private System.Windows.Forms.Label lblRunState;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ParaTextBox txtTemper;
    }
}
