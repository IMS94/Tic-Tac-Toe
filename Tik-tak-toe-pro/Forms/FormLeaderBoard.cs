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

         public List<int> easyBoardScore { get; set; }
        public List<int> mediumBoardScore { get; set; }
        public List<int> hardBoardScore { get; set; }

        public List<string> easyBoardNameRefs { get; set; }
        public List<string> mediumBoardNameRefs { get; set; }
        public List<string> hardBoardNameRefs { get; set; }


        public FormLeaderBoard(LeaderBoard leaderBoardE,Setting settingE)
        {
            InitializeComponent();
            leaderBoard = leaderBoardE;
            setting = settingE;
            lbname.BackColor = Color.Black;
            lbscore.BackColor = Color.Black;
            btadd.BackColor = Color.Green;
            pbeasy.BackColor = Color.Orange;
            lblEasy.ForeColor = Color.Orange;
            pbhard.BackColor = Color.Transparent;
            pbmedium.BackColor = Color.Transparent;
            lblscore.Text = this.leaderBoard.getScore(setting.current[1], setting.current[2]).ToString();
            
            
            NamesAndScores lists = DBManagement.getSinglePlayerScores(1);
            easyBoardNameRefs = lists.names;
            easyBoardScore = lists.scores;

            lists = DBManagement.getSinglePlayerScores(2);
            mediumBoardNameRefs = lists.names;
            mediumBoardScore = lists.scores;

            lists = DBManagement.getSinglePlayerScores(3);
            hardBoardNameRefs = lists.names;
            hardBoardScore = lists.scores;

            this.addTolist(easyBoardNameRefs, easyBoardScore);

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
            lblEasy.ForeColor = Color.Orange;
            lblMedium.ForeColor = Color.White;
            lbHard.ForeColor = Color.White;
            this.addTolist(easyBoardNameRefs,easyBoardScore);
        }

        private void lblMedium_Click(object sender, EventArgs e)
        {
            pbeasy.BackColor = Color.Transparent;
            pbhard.BackColor = Color.Transparent;
            pbmedium.BackColor = Color.Orange;
            lblEasy.ForeColor = Color.White;
            lblMedium.ForeColor = Color.Orange;
            lbHard.ForeColor = Color.White;
            this.addTolist(mediumBoardNameRefs,mediumBoardScore);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pbeasy.BackColor = Color.Transparent;
            pbhard.BackColor = Color.Orange;
            pbmedium.BackColor = Color.Transparent;
            lblEasy.ForeColor = Color.White;
            lblMedium.ForeColor = Color.White;
            lbHard.ForeColor = Color.Orange;

            this.addTolist(hardBoardNameRefs, hardBoardScore);
        }

        private void addTolist(List<string> names,List<int> scores)
        { 
            lbname.Items.Clear();
            lbscore.Items.Clear();

            
            for (int i = 0; i < names.Count; i++)
            {
                lbname.Items.Add(names[i]);
                lbscore.Items.Add(scores[i]);
            }

        }
        public void setinvisibleNewEntryComponents() {
            tbnewname.Visible = false;
            lblyourscore.Visible = false;
            lblscore.Visible = false;
            btadd.Visible = false;

        }



        public int getScore(int countPC, int countUser)
        {
            //method to calculate score
            int score = 50;
            score = score + 5 * countUser - 5 * countPC;
            return score;

        }



        private void btadd_Click(object sender, EventArgs e)
        {
            if(tbnewname.Text.Length<3){
                return;
            }

            //add to database
            DBManagement.addSinglePlayerScores(tbnewname.Text,getScore(setting.current[1],setting.current[2]),setting.difficultyLevel);

            if(setting.difficultyLevel==1){
                NamesAndScores lists = DBManagement.getSinglePlayerScores(1);
                easyBoardNameRefs = lists.names;
                easyBoardScore = lists.scores;
               
            }
            else if (setting.difficultyLevel == 2)
            {
                NamesAndScores lists = DBManagement.getSinglePlayerScores(2);
                mediumBoardNameRefs = lists.names;
                mediumBoardScore = lists.scores;
            }
            else 
            {
                NamesAndScores lists = DBManagement.getSinglePlayerScores(3);
                hardBoardNameRefs = lists.names;
                hardBoardScore = lists.scores;
            }
            if(pbeasy.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Orange;
                pbhard.BackColor = Color.Transparent;
                pbmedium.BackColor = Color.Transparent;
                this.addTolist(easyBoardNameRefs, easyBoardScore);
            }
            else if(pbhard.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Transparent;
                pbhard.BackColor = Color.Orange;
                pbmedium.BackColor = Color.Transparent;
                this.addTolist(hardBoardNameRefs, hardBoardScore);
            }
            else if (pbmedium.BackColor.Equals(Color.Orange))
            {
                pbeasy.BackColor = Color.Transparent;
                pbhard.BackColor = Color.Transparent;
                pbmedium.BackColor = Color.Orange;
                this.addTolist(mediumBoardNameRefs, mediumBoardScore);
            }
            setting.current[0] = 0;
            setting.current[1] = 0;
            setting.current[2] = 0;
            btadd.Enabled = false;
            
        }

        private void tbnewname_Click(object sender, EventArgs e)
        {
            tbnewname.Text = "";
            tbnewname.ForeColor = Color.White;
        }

        
        
    }     
}

