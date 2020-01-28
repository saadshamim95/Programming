using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Repository
{
    public class RepositoryImpl : IRepository
    {
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EmployeeManagement; Integrated Security=SSPI";
        public bool Add(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("emAddEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);

            connection.Open();

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("emDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            Employee employee = new Employee();
            employee.EmployeeID = id;
            command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("emGetAllEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.Email = reader["Email"].ToString();
                    employee.Mobile = reader["Mobile"].ToString();

                    employeeList.Add(employee);
                }
                connection.Close();
            }
            return employeeList;
        }

        public bool Update(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("emUpdateEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Mobile", employee.Mobile);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}