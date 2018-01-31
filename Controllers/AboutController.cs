using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return Content("About page");
        }
        public IActionResult Index()
        {
            return Content("About Index");
        }
        public IActionResult Location()
        {
            return Content("About location");
        }
    }
}