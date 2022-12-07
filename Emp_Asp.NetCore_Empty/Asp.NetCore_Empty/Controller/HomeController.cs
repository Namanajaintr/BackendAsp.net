using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore_Empty.Modal;



namespace Asp.NetCore_Empty.controller
{
    //request goes to Controller:home by default as given in startup.cs
    public class HomeController : Controller
    {
        //Constructor Dependency Injection
        public IEmployee _employee;
        public HomeController(IEmployee employee) {
            _employee = employee;
        }

        public string Index() {
            return _employee.getEmpDetails(2).Address;
        }

        public ViewResult Index1() {
            Employee emp = _employee.getEmpDetails(2);
            ViewData["Employee"] = emp;
            ViewData["Title"] = "Employee Details";
            return View();
        }
        //public String Index() {
        //    //action method returns a string
        //    return "namna";
        //}
        //public IActionResult Index() {
        //    return View();
        //}
    }

}
