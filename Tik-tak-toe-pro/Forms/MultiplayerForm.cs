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

namespace Tik_tak_toe_pro
{
    public partial class MultiplayerForm : Form
    {
        Setting setting;
        public MultiplayerForm(Setting setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm(setting);
            startForm.Visible = true;
            this.Dispose();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (thisPC.Checked)
            {
                FormPlayVsHuman vsHuman = new FormPlayVsHuman(setting);
                vsHuman.Visible = true;
                this.Visible=false;
            }
            else {
                
                //SocketManagement sm = new SocketManagement("192.168.173.1", 8000);
                //sm.startAsClient();
                IPAddressForm ipForm = new IPAddressForm(setting);
                ipForm.Visible = true;
                this.Visible = false;
            }
        }

        

    }     
}

