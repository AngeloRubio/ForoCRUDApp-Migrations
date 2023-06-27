using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Models {
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=tallerBackendRubioMero;User Id=sa;Password=clave;");
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
