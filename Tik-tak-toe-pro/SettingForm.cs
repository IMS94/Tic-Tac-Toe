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
    public partial class SettingForm : Form
    {
        Setting setting;
        
        public SettingForm(Setting settingE)
        {
            InitializeComponent();
            setting = settingE;

            if (setting.difficultyLevel == 1) 
            {
                levelEasy.Checked = true;
            }
            else if (setting.difficultyLevel == 2)
            {
                levelMedium.Checked = true;
            }
            else  
            {
                levelHard.Checked = true;
            }
            
        }

     
      
        private void label2_Click(object sender, EventArgs e)
        {
            if (levelHard.Checked)
            {
                setting.difficultyLevel = 3;
            }
            else if (levelMedium.Checked)
            {
                setting.difficultyLevel = 2;
            }
            else 
            {
                setting.difficultyLevel = 1;
            }
            this.Dispose();
        }

    }     
}

