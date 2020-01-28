using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controller
{
    //[Route("api/[controller]")]
    //[ApiController]    
    /// <summary>
    /// Employee Controller Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class EmployeeController : ControllerBase
    {
        IManager manager = new ManagerImpl();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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