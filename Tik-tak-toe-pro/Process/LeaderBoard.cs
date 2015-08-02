using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    //reference[0]=score.toSring()   reference[1]=name;
    public class LeaderBoard
    {
        public List<int> easyBoardScore { get; set; }
        public List<int> mediumBoardScore { get; set; }
        public List<int> hardBoardScore { get; set; }

        public List<string> easyBoardNameRefs { get; set; }
        public List<string> mediumBoardNameRefs { get; set; }
        public List<string> hardBoardNameRefs { get; set; }

        public LeaderBoard()
        {
            easyBoardScore = new List<int>();
            mediumBoardScore = new List<int>();
            hardBoardScore = new List<int>();

            easyBoardNameRefs = new List<string>();
            mediumBoardNameRefs = new List<string>();
            hardBoardNameRefs = new List<string>();
        }


        public int getScore(int countPC,int countUser ) {
            //method to calculate score
            int score = 50;
            score = score + 5 * countUser - 5 * countPC;
            return score;
        
        }
        public void addNewScore(string name, int countPC, int countUser, List<string> boardNames,List<int> boardScore)
        {
            int score;
            score = getScore(countPC, countUser);
            
            //add new reference and score to lists
            boardNames.Add(name);
            boardScore.Add(score);
            
            //sort the list
            boardScore.Sort();
            
            //if count >10 remove min
            int minScore;

            if (boardScore.Count > 10)
            { 
                minScore=boardScore[0];
                for(int i=10;i>=0;i++)
                {
                    if (boardNames[i][0].Equals(minScore.ToString())) 
                    {
                        boardNames.RemoveAt(i);
                        break;
                    } 
                }

                boardScore.RemoveAt(0);
            }
        }
    }
}
