using System.Collections.Generic;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Repository
{
    public interface IRepository
    {
        bool Add(Employee employee);
        bool Update(Employee employee);
        bool Delete(Employee employee);
        List<Employee> GetAllEmployees();
    }
}