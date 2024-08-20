using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorLibrary.Models;

namespace RazorMovies.Data
{
    public class RazorMoviesContext : DbContext
    {
        public RazorMoviesContext (DbContextOptions<RazorMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorLibrary.Models.Movie> Movie { get; set; } = default!;
    }
}
