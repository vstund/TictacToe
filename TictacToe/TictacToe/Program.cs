using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe.");

            // TODO: Add payers names
            Player player1 = new Player("Player 1", 'X');
            Player player2 = new Player("Player 2", 'O');

            Board board = new Board();
            Turn turn = new Turn();

            int turns = 0;
            int maxTurns = 9;
            bool gameComplete = false;

            // Print starting board
            board.PrintBoard();

            while (turns < maxTurns && !gameComplete)
            {
                // TODO: exit if someone won faster

                Player player = turns % 2 == 0 ? player1 : player2;

                var input = turn.GetInput(player);
                board.SetFields(input, player);
                board.PrintBoard();

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
