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

namespace JKMEWApp.SM.SysSetting
{
    public partial class FrmEquipParaSet : UIForm
    {
        public FrmEquipParaSet()
        {
            InitializeComponent();
        }

        private async void FrmEquipParaSet_Load(object sender, EventArgs e)
        {
            await ModbusDataCenter.LoadSqlData();
            InitParaTextBoxEvent();
            ReadSlaveData();
        }

        //给页面上的所有ParaTextBox注册事件
        private void InitParaTextBoxEvent()
        {
            List<ParaTextBox> paraTextBoxes = gbParas.Controls.OfType<ParaTextBox>().ToList();
            foreach (ParaTextBox tmp in paraTextBoxes)
            {
                tmp.ParaTextBoxClickHandler += Tmp_ParaTextBoxClickHandler;
            }
        }

        //ParaTextBox的点击事件
        private void Tmp_ParaTextBoxClickHandler(object sender, EventArgs e)
        {
            ParaTextBox paraTextBox = (ParaTextBox)sender;
            FrmParaModify frmParaModify = new FrmParaModify(paraTextBox.VarName, paraTextBox.DataVal);
            frmParaModify.ShowDialog();
        }

        private void ReadSlaveData()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await ModbusHelper.ReadEquipParaSet();

                    foreach (var item in ModbusDataCenter.SetParaValues)
                    {
                        this.Invoke(new Action(() =>
                        {
                            ParaTextBox paraTextBox = FindParaTextBox(item.Key);
                            paraTextBox.DataVal = item.Value;
                        }));
                    }

                    Thread.Sleep(5000);
                }
            });
        }

        private ParaTextBox FindParaTextBox(string varName)
        {
            List<ParaTextBox> paraTextBoxes = gbParas.Controls.OfType<ParaTextBox>().ToList();
            return paraTextBoxes.Where(pt => pt.VarName == varName).FirstOrDefault();
        }
    }
}