using Microsoft.EntityFrameworkCore;
using MoviApiDomein.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviApi.Persistance.Context
{
   public class MovieContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AGAFARD;İnitial Catalog=ApiMovieDb;Trusted_Connection=True;integrated Security=true");
        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review>Reviews { get; set; }
        public DbSet<Tag>Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
