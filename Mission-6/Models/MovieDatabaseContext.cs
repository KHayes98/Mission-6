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

        public DbSet<MovieForm> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(

                    new MovieForm
                    {
                        MovieID = 1,
                        category = "Action/Adventure",
                        title = "Star Trek (2009)",
                        year = 2009,
                        director = "J.J. Abrams",
                        rating = "PG-13",
                        edited = false,
                        lentTo = "",
                        notes = ""
                    },
                    new MovieForm
                    {
                        MovieID = 2,
                        category = "Action/Adventure",
                        title = "Star Wars: Revenge of the Sith",
                        year = 2005,
                        director = "George Lucus",
                        rating = "PG-13",
                        edited = false,
                        lentTo = "",
                        notes = ""
                    },
                    new MovieForm
                    {
                        MovieID = 3,
                        category = "Action/Adventure",
                        title = "Captain America: The Winter Soldier",
                        year = 2014,
                        director = "Joe & Anthony Russo",
                        rating = "PG-13",
                        edited = false,
                        lentTo = "",
                        notes = ""
                    }
                );
        }
    }
}