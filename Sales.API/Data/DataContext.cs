using Microsoft.EntityFrameworkCore;
using Sales.Shared.Entities;

namespace Sales.API.Data
{
    // DataContext hereda de la clase Dbcontext
    public class DataContext : DbContext
    {

        // ctor para conectar a la BD
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        // propiedad para mapear tablas
        public DbSet<Country> countries { get; set; }

        // validacion para duplicados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }
    }
}