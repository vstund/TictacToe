using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    class Turn
    {
        int input;
        string inputTxt;

        public int GetInput(Player player)
        {
            

            input = 0;

            while (input == 0)
            {
                inputTxt = Console.ReadLine();

                switch (inputTxt)
                {
                    case "1": input = 1; break;
                    case "2": input = 2; break;
                    case "3": input = 3; break;
                    case "4": input = 4; break;
                    case "5": input = 5; break;
                    case "6": input = 6; break;
                    case "7": input = 7; break;
                    case "8": input = 8; break;
                    case "9": input = 9; break;
                    default:
                        Console.WriteLine("Validate input must be number in range 1-9."); break;
                }
            }

            //input = Convert.ToInt32(Console.ReadLine());

            // TODO: validate input must be number in range 1-9
            // Console.WriteLine("Please enter number in range from 1 to 9!");

            // TODO: validate already filled fields

            return input;
        }
        public void AskForInput(Player player)
        {
            Console.WriteLine($"{player.Name} choose your field! You are playing with '{player.Sign}'.");
        }
    }
}