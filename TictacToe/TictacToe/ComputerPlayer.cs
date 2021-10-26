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
             return new Random().Next(1,9);
        }

        public void AskForInput()
        {
            // TODO: maybe inside MakeAMove() ?
            Console.WriteLine($"{Name} choosing field! {Name} is playing with '{Sign}'.");
        }
    }
}
