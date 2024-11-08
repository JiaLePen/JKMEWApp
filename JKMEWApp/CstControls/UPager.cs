using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JKMEWApp.CstControls
{
    public partial class UPager : UserControl
    {
        public UPager()
        {
            InitializeComponent();
        }

        public event EventHandler OnPageChanged;


        //总数据条数
        private int _record = 0;

        public int Record
        {
            get
            {
                return _record;
            }
            set
            {
                _record = value;
                InitPageInfo();
            }
        }

        //当前显示的是第几页
        private int _currentPage = 1;

        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                if (TotalPage == 0)
                {
                    _currentPage = 1;
                }
                else if (value > TotalPage)
                {
                    _currentPage = TotalPage;
                }
                else if (value < 1)
                {
                    _currentPage = 1;
                }
                else
                {
                    _currentPage = value;
                }

                InitPageInfo();
            }
        }

        //每页显示的数据条数
        private int _pageSize = 5;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        //从什么位置开始显示数据
        private int _startRecord = 0;

        public int StartRecord
        {
            get
            {
                return (CurrentPage - 1) * PageSize;
            }
        }

        //总页数
        private int _totalPage = 0;

        public int TotalPage
        {
            get
            {
                if (Record == 0)
                {
                    return 0;
                }

                return Math.Ceiling(Record / (float)PageSize).GetInt();
            }
        }

        //初始化页面信息的方法
        public void InitPageInfo()
        {
            lblPageInfo.Text = string.Format("共 {0} 条记录  共 {1} 页  当前第 {2} 页", Record, TotalPage, CurrentPage);
            txtCurrentPage.Text = CurrentPage.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (Record > 0)
            {
                if (CurrentPage == 1)
                {
                    MessageBox.Show("当前已经是首页");
                    return;
                }
                else
                {
                    CurrentPage = 1;
                }

                OnPageChanged?.Invoke(sender, e);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Record > 0)
            {
                if (CurrentPage == 1)
                {
                    MessageBox.Show("当前已经是首页");
                    return;
                }
                else
                {
                    CurrentPage = CurrentPage - 1;
                }

                OnPageChanged?.Invoke(sender, e);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Record > 0)
            {
                if (CurrentPage == TotalPage)
                {
                    MessageBox.Show("当前已经是尾页");
                    return;
                }
                else
                {
                    CurrentPage = CurrentPage + 1;
                }

                OnPageChanged?.Invoke(sender, e);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (Record > 0)
            {
                if (CurrentPage == TotalPage)
                {
                    MessageBox.Show("当前已经是尾页");
                    return;
                }
                else
                {
                    CurrentPage = TotalPage;
                }

                OnPageChanged?.Invoke(sender, e);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (Record > 0)
            {
                string txtPage = txtCurrentPage.Text.Trim();
                if (txtPage.CheckNullEmpty() || !(Regex.IsMatch(txtPage, @"^\d+$")))
                {
                    MessageBox.Show("请正确填写页码！");
                    return;
                }

                int page = Convert.ToInt32(txtPage);
                if (page <= 0)
                {
                    page = 1;
                }
                if (page > TotalPage)
                {
                    page = TotalPage;
                }

                CurrentPage = page;

                OnPageChanged?.Invoke(sender, e);
            }
        }
    }
}