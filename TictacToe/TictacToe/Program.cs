using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe.");

            Player player1 = new Player("Player 1", Signs.O);
            Player player2 = new Player("Player 2", Signs.X);

            Board board = new Board();
            Turn turn = new Turn();
            
            int turns = 0;
            int maxTurns = 9;

            // Print starting board
            board.PrintBoard(); 

            while (turns <= maxTurns) {
                // TODO: exit if someone won faster
                // var hasWinner = gameCompleteChecker(board.Fields)
                // if (hasWinner) break; // un say who won

                Player player = turns % 2 == 0 ? player1 : player2;

                var input = turn.GetInput(player);
                board.SetFields(input, player);
                board.PrintBoard();

                turns++;
            };

            // TODO: winner message

        }
    }
}
