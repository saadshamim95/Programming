//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeManagementSystem.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model Class Employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The user name
        /// </summary>
        private string userName;

        /// <summary>
        /// The pass
        /// </summary>
        private string pass;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The mobile
        /// </summary>
        private string mobile;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
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

        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        /// <value>
        /// The pass.
        /// </value>
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

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
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

        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
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