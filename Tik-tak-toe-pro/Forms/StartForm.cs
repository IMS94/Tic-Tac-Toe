using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
//using System.Drawing;

namespace Tik_tak_toe_pro
{
    public partial class StartForm : Form
    {
        Setting setting;
        

        public StartForm(Setting settingE)
        {
            InitializeComponent();
            setting = settingE;
            
        }

        private void pbVsComputer_MouseEnter(object sender, EventArgs e)
        {
            pbVsComputer.Image = Tik_tak_toe_pro.Properties.Resources.vsPC;
        }

        private void pbVsComputer_MouseLeave(object sender, EventArgs e)
        {
             pbVsComputer.Image = Tik_tak_toe_pro.Properties.Resources.vsComputerDarkDark;
        }

        private void pbVsHuman_MouseEnter(object sender, EventArgs e)
        {
            pbVsHuman.Image = Tik_tak_toe_pro.Properties.Resources.vsHuman;
        }

        private void pbVsHuman_MouseLeave(object sender, EventArgs e)
        {
            pbVsHuman.Image = Tik_tak_toe_pro.Properties.Resources.vsHumanDark;
        }

        private void pbVsSetting_MouseEnter(object sender, EventArgs e)
        {
            pbVsSetting.Image = Tik_tak_toe_pro.Properties.Resources.settings;
        }

        private void pbVsSetting_MouseLeave(object sender, EventArgs e)
        {
            pbVsSetting.Image = Tik_tak_toe_pro.Properties.Resources.settingsDark;
        }

        private void pbVsExit_MouseEnter(object sender, EventArgs e)
        {
             pbVsExit.Image = Tik_tak_toe_pro.Properties.Resources.Exit;
        }

        private void pbVsExit_MouseLeave(object sender, EventArgs e)
        {
             pbVsExit.Image = Tik_tak_toe_pro.Properties.Resources.ExitDark;
        }

        private void pbVsExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pbVsComputer_Click(object sender, EventArgs e)
        {
            DBManagement.getSinglePlayerScores(1);
            FormPlayVsComputer vsPc = new FormPlayVsComputer(setting);
            vsPc.Visible = true;
            this.Visible = false;
        }

        private void pbVsSetting_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm(setting);
            sf.Visible = true;

        }

        private void pbVsHuman_Click(object sender, EventArgs e)
        {
            MultiplayerForm multiplayerForm = new MultiplayerForm(setting);
            multiplayerForm.Visible = true;
            this.Visible=false;
            
        }
        

    }     
}

