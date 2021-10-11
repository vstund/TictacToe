using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    class Turn
    {
        public int GetInput()
        {
            Console.WriteLine("Player 1 choose your field!");
            int input = Convert.ToInt32(Console.ReadLine());

            // TODO: validate input must be number in range 1-9
            // Console.WriteLine("Please enter number in range from 1 to 9!");

            // TODO: validate already filled fields

            return input;
        }
    }
}
