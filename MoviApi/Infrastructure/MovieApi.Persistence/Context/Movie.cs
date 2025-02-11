using Microsoft.EntityFrameworkCore;
using MoviApiDomein.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class Movie:DbContext
    {  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=AGAFARD;initial Catalog=ApiMovieDb ;integrated Security=true;Trusted_Connection=True;");
        }
        public DbSet<Category> categories{ get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }  

    }
}
