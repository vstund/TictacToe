using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    public class NumberGreaterOrEqualToOneAndLessOrEqualNine : Exception
    {
        public NumberGreaterOrEqualToOneAndLessOrEqualNine()
        {

        }
        public NumberGreaterOrEqualToOneAndLessOrEqualNine(string message) : base(message)
        {

        }

        public NumberGreaterOrEqualToOneAndLessOrEqualNine(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
