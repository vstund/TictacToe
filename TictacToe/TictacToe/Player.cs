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
        public Player(string name, Signs sign)
        {
            Name = name;
            Sign = sign;
        }

        public string Name { get; set; }
        public Signs Sign { get; set; }

        public int MakeAMove()
        {
            Console.WriteLine($"{Name} choose your field! You are playing with '{Sign}'.");

            int input = -1;
            var isValid = false;

            while (!isValid)
            {
                var inputTxt = Console.ReadLine();
                isValid = ValidateMove(inputTxt);

                if (isValid) input = Convert.ToInt32(inputTxt);
            }

            return input;
            
        }

        private bool ValidateMove(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Field can't be empty! Try again.");
                return false;
            }
            if (!int.TryParse(input, out int result))
            { // note the exclamation mark, reverses condition
                Console.WriteLine("Please enter number in range from 1 to 9!");
                return false;
            }

            return true;
        }
    }
}

