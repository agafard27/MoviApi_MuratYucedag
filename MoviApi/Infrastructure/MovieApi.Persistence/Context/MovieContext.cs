using Microsoft.EntityFrameworkCore;
using MoviApiDomein.Entities;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { } // ✅ Constructor eklendi!

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)  // ❗ Sadece eğer yapılandırılmamışsa çalıştır.
            {
                optionsBuilder.UseSqlServer("Server=AGAFARD;Database=ApiMovieDb;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        public DbSet<Movie> Movies { get; set; }  // ✅ Hatalı olan DbSet<MovieContext> yerine düzeltildi!
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
