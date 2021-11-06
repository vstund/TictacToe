using System;

namespace TictacToe
{
    class ComputerPlayer: IPlayer
    {

        public ComputerPlayer(Signs sign)
        {
            string[] computerPlayerName = new string[10] {"Charlie","Anna","Dzidra","Elizabeth","Leon","John","Vladimir","Aleksandr","Aigars","Teo" };
            Name = computerPlayerName[new Random().Next(0, 9)];
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
