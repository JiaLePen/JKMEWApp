using Common;
using JKMEWApp.BLL;
using JKMEWApp.Models.DTO;
using JKMEWApp.Models.Models;
using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.Report
{
    public partial class FrmReport : UIForm
    {
        private List<string> _defaultColumns;
        private ReportBLL _reportBLL = new ReportBLL();
        private List<ParaDataInfo> _paraDataInfos;

        private DataGridViewTextBoxColumn colInsertTime = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCWInTemper = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCWOutTemper = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colFreezeInTemper = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colFreezeOutTemper = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCWInPressure = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCWOutPressure = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colFreezeInPressure = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colFreezeOutPressure = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCoolPump1Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCoolPump2Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCoolPump3Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colColdPump1Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colColdPump2Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colColdPump3Frequency = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn colCurRoomTemper = new DataGridViewTextBoxColumn();

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            InitCboTypes();
            InitDgvColumns();
        }

        private void InitCboTypes()
        {
            cboReportTypes.Items.Add("日报表");
            cboReportTypes.Items.Add("周报表");
            cboReportTypes.Items.Add("月报表");
            cboReportTypes.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化列
        /// </summary>
        private void InitDgvColumns()
        {
            dgvDataList.Columns.Clear();
            DataGridViewTextBoxColumn[] colArr = new DataGridViewTextBoxColumn[]
           {
               colInsertTime,colCWInTemper,colCWOutTemper,
               colFreezeInTemper,colFreezeOutTemper,
               colCWInPressure,colCWOutPressure,
               colFreezeInPressure,colFreezeOutPressure,
               colCoolPump1Frequency,colCoolPump2Frequency,colCoolPump3Frequency,
               colColdPump1Frequency,colColdPump2Frequency,colColdPump3Frequency,
               colCurRoomTemper
           };
            dgvDataList.Columns.AddRange(colArr);

            SetCol(colInsertTime, "colInsertTime", "入库时间", "InsertTime", true, 150);
            SetCol(colCWInTemper, "colCWInTemper", "冷却进水温度", "CWInTemperature", true, 180);
            SetCol(colCWOutTemper, "colCWOutTemper", "冷却出水温度", "CWOutTemperature", true, 180);
            SetCol(colFreezeInTemper, "colFreezeInTemper", "冷冻供水温度", "FreezeInTemperature", true, 180);
            SetCol(colFreezeOutTemper, "colFreezeOutTemper", "冷冻回水温度", "FreezeOutTemperature", true, 180);
            SetCol(colCWInPressure, "colCWInPressure", "冷却进水压力", "CWInPressure", true, 180);
            SetCol(colCWOutPressure, "colCWOutPressure", "冷却出水压力", "CWOutPressure", true, 180);
            SetCol(colFreezeInPressure, "colFreezeInPressure", "冷冻供水压力", "FreezeInPressure", true, 180);
            SetCol(colFreezeOutPressure, "colFreezeOutPressure", "冷冻回水压力", "FreezeOutPressure", true, 180);
            SetCol(colCoolPump1Frequency, "colCoolPump1Frequency", "1#冷却泵频率", "CoolPump1Frequency", true, 180);
            SetCol(colCoolPump2Frequency, "colCoolPump2Frequency", "2#冷却泵频率", "CoolPump2Frequency", true, 180);
            SetCol(colCoolPump3Frequency, "colCoolPump3Frequency", "3#冷却泵频率", "CoolPump3Frequency", true, 180);
            SetCol(colColdPump1Frequency, "colColdPump1Frequency", "1#冷冻泵频率", "ColdPump1Frequency", true, 180);
            SetCol(colColdPump2Frequency, "colColdPump2Frequency", "2#冷冻泵频率", "ColdPump2Frequency", true, 180);
            SetCol(colColdPump3Frequency, "colColdPump3Frequency", "3#冷冻泵频率", "ColdPump3Frequency", true, 180);
            SetCol(colCurRoomTemper, "colCurRoomTemper", "当前室内温度", "CurRoomTemperature", true, 180);
        }

        /// <summary>
        /// 设置列属性
        /// </summary>
        /// <param name="col"></param>
        /// <param name="colName"></param>
        /// <param name="headTxt"></param>
        /// <param name="proName"></param>
        /// <param name="isReadOnly"></param>
        /// <param name="width"></param>
        private void SetCol(DataGridViewColumn col, string colName, string headTxt, string proName, bool isReadOnly, int width)
        {
            col.Name = colName;
            col.HeaderText = headTxt;
            col.DataPropertyName = proName;
            col.ReadOnly = isReadOnly;
            col.Width = width;
            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if (proName == "InsertTime")
            {
                col.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            }
        }

        //查询数据
        private void btnFind_Click(object sender, EventArgs e)
        {
            FrmGetFindCondition getFindCondition = new FrmGetFindCondition();
            getFindCondition.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dialogResult = getFindCondition.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _defaultColumns = getFindCondition.ReportColumns;

                ShowHideDgvColumns(_defaultColumns);

                LoadReportDatas();
            }
        }

        private async Task LoadReportDatas()
        {
            string strTime = dtTime.Text;
            var obj = new
            {
                StrTime = strTime,
                Type = cboReportTypes.SelectedIndex
            };

            ResponseInfo response = await _reportBLL.DoGetReports(obj);
            if (response.Status == 1)
            {
                _paraDataInfos = response.Value as List<ParaDataInfo>;
                dgvDataList.AutoGenerateColumns = false;
                dgvDataList.DataSource = _paraDataInfos;

                dt = ConvertListToDataTable(_paraDataInfos, _defaultColumns);
            }
        }

        //让DataGirdView对应的列显示和隐藏
        private void ShowHideDgvColumns(List<string> columns)
        {
            DataGridViewColumnCollection dgvColumns = dgvDataList.Columns;
            foreach (DataGridViewColumn tmp in dgvColumns)
            {
                if (columns.Contains(tmp.DataPropertyName))
                {
                    tmp.Visible = true;
                }
                else
                {
                    tmp.Visible = false;
                }
            }
            colInsertTime.Visible = true;
        }

        private void cboReportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboReportTypes.SelectedIndex)
            {
                case 2:
                    dtTime.CustomFormat = "yyyy-MM-01 00:00:00";
                    break;

                case 0:
                case 1:
                    dtTime.CustomFormat = "yyyy-MM-dd 00:00:00";
                    break;
            }
        }

        private int rowIndex = 0; //当前行
        private int page = 1;  //当前页
        private int rowsPerPage = 0;//每页显示多少行
        private DataTable dt = null;

        //打印文档
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = true;
            Graphics g = e.Graphics;
            Pen borderPen = new Pen(Color.Silver, 1);
            int start = e.MarginBounds.Left, height = 40, top = e.MarginBounds.Top - height,
                width = e.MarginBounds.Width, rightX = width + start;
            int colWidth = 160;
            int maxCol = width / colWidth;
            //if (maxCol < dt.Columns.Count)
            //{
            //    MessageBox.Show("", "报表列数太多！");
            //    return;
            //}
            if (e.PageSettings.Landscape)
                width = e.PageSettings.PaperSize.Height - 2 * start;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            //矩形
            Rectangle rect = new Rectangle(start, top, width, height);
            g.DrawRectangle(new Pen(Color.White), rect);
            string strTitle = "报 表 数 据";
            Font titleFont = new Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            SizeF titleSize = g.MeasureString(strTitle, titleFont);
            //绘制Title
            g.DrawString(strTitle, titleFont, new SolidBrush(Color.Teal), start + (width - titleSize.Width) / 2, top, format);
            int topFirstLine = top + 50;
            // g.DrawLine(borderPen, new Point(start,topFirstLine), new Point(rightX, topFirstLine));
            string reportTypeName = cboReportTypes.Text;
            Font font1 = new Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            //绘制报表条件信息
            g.DrawString($"报表类型：{reportTypeName}             日期：{dtTime.Text}", font1, new SolidBrush(Color.Black), start, topFirstLine + 10);
            g.DrawLine(borderPen, new Point(start, topFirstLine + 40), new Point(rightX, topFirstLine + 40));
            //绘制列标题
            int topHeadBLine = topFirstLine + 80;
            Rectangle rectHeader = new Rectangle(start + 1, topFirstLine + 41, width - 2, 38);
            g.DrawRectangle(new Pen(Color.Silver), rectHeader);
            g.FillRectangle(new SolidBrush(Color.DarkCyan), rectHeader);
            //绘制左边竖线
            g.DrawLine(borderPen, new Point(start, topFirstLine + 40), new Point(start, topFirstLine + 80));
            int rowHeader = 50;
            int colHeadTop = topFirstLine + 50;
            //画RowHeader列
            g.DrawString($"编号", font1, new SolidBrush(Color.Black), (start) + 10, colHeadTop);
            g.DrawLine(borderPen, new Point(start + rowHeader, topFirstLine + 40), new Point(start + rowHeader, topFirstLine + 80));

            Font fontcolTitle = new Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            int n = 0;
            for (int i = 0; i < dgvDataList.Columns.Count; i++)
            {
                if (dgvDataList.Columns[i].Visible)
                {
                    string colName = dgvDataList.Columns[i].HeaderText;
                    g.DrawString($"{colName}", font1, new SolidBrush(Color.Black), (start + rowHeader) + colWidth * n + 10, colHeadTop);
                    // g.DrawLine(borderPen, new Point((start + rowHeader) + colWidthT, topFirstLine + 41), new Point((start + rowHeader) + colWidthT, topFirstLine + 80));
                    n++;
                }
            }

            g.DrawLine(borderPen, new Point(start, topFirstLine + 80), new Point(rightX, topFirstLine + 80));
            g.DrawLine(borderPen, new Point(rightX, topFirstLine + 80), new Point(rightX, topFirstLine + 40));

            start = e.MarginBounds.Left;
            top = topFirstLine + 80;
            //绘制数据
            while (rowIndex < dt.Rows.Count)
            {
                int id = rowIndex + 1;
                g.DrawString($"{id}", font1, new SolidBrush(Color.Black), start + 10, top + 10);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string val = dt.Rows[rowIndex][j].ToString();
                    if (dt.Columns[j].DataType == typeof(DateTime))
                    {
                        val = Convert.ToDateTime(dt.Rows[rowIndex][j]).ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    g.DrawString($"{val}", font1, new SolidBrush(Color.Black), (start + rowHeader) + j * colWidth + 10, top + 10);
                    //g.DrawLine(borderPen, new Point((start + rowHeader) + colWidth * (n + 1), topFirstLine + 41), new Point((start + rowHeader) + colWidth * (n + 1), topFirstLine + 80));
                }

                //左边竖线
                g.DrawLine(borderPen, new Point(start, top), new Point(start, top + 40));
                //底部的线
                g.DrawLine(borderPen, new Point(start, top + 40), new Point(rightX, top + 40));
                //右边竖线
                g.DrawLine(borderPen, new Point(rightX, top), new Point(rightX, top + 40));
                start = e.MarginBounds.Left;
                top += 40;
                if (page == 1)
                    rowsPerPage++;
                rowIndex++;
                if (top + 40 > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
            string footer = " 第 " + page + " 页，共 " + Math.Ceiling(((double)dt.Rows.Count / rowsPerPage)).ToString() + " 页";
            e.Graphics.DrawString(footer, font1, Brushes.Black, start + (width - e.Graphics.MeasureString(footer, font1).Width) / 2, e.MarginBounds.Bottom);
            page++;
        }

        public DataTable ConvertListToDataTable(List<ParaDataInfo> dataList, List<string> columns)
        {
            // 创建 DataTable
            DataTable dataTable = new DataTable();

            // 如果 dataList 不为空且包含数据
            if (dataList != null && dataList.Count > 0)
            {
                // 获取属性信息
                PropertyInfo[] properties = typeof(ParaDataInfo).GetProperties();

                dataTable.Columns.Add("InsertTime", typeof(string));
                // 添加指定列作为 DataTable 的列
                foreach (string columnName in columns)
                {
                    PropertyInfo property = properties.FirstOrDefault(p => p.Name.ToLower() == columnName.ToLower());
                    if (property != null)
                    {
                        Type columnType = property.PropertyType;
                        if (Nullable.GetUnderlyingType(columnType) != null)
                        {
                            //获取可空类型的底层实际类型
                            columnType = Nullable.GetUnderlyingType(columnType);
                        }
                        dataTable.Columns.Add(columnName, columnType);
                    }
                }

                // 遍历 List 中的每个对象，将指定列的属性值添加到 DataTable 的行中
                foreach (ParaDataInfo data in dataList)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (string columnName in columns)
                    {
                        PropertyInfo property = properties.FirstOrDefault(p => p.Name.ToLower() == columnName.ToLower());
                        if (property != null)
                        {
                            object value = property.GetValue(data);
                            row[columnName] = value ?? DBNull.Value;
                        }
                    }
                    row["InsertTime"] = data.InsertTime.ToString();
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        //点击打印文档按钮的事件
        private void BtnPriveiw_Click(object sender, EventArgs e)
        {
            if (_paraDataInfos == null || _paraDataInfos.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("提示", "请先加载数据再打印");
                return;
            }
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                //预览数据
                printPreviewDialog.ShowDialog();
            }
        }

        //导出excel
        private void BtnToExcel_Click(object sender, EventArgs e)
        {
            if (_paraDataInfos == null || _paraDataInfos.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("提示", "请先加载数据再导出");
                return;
            }

            int count = ExcelHelper.DataTableToExcel(dt, $"d:\\{cboReportTypes.Text}-{dtTime.Value.ToString("yyyyMMdd")} 数据.xls", $"{cboReportTypes.Text}", true);

            if (count > 0)
            {
                MessageBox.Show("导出报表数据", "数据导出成功！");
            }
            else
            {
                MessageBox.Show("导出报表数据", "数据导出失败！");
                return;
            }
        }

        private void btnExcelPre_Click(object sender, EventArgs e)
        {
            if (_paraDataInfos == null || _paraDataInfos.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("提示", "请先加载数据再预览");
                return;
            }
            ExcelHelper.ShowExcel(dt);
        }

        private void dgvDataList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //添加行号
                SolidBrush v_SolidBrush = new SolidBrush(dgvDataList.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;
                string v_Line = v_LineNo.ToString();
                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加行号时发生错误，错误信息：" + ex.Message, "操作失败");
            }
        }
    }
}