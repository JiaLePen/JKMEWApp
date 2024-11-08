namespace JKMEWApp.Report
{
    partial class FrmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnToExcel = new System.Windows.Forms.Button();
            this.btnExcelPre = new System.Windows.Forms.Button();
            this.BtnPriveiw = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cboReportTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnToExcel);
            this.panel1.Controls.Add(this.btnExcelPre);
            this.panel1.Controls.Add(this.BtnPriveiw);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.dtTime);
            this.panel1.Controls.Add(this.cboReportTypes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 76);
            this.panel1.TabIndex = 4;
            // 
            // BtnToExcel
            // 
            this.BtnToExcel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnToExcel.FlatAppearance.BorderSize = 0;
            this.BtnToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToExcel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnToExcel.Location = new System.Drawing.Point(882, 25);
            this.BtnToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnToExcel.Name = "BtnToExcel";
            this.BtnToExcel.Size = new System.Drawing.Size(90, 27);
            this.BtnToExcel.TabIndex = 11;
            this.BtnToExcel.Text = "Excel导出";
            this.BtnToExcel.UseVisualStyleBackColor = false;
            this.BtnToExcel.Click += new System.EventHandler(this.BtnToExcel_Click);
            // 
            // btnExcelPre
            // 
            this.btnExcelPre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcelPre.FlatAppearance.BorderSize = 0;
            this.btnExcelPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPre.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExcelPre.Location = new System.Drawing.Point(777, 25);
            this.btnExcelPre.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelPre.Name = "btnExcelPre";
            this.btnExcelPre.Size = new System.Drawing.Size(94, 27);
            this.btnExcelPre.TabIndex = 12;
            this.btnExcelPre.Text = "Excel预览";
            this.btnExcelPre.UseVisualStyleBackColor = false;
            this.btnExcelPre.Click += new System.EventHandler(this.btnExcelPre_Click);
            // 
            // BtnPriveiw
            // 
            this.BtnPriveiw.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnPriveiw.FlatAppearance.BorderSize = 0;
            this.BtnPriveiw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPriveiw.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPriveiw.Location = new System.Drawing.Point(678, 25);
            this.BtnPriveiw.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPriveiw.Name = "BtnPriveiw";
            this.BtnPriveiw.Size = new System.Drawing.Size(82, 27);
            this.BtnPriveiw.TabIndex = 13;
            this.BtnPriveiw.Text = "打印预览";
            this.BtnPriveiw.UseVisualStyleBackColor = false;
            this.BtnPriveiw.Click += new System.EventHandler(this.BtnPriveiw_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Location = new System.Drawing.Point(588, 25);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(69, 27);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(318, 24);
            this.dtTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(200, 27);
            this.dtTime.TabIndex = 10;
            // 
            // cboReportTypes
            // 
            this.cboReportTypes.BackColor = System.Drawing.Color.SteelBlue;
            this.cboReportTypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboReportTypes.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboReportTypes.ForeColor = System.Drawing.Color.White;
            this.cboReportTypes.FormattingEnabled = true;
            this.cboReportTypes.Location = new System.Drawing.Point(104, 24);
            this.cboReportTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cboReportTypes.Name = "cboReportTypes";
            this.cboReportTypes.Size = new System.Drawing.Size(116, 28);
            this.cboReportTypes.TabIndex = 9;
            this.cboReportTypes.SelectedIndexChanged += new System.EventHandler(this.cboReportTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "日期时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "报表类型：";
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            this.dgvDataList.AllowUserToResizeColumns = false;
            this.dgvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.ColumnHeadersHeight = 40;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataList.EnableHeadersVisualStyles = false;
            this.dgvDataList.GridColor = System.Drawing.Color.Silver;
            this.dgvDataList.Location = new System.Drawing.Point(0, 111);
            this.dgvDataList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataList.RowHeadersWidth = 51;
            this.dgvDataList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDataList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataList.RowTemplate.Height = 35;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(997, 431);
            this.dgvDataList.TabIndex = 5;
            this.dgvDataList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDataList_RowPostPaint);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FrmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.dgvDataList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReport";
            this.Text = "报表管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnToExcel;
        private System.Windows.Forms.Button btnExcelPre;
        private System.Windows.Forms.Button BtnPriveiw;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cboReportTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}