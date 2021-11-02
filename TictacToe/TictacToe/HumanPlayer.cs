using System;



namespace TictacToe
{
    public class HumanPlayer: IPlayer
    {
        // This is constructor
        public HumanPlayer(string name, Signs sign)
        {
            Name = name;
            Sign = sign;
        }

        public string Name { get; set; }
        public Signs Sign { get; set; }

        public int MakeAMove(char[,] board)
        {
            Console.WriteLine($"{Name} choose your field! You are playing with '{Sign}'.");

            var move = ThinkAMove(board);
            return move;
        }

        public int ThinkAMove(char[,] board)
        {
            int input = -1;
            var isValid = false;

            while (!isValid)
            {
                var inputTxt = Console.ReadLine();
                isValid = ValidateInput(inputTxt, out int inputNum);

                if (isValid) input = inputNum;
            }

            return input;

        }

        private bool ValidateInput(string input, out int inputNum)
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

