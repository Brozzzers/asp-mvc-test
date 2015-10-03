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
        public int      Salary      { get; set; }

    }

}