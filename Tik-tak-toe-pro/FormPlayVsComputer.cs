using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tik_tak_toe_pro
{
    public partial class FormPlayVsComputer : Form
    {
        private int[,] grid;
        Setting setting;
        PlayModel playModel;
        
        public FormPlayVsComputer(Setting settingE)
        {
            InitializeComponent();
            grid = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = 0;
                }
            }
            setting = settingE;
            int level=setting.difficultyLevel;
            if (level == 1)
            {
                playModel = new Easy(1, -1);
            }
            else if (level == 2) {

                playModel = new Medium(1, -1);
            }
            else if (level == 3)
            {
                playModel = new Hard(1, -1);
            }
            
            bool b = !setting.isStartedByPC;
            playModel.setStarted(b);
            setting.isStartedByPC = b;
            if (b)
            {
                playModel.pcPlay(grid, playModel.pcMark);
                this.refreshVal();
            }
        }

        public void refreshVal() 
        {
        if (grid[0,0] == 0) { lbl00.Text="";}else if (grid[0,0]== 1){lbl00.Text="X";}else if(grid[0,0]==-1){lbl00.Text="O";}
        if (grid[0,1] == 0) { lbl01.Text="";}else if (grid[0,1]== 1){lbl01.Text="X";}else if(grid[0,1]==-1){lbl01.Text="O";}
        if (grid[0,2] == 0) { lbl02.Text="";}else if (grid[0,2]== 1){lbl02.Text="X";}else if(grid[0,2]==-1){lbl02.Text="O";}
        if (grid[1,0] == 0) { lbl10.Text="";}else if (grid[1,0]== 1){lbl10.Text="X";}else if(grid[1,0]==-1){lbl10.Text="O";}
        if (grid[1,1] == 0) { lbl11.Text="";}else if (grid[1,1]== 1){lbl11.Text="X";}else if(grid[1,1]==-1){lbl11.Text="O";}
        if (grid[1,2] == 0) { lbl12.Text="";}else if (grid[1,2]== 1){lbl12.Text="X";}else if(grid[1,2]==-1){lbl12.Text="O";}
        if (grid[2,0] == 0) { lbl20.Text="";}else if (grid[2,0]== 1){lbl20.Text="X";}else if(grid[2,0]==-1){lbl20.Text="O";}
        if (grid[2,1] == 0) { lbl21.Text="";}else if (grid[2,1]== 1){lbl21.Text="X";}else if(grid[2,1]==-1){lbl21.Text="O";}
        if (grid[2, 2] == 0) { lbl22.Text = ""; } else if (grid[2, 2] == 1) { lbl22.Text = "X"; } else if (grid[2, 2] == -1) { lbl22.Text = "O"; }
        
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
            StartForm st = new StartForm(setting);
            st.Visible = true;
            this.Dispose();
           
        }

        private void lbl02_Click(object sender, EventArgs e)
        {
            playModel.userPlay(0, 2, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            playModel.userPlay(1, 2, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            playModel.userPlay(2, 2, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl01_Click(object sender, EventArgs e)
        {
            playModel.userPlay(0, 1, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            playModel.userPlay(1, 1, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            playModel.userPlay(2, 1, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
          
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl00_Click(object sender, EventArgs e)
        {
            playModel.userPlay(0, 0, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
         
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            playModel.userPlay(1, 0, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark), false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            playModel.userPlay(2, 0, grid, playModel.userMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.userMark),false);
            this.refreshVal();
           
            playModel.pcPlay(grid, playModel.pcMark);
            this.gameDecision(NormalPlay.checkStatus(grid, playModel.pcMark), true);
            this.refreshVal();
        
        }

        //false=user  true =PC
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
                    labelStatus.Text = "Computer Won";
                    panel1.Enabled = false;

                }
            else if (!b && s.Equals("win"))
            {
                panel1.BackColor = Color.DarkGray;
                labelStatus.Text = "Congradulations,You Won";
                panel1.Enabled = false;

            }
           

        }

        private void lblReplay_Click(object sender, EventArgs e)
        {
            FormPlayVsComputer vsPcNew = new FormPlayVsComputer(setting);
            vsPcNew.Visible = true;
            this.Visible = false;
        }

        
    }
}
