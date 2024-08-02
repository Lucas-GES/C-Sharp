using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Model.CompanyAgregate;
using WebAPI.Domain.Model.EmployeeAgregate;

namespace WebAPI.Infraestrutura
{
    public class ConnectionContext : DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=studies;" +
            "User Id=postgres;" + 
            "Password=8856223;");
    }
}
