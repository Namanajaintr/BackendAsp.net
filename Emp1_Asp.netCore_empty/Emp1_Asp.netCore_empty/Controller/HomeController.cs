using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emp1_Asp.netCore_empty.Model;

namespace Emp1_Asp.netCore_empty.controller
{
   
        public class HomeController : Controller
        {
            private IEmployeeRepository _employeeRepository;

            public HomeController(IEmployeeRepository employeeRepository) {
                _employeeRepository = employeeRepository;
            }

            [HttpGet]
            public ViewResult Create() {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Employee employee) {
                if (ModelState.IsValid) {
                    Employee newEmployee = _employeeRepository.Add(employee);
                }

                return View();
            }
        }
    
}
