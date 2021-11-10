using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TictacToe.Web.Models
{
    /**
     * Not used for now. But could be single source of truth in future.
     */
    public class Board
    {
       
        public int Id { get; set; }
        [NotMapped]
        public char[,] Fields { get; set; }
    }
}
