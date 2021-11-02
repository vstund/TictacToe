using System;

namespace TictacToe
{
    class ComputerPlayer: IPlayer
    {

        public ComputerPlayer(Signs sign)
        {
            Name = "Computer Charlie";
            Sign = sign;
        }

        public string Name { get; set; }
        public Signs Sign { get; set; }

        public int MakeAMove(char[,] board)
        {
            var move = ThinkAMove(board);
            Console.WriteLine($"{Name} choose field #{move}!");

            return move;
        }

        public int ThinkAMove(char[,] board)
        {
            var chosenField = new Random().Next(1, 9);
            return chosenField;
        }
    }
}
