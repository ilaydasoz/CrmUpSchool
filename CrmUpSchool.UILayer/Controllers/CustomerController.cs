﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmUpSchool.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Controllers
{
    public class CustomerController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Customers.ToList();
            return View(values);
        }
    }
}
