using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    class Human 
    {
        public int user1Mark { set; get; }
        public int user2Mark { set; get; }
        public Human(int user1MarkE, int user2MarkE) { user1Mark = user1MarkE; user2Mark = user2MarkE; }
        public void userPlay(int X, int Y, int[,] grid, int turn) 
        {
            if (grid[X, Y] == 0)
            {
                grid[X, Y] = turn;
            }
        }
    
    }
}
