using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TictacToe.Web.Models
{
    public interface IFieldRepository
    {
        Task<IEnumerable<Field>> GetFieldsByBoard(int boardId);
        Task<Field> GetField(int id, int boardId);
        Task<Field> UpdateField(Field field);
    }
}
