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
            List<Employee> le = new List<Employee>();

            SalesERPDAL salesDAL = new SalesERPDAL();

            return salesDAL.Employees.ToList();
        }
    }
}