using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    class Hard : PlayModel
    {
 
        public Hard(int userMarkE, int pcMarkE) { userMark = userMarkE; pcMark = pcMarkE; }
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
                    grid[1, 1] = turn;
                    pcTurn1X = 1;
                    pcTurn1Y = 1;
                }
                else if (countPC == 1)
                {

                    if ((userTurn1X + userTurn1Y) % 2 == 0)
                    {
                        grid[2 - userTurn1X, 2 - userTurn1Y] = turn;
                        pcTurn2X = 2 - userTurn1X;
                        pcTurn2Y = 2 - userTurn1Y;
                    }
                    else
                    {
                        if (userTurn1X == 1)
                        {
                            grid[2, userTurn1Y] = turn;
                            pcTurn2X = 2;
                            pcTurn2Y = userTurn1Y;
                        }
                        else
                        {
                            grid[userTurn1X, 2] = turn;
                            pcTurn2X = userTurn1X;
                            pcTurn2Y = 2;
                        }
                    }
                }
                else if (countPC == 2)
                {
                    if ((userTurn1X + userTurn1Y) % 2 == 0)
                    {
                        if ((userTurn2X + userTurn2Y) % 2 == 0)
                        {
                            result=NormalPlay.play(grid, pcMark);   
                        }
                        else
                        {
                            if (userTurn1X - userTurn2X == 1 && userTurn1Y == userTurn2Y || userTurn1X == userTurn2X && userTurn1Y - userTurn2Y == 1)
                            {
                                grid[2 * userTurn2X - userTurn1X, 2 * userTurn2Y - userTurn1Y] = turn;
                            }
                            else
                            {
                                grid[2 - (2 * userTurn2X - pcTurn2X), 2 - (2 * userTurn2Y - pcTurn2Y)] = turn;
                            }
                        }
                    }
                    else
                    {
                        if (grid[2 - (userTurn1X * 2 - pcTurn2X), 2 - (2 * userTurn1Y - pcTurn2Y)] == 0)
                        {
                            grid[2 - (userTurn1X * 2 - pcTurn2X), 2 - (2 * userTurn1Y - pcTurn2Y)] = turn;
                        }
                        else {
                            grid[2 - pcTurn2X, 2 - pcTurn2Y] = turn;
                        }
                    }
                }
                else 
                {
                    result=NormalPlay.play(grid,pcMark);
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
                else if (countPC == 1)
                {
                    if (userTurn1X == 1 && userTurn1Y == 1)
                    {
                        if (userTurn2X == 2 && userTurn2Y == 0)
                        {
                            grid[0, 0] = turn;
                            pcTurn1X = 0;
                            pcTurn1Y = 0;
                        }
                        else
                        {
                            result = NormalPlay.play(grid, pcMark);
                        }
                    }
                    else 
                    {
                        if (userTurn1X + userTurn2X == 2 && userTurn1Y + userTurn2Y == 2)
                        {
                            grid[0, 1] = turn;
                            pcTurn1X = 0;
                            pcTurn1Y = 1;
                        }
                        else 
                        {
                            result = NormalPlay.play(grid, pcMark);
                        
                        }
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
