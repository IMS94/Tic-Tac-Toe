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
        List<int> easyBoardScore = new List<int>();
        List<int> mediumBoardScore = new List<int>();
        List<int> hardBoardScore = new List<int>();
        
        List<string[]> easyBoardNames = new List<string[]>();
        List<string[]> mediumBoardNames = new List<string[]>();
        List<string[]> hardBoardNames = new List<string[]>();

        public void addNewScore(string name, int countPC, int countUser, List<string[]> boardNames,List<int> boardScore)
        {
            //method to calculate score
            int score=50;
            score = score + 5 * countUser - 5 * countPC;
            string[] reference = new string[2];
            reference[0] = score.ToString();
            reference[1] = name;
            boardNames.Add(reference);
            boardScore.Add(score);
            //sort here
        }

        public bool sortList(List<int[]> list, List<string> names)
        {



            if (list.Count > 10) 
            {
                list.RemoveAt(10);
                names.RemoveAt(10);

            }

        }




    }
}
