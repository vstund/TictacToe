using System;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe.");
            
            // TODO: Add payers names
            Player player1 = new Player("Player 1", Signs.O);
            Player player2 = new Player("Player 2", Signs.X);

            Board board = new Board();
            Turn turn = new Turn();
            
            int turns = 0;
            int maxTurns = 9;

            // Print starting board
            board.PrintBoard();

            bool gameComplete = false;
            
            while (turns <= maxTurns && !gameComplete) {
                // TODO: exit if someone won faster

                Player player = turns % 2 == 0 ? player1 : player2;

                var input = turn.GetInput(player);
                board.SetFields(input, player);
                board.PrintBoard();

                turns++;

               gameComplete = board.GameCompleteChecker();
                //undecided = undecidedChecker(firstLine, secondLine, thirdLine);

                if (gameComplete)
                {
                    Console.WriteLine($"Spēle beigusies, {player.Name} uzvarēja!");
                }
                if(turns == maxTurns)
                {
                    Console.WriteLine("Spēle beigusies ar neizšķirtu");
                }
              //  if (undecided)
              //  {
              //      Console.WriteLine();
              //      Console.WriteLine("Spēle beigusies ar neizšķirtu!");
              //  }




            };

        }
    }
}
