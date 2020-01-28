using System.Collections.Generic;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repository;

namespace EmployeeManagementSystem.Manager
{
    public class Manager : IManager
    {
        IRepository repository = new RepositoryImpl();

        public bool AddEmployee(Employee employee)
        {
            var result = this.repository.Add(employee);
            return result;
        }

        public bool DeleteEmployee(Employee employee)
        {
            var result = this.repository.Delete(employee);
            return result;
        }

        public List<Employee> GetAllEmployees()
        {
            var result = this.repository.GetAllEmployees();
            return result;
        }

        public bool UpdateEmployee(Employee employee)
        {
            var result = this.repository.Update(employee);
            return result;
        }
    }
}