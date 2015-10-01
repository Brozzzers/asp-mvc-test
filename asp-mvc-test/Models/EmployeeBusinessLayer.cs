using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using asp_mvc_test.DataAccessLayer;

namespace asp_mvc_test.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL s = new SalesERPDAL();

            return s.Employees.ToList();
        }
    }
}