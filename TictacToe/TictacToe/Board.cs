using System;

namespace TictacToe
{
    class Board
    {
        private char[,] Fields { get; set; }

        // This is constructor
        public Board() 
        {
            Fields = GetStartingFields();
        }

        private char[,] GetStartingFields()
        {
            return new char[,] {
                    { '1', '2', '3' },
                    { '4', '5', '6' },
                    { '7', '8', '9' }
                };
        }

        public void SetFields(int fieldNumber, Player player)
        {
            var playerSign = (char)player.Sign;

            switch (fieldNumber) 
            {
                case 1: Fields[0, 0] = playerSign; break;
                case 2: Fields[0, 1] = playerSign; break;
                case 3: Fields[0, 2] = playerSign; break;
                case 4: Fields[1, 0] = playerSign; break;
                case 5: Fields[1, 1] = playerSign; break;
                case 6: Fields[1, 2] = playerSign; break;
                case 7: Fields[2, 0] = playerSign; break;
                case 8: Fields[2, 1] = playerSign; break;
                case 9: Fields[2, 2] = playerSign; break;
            }
        }

        public void PrintBoard() {
            Console.WriteLine();
            Console.WriteLine(" {0} | {1} | {2} ", Fields[0,0], Fields[0,1], Fields[0,2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Fields[1, 0], Fields[1, 1], Fields[1, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Fields[2, 0], Fields[2, 1], Fields[2, 2]);
            Console.WriteLine();
        }
    }
}
