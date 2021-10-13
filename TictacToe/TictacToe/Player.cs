using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TictacToe
{
    class Player
    {
        // This is constructor
        public Player(string name, char sign)
        {
            Name = name;
            Sign = sign;
        }

        public string Name { get; set; }
        public char Sign { get; set; }
    }
}

