using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
		[Required]
		public string UserName {get; set; }
		[Required]
		public string Pass {get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}