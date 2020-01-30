using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string pass;
        private string email;
        private string mobile;

        [Required]
        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        [Required]
        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

		[Required]
		public string UserName 
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

		[Required]
		public string Pass 
        {
            get
            {
                return this.pass;
            }
            set
            {
                this.pass = value;
            }
        }

        [Required]
        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        [Required]
        public string Mobile 
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }
    }
}