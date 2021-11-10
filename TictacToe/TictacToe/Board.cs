using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TictacToe
{
    public class Board
    {
        public int Id { get; set; }
        [NotMapped]
        public char[,] Fields { get; set; }

        // This is constructor
        public Board()
        {
            Fields = SetStartingFields();
        }
        //For tests
        public Board(char[,] testBord)
        {
            Fields = testBord;
        }

        private char[,] SetStartingFields()
        {
            return new char[,] {
                    { '1', '2', '3' },
                    { '4', '5', '6' },
                    { '7', '8', '9' }
                };
        }

        
        public void SetFields(int fieldNumber, IPlayer player)
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

        public void PrintBoard()
        {
            Console.WriteLine();
            Console.WriteLine(" {0} | {1} | {2} ", Fields[0, 0], Fields[0, 1], Fields[0, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Fields[1, 0], Fields[1, 1], Fields[1, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", Fields[2, 0], Fields[2, 1], Fields[2, 2]);
            Console.WriteLine();
        }

        public bool GameCompleteChecker()
        {
            if (Fields[0,0] == Fields[0, 1] && Fields[0,0] == Fields[0, 2])
            {
                return true;
            }
            else if (Fields[1, 0] == Fields[1, 1] && Fields[1, 0] == Fields[1, 2])
            {
                return true;
            }
            else if (Fields[2, 0] == Fields[2, 1] && Fields[2, 0] == Fields[2, 2])
            {
                return true;
            }
            else if (Fields[0, 0] == Fields[1, 1] && Fields[0, 0] == Fields[2, 2])
            {
                return true;
            }
            else if (Fields[0, 0] == Fields[1, 0] && Fields[0, 0] == Fields[2, 0])
            {
                return true;
            }
            else if (Fields[2, 0] == Fields[1, 1] && Fields[2, 0] == Fields[0, 2])
            {
                return true;
            }
            else if (Fields[0, 2] == Fields[1, 2] && Fields[0, 2] == Fields[2, 2])
            {
                return true;
            }
            else if (Fields[0, 1] == Fields[1, 1] && Fields[0, 1] == Fields[2, 1])
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if target field is empty or not.
        /// 
        /// </summary>
        public bool IsEmptyFieldChecker(int fieldNumber)
        {

            var rowLength = Fields.GetLength(0);
            var columnLength = Fields.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {              
                    var boardFieldNum = (int)(Fields[i, j] - '0'); // some dark magic for type conversion, convert char to int
                    if (boardFieldNum == fieldNumber)
                    {
                        return true;
                    }
                }
            }

            Console.WriteLine($"Field {fieldNumber} is already used. Try again.");

            return false;
        }
    }
}
