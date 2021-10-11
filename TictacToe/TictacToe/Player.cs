using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Signs
{
    X = 'X',
    O = 'O',
}

namespace TictacToe
{
    class Player
    {
        // This is constructor
        public Player(string name, Signs sign)
        {
            Name = name;
            Sign = sign;
        }

        public string Name { get; set; }
        public Signs Sign { get; set; }
    }
}

