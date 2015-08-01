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

        /*
         * To connect as the client
         */
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
            Console.WriteLine("Connected!");
            SocketManagement sm = new SocketManagement(ipText.Text,8000);
            bool hasStarted = sm.startAsClient();

            if (hasStarted) {
                hostButton.Enabled = false;
                clientButton.Enabled = false;
                /* 
                 * Then open the playing window and assign names and signs.
                 */

                NetworkPlayForm networkForm = new NetworkPlayForm(setting,sm,nameBox.Text);
                networkForm.Visible = true;
                this.Visible = false;


                /*int[][]data=sm.getBoard();
                
                for (int y = 0; y < data.Length; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        Console.WriteLine(data[y][x]);
                    }
                }*/
            }
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
            Console.WriteLine("Hosted!");
            SocketManagement sm = new SocketManagement(ipText.Text, 8000);
            bool hasStarted = sm.startAsServer();
            
            if(hasStarted){
                hostButton.Enabled = false;
                clientButton.Enabled = false;
                /*int[][] grid=new int[3][];
                for (int y = 0; y < grid.Length; y++)
                    for (int x = 0; x < 3; x++)
                        grid[y][x] = 1;
                while(true)
                sm.sendBoard(grid);*/

                NetworkPlayForm networkForm = new NetworkPlayForm(setting,sm,nameBox.Text);
                networkForm.Visible = true;
                this.Visible = false;
            }
        }

       
        
        

    }     
}

