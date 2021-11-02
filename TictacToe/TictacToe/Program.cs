using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.InitiateGame();

            IPlayer player1 = menu.Player1;
            IPlayer player2 = menu.Player2;

            Board board = new Board();

            int turns = 0;
            int maxTurns = 9;
            bool gameComplete = false;

            // Print starting board
            board.PrintBoard();

            while (turns < maxTurns && !gameComplete)
            {
                IPlayer player = turns % 2 == 0 ? player1 : player2;
                
                bool isEmpty = true;

                do
                {
                    int chosenField = player.MakeAMove(board.Fields);
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