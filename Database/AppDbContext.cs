using Microsoft.EntityFrameworkCore;
using Dotnet.Models;
using dotnet_app_roberto.Models;
namespace Dotnet.Database;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=;User Id=sa;Password= ;TrustServerCertificate=True;");
    }
}
