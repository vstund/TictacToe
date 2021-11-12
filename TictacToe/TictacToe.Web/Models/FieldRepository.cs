using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TictacToe.Web.Models
{
    /**
     * Implementation class.
     * Retrieve and store data in db.
     */
    public class FieldRepository : IFieldRepository
    {
        private readonly ApiContext _context;

        public FieldRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<Field> GetField(int fieldId, int boardId)
        {
            //var result = await _context.Fields.FirstOrDefaultAsync(f => f.Id == fieldId);
            //await _context.SaveChangesAsync();

            //return result;

            return await _context.Fields
                .Include(f => f.Board)
                .FirstOrDefaultAsync(f => f.Id == fieldId);
        }

        public async Task<IEnumerable<Field>> GetFieldsByBoard(int boardId)
        {
            IQueryable<Field> query = _context.Fields;

            query = query.Where(f => f.BoardId.Equals(boardId));

            return await query.ToListAsync();
        }

        public async Task<Field> UpdateField(Field field)
        {
            var result = await _context.Fields.FirstOrDefaultAsync(f => f.Id == field.Id);
            

            if (result != null)
            {
                result.Sign = field.Sign;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
