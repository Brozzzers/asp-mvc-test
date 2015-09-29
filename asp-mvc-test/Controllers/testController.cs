using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_mvc_test.Controllers
{
    public class Customer
    {
        public string Name { get; set; }
        public string Adr { get; set; }

        public override string ToString()
        {
            return this.Adr + " | " + this.Name;
        }
    }

    public class testController : Controller
    {     
        public ActionResult Index()
        {
            return View("TestV");
        }

        public Customer getCust()
        {
            Customer cus = new Customer();
            cus.Name    =   "Cus 1";
            cus.Adr     =   "Adr"; 
            return cus;
        }
    }
}