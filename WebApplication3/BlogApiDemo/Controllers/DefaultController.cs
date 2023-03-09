using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c =new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c =new Context();
            var employees = c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id )
        {
            using var c = new Context();
            var employees = c.Employees.Find(id);
            if (employees==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employees);

            }
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var employees = c.Employees.Find(id);
            if (employees == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employees);
                c.SaveChanges();
                return Ok();

            }
        }
        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var c = new Context();
            var employees = c.Find<Employee>(employee.ID);
            if (employees == null)
            {
                return NotFound();
            }
            else
            {
                employees.Name= employee.Name;
                c.Update(employees);
                c.SaveChanges();
                return Ok();

            }
        }
    }
}
