using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mvc_train.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter t")]
        public string? EmployeeName { get; set; }

        [Required(ErrorMessage = "Please Enter The Phone")]
        public string? EmployeePhone { get; set; }
        [Required(ErrorMessage = "Please Enter Verfied Email")]
        [Column("email")]
        public string? EmployeeEmail { get; set; }

        public int? EmployeeAge { get; set; }

        public decimal? EmployeeSalary { get; set; }
    }
}
