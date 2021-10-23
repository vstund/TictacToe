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
            (bool isValid, int inputNum) validation = (false, -1); // Tuple type

            while (!validation.isValid)
            {
                var inputTxt = Console.ReadLine();
                validation = ValidateMove(inputTxt);

                if (validation.isValid) return validation.inputNum;
            }

            return validation.inputNum;
            
        }

        public void AskForInput()
        {
            Console.WriteLine($"{Name} choose your field! You are playing with '{Sign}'.");
        }

        private (bool isValid, int inputNum) ValidateMove(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Field can't be empty! Try again.");
                return (false, -1);
            }
            if (!int.TryParse(input, out int inputNum))
            { // note the exclamation mark, reverses condition
                Console.WriteLine("Please enter number in range from 1 to 9!");
                return (false, -1);
            }
            if (inputNum < 1 || inputNum > 9)
            {
                Console.WriteLine("Please enter number in range from 1 to 9!");
                return (false, -1);
            }

            return (true, inputNum);
        }
    }
}

