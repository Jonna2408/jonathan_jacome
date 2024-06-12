using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions<PruebaContext> options) : base(options) 
        {
        
        }

        public DbSet<Tareas> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>().ToTable("Tareas");
        }
    }
}
