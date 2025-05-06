using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using AppTeste.Models; // Caso Veiculo esteja neste namespace


namespace AppTeste.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
