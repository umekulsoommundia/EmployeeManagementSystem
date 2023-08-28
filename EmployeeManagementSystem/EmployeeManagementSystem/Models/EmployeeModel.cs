using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? DOB { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Designation { get; set; }
        public string? Address { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryId { get; set; }
        public string? isActive { get; set; }

    }
}
