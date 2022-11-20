using System;
using System.Collections.Generic;
using CrmUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Areas.Employee.Controllers
{
    public class ChartController : Controller
    {
        List<DepartmentSalary> departmentSalaries = new List<DepartmentSalary>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartmentChart()
        {
            departmentSalaries.Add(new DepartmentSalary
            {
                departmentname = "Accounting",
                salaryavg = 10000
            });

            departmentSalaries.Add(new DepartmentSalary
            {
                departmentname = "IT",
                salaryavg = 20000
            });

            departmentSalaries.Add(new DepartmentSalary
            {
                departmentname = "Sales",
                salaryavg = 12000
            });

            return Json(new { jsonList = departmentSalaries });
        }
    }
}
