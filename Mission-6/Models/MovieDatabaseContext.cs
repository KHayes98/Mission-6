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

        public DbSet<movieForm> responses { get; set; }

    }
}