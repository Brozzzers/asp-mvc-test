using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_mvc_test.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }

        public FooterViewModel FooterData { get; set; }
    }
}
