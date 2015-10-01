using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_mvc_test.Models;
using asp_mvc_test.ViewModels;

namespace asp_mvc_test.Controllers
{
    public class EmployeeController : Controller
    {     
        public ActionResult Index()
        {
            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            EmployeeListViewModel elvm = new EmployeeListViewModel();
            elvm.Employees = new List<EmployeeViewModel>();

            foreach (Employee e1 in ebl.GetEmployees())
            {
                EmployeeViewModel evm = new EmployeeViewModel();

                evm.EmployeeName = e1.FirstName + " " + e1.LastName;
                evm.Salary = e1.Salary.ToString("C");

                if (e1.Salary > 15000)
                    evm.SalaryColor = "yellow";
                else
                    evm.SalaryColor = "green";

                elvm.Employees.Add(evm);
            }            

            return View("EmployeeView",elvm);

       }       
    }
}