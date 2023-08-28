using EmployeeManagementSystem.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


namespace EmployeeManagementSystem.Models
{
    public class EmployeeDBContext:DbContext
    {

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }
        public DbSet<EmployeeModel> Employees { get; set; }

   }
}
