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
using System.Net.Sockets;

namespace Tik_tak_toe_pro
{
    public partial class IPAddressForm : Form
    {
        Setting setting;
        public IPAddressForm(Setting setting)
        {
            InitializeComponent();
            this.setting = setting;
            ipListBox.Items.Clear();
            ipListBox.Items.Add(getIPAddresses());
            waitLabel.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MultiplayerForm multiplayerForm = new MultiplayerForm(setting);
            multiplayerForm.Visible = true;
            this.Visible = false;
        }



        private String getIPAddresses() {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }



        private bool verifyIPAddress(String ip) {
            IPAddress address;
            
            if (IPAddress.TryParse(ip, out address))
            {
                return true;
            }
            return false;
        }

        /*
         * To connect as the client
         */
        private void clientButton_Click(object sender, EventArgs e)
        {   
            if (!verifyIPAddress(connectIpBox.Text)) 
            {
                System.Windows.Forms.MessageBox.Show("Entered IP Adress is not valid !");
                return;
            }

            if(nameBox.Text.Length<2){
                System.Windows.Forms.MessageBox.Show("Please enter a valid name !");
                return;
            }

            //start host.
            Console.WriteLine("Connected!");
            SocketManagement sm = new SocketManagement(connectIpBox.Text, 8000);
            bool hasStarted = sm.startAsClient();

            if (hasStarted) {
                waitLabel.Visible = true;
                hostButton.Enabled = false;
                clientButton.Enabled = false;
                 
                 // Then open the playing window and assign names and signs.
                 

                NetworkPlayForm networkForm = new NetworkPlayForm(setting,sm,nameBox.Text);
                networkForm.Visible = true;
                this.Visible = false;


            }
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            
            if (nameBox.Text.Length < 2)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid name !");
                return;
            }

            String ip=ipListBox.SelectedItem.ToString();

            if (!verifyIPAddress(ip))
            {
                System.Windows.Forms.MessageBox.Show("Entered IP Adress is not valid !");
                return;
            }

            Console.WriteLine("Hosted!");
            SocketManagement sm = new SocketManagement(ip, 8000);
            bool hasStarted = sm.startAsServer();

            if(hasStarted){
                waitLabel.Visible = true;
                hostButton.Enabled = false;
                clientButton.Enabled = false;
                
                NetworkPlayForm networkForm = new NetworkPlayForm(setting,sm,nameBox.Text);
                networkForm.Visible = true;
                this.Visible = false;
            }
        }

       
        
        

    }     
}

