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
        public string   EmployeeId  { get; set; }
        public string   FirstName   { get; set; }
        public string   LastName    { get; set; }
        public int      Salary      { get; set; }

    }

}