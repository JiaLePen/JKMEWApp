using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp.CstControls
{
    public partial class UCAlarmControl : Control
    {
        private int inColorIndex = 0;//当前颜色索引值
        private System.Timers.Timer timer = null;
        private Rectangle m_rectWorking;//工作区  灯泡部分的绘制

        public UCAlarmControl()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息，减少闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区，减少闪烁
            SetStyle(ControlStyles.UserPaint, true);//控件由其自身而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//控件调整其大小时重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景

            this.SizeChanged += UCAlarmControl_SizeChanged;
            this.Size = new Size(50, 50);

            //定时器初始化
            timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Interval = 200;
            timer.Elapsed += Timer_Elapsed;
        }

        //定时器的方法：切换颜色数组中选中颜色的序号
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                inColorIndex++;
                if (inColorIndex >= alarmLightColor.Length)
                {
                    inColorIndex = 0;
                }
                Invalidate();
            }));
        }

        private void UCAlarmControl_SizeChanged(object sender, EventArgs e)
        {
            m_rectWorking = new Rectangle(Width / 8, Height / 8, Width - Width / 4, Height - Height / 4);
        }

        //报警灯颜色的数组
        private Color[] alarmLightColor = { Color.Red };

        [Description("灯的颜色，当需要闪烁时，至少要设置2种或以上的颜色，不需要闪烁，至少需要一种颜色")]
        public Color[] AlarmLightColor
        {
            get { return alarmLightColor; }
            set
            {
                if (value == null || value.Length == 0)
                    return;
                alarmLightColor = value;
                //重绘当前的报警灯
                Invalidate();
            }
        }

        //报警灯底座颜色
        private Color alarmStandColor = Color.Gray;

        [DefaultValue(typeof(Color), "Gray"), Description("灯座颜色")]
        public Color AlarmStandColor
        {
            get { return alarmStandColor; }
            set
            {
                alarmStandColor = value;
                Invalidate();
            }
        }

        //报警灯闪烁的时间间隔
        private int twinkleInterval = 100;

        [DefaultValue(typeof(int), "0"), Description("闪烁间隔时间（毫秒），当值为0时，不闪烁")]
        public int TwinkleInterval
        {
            get { return twinkleInterval; }
            set
            {
                if (value < 0) return;
                twinkleInterval = value;
                if (value == 0 || alarmLightColor.Length <= 1)
                {
                    timer.Enabled = false;
                }
                else
                {
                    inColorIndex = 0;
                }
                Invalidate();
            }
        }

        //是否报警
        private bool isOn = false;

        [DefaultValue(typeof(bool), "False"), Description("指示是否报警")]
        public bool IsOn
        {
            get { return isOn; }
            set
            {
                isOn = value;
                if (isOn && twinkleInterval > 0)
                {
                    timer.Interval = twinkleInterval;
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                    inColorIndex = 0;
                }
                Invalidate();
            }
        }

        //报警灯的下位机参数名字
        private string varName;

        [DefaultValue(typeof(string), "VarName"), Description("报警状态参数名称")]
        public string VarName
        {
            get { return varName; }
            set
            {
                varName = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //当前灯的颜色
            Color c = AlarmLightColor[inColorIndex];
            //灯泡部分的路径
            GraphicsPath path = new GraphicsPath();
            //左边竖线  从下——上
            path.AddLine(m_rectWorking.Left, m_rectWorking.Bottom - Height / 4 + 2, m_rectWorking.Left, m_rectWorking.Top + m_rectWorking.Width);
            //半圆弧
            path.AddArc(m_rectWorking.Left, m_rectWorking.Top, m_rectWorking.Width, m_rectWorking.Width, 180f, 180f);
            //右边竖线  从上——下
            path.AddLine(m_rectWorking.Right, m_rectWorking.Top + m_rectWorking.Width, m_rectWorking.Right, m_rectWorking.Bottom - Height / 4 + 2);

            path.CloseAllFigures();//关闭图形，形成一个闭合区域
            //填充灯泡
            g.FillPath(new SolidBrush(c), path);
            //填充灯座  1/4Height
            g.FillRectangle(new SolidBrush(alarmStandColor), new Rectangle(0, m_rectWorking.Bottom - Height / 4, Width, Height / 4));
        }
    }
}