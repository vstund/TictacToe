using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    class Turn
    {
        public void MakeTurn() {
            Console.WriteLine("Player 1 choose your field!");

            try
            {
                string inputText = Console.ReadLine();
                int playerInput = int.Parse(inputText);

                if (playerInput < 1 || playerInput > 9)
                {
                    throw new ArgumentException("Number is not in allowed range");
                };

                Console.WriteLine($"Player entered: {playerInput}");
            }
            catch
            {
                Console.WriteLine("Please enter number in range from 1 to 9!");
            }
        }
    }
}
