using System.ComponentModel.DataAnnotations;
namespace EMSv2.Models
{

    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(50)]
        public string Department { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(1000, 1000000, ErrorMessage = "Salary must be between 1,000 and 1,000,000")]
        public decimal Salary { get; set; }
    }

}
