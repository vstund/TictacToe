using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe.");
            Console.WriteLine("Enter the name of the first player:");
            string player1Input = Console.ReadLine();
            Console.WriteLine("Enter the second player's name:");
            string player2Input = Console.ReadLine();

            // TODO: choice human vs human, pc vs human, pc vs pc
            IPlayer player1 = new HumanPlayer(player1Input, Signs.X);
            // IPlayer player2 = new HumanPlayer(player2Input, Signs.O);
            IPlayer player2 = new ComputerPlayer(Signs.O);

            Board board = new Board();

            int turns = 0;
            int maxTurns = 9;
            bool gameComplete = false;
            board.isEmpty = true;

            // Print starting board
            board.PrintBoard();

            while (turns < maxTurns && !gameComplete)
            {
                IPlayer player = turns % 2 == 0 ? player1 : player2;

                player.AskForInput();
               
                while (board.isEmpty)
                {
                    int chosenField = player.MakeAMove();

                    board.isEmpty = board.IsEmptyFieldChecker(chosenField);

                    if (board.isEmpty)
                    {
                        board.SetFields(chosenField, player);
                        board.PrintBoard();
                        board.isEmpty = false;
                    }
                    else
                    {
                        Console.WriteLine($"{chosenField} is alredy used.");
                        turns--;
                    }
                }

                turns++;
                board.isEmpty = true; 

                gameComplete = board.GameCompleteChecker();

                if (gameComplete)
                {
                    Console.WriteLine($"Player {player.Name} has won");
                }
                else
                      if (turns == maxTurns)
                {
                    Console.WriteLine("Draw");
                }
            }
        }
    }
}