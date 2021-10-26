using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    interface IPlayer
    {

        public string Name { get; set; }
        public Signs Sign { get; set; }

        void AskForInput();
        int MakeAMove();
    }
}
