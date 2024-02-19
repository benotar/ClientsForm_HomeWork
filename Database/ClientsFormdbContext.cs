using Microsoft.EntityFrameworkCore; 
using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Database;

public class ClientsFormdbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;

    public ClientsFormdbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=127.0.0.1;user=root;database=ClientsFormdb", ServerVersion.Parse("8.0.30-mysql"));
    }
}
