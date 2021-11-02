using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    public interface IPlayer
    {

        public string Name { get; set; }
        public Signs Sign { get; set; }

        int MakeAMove(char[,] board);
        int ThinkAMove(char[,] board);
    }
}
