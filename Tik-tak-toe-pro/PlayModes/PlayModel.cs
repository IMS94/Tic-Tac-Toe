using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe_pro
{
    abstract class PlayModel
    {
        
        public int userMark { get; set; }
        public int pcMark { get; set; }

        public bool isStartedByPC { get; set; }

        protected int userTurn1X;
        protected int userTurn1Y;

        protected int userTurn2X;
        protected int userTurn2Y;

        protected int pcTurn1X;
        protected int pcTurn1Y;

        protected int pcTurn2X;
        protected int pcTurn2Y;

        protected int countUser = 0;
        protected int countPC = 0;

        protected int previousPCX=-1;
        protected int previousPCY=-1;
        public abstract void setStarted(bool b);
        public abstract void userPlay(int X, int Y, int[,] grid, int turn);
        public abstract string pcPlay(int[,] grid, int turn);

       
    }
}
