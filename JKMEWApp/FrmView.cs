using JKMEWApp.CstControls;
using JKMEWApp.Tools;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKMEWApp
{
    public partial class FrmView : UIForm
    {
        private List<UIPipe> _allPipes;
        private List<UIPipe> _group1Pipes = new List<UIPipe>();
        private List<UIPipe> _group2Pipes = new List<UIPipe>();
        private List<UIPipe> _group3Pipes = new List<UIPipe>();
        private List<UIPipe> _commonPipes = new List<UIPipe>();
        private HashSet<UIPipe> _floatPipes = new HashSet<UIPipe>();

        private List<Control> _group1Devices = new List<Control>();
        private List<Control> _group2Devices = new List<Control>();
        private List<Control> _group3Devices = new List<Control>();
        private List<Control> _commonDevices = new List<Control>();
        private List<Control> _allDevices = new List<Control>();
        private HashSet<Control> _startDevices = new HashSet<Control>();

        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            //初始化水管
            InitPipes();
            //初始化设备分组
            InitDevices();
        }

        //初始化水管
        private void InitPipes()
        {
            _allPipes = this.GetControls<UIPipe>().ToList();

            _group1Pipes.Add(group1PipeCold01);
            _group1Pipes.Add(group1PipeCold02);
            _group1Pipes.Add(group1PipeHot01);
            _group1Pipes.Add(group1PipeHot02);
            _group1Pipes.Add(group1PipeHot03);
            _group1Pipes.Add(group1PipeHot04);

            _group2Pipes.Add(group2PipeCold01);
            _group2Pipes.Add(group2PipeCold02);
            _group2Pipes.Add(group2PipeHot01);
            _group2Pipes.Add(group2PipeHot02);
            _group2Pipes.Add(group2PipeHot03);
            _group2Pipes.Add(group2PipeHot04);

            _group3Pipes.Add(group3PipeCold01);
            _group3Pipes.Add(group3PipeCold02);
            _group3Pipes.Add(group3PipeHot01);
            _group3Pipes.Add(group3PipeHot02);
            _group3Pipes.Add(group3PipeHot03);
            _group3Pipes.Add(group3PipeHot04);

            _commonPipes = _allPipes.Except(_group1Pipes).Except(_group2Pipes).Except(_group3Pipes).ToList();
            Console.WriteLine(_commonPipes);
        }

        private void InitDevices()
        {
            _group1Devices.Add(coldPump01);
            _group1Devices.Add(ucwCrew1);
            _group1Devices.Add(coolPump1);

            _group2Devices.Add(coldPump02);
            _group2Devices.Add(ucwCrew2);
            _group2Devices.Add(coolPump2);

            _group3Devices.Add(coldPump03);
            _group3Devices.Add(ucwCrew3);
            _group3Devices.Add(coolPump3);

            _commonDevices.Add(uwpMatchine);
            _commonDevices.Add(cwTower01);
            _commonDevices.Add(cwTower02);

            _allDevices.AddRange(_group1Devices);
            _allDevices.AddRange(_group2Devices);
            _allDevices.AddRange(_group3Devices);
            _allDevices.AddRange(_commonDevices);
        }

        #region 启动按钮事件

        private bool IsAllDeviceRunOver = true;

        private async void group1Start_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;

                _group1Pipes.ForEach(item => _floatPipes.Add(item));
                _commonPipes.ForEach(item => _floatPipes.Add(item));
                SetPipeGroupFloat(_floatPipes.ToList());
                timer1.Start();

                _group1Devices.ForEach(item => _startDevices.Add(item));
                _commonDevices.ForEach(item => _startDevices.Add(item));
                await SetDevicesRun(_startDevices.ToList());

                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        private async void group1Stop_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;
                _group1Pipes.ForEach(item => _floatPipes.Remove(item));
                SetPipeGroupFloat(_floatPipes.ToList());

                _group1Devices.ForEach(item => _startDevices.Remove(item));
                await SetDevicesStop(_startDevices.ToList());
                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        private async void group2Start_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;
                _group2Pipes.ForEach(item => _floatPipes.Add(item));
                _commonPipes.ForEach(item => _floatPipes.Add(item));

                SetPipeGroupFloat(_floatPipes.ToList());
                timer1.Start();

                _group2Devices.ForEach(item => _startDevices.Add(item));
                _commonDevices.ForEach(item => _startDevices.Add(item));
                await SetDevicesRun(_startDevices.ToList());
                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        private async void group2Stop_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;
                _group2Pipes.ForEach(item => _floatPipes.Remove(item));
                SetPipeGroupFloat(_floatPipes.ToList());

                _group2Devices.ForEach(item => _startDevices.Remove(item));
                await SetDevicesStop(_startDevices.ToList());

                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        private async void group3Start_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;
                _group3Pipes.ForEach(item => _floatPipes.Add(item));
                _commonPipes.ForEach(item => _floatPipes.Add(item));

                SetPipeGroupFloat(_floatPipes.ToList());
                timer1.Start();

                _group3Devices.ForEach(item => _startDevices.Add(item));
                _commonDevices.ForEach(item => _startDevices.Add(item));
                await SetDevicesRun(_startDevices.ToList());
                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        private async void group3Stop_Click(object sender, EventArgs e)
        {
            if (IsAllDeviceRunOver)
            {
                IsAllDeviceRunOver = false;
                _group3Pipes.ForEach(item => _floatPipes.Remove(item));
                SetPipeGroupFloat(_floatPipes.ToList());

                _group3Devices.ForEach(item => _startDevices.Remove(item));
                await SetDevicesStop(_startDevices.ToList());
                IsAllDeviceRunOver = true;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("提示", "上次操作还没有完成");
            }
        }

        #endregion 启动按钮事件

        //让设备启动的方法
        private async Task SetDevicesRun(List<Control> startDevices)
        {
            await Task.Run(async () =>
            {
                foreach (Control control in startDevices)
                {
                    //风机
                    if (control is UWPMatchine)
                    {
                        UWPMatchine uWPMatchine = (UWPMatchine)control;

                        if (uwpMatchine.ActualState == false)
                        {
                            await StartOrStopuwpMatchine(uwpMatchine, true);

                            Thread.Sleep(1000);
                        }
                    }
                    //水泵
                    else if (control is UPump)
                    {
                        UPump uPump = (UPump)control;

                        if (uPump.Name.StartsWith("cold"))
                        {
                            //冷冻泵
                            if (uPump.ActualState == false)
                            {
                                await StartOrStopColdPump(uPump, uPump.Name.Substring(8) + "#", true);

                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            //冷却泵
                            if (uPump.ActualState == false)
                            {
                                await StartOrStopCoolPump(uPump, uPump.Name.Substring(8) + "#", true);

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    //冷水机组
                    else if (control is UCWCrew)
                    {
                        UCWCrew uCWCrew = (UCWCrew)control;
                        if (uCWCrew.ActualState == false)
                        {
                            await StartOrStopCWCrew(uCWCrew, uCWCrew.Name.Substring(7) + "#", true);

                            Thread.Sleep(1000);
                        }
                    }
                    //冷却塔
                    else if (control is UCWTower)
                    {
                        UCWTower tower = (UCWTower)control;
                        if (tower.ActualState == false)
                        {
                            await StartOrStopCWTower(tower, tower.Name.Substring(7), true);

                            Thread.Sleep(1000);
                        }
                    }
                }
            });
        }

        //让设备停止的方法
        private async Task SetDevicesStop(List<Control> startDevices)
        {
            await Task.Run(async () =>
            {
                List<Control> stopDevices = _allDevices.Except(startDevices).ToList();

                //停止除了运行设备之外的其他所有设备
                foreach (Control control in stopDevices)
                {
                    //风机
                    if (control is UWPMatchine)
                    {
                        UWPMatchine uWPMatchine = (UWPMatchine)control;

                        if (uwpMatchine.ActualState == true)
                        {
                            await StartOrStopuwpMatchine(uwpMatchine, false);

                            Thread.Sleep(1000);
                        }
                    }
                    //水泵
                    else if (control is UPump)
                    {
                        UPump uPump = (UPump)control;

                        if (uPump.Name.StartsWith("cold"))
                        {
                            //冷冻泵
                            if (uPump.ActualState == true)
                            {
                                await StartOrStopColdPump(uPump, uPump.Name.Substring(8) + "#", false);

                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            //冷却泵
                            if (uPump.ActualState == true)
                            {
                                await StartOrStopCoolPump(uPump, uPump.Name.Substring(8) + "#", false);

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    //冷水机组
                    else if (control is UCWCrew)
                    {
                        UCWCrew uCWCrew = (UCWCrew)control;
                        if (uCWCrew.ActualState == true)
                        {
                            await StartOrStopCWCrew(uCWCrew, uCWCrew.Name.Substring(7) + "#", false);

                            Thread.Sleep(1000);
                        }
                    }
                    //冷却塔
                    else if (control is UCWTower)
                    {
                        UCWTower tower = (UCWTower)control;
                        if (tower.ActualState == true)
                        {
                            await StartOrStopCWTower(tower, tower.TowerName.Substring(0, 2), false);

                            Thread.Sleep(1000);
                        }
                    }
                }

                //如果最后运行的设备只剩下公共设备，就停止公共机组设备
                if (startDevices.Count == _commonDevices.Count)
                {
                    foreach (var item in _commonDevices)
                    {
                        if (item is UCWTower)
                        {
                            if (((UCWTower)item).ActualState != false)
                            {
                                UCWTower tower = (UCWTower)item;
                                //停止冷却塔
                                await StartOrStopCWTower(tower, tower.Name.Substring(7), false);

                                Thread.Sleep(500);
                            }
                        }
                        else if (item is UWPMatchine)
                        {
                            if (((UWPMatchine)item).ActualState != false)
                            {
                                UWPMatchine uWPMatchine = (UWPMatchine)item;
                                //停止风机
                                await StartOrStopuwpMatchine(uWPMatchine, false);

                                Thread.Sleep(500);
                            }
                        }
                    }
                }
            });
        }

        //启动或者停止风机的方法
        private async Task<bool> StartOrStopuwpMatchine(UWPMatchine uWPMatchine, bool state)
        {
            bool bl = false;
            if (state)
            {
                bl = await RunDevice(uWPMatchine.IsRunStateName, "", "风机");
            }
            else
            {
                bl = await CloseDevice(uWPMatchine.IsRunStateName, "", "风机");
            }
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    uWPMatchine.ActualState = state;
                }));
            }
            return bl;
        }

        //启动或者停止冷冻泵
        private async Task<bool> StartOrStopColdPump(UPump pump, string pumpName, bool state)
        {
            bool bl = false;
            if (state)
            {
                bl = await RunDevice(pump.PumpStateName, pumpName, "冷冻泵");
            }
            else
            {
                bl = await CloseDevice(pump.PumpStateName, pumpName, "冷冻泵");
            }
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    pump.ActualState = state;
                }));
            }
            return bl;
        }

        //启动或者停止冷却泵
        private async Task<bool> StartOrStopCoolPump(UPump pump, string pumpName, bool state)
        {
            bool bl = false;
            if (state)
            {
                bl = await RunDevice(pump.PumpStateName, pumpName, "冷却泵");
            }
            else
            {
                bl = await CloseDevice(pump.PumpStateName, pumpName, "冷却泵");
            }
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    pump.ActualState = state;
                }));
            }
            return bl;
        }

        //启动冷水机组
        private async Task<bool> StartOrStopCWCrew(UCWCrew uCWCrew, string crewName, bool state)
        {
            bool bl = false;
            if (state)
            {
                bl = await RunDevice(uCWCrew.CrewStateName, crewName, "冷水机组");
            }
            else
            {
                bl = await CloseDevice(uCWCrew.CrewStateName, crewName, "冷水机组");
            }
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    uCWCrew.ActualState = state;
                }));
            }
            return bl;
        }

        //启动冷却塔
        private async Task<bool> StartOrStopCWTower(UCWTower tower, string towerName, bool state)
        {
            bool bl = false;
            if (state)
            {
                bl = await RunDevice(tower.TowerStateName, towerName, "冷却塔");
            }
            else
            {
                bl = await CloseDevice(tower.TowerStateName, towerName, "冷却塔");
            }
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    tower.ActualState = state;
                }));
            }
            return bl;
        }

        private int num = 0;

        /// <summary>
        /// 启动具体设备的方法
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="devNum"></param>
        /// <param name="devType"></param>
        /// <returns></returns>
        private async Task<bool> RunDevice(string varName, string devNum, string devType)
        {
            num++;
            this.Invoke(new Action(() =>
            {
                lblMsg.Text += $"{num}:正在开启{devNum}{devType}，请稍后！\r\n";
            }));

            //修改设备运行状态
            bool bl = await Task.Run(() =>
            {
                Thread.Sleep(500);
                return true;
            });
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    lblMsg.Text += $"{devNum}{devType}已运行！\r\n";
                }));

                return bl;
            }
            return false;
        }

        /// <summary>
        /// 关闭具体设备的方法
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="devNum"></param>
        /// <param name="devType"></param>
        /// <returns></returns>
        private async Task<bool> CloseDevice(string varName, string devNum, string devType)
        {
            num++;
            this.Invoke(new Action(() =>
            {
                lblMsg.Text += $"{num}:正在关闭{devNum}{devType}，请稍后！\r\n";
            }));

            bool bl = await Task.Run(() =>
            {
                Thread.Sleep(500);
                return true;
            });
            if (bl)
            {
                this.Invoke(new Action(() =>
                {
                    lblMsg.Text += $"{devNum}{devType}已停止运行！\r\n";
                }));

                return bl;
            }
            return false;
        }

        #region 控制水管流动

        private void SetPipeGroupFloat(List<UIPipe> floatPipes)
        {
            SetPipeStatus(floatPipes, true);

            List<UIPipe> otherPipes = _allPipes.Except(floatPipes).ToList();
            SetPipeStatus(otherPipes, false);

            //如果当前只剩下公共水管在流动，就停止定时器
            if (_floatPipes.Count == _commonPipes.Count)
            {
                SetPipeStatus(_commonPipes, false);
                floatPipes.RemoveRange(0, _floatPipes.Count);
                timer1?.Stop();
            }

            _allPipes.ForEach(item => item.Invalidate());
        }

        //设置水管是否激活的状态
        private void SetPipeStatus(List<UIPipe> pipes, bool isActive)
        {
            foreach (var item in pipes)
            {
                item.Active = isActive;
            }
        }

        //水管定时器执行的方法
        private void timer1_Tick(object sender, EventArgs e)
        {
            _allPipes.ForEach(item => item.Invalidate());
        }

        #endregion 控制水管流动

        private void lblMsg_TextChanged(object sender, EventArgs e)
        {
            //文本框选中的起始点在最后
            lblMsg.SelectionStart = lblMsg.TextLength;
            //将控件内容滚动到当前插入符号位置
            lblMsg.ScrollToCaret();
        }
    }
}