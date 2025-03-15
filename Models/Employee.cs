﻿using System.ComponentModel.DataAnnotations;

namespace Mvc_train.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter The Name")]
        public string? EmployeeName { get; set; }

        [Required(ErrorMessage = "Please Enter The Name")]
        public string? EmployeePhone { get; set; }

        public string? EmployeeEmail { get; set; }

        public int? EmployeeAge { get; set; }

        public decimal? EmployeeSalary { get; set; }
    }
}
