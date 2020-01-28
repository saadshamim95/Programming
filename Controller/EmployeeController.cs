using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controller
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController : ControllerBase
    {
        IManager manager = new ManagerImpl();

        [HttpPost]
        [Route("api/Add")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {          
            var result = this.manager.AddEmployee(employee);
            if (result)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest("Error Occurred while adding!!!");
            }
        }

        [HttpPut]
        [Route("api/Update")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            var result = this.manager.UpdateEmployee(employee);
            if (result)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest("Error Occurred while updating!!!");
            }
        }

        [HttpDelete]
        [Route("api/Delete")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = this.manager.DeleteEmployee(id);
            if (result)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest("Error Occurred while deleting!!!");
            }
        }
    }
}