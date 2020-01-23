//-----------------------------------------------------------------------
// <copyright file="IEmployeeDAL.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for EmployeeDAL
    /// </summary>
    public interface IEmployeeDAL
    {
        /// <summary>
        /// Selects all employees.
        /// </summary>
        /// <returns>It returns List of Employee</returns>
        List<Employee> SelectAllEmployees();
    }
}