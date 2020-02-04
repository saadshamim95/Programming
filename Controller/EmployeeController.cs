//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Controller
{
    using System;
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Model;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Employee Controller Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        private readonly IManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns Action result</returns>
        [HttpPost]
        [Route("Add")]
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
        /// <returns>It returns Action result</returns>
        [HttpPut]
        [Route("Update")]
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
        /// <param name="email">The email.</param>
        /// <returns>It returns Action result</returns>
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteEmployee(string email)
        {
            var result = this.manager.DeleteEmployee(email);
            if (result)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest("Error Occurred while deleting!!!");
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns Action result</returns>
        [HttpGet]
        [Route("Show")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var result = this.manager.GetAllEmployees();
                return this.Ok(result);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns Action result</returns>
        [HttpPost]
        [Route("Login")]
        public IActionResult EmployeeLogin([FromBody] Employee employee)
        {
            var result = this.manager.EmployeeLogin(employee);
            if (result)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest("Login Error!!!");
            }
        }
    }
}