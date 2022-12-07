using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Asp.netcoreEmpty.controller
{
    public class ErrorController : Controller
    {
        public IActionResult HttpStatusCodeHandler(int statusCode) {
            switch (statusCode) {
                case 404:
                    return View("../Error/Error.cshtml");
                    break;
            }
            return View("../Error/Error.cshtm");
        }
        public IActionResult Error(int? statusCode = null) {
            if (statusCode.HasValue) {
                if (statusCode == 404 || statusCode == 500) {
                    var viewName = statusCode.ToString();
                    return View(viewName);
                }
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
