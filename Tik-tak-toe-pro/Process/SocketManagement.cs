using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Tik_tak_toe_pro
{
    public class SocketManagement
    {
        private IPAddress ip;
        private int port;
        private TcpListener tcpListener;
        private TcpClient client;
        private NetworkStream stream;


        /*  
         * Constructor to open a socket if wanted.
         * Can operate as server or the client. 
         */
        public SocketManagement(String ip, int port) {
            this.ip = IPAddress.Parse(ip);
            this.port = port;
        }

        /*
         * Method to start a server
         */
        public bool StartAsServer(){
            try
            {
                tcpListener = new TcpListener(ip, port);
                tcpListener.Start();
                client = tcpListener.AcceptTcpClient();
                stream = client.GetStream();
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message); 
                return false; 
            }
            return true;
        }

        /*
         * Method to start as client
         */
        public bool startAsClient() {
            client = new TcpClient();
            client.Connect(ip, port);

            stream = client.GetStream();

            return true;
        }


        public bool sendBoard(int[][] grid)
        {
            try
            {
                string data = "";
                for (int y = 0; y < 3; y++)
                    for (int x = 0; x < 3; x++)
                        data += grid[y][x];

                byte[] dataBytes = new byte[255];
                dataBytes = new ASCIIEncoding().GetBytes(data);
                stream.Write(dataBytes, 0, dataBytes.Length);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); return false; }
            return true;
        }


        public int[][] getBoard()
        {

            byte[] bytes = new byte[255];
            stream.Read(bytes, 0, bytes.Length);
            string temp = new ASCIIEncoding().GetString(bytes);
            char[] charOfTemp = temp.ToCharArray();
            
            int[][] grid = { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                    grid[y][x] = Int32.Parse("" + charOfTemp[(y * 3) + x]);
            
            return grid;
        }

    }
}
