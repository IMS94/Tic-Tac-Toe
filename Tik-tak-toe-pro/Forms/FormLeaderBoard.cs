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
    public partial class FormLeaderBoard : Form
    {
        LeaderBoard leaderBoard;
        Setting setting;
        public FormLeaderBoard(LeaderBoard leaderBoardE,Setting settingE)
        {
            InitializeComponent();
            leaderBoard = leaderBoardE;
            setting = settingE;
            lbname.BackColor = Color.Black;
            lbscore.BackColor = Color.Black;
            btadd.BackColor = Color.Green;
            pbeasy.BackColor = Color.Orange;
            pbhard.BackColor = Color.Transparent;
            pbmedium.BackColor = Color.Transparent;
            lblscore.Text = this.leaderBoard.getScore(setting.current[1], setting.current[2]).ToString();
            this.addTolist(leaderBoard.easyBoardNameRefs, leaderBoard.easyBoardScore);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblEasy_Click(object sender, EventArgs e)
        {
            pbeasy.BackColor = Color.Orange;
            pbhard.BackColor = Color.Transparent;
            pbmedium.BackColor = Color.Transparent;
            this.addTolist(leaderBoard.easyBoardNameRefs, leaderBoard.easyBoardScore);
        }

        private void lblMedium_Click(object sender, EventArgs e)
        {
            pbeasy.BackColor = Color.Transparent;
            pbhard.BackColor = Color.Transparent;
            pbmedium.BackColor = Color.Orange;
            this.addTolist(leaderBoard.mediumBoardNameRefs, leaderBoard.mediumBoardScore);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pbeasy.BackColor = Color.Transparent;
            pbhard.BackColor = Color.Orange;
            pbmedium.BackColor = Color.Transparent;
            this.addTolist(leaderBoard.hardBoardNameRefs, leaderBoard.hardBoardScore);
        }

        private void addTolist(List<string[]> boardNameRefs,List<int> scores)
        { 
            lbname.Items.Clear();
            lbscore.Items.Clear();

            List<string[]> names=new List<string[]>();

            for (int i = 0; i < boardNameRefs.Count; i++)
            {
                names.Add(boardNameRefs[i]);
            }

            for (int i = scores.Count - 1; i >= 0; i--)
            {
                lbscore.Items.Add(scores[i]);
                for (int j = 0; j < names.Count; j++)
                {
                    if (names[j][0].Equals(scores[i].ToString()))
                    {
                        lbname.Items.Add(names[j][1]);
                        names.RemoveAt(j);
                    }
                }
            }
        
        }
        public void setinvisibleNewEntryComponents() {
            tbnewname.Visible = false;
            lblyourscore.Visible = false;
            lblscore.Visible = false;
            btadd.Visible = false;

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if(setting.difficultyLevel==1){
                leaderBoard.addNewScore(tbnewname.Text, setting.current[1], setting.current[2], leaderBoard.easyBoardNameRefs, leaderBoard.easyBoardScore);
            }
            else if (setting.difficultyLevel == 2)
            {
                leaderBoard.addNewScore(tbnewname.Text, setting.current[1], setting.current[2], leaderBoard.mediumBoardNameRefs, leaderBoard.mediumBoardScore);
            }
            else 
            {
                leaderBoard.addNewScore(tbnewname.Text, setting.current[1], setting.current[2], leaderBoard.hardBoardNameRefs, leaderBoard.hardBoardScore);

            }
            if(pbeasy.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Orange;
                pbhard.BackColor = Color.Transparent;
                pbmedium.BackColor = Color.Transparent;
                this.addTolist(leaderBoard.easyBoardNameRefs, leaderBoard.easyBoardScore);
            }
            else if(pbhard.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Transparent;
                pbhard.BackColor = Color.Orange;
                pbmedium.BackColor = Color.Transparent;
                this.addTolist(leaderBoard.hardBoardNameRefs, leaderBoard.hardBoardScore);
            }
            else if (pbmedium.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Transparent;
                pbhard.BackColor = Color.Transparent;
                pbmedium.BackColor = Color.Orange;
                this.addTolist(leaderBoard.mediumBoardNameRefs, leaderBoard.mediumBoardScore);
            }
            setting.current[0] = 0;
            setting.current[1] = 0;
            setting.current[2] = 0;
            btadd.Enabled = false;
            
        }
        
        
    }     
}

