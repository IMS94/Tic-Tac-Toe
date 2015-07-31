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
using System.Net;

namespace Tik_tak_toe_pro
{
    public partial class IPAddressForm : Form
    {
        Setting setting;
        public IPAddressForm(Setting setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MultiplayerForm multiplayerForm = new MultiplayerForm(setting);
            multiplayerForm.Visible = true;
            this.Visible = false;
        }



        private bool verifyIPAddress(String ip) {
            IPAddress address;
            
            if (IPAddress.TryParse(ip, out address))
            {
                return true;
            }
            return false;
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            if (!verifyIPAddress(ipText.Text)) 
            {
                System.Windows.Forms.MessageBox.Show("Entered IP Adress is not valid !");
                return;
            }

            if(nameBox.Text.Length<2){
                System.Windows.Forms.MessageBox.Show("Please enter a valid name !");
                return;
            }

            //start host.
            SocketManagement sm = new SocketManagement(ipText.Text,8000);
            sm.startAsClient();

        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            if (!verifyIPAddress(ipText.Text))
            {
                System.Windows.Forms.MessageBox.Show("Entered IP Adress is not valid !");
                return;
            }

            if (nameBox.Text.Length < 2)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid name !");
                return;
            }

            SocketManagement sm = new SocketManagement(ipText.Text, 8000);
            sm.startAsServer();

        }

       
        
        

    }     
}

