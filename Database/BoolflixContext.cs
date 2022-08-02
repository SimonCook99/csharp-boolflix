using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Database{
    public class BoolflixContext : DbContext{

        public DbSet<ContenutoVideo> Videos {get; set;}
        public DbSet<Film> Films {get; set;}
        public DbSet<Genere> Genres {get; set;}
        public DbSet<PlayList> Playlists {get; set;}
        public DbSet<Profilo> Users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix;Integrated Security=True");
        }

    }
}
