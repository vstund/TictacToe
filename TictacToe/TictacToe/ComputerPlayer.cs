using System;

namespace TictacToe
{
    class ComputerPlayer: IPlayer
    {

        public ComputerPlayer(Signs sign)
        {
            string[] computerPlayerName = new string[10] {"Charlie","Anna","Dzidra","Elizabeth","Leon","John","Vladimir","Aleksandr","Aigars","Teo" };
            Name = computerPlayerName[new Random().Next(0, computerPlayerName.Length-1)];
            Sign = sign;
        }

        public override string Name { get; set; }
        public override Signs Sign { get; set; }

        public override int MakeAMove(char[,] board)
        {
            var move = ThinkAMove(board);
            Console.WriteLine($"{Name} choose field #{move}!");

            return move;
        }

        public override int ThinkAMove(char[,] board)
        {
            var chosenField = new Random().Next(1, 9);
            return chosenField;
        }
    }
}
