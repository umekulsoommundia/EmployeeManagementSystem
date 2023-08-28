using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeDBContextFactory : IDesignTimeDbContextFactory<EmployeeDBContext>
    {
        public EmployeeDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<EmployeeDBContext>();
            builder.UseSqlServer(configuration.GetConnectionString("constring"));
            return new EmployeeDBContext(builder.Options);
        }
    }
}
