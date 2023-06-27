using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Models {
    public class ApplicationDbContext : DbContext
    {
        private DbSet<Usuario> usuarios;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=tallerBackendRubioMero;User Id=sa;Password=angelo;");
            }
        }

        public DbSet<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
    }
}
