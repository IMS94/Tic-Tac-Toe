﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Tik_tak_toe_pro
{
    public partial class NetworkPlayForm : Form
    {
        private int[,] grid;
        Setting setting;
        Human playModel;
        private bool myTurn;
        private SocketManagement socketManagement;
        private String me, opponent;
        Thread threadMain;


        delegate void refreshValCallback();
        delegate void replayCallBack();
        public NetworkPlayForm(Setting settingE,SocketManagement socketManagement,String me)
        {
            InitializeComponent();
            this.me = me;
            this.socketManagement = socketManagement;
            lbluser1.Text = me;
            grid = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }

            setting = settingE;

            myTurn = true;
            setupNames();   //set the names of the users.
            refreshVal();
            lblReplay.Visible = false;

            if(!myTurn){
                threadMain = new Thread(() =>
                {
                    refreshVal();
                    //grid = socketManagement.getBoard();
                    String message = socketManagement.getMessage();
                    message = message.Replace("\0", String.Empty);
                    if (String.Compare(message, "-1") == 0)
                    {
                        //then replay
                        replay();
                        return;
                    }
                    else
                    {
                        grid = getBoard(message);
                    }
                    myTurn = true;
                    refreshVal();

                });
                threadMain.Start();
                
            }
        }


        private void setupNames(){
            while(true){
                if (socketManagement.getConnectionType() == SocketManagement.SERVER)
                {
                    myTurn = true;
                    playModel = new Human(1, -1);
                    lbluser1.Text = me + " - X";
                    socketManagement.sendMessage(me);
                    while (true) {
                        String name = socketManagement.getMessage();
                        name=name.Replace("\0", String.Empty);
                        if(Regex.Matches(name,"[a-zA-Z]").Count>2){
                            //Then the name arrived.
                            opponent = name;
                            lbluser2.Text = (opponent + " - O");
                            break;
                        }
                    }
                    break;
                }
                else if (socketManagement.getConnectionType() == SocketManagement.CLIENT) {
                    myTurn = false;
                    playModel = new Human(-1, 1);
                    lbluser1.Text = me + " - O";
                    lblReplay.Visible = false;

                    while (true)
                    {
                        String name = socketManagement.getMessage();
                        name=name.Replace("\0", String.Empty);
                        if (Regex.Matches(name, "[a-zA-Z]").Count > 2)
                        {
                            //Then the name arrived.
                            opponent = name;
                            lbluser2.Text = name + " - X";
                            socketManagement.sendMessage(me);
                            break;
                        }
                    }
                    break;
                }
            }
            //lbluser2.Text = opponent;
            
        }

        public void refreshVal() 
        {
            if (lbl00.InvokeRequired)
            {
                refreshValCallback d = new refreshValCallback(refreshVal);
                this.Invoke(d);
            }
            else
            {
                if (grid[0, 0] == 0) { lbl00.Text = ""; } else if (grid[0, 0] == 1) { lbl00.Text = "X"; } else if (grid[0, 0] == -1) { lbl00.Text = "O"; }
                if (grid[0, 1] == 0) { lbl01.Text = ""; } else if (grid[0, 1] == 1) { lbl01.Text = "X"; } else if (grid[0, 1] == -1) { lbl01.Text = "O"; }
                if (grid[0, 2] == 0) { lbl02.Text = ""; } else if (grid[0, 2] == 1) { lbl02.Text = "X"; } else if (grid[0, 2] == -1) { lbl02.Text = "O"; }
                if (grid[1, 0] == 0) { lbl10.Text = ""; } else if (grid[1, 0] == 1) { lbl10.Text = "X"; } else if (grid[1, 0] == -1) { lbl10.Text = "O"; }
                if (grid[1, 1] == 0) { lbl11.Text = ""; } else if (grid[1, 1] == 1) { lbl11.Text = "X"; } else if (grid[1, 1] == -1) { lbl11.Text = "O"; }
                if (grid[1, 2] == 0) { lbl12.Text = ""; } else if (grid[1, 2] == 1) { lbl12.Text = "X"; } else if (grid[1, 2] == -1) { lbl12.Text = "O"; }
                if (grid[2, 0] == 0) { lbl20.Text = ""; } else if (grid[2, 0] == 1) { lbl20.Text = "X"; } else if (grid[2, 0] == -1) { lbl20.Text = "O"; }
                if (grid[2, 1] == 0) { lbl21.Text = ""; } else if (grid[2, 1] == 1) { lbl21.Text = "X"; } else if (grid[2, 1] == -1) { lbl21.Text = "O"; }
                if (grid[2, 2] == 0) { lbl22.Text = ""; } else if (grid[2, 2] == 1) { lbl22.Text = "X"; } else if (grid[2, 2] == -1) { lbl22.Text = "O"; }

                if (myTurn)
                {
                    lbluser2.ForeColor = Color.DimGray;
                    lbluser1.ForeColor = Color.White;
                }
                else {
                    lbluser2.ForeColor = Color.White;
                    lbluser1.ForeColor = Color.DimGray;
                }

                //check if one of them won
                //user1=false, user2=true
                this.gameDecision(NormalPlay.checkStatus(grid, playModel.user1Mark), false);
                this.gameDecision(NormalPlay.checkStatus(grid, playModel.user2Mark), true);

            }
        }

        private void lblReplay_MouseEnter(object sender, EventArgs e)
        {
            lblReplay.BackColor = Color.DimGray;
        }

        private void lblReplay_MouseLeave(object sender, EventArgs e)
        {
            lblReplay.BackColor = Color.Transparent;
        }

        private void lblMenu_MouseEnter(object sender, EventArgs e)
        {
            lblMenu.BackColor = Color.DimGray;
        }

        private void lblMenu_MouseLeave(object sender, EventArgs e)
        {
            lblMenu.BackColor = Color.Transparent;
        }

        private void lbl02_MouseEnter(object sender, EventArgs e)
        {
            lbl02.BackColor = Color.DimGray;
            lbl02.ForeColor = Color.Black;
        }

        private void lbl02_MouseLeave(object sender, EventArgs e)
        {
            lbl02.BackColor = Color.Transparent;
            lbl02.ForeColor = Color.DimGray;
        }

        private void lbl01_MouseEnter(object sender, EventArgs e)
        {
            lbl01.BackColor = Color.DimGray;
            lbl01.ForeColor = Color.Black;
        }

        private void lbl01_MouseLeave(object sender, EventArgs e)
        {
            lbl01.BackColor = Color.Transparent;
            lbl01.ForeColor = Color.DimGray;
        }

        private void lbl00_MouseEnter(object sender, EventArgs e)
        {
            lbl00.BackColor = Color.DimGray;
            lbl00.ForeColor = Color.Black;
        }

        private void lbl00_MouseLeave(object sender, EventArgs e)
        {
            lbl00.BackColor = Color.Transparent;
            lbl00.ForeColor = Color.DimGray;
        }

        private void lbl12_MouseEnter(object sender, EventArgs e)
        {
            lbl12.BackColor = Color.DimGray;
            lbl12.ForeColor = Color.Black;
        }

        private void lbl12_MouseLeave(object sender, EventArgs e)
        {
            lbl12.BackColor = Color.Transparent;
            lbl12.ForeColor = Color.DimGray;
        }

        private void lbl11_MouseEnter(object sender, EventArgs e)
        {
            lbl11.BackColor = Color.DimGray;
            lbl11.ForeColor = Color.Black;
        }

        private void lbl11_MouseLeave(object sender, EventArgs e)
        {
            lbl11.BackColor = Color.Transparent;
            lbl11.ForeColor = Color.DimGray;
        }

        private void lbl10_MouseEnter(object sender, EventArgs e)
        {
            lbl10.BackColor = Color.DimGray;
            lbl10.ForeColor = Color.Black;
        }

        private void lbl10_MouseLeave(object sender, EventArgs e)
        {
            lbl10.BackColor = Color.Transparent;
            lbl10.ForeColor = Color.DimGray;
        }

        private void lbl22_MouseEnter(object sender, EventArgs e)
        {
            lbl22.BackColor = Color.DimGray;
            lbl22.ForeColor = Color.Black;
        }

        private void lbl22_MouseLeave(object sender, EventArgs e)
        {
            lbl22.BackColor = Color.Transparent;
            lbl22.ForeColor = Color.DimGray;
        }

        private void lbl21_MouseEnter(object sender, EventArgs e)
        {
            lbl21.BackColor = Color.DimGray;
            lbl21.ForeColor = Color.Black;
        }

        private void lbl21_MouseLeave(object sender, EventArgs e)
        {
            lbl21.BackColor = Color.Transparent;
            lbl21.ForeColor = Color.DimGray;
        }

        private void lbl20_MouseEnter(object sender, EventArgs e)
        {
            lbl20.BackColor = Color.DimGray;
            lbl20.ForeColor = Color.Black;}

        private void lbl20_MouseLeave(object sender, EventArgs e)
        {
            lbl20.BackColor = Color.Transparent;
            lbl20.ForeColor = Color.DimGray;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            socketManagement.closeSocket();
            StartForm st = new StartForm(setting);
            st.Visible = true;
            this.Dispose();
           
        }

        private void lbl02_Click(object sender, EventArgs e)
        {
                if (!myTurn)
                {
                    return;
                }
                if (grid[0, 2] == 0)
                {
                    labelClick(0, 2);
                  //  lbl02.Enabled = false;
                }
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[1, 2] == 0)
            {
                labelClick(1, 2);
                //lbl12.Enabled = false;
            }
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[2, 2] == 0)
            {

                labelClick(2, 2);
               // lbl22.Enabled = false;
            }
        }

        private void lbl01_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[0, 1] == 0)
            {

                labelClick(0, 1);
                //lbl01.Enabled = false;
            }
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[1, 1] == 0)
            {

                labelClick(1, 1);
                //lbl11.Enabled = false;
            }
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[2, 1] == 0)
            {

                labelClick(2, 1);
                //lbl21.Enabled = false;
            }
        }

        private void lbl00_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[0, 0] == 0)
            {
                labelClick(0, 0);
                //lbl00.Enabled = false;
            }
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[1, 0] == 0)
            {
                labelClick(1, 0);
                //lbl10.Enabled = false;
            }
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            if (!myTurn)
            {
                return;
            }
            if (grid[2, 0] == 0)
            {
                labelClick(2, 0);
             //   lbl20.Enabled = false;
            }
        }


        private void ListenChanges() {
            try
            {
                socketManagement.sendBoard(grid);
                //grid = socketManagement.getBoard();
                String message = socketManagement.getMessage();
                message = message.Replace("\0", String.Empty);
                if (String.Compare(message, "-1") == 0)
                {
                    //then replay
                    replay();
                    return;
                }
                else
                {
                    grid = getBoard(message);
                }

                myTurn = true;
                refreshVal();
            }
            catch(Exception ex){
                
            }
        }


        private void labelClick(int X,int Y) 
        {

            if (myTurn)
            {
                myTurn = false;
                playModel.userPlay(X, Y, grid, playModel.user1Mark);

                //check if one of them has won
                //this.gameDecision(NormalPlay.checkStatus(grid, playModel.user1Mark), false);
                //this.gameDecision(NormalPlay.checkStatus(grid, playModel.user1Mark), true);
                
                refreshVal();
                
                Thread listener = new Thread(new ThreadStart(
                    ListenChanges
                ));
                listener.Start();
                
            }
            
        }


        private int[,] getBoard(String message) { 
            int[,] grid = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                
                char[] charOfMessage = message.ToCharArray();

                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        /*
                         * Retrieve the grid with -1 replaced for 2
                         */
                        grid[y, x] = Int32.Parse("" + charOfMessage[(y * 3) + x]);
                        if (grid[y, x] == 2)
                        {
                            grid[y, x] = -1;
                        }
                    }
                }
                return grid;
        }


        private String setBoard() {
            string data = "";
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    /*
                     * Assign 2 for (-1)
                     */
                    if (grid[y, x] == -1)
                    {
                        data += 2;
                    }
                    else
                    {
                        data += grid[y, x];
                    }
                }
            }
            return data;
        }



        //false=user1  true =user2
        private void gameDecision(string s,bool b)
        {
            if (s.Equals("draw"))
            {
                panel1.BackColor = Color.DarkGray;
                labelStatus.Text = "Match Drawn";
                panel1.Enabled = false;

            }

            if(b && s.Equals("win"))
                {
                    panel1.BackColor = Color.DarkGray;
                    labelStatus.Text = opponent+" Won";
                    panel1.Enabled = false;

                }
            else if (!b && s.Equals("win"))
            {
                panel1.BackColor = Color.DarkGray;
                labelStatus.Text = me+" Won";
                panel1.Enabled = false;

            }
           

        }



        private void replay() {
            myTurn = true;
            grid = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            refreshVal();

            new Thread(() => {
                ListenChanges();
            });
        }

        private void reset() {
            if (lbl00.InvokeRequired)
            {
                replayCallBack c = new replayCallBack(reset);
                this.Invoke(c);
            }
            else
            {
                lbl00.Enabled = true;
                lbl01.Enabled = true;
                lbl02.Enabled = true;
                lbl10.Enabled = true;
                lbl12.Enabled = true;
                lbl11.Enabled = true;
                lbl20.Enabled = true;
                lbl21.Enabled = true;
                lbl22.Enabled = true;
                panel1.Enabled = true;
                labelStatus.Text = "";
            }
        }


        private void lblReplay_Click(object sender, EventArgs e)
        {
            //start a new game
            if (socketManagement.flushStream())
            {
                socketManagement.sendMessage("-1");
                myTurn = true;
                grid = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                refreshVal();
                reset();
                
            }
            
        }

        

        
    }
}
