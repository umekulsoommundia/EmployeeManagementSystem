using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? Deadline { get; set; }
        public int? EmployeeId { get; set; }
        public string? status { get; set; }
    }
}
