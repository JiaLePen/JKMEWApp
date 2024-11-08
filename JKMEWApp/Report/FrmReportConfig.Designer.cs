namespace JKMEWApp.Report
{
    partial class FrmReportConfig
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lbSelParaList = new System.Windows.Forms.ListBox();
            this.lbParaList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(280, 362);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 26);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(153, 362);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(50, 26);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.BackColor = System.Drawing.Color.DimGray;
            this.btnLeftAll.FlatAppearance.BorderSize = 0;
            this.btnLeftAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftAll.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLeftAll.ForeColor = System.Drawing.Color.White;
            this.btnLeftAll.Location = new System.Drawing.Point(240, 267);
            this.btnLeftAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(40, 25);
            this.btnLeftAll.TabIndex = 24;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = false;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DimGray;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(240, 230);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 25);
            this.btnLeft.TabIndex = 25;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.BackColor = System.Drawing.Color.DimGray;
            this.btnRightAll.FlatAppearance.BorderSize = 0;
            this.btnRightAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightAll.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRightAll.ForeColor = System.Drawing.Color.White;
            this.btnRightAll.Location = new System.Drawing.Point(240, 129);
            this.btnRightAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(40, 25);
            this.btnRightAll.TabIndex = 26;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = false;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DimGray;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(240, 90);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 25);
            this.btnRight.TabIndex = 27;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lbSelParaList
            // 
            this.lbSelParaList.BackColor = System.Drawing.Color.SteelBlue;
            this.lbSelParaList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelParaList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSelParaList.ForeColor = System.Drawing.Color.Brown;
            this.lbSelParaList.FormattingEnabled = true;
            this.lbSelParaList.ItemHeight = 17;
            this.lbSelParaList.Location = new System.Drawing.Point(308, 69);
            this.lbSelParaList.Margin = new System.Windows.Forms.Padding(2);
            this.lbSelParaList.Name = "lbSelParaList";
            this.lbSelParaList.Size = new System.Drawing.Size(157, 240);
            this.lbSelParaList.TabIndex = 22;
            // 
            // lbParaList
            // 
            this.lbParaList.BackColor = System.Drawing.Color.Gray;
            this.lbParaList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbParaList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbParaList.ForeColor = System.Drawing.Color.White;
            this.lbParaList.FormattingEnabled = true;
            this.lbParaList.ItemHeight = 17;
            this.lbParaList.Location = new System.Drawing.Point(54, 69);
            this.lbParaList.Margin = new System.Windows.Forms.Padding(2);
            this.lbParaList.Name = "lbParaList";
            this.lbParaList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbParaList.Size = new System.Drawing.Size(157, 240);
            this.lbParaList.TabIndex = 23;
            // 
            // FrmReportConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(515, 424);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbSelParaList);
            this.Controls.Add(this.lbParaList);
            this.Name = "FrmReportConfig";
            this.Text = "报表参数设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmReportConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ListBox lbSelParaList;
        private System.Windows.Forms.ListBox lbParaList;
    }
}