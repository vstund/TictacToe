using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe.");

            Board board = new Board();
            Turn turn = new Turn();
            
            int turns = 0;
            int maxTurns = 9;

            // Print starting board
            board.PrintBoard(); 

            while (turns <= maxTurns) {
                // TODO: exit if someone won faster

                var input = turn.GetInput();
                board.SetFields(input, 'O');
                board.PrintBoard();

                turns++;
            };

        }
    }
}
