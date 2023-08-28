using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class SalaryModel
    {

        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? Amount { get; set; }
        public int? PaymentDate { get; set; }

    }
}
