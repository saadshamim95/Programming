//-----------------------------------------------------------------------
// <copyright file="DependencyInjection.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for testing Dependency Injection
    /// </summary>
    public class DependencyInjection
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> listEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in listEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.Id, emp.Name, emp.Department);
            }
        }
    }
}