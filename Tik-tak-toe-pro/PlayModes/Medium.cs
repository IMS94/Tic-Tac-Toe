using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    class Medium : PlayModel
    {
 
        public Medium(int userMarkE, int pcMarkE) { userMark = userMarkE; pcMark = pcMarkE; }
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
            if (isStartedByPC)
            {
                if (countPC == 0)
                {
                    if (grid[1, 1] == 0)
                    {
                        grid[1, 1] = turn;
                        pcTurn1X = 1;
                        pcTurn1Y = 1;
                    }
                    else {
                        result = NormalPlay.play(grid, pcMark);
                    }
                }
                else if (countPC == 1)
                {

                    if ((userTurn1X + userTurn1Y) % 2 == 0)
                    {
                        if (grid[2 - userTurn1X, 2 - userTurn1Y] == 0)
                        {
                            grid[2 - userTurn1X, 2 - userTurn1Y] = turn;
                            pcTurn2X = 2 - userTurn1X;
                            pcTurn2Y = 2 - userTurn1Y;
                        }
                        else
                        {
                            result = NormalPlay.play(grid, pcMark);
                        }
                    }
                    else
                    {
                        if (userTurn1X == 1)
                        {
                            if (grid[2, userTurn1Y] == 0)
                            {
                                grid[2, userTurn1Y] = turn;
                                pcTurn2X = 2;
                                pcTurn2Y = userTurn1Y;
                            }
                            else {
                                result = NormalPlay.play(grid, pcMark);
                            }
                        }
                        else
                        {
                            if (grid[userTurn1X, 2] == 0)
                            {
                                grid[userTurn1X, 2] = turn;
                                pcTurn2X = userTurn1X;
                                pcTurn2Y = 2;
                            }
                            else 
                            {
                                result = NormalPlay.play(grid, pcMark);
                            }
                        }
                    }
                }
                else 
                {
                    result = NormalPlay.play(grid, pcMark);
                }
            }
            else
            {
                
                if (countPC == 0)
                {
                    if (grid[1, 1] == 0)
                    {
                        grid[1, 1] = turn;
                        pcTurn1X = 1;
                        pcTurn1Y = 1;
                    }
                    else {
                        grid[0, 2] = turn;
                        pcTurn1X = 0;
                        pcTurn1Y = 2;
                    }
                }
                
                else 
                {
                    result = NormalPlay.play(grid, pcMark);
                
                }

            }
            countPC += 1;
            return result;

        }
    }
}
