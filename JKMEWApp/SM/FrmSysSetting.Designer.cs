namespace JKMEWApp.SM
{
    partial class FrmSysSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParaManage = new Sunny.UI.UIButton();
            this.btnModbusSet = new Sunny.UI.UIButton();
            this.btnEquiparm = new Sunny.UI.UIButton();
            this.panelPage = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnParaManage);
            this.panel1.Controls.Add(this.btnModbusSet);
            this.panel1.Controls.Add(this.btnEquiparm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnParaManage
            // 
            this.btnParaManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnParaManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParaManage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnParaManage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnParaManage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnParaManage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnParaManage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnParaManage.Font = new System.Drawing.Font("宋体", 10F);
            this.btnParaManage.Location = new System.Drawing.Point(345, 8);
            this.btnParaManage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnParaManage.Name = "btnParaManage";
            this.btnParaManage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnParaManage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnParaManage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnParaManage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnParaManage.ShowFocusLine = true;
            this.btnParaManage.Size = new System.Drawing.Size(101, 28);
            this.btnParaManage.Style = Sunny.UI.UIStyle.Custom;
            this.btnParaManage.StyleCustomMode = true;
            this.btnParaManage.TabIndex = 86;
            this.btnParaManage.Text = "参数配置";
            this.btnParaManage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParaManage.Click += new System.EventHandler(this.btnParaManage_Click);
            // 
            // btnModbusSet
            // 
            this.btnModbusSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModbusSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModbusSet.Font = new System.Drawing.Font("宋体", 10F);
            this.btnModbusSet.Location = new System.Drawing.Point(227, 8);
            this.btnModbusSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModbusSet.Name = "btnModbusSet";
            this.btnModbusSet.ShowFocusLine = true;
            this.btnModbusSet.ShowTips = true;
            this.btnModbusSet.Size = new System.Drawing.Size(104, 28);
            this.btnModbusSet.Style = Sunny.UI.UIStyle.Custom;
            this.btnModbusSet.StyleCustomMode = true;
            this.btnModbusSet.TabIndex = 85;
            this.btnModbusSet.Text = "通信设置";
            this.btnModbusSet.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModbusSet.Click += new System.EventHandler(this.btnModbusSet_Click);
            // 
            // btnEquiparm
            // 
            this.btnEquiparm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEquiparm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquiparm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEquiparm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEquiparm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnEquiparm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEquiparm.FillSelectedColor = System.Drawing.Color.White;
            this.btnEquiparm.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEquiparm.Location = new System.Drawing.Point(462, 8);
            this.btnEquiparm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEquiparm.Name = "btnEquiparm";
            this.btnEquiparm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnEquiparm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnEquiparm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEquiparm.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnEquiparm.ShowFocusLine = true;
            this.btnEquiparm.Size = new System.Drawing.Size(93, 28);
            this.btnEquiparm.Style = Sunny.UI.UIStyle.Custom;
            this.btnEquiparm.StyleCustomMode = true;
            this.btnEquiparm.TabIndex = 87;
            this.btnEquiparm.Text = "设备参数设置";
            this.btnEquiparm.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEquiparm.Click += new System.EventHandler(this.btnEquiparm_Click);
            // 
            // panelPage
            // 
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPage.Location = new System.Drawing.Point(0, 83);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(800, 367);
            this.panelPage.TabIndex = 2;
            // 
            // FrmSysSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSysSetting";
            this.Text = "系统设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSysSetting_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton btnParaManage;
        private Sunny.UI.UIButton btnModbusSet;
        private Sunny.UI.UIButton btnEquiparm;
        private System.Windows.Forms.Panel panelPage;
    }
}