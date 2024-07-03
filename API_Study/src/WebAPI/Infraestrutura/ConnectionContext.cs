using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Infraestrutura
{
    public class ConnectionContext : DbContext 
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=studies;" +
            "User Id=postgres;" + 
            "Password=8856223;");
    }
}
