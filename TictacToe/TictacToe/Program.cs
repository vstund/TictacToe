using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            IPlayer player1 = menu.Player1;
            IPlayer player2 = menu.Player2;

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