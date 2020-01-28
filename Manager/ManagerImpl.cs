using System.Collections.Generic;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repository;

namespace EmployeeManagementSystem.Manager
{
    public class ManagerImpl : IManager
    {
        IRepository repository = new RepositoryImpl();

        public bool AddEmployee(Employee employee)
        {
            var result = this.repository.Add(employee);
            return result;
        }

        public bool DeleteEmployee(int id)
        {
            var result = this.repository.Delete(id);
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