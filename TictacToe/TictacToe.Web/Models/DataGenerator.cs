using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TictacToe;

namespace TictacToe.Web.Models
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                // Look for any board games already in database.
                if (context.BoardContext.Any())
                {
                    return;   // Database has been seeded
                }

                context.BoardContext.Add(new TictacToe.Board());

                context.SaveChanges();
            }
        }
    }
}