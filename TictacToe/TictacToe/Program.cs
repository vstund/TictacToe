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

            Player player1 = new Player(player1Input, Signs.X);
            Player player2 = new Player(player2Input, Signs.O);

            Board board = new Board();

            int turns = 0;
            int maxTurns = 9;
            bool gameComplete = false;

            // Print starting board
            board.PrintBoard();

            while (turns < maxTurns && !gameComplete)
            {
                Player player = turns % 2 == 0 ? player1 : player2;

                player.AskForInput();
                bool isEmpty = true;

                do
                {
                    int chosenField = player.MakeAMove();
                    isEmpty = board.IsEmptyFieldChecker(chosenField);

                    if (isEmpty)
                    {
                        board.SetFields(chosenField, player);
                        board.PrintBoard();
                        break;
                    }

                } while (!isEmpty);

                turns++;

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