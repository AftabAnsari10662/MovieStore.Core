using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieStore.Core.Data
{
    public class MovieStoreContext : DbContext
    {
        public MovieStoreContext(
            DbContextOptions<MovieStoreContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int RelaseYear { get; set; }
    }

}
