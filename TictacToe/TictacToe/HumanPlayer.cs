using System;



namespace TictacToe
{
    public class HumanPlayer : IPlayer
    {
        // This is constructor
        public HumanPlayer(string name, Signs sign)
        {
            Name = name;
            Sign = sign;
        }

        public override string Name { get; set; }
        public override Signs Sign { get; set; }

        public override int MakeAMove(char[,] board)
        {
            Console.WriteLine($"{Name} choose your field! You are playing with '{Sign}'.");

            var move = ThinkAMove(board);
            return move;
        }

        public override int ThinkAMove(char[,] board)
        {
            var inputTxt = Console.ReadLine();
            int userNumber;

            try
            {
                userNumber = int.Parse(inputTxt);

                if (userNumber > 9 || userNumber < 1)
                {
                    throw new NumberGreaterOrEqualToOneAndLessOrEqualNine("Please enter number in range from 1 to 9!");
                }
            }
            catch (NumberGreaterOrEqualToOneAndLessOrEqualNine error)
            {
                Console.WriteLine($"{error.Message}");
                userNumber = ThinkAMove(board);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Allowed only numbers. Try again!");
                userNumber = ThinkAMove(board);
            }
            return userNumber;
        }
    }
}

