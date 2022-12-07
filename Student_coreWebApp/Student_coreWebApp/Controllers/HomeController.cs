using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Student_coreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace Student_coreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student) {
            if (ModelState.IsValid) {

            }
            return View();
        }

    }
}
