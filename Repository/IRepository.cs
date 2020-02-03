//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Repository
{
    using System.Collections.Generic;
    using EmployeeManagementSystem.Model;

    /// <summary>
    /// Repository Interface
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It return true if added else false</returns>
        bool Add(Employee employee);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns true if update successful else false</returns>
        bool Update(Employee employee);

        /// <summary>
        /// Deletes the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>it returns true if delete successful else false</returns>
        bool Delete(string email);

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