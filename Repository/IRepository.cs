using System.Collections.Generic;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Repository
{
    public interface IRepository
    {
        bool Add(string FirstName, string LastName, string Email, string Mobile);
        bool Update(Employee employee);
        bool Delete(Employee employee);
        List<Employee> GetAllEmployees();
    }
}