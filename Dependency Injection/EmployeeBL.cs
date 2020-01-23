//-----------------------------------------------------------------------
// <copyright file="EmployeeBL.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Employee BL class
    /// </summary>
    public class EmployeeBL
    {
        /// <summary>
        /// The employee dal
        /// </summary>
        private IEmployeeDAL employeeDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBL"/> class.
        /// </summary>
        /// <param name="employeeDAL">The employee dal.</param>
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns List of Employees</returns>
        public List<Employee> GetAllEmployees()
        {
            return this.employeeDAL.SelectAllEmployees();
        }
    }
}