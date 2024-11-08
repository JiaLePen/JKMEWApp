namespace JKMEWApp.CstControls
{
    partial class UPager
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
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnFirst = new Sunny.UI.UIButton();
            this.btnPrev = new Sunny.UI.UIButton();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnLast = new Sunny.UI.UIButton();
            this.btnGo = new Sunny.UI.UIButton();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageInfo.Location = new System.Drawing.Point(17, 18);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(209, 12);
            this.lblPageInfo.TabIndex = 0;
            this.lblPageInfo.Text = "共 4 条记录 ，共 1 页  当前第 1 页";
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFirst.Location = new System.Drawing.Point(312, 14);
            this.btnFirst.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(49, 20);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "首页";
            this.btnFirst.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(367, 15);
            this.btnPrev.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(49, 20);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "上一页";
            this.btnPrev.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(422, 15);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 20);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一页";
            this.btnNext.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLast.Location = new System.Drawing.Point(477, 15);
            this.btnLast.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(49, 20);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "尾页";
            this.btnLast.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.Location = new System.Drawing.Point(642, 14);
            this.btnGo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(49, 20);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "转到";
            this.btnGo.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPage.Location = new System.Drawing.Point(560, 12);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(76, 21);
            this.txtCurrentPage.TabIndex = 6;
            // 
            // UPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblPageInfo);
            this.Name = "UPager";
            this.Size = new System.Drawing.Size(705, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageInfo;
        private Sunny.UI.UIButton btnFirst;
        private Sunny.UI.UIButton btnPrev;
        private Sunny.UI.UIButton btnNext;
        private Sunny.UI.UIButton btnLast;
        private Sunny.UI.UIButton btnGo;
        private System.Windows.Forms.TextBox txtCurrentPage;
    }
}
