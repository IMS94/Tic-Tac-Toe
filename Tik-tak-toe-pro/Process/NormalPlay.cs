using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    class NormalPlay
    {
        //X=1;
        //O=-1;
        //null=0;
        public static string checkStatus(int[,] grid, int value)
        {
            string b = "normal";

            bool isFull=true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        isFull=false;
                       
                    }
                }
            }
            if (isFull) { b = "draw"; }
            
            for (int x = 0; x < 3; x++)
            {
                if (grid[x, 0] == grid[x, 1] && grid[x, 1] == grid[x, 2] && grid[x, 1] == value)
                {
                    b="win";
                }
            }
            for (int y = 0; y < 3; y++)
            {
                if (grid[0, y] == grid[1, y] && grid[1, y] == grid[2, y] && grid[0, y] == value)
                {
                    b = "win";
                }
            }
            if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] == value)
            {
                b = "win";
            }
            if (grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2] && grid[1, 1] == value)
            {
                b = "win";
            }

            return b;
        }

        public static string play(int[,] grid, int turn) 
        {
            bool a = winPlay(grid, turn);
            if (a) { return "win";}
            else 
            {
                bool b = savePlay(grid, turn);
                if (b) { return "normal"; }
                else
                {
                    bool c = randomPlay(grid, turn);
                    if (c) { return "normal"; }
                    else { return "draw"; }
                }
            }
        
        
        }
        public static bool winPlay(int[,] grid, int turn)
        {
            int op;
            op = turn;
            //column win
            for (int x = 0; x < 3; x++)
            {
                if (grid[x, 0] == grid[x, 1] && grid[x, 0] == op && grid[x, 2] == 0)
                {
                    grid[x, 2] = turn;
                    return true;
                }
                else if (grid[x, 1] == grid[x, 2] && grid[x, 1] == op && grid[x, 0] == 0)
                {
                    grid[x, 0] = turn;
                    return true;
                }
                else if (grid[x, 0] == grid[x, 2] && grid[x, 0] == op && grid[x, 1] == 0)
                {
                    grid[x, 1] = turn;
                    return true;
                }
            }

            //raw win
            for (int y = 0; y < 3; y++)
            {
                if (grid[0, y] == grid[1, y] && grid[0, y] == op && grid[2, y] == 0)
                {
                    grid[2, y] = turn;
                    return true;
                }
                else if (grid[1, y] == grid[2, y] && grid[1, y] == op && grid[0, y] == 0)
                {
                    grid[0, y] = turn;
                    return true;
                }
                else if (grid[0, y] == grid[2, y] && grid[0, y] == op && grid[1, y] == 0)
                {
                    grid[1, y] = turn;
                    return true;
                }
            }

            //cross win
            if (grid[0, 0] == grid[1, 1] && grid[0, 0] == op && grid[2, 2] == 0)
            {
                grid[2, 2] = turn;
                return true;
            }
            else if (grid[0, 0] == grid[2, 2] && grid[0, 0] == op && grid[1, 1] == 0)
            {
                grid[1, 1] = turn;
                return true;
            }
            else if (grid[1, 1] == grid[2, 2] && grid[1, 1] == op && grid[0, 0] == 0)
            {
                grid[0, 0] = turn;
                return true;
            }

            //cross win 2nd
            if (grid[0, 2] == grid[1, 1] && grid[1, 1] == op && grid[2, 0] == 0)
            {
                grid[2, 0] = turn;
                return true;
            }
            else if (grid[2, 0] == grid[1, 1] && grid[1, 1] == op && grid[0, 2] == 0)
            {
                grid[0, 2] = turn;
                return true;
            }
            else if (grid[0, 2] == grid[2, 0] && grid[0, 2] == op && grid[1, 1] == 0)
            {
                grid[1, 1] = turn;
                return true;
            }

            return false;
        }




        public static bool savePlay(int[,] grid, int turn)
        {
            int op;
            if (turn == 1) { op = -1; }
            else { op = 1; }

            //column save
            for (int x = 0; x < 3; x++)
            {
                if (grid[x, 0] == grid[x, 1] && grid[x, 0] == op && grid[x, 2] == 0)
                {
                    grid[x, 2] = turn;
                    return true;
                }
                else if (grid[x, 1] == grid[x, 2] && grid[x, 1] == op && grid[x, 0] == 0)
                {
                    grid[x, 0] = turn;
                    return true;
                }
                else if (grid[x, 0] == grid[x, 2] && grid[x, 0] == op && grid[x, 1] == 0)
                {
                    grid[x, 1] = turn;
                    return true;
                }
            }

            //raw save
            for (int y = 0; y < 3; y++)
            {
                if (grid[0, y] == grid[1, y] && grid[0, y] == op && grid[2, y] == 0)
                {
                    grid[2, y] = turn;
                    return true;
                }
                else if (grid[1, y] == grid[2, y] && grid[1, y] == op && grid[0, y] == 0)
                {
                    grid[0, y] = turn;
                    return true;
                }
                else if (grid[0, y] == grid[2, y] && grid[0, y] == op && grid[1, y] == 0)
                {
                    grid[1, y] = turn;
                    return true;
                }
            }

            //cross save
            if (grid[0, 0] == grid[1, 1] && grid[0, 0] == op && grid[2, 2] == 0)
            {
                grid[2, 2] = turn;
                return true;
            }
            else if (grid[0, 0] == grid[2, 2] && grid[0, 0] == op && grid[1, 1] == 0)
            {
                grid[1, 1] = turn;
                return true;
            }
            else if (grid[1, 1] == grid[2, 2] && grid[1, 1] == op && grid[0, 0] == 0)
            {
                grid[0, 0] = turn;
                return true;
            }

            //cross save 2nd
            if (grid[0, 2] == grid[1, 1] && grid[1, 1] == op && grid[2, 0] == 0)
            {
                grid[2, 0] = turn;
                return true;
            }
            else if (grid[2, 0] == grid[1, 1] && grid[1, 1] == op && grid[0, 2] == 0)
            {
                grid[0, 2] = turn;
                return true;
            }
            else if (grid[0, 2] == grid[2, 0] && grid[0, 2] == op && grid[1, 1] == 0)
            {
                grid[1, 1] = turn;
                return true;
            }

            return false;

        }
        public static bool randomPlay(int[,] grid, int turn)
        {
            //no save then random
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        grid[i, j] = turn;
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
