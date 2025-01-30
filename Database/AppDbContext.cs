using Microsoft.EntityFrameworkCore;
using Dotnet.Models;

namespace Dotnet.Database;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=appdb;User Id=sa;Password=123456;");
    }
}
