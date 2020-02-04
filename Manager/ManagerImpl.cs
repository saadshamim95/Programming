//-----------------------------------------------------------------------
// <copyright file="ManagerImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Manager
{
    using System.Collections.Generic;
    using EmployeeManagementSystem.Model;
    using EmployeeManagementSystem.Repository;

    /// <summary>
    /// Class implementing Manager Interface
    /// </summary>
    /// <seealso cref="EmployeeManagementSystem.Manager.IManager" />
    public class ManagerImpl : IManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerImpl"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ManagerImpl(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// It returns true if added else false
        /// </returns>
        public bool AddEmployee(Employee employee)
        {
            var result = this.repository.Add(employee);
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// It returns true if delete successful else false
        /// </returns>
        public bool DeleteEmployee(string email)
        {
            var result = this.repository.Delete(email);
            return result;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>
        /// It returns List of Employees
        /// </returns>
        public List<Employee> GetAllEmployees()
        {
            var result = this.repository.GetAllEmployees();
            return result;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// It returns true if update successful else false
        /// </returns>
        public bool UpdateEmployee(Employee employee)
        {
            var result = this.repository.Update(employee);
            return result;
        }

        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// It returns true if Login successful else false
        /// </returns>
        public bool EmployeeLogin(Employee employee)
        {
            var result = this.repository.EmployeeLogin(employee);
            return result;
        }

        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// It returns true if Password changed successfully
        /// </returns>
        public bool ForgetPassword(Employee employee)
        {
            var result = this.repository.ForgetPassword(employee);
            return result;
        }
    }
}