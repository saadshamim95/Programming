//-----------------------------------------------------------------------
// <copyright file="RepositoryImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Repository
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using EmployeeManagementSystem.Model;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Class implementing IRepository interface
    /// </summary>
    /// <seealso cref="EmployeeManagementSystem.Repository.IRepository" />
    public class RepositoryImpl : IRepository
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// The connection string
        /// </summary>
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EmployeeManagement; Integrated Security=SSPI";

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryImpl"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public RepositoryImpl(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It return true if query executes else false</returns>
        public bool Add(Employee employee)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand("emAddEmployee", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@UserName", employee.UserName);
            command.Parameters.AddWithValue("@Pass", employee.Pass);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@Mobile", employee.Mobile);

            connection.Open();

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>It return true if query executes else false</returns>
        public bool Delete(string email)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand("emDeleteEmployee", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            Employee employee = new Employee
            {
                Email = email
            };
            command.Parameters.AddWithValue("@Email", employee.Email);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns List of employees</returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand("emGetAllEmployee", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Name = reader["Name"].ToString(),
                        UserName = reader["UserName"].ToString(),
                        Pass = reader["Pass"].ToString(),
                        Email = reader["Email"].ToString(),
                        Mobile = reader["Mobile"].ToString()
                    };

                    employeeList.Add(employee);
                }

                connection.Close();
            }

            return employeeList;
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It return true if query executes else false</returns>
        public bool Update(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand("emUpdateEmployee", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@UserName", employee.UserName);
                command.Parameters.AddWithValue("@Pass", employee.Pass);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Mobile", employee.Mobile);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool EmployeeLogin(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand("emLoginEmployee", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Pass", employee.Pass);
                
                connection.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
                int result = dataTable.Rows.Count;
                connection.Close();
                if (result == 1)
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