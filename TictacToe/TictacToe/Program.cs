﻿using System;

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
            Turn turn = new Turn();

            int turns = 0;
            int maxTurns = 9;
            bool gameComplete = false;
            bool isEmpty = true;

            // Print starting board
            board.PrintBoard();

            while (turns < maxTurns && !gameComplete)
            {
                Player player = turns % 2 == 0 ? player1 : player2;

                while (isEmpty)
                {
                    var input = turn.GetInput(player);

                    isEmpty = board.IsEmptyFieldChecker(input);

                    if (isEmpty)
                    {
                        board.SetFields(input, player);
                        isEmpty = false;
                    }
                    else
                    {
                        Console.WriteLine($"{input} is alredy used.");
                        turns--;
                    }
                }

                board.PrintBoard();
                turns++;
                isEmpty = true;

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