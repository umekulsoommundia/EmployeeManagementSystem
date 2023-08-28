using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class DepartmentModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
