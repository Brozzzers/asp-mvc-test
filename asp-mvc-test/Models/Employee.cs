using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace asp_mvc_test.Models
{
    public class Employee
    {
        [Key]      
        public int   EmployeeId  { get; set; }

        [Required(ErrorMessage ="Enter the First Name")]
        public string   FirstName   { get; set; }

        [Required(ErrorMessage = "Enter the Last Name")]
        [StringLength(5,ErrorMessage ="LastName should be not greater than 5")]
        public string   LastName    { get; set; }

        [SalaryValidation]
        public int      Salary      { get; set; }

    }

    public class SalaryValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult("Enter the salary!");
            }
            if ((int)value > 50000)
            {
                return new ValidationResult("Too big!");
            }
            return ValidationResult.Success;
        }
    }

}