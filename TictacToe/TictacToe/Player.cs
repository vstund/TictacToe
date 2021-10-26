using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TictacToe
{
    public class Player
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
            var input = -1;
            bool isValid = false;

            while (!isValid)
            {
                var inputTxt = Console.ReadLine();
                isValid = ValidateMove(inputTxt, out int inputNum);

                if (isValid) input = inputNum;
            }

            return input;
            
        }

        public void AskForInput()
        {
            Console.WriteLine($"{Name} choose your field! You are playing with '{Sign}'.");
        }

        private bool ValidateMove(string input, out int inputNum)
        {
            inputNum = -1;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Field can't be empty! Try again.");
                return false;
            }
            if (!int.TryParse(input, out inputNum))
            { // note the exclamation mark, reverses condition
                Console.WriteLine("Please enter number in range from 1 to 9!");
                return false;
            }
            if (inputNum < 1 || inputNum > 9)
            {
                Console.WriteLine("Please enter number in range from 1 to 9!");
                return false;
            }

            return true;
        }
    }
}

