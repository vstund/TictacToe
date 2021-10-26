using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    class Menu
    {
        public Menu()
        {
            InitiateGame();
        }
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }

        public void InitiateGame()
        {
            //Console.Clear();
            Console.WriteLine("Let's play Tic Tac Toe.");
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Human vs Human");
            Console.WriteLine("2) Human vs Computer");
            Console.WriteLine("3) Computer vs Computer");
            // TODO: validate input
            Console.Write("\r\nSelect an option: ");

            // TODO: output who is playing with whom
            // TODO: computer names

            switch (Console.ReadLine())
            {
                case "1":
                    Player1 = SetHumanPlayer();
                    Player2 = SetHumanPlayer();
                    break;
                case "2":
                    Player1 = SetHumanPlayer();
                    Player2 = SetComputerPlayer();
                    break;
                case "3":
                    Player1 = SetComputerPlayer();
                    Player2 = SetComputerPlayer();
                    break;
                default:
                    return;
            }
        }

        private IPlayer SetHumanPlayer() {
            // TODO: custom message for each scenario
            // Player 1 name? Player 2 name?
            // Your name?
            Console.WriteLine("Enter the name of the first player:");
            string player1Input = Console.ReadLine();

            return new HumanPlayer(player1Input, Signs.X);
        }
        private IPlayer SetComputerPlayer()
        {
            return new ComputerPlayer(Signs.O);
        }
    }
}
