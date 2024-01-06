using Microsoft.AspNetCore.Mvc;
using TechcareerDotnetBootcamp.Models;

namespace TechcareerDotnetBootcamp.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly TechCareerDbContext _dbContext;

        public EmployeeController(TechCareerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/employee
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            var employees = _dbContext.Employees.ToList();
            return employees;
        }

        // GET: api/employee/5
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            return Ok(employee);
        }

        // POST: api/employee
        [HttpPost]
        public void CreateEmployee([FromBody] Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        // // PUT api/employee/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] Employee employee)
        // {
        //     using var context = new TechCareerDbContext();
        //     var employeeToUpdate = context.Employees.Find(id);
        //     employeeToUpdate.FirstName = employee.FirstName;
        //     employeeToUpdate.LastName = employee.LastName;
        //     employeeToUpdate.Address = employee.Address;
        //     employeeToUpdate.BirthDate = employee.BirthDate;
        //     employeeToUpdate.City = employee.City;
        //     employeeToUpdate.AddDate = employee.AddDate;
        //     context.SaveChanges();
        // }

        // // DELETE api/employee/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        //     using var context = new TechCareerDbContext();
        //     var employeeToDelete = context.Employees.Find(id);
        //     context.Employees.Remove(employeeToDelete);
        //     context.SaveChanges();
        // }
    }
}
