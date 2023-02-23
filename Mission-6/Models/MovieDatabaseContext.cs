using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6.Models
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext (DbContextOptions<MovieDatabaseContext> options) : base (options)
        {

        }

        public DbSet<MovieForm> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName="Action/Adventure"},
                    new Category { CategoryID = 2, CategoryName="Comedy"},
                    new Category { CategoryID = 3, CategoryName = "Drama" },
                    new Category { CategoryID = 4, CategoryName = "Family" },
                    new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                    new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                    new Category { CategoryID = 7, CategoryName = "Television" },
                    new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<MovieForm>().HasData(

                    new MovieForm
                    {
                        MovieID = 1,
                        CategoryID = 1,
                        Title = "Star Trek (2009)",
                        Year = 2009,
                        Director = "J.J. Abrams",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },
                    new MovieForm
                    {
                        MovieID = 2,
                        CategoryID = 1,
                        Title = "Star Wars: Revenge of the Sith",
                        Year = 2005,
                        Director = "George Lucus",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },
                    new MovieForm
                    {
                        MovieID = 3,
                        CategoryID = 1,
                        Title = "Captain America: The Winter Soldier",
                        Year = 2014,
                        Director = "Joe & Anthony Russo",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    }
                );
        }
    }
}