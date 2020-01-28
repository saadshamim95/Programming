using EmployeeManagementSystem.Model;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Manager
{
    public interface IManager
    {
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
    }
}