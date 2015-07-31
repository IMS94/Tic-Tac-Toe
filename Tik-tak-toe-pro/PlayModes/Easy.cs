using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    class Easy : PlayModel
    {

        public Easy(int userMarkE, int pcMarkE) { userMark = userMarkE; pcMark = pcMarkE; }
        public override void setStarted(bool b) { isStartedByPC = b; }
        public override void userPlay(int X, int Y, int[,] grid, int turn) 
        {
            
            if (countUser == 0) { userTurn1X = X; userTurn1Y = Y; }
            else if (countUser == 1) { userTurn2X = X; userTurn2Y = Y; }
            grid[X, Y] = turn;
            countUser = countUser + 1;

        }
        public override string pcPlay(int[,] grid, int turn)
        {
            string result ="normal";
            result = NormalPlay.play(grid, pcMark);
            countPC += 1;
            return result;

        }


       
    }
}
