using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    public abstract class IPlayer
    {
        public abstract string Name { get; set; }
        public abstract Signs Sign { get; set; }

        public abstract int MakeAMove(char[,] board);
        public abstract int ThinkAMove(char[,] board);
    }
}
