using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _dbContext;
        public EmployeeController(EmployeeDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var Employees = _dbContext.Employees.ToList();
            return View(Employees);
        }
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeModel emp)
        {
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
