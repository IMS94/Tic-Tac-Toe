using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    public class Setting
    {
        //difficultylevel- 1- easy  2-medium  3-hard
        public LeaderBoard leaderBoard { set; get; }
        public int difficultyLevel{set;get;}
        public bool isStartedByPC { set; get; }

        public int[] current;       //corrent[0]=total count current[1]=pcwinCount current[2]=userwincount;
        public Setting()
        {
            this.leaderBoard = new LeaderBoard();
            current = new int[3];
        }
        
    }
}
