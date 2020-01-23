//-----------------------------------------------------------------------
// <copyright file="EmployeeDAL.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Class EmployeeDAL(Data Access Layer) implementing interface IEmployeeDAL
    /// </summary>
    /// <seealso cref="Design_Pattern.IEmployeeDAL" />
    public class EmployeeDAL : IEmployeeDAL
    {
        /// <summary>
        /// Selects all employees.
        /// </summary>
        /// <returns>
        /// It returns List of Employee
        /// </returns>
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { Id = 1, Name = "Saad", Department = "IT" });
            listEmployees.Add(new Employee() { Id = 2, Name = "Mayank", Department = "HR" });
            listEmployees.Add(new Employee() { Id = 3, Name = "Amit", Department = "Payroll" });

            return listEmployees;
        }
    }
}