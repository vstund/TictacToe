using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TictacToe.Web.Models
{
    public class Field
    {
        public int Id { get; set; }
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
        public char Sign { get; set; }

        public int BoardId { get; set; } // one to many relationship
        public Board Board { get; set; }
    }
}