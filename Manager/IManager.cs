﻿//-----------------------------------------------------------------------
// <copyright file="IManager.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Manager
{
    using System.Collections.Generic;
    using EmployeeManagementSystem.Model;

    /// <summary>
    /// Manager Interface
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns true if added else false</returns>
        bool AddEmployee(Employee employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns true if update successful else false</returns>
        bool UpdateEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>It returns true if delete successful else false</returns>
        bool DeleteEmployee(string email);

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns List of Employees</returns>
        List<Employee> GetAllEmployees();

        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns true if Login successful else false</returns>
        bool Login(Employee employee);
    }
}