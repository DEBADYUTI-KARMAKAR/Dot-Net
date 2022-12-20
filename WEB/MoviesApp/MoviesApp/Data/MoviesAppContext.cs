using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public class MoviesAppContext : DbContext
    {
        public MoviesAppContext (DbContextOptions<MoviesAppContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesApp.Models.Movie> Movie { get; set; } = default!;
    }
}
