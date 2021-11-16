using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TictacToe.Web.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<TictacToe.Web.Models.Board> Boards { get; set; }
        public DbSet<TictacToe.Web.Models.Field> Fields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            // Seed Board table
            modelBuilder.Entity<Board>().HasData(
                new Board { BoardId = 1 }
            );

            // Seed Field table
            modelBuilder.Entity<Field>().HasData(
               new Field { 
                   Id = 1, 
                   Xcoordinate = 0, 
                   Ycoordinate = 0, 
                   Sign = ' ',  
                   BoardId = 1 
               }
           );

            modelBuilder.Entity<Field>().HasData(
                new Field
                {
                    Id = 2,
                    Xcoordinate = 0,
                    Ycoordinate = 1,
                    Sign = ' ',
                    BoardId = 1
                }
            );

            modelBuilder.Entity<Field>().HasData(
               new Field
               {
                   Id = 3,
                   Xcoordinate = 0,
                   Ycoordinate = 2,
                   Sign = ' ',
                   BoardId = 1
               }
            );

            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 4,
                  Xcoordinate = 1,
                  Ycoordinate = 0,
                  Sign = ' ',
                  BoardId = 1
              }
            );

            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 5,
                  Xcoordinate = 1,
                  Ycoordinate = 1,
                  Sign = ' ',
                  BoardId = 1
              }
            );

            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 6,
                  Xcoordinate = 1,
                  Ycoordinate = 2,
                  Sign = ' ',
                  BoardId = 1
              }
            );

            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 7,
                  Xcoordinate = 2,
                  Ycoordinate = 0,
                  Sign = ' ',
                  BoardId = 1
              }
            );

            modelBuilder.Entity<Field>().HasData(
              new Field
              {
                  Id = 8,
                  Xcoordinate = 2,
                  Ycoordinate = 1,
                  Sign = ' ',
                  BoardId = 1
              }
            );

            modelBuilder.Entity<Field>().HasData(
             new Field
             {
                 Id = 9,
                 Xcoordinate = 2,
                 Ycoordinate = 2,
                 Sign = ' ',
                 BoardId = 1
             }
           );
        }

        
    }
}
