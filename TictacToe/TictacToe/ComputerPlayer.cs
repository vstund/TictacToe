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

        public int MakeAMove()
        {
            var chosenField = new Random().Next(1, 9);
            Console.WriteLine($"{Name} choose field #{chosenField}!");

            return chosenField;
        }
    }
}
