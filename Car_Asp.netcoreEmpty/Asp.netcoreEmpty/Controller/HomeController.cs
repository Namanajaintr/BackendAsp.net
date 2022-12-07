using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netcoreEmpty.Modal;
using Asp.netcoreEmpty.ViewModel;

namespace Asp.netcoreEmpty.controller
{
    
    [Route("[controller]")]
    public class HomeController : Controller
    {
        //Constructor Dependency Injection
        //Injecting the interface to the constructor as a parameter

        public ICar _cars;
        public HomeController(ICar car) {
            _cars = car;
        }
        [Route("")]
        [Route("Home")] 
        [Route("Index/{Car_No?}")]
        [Route("[action]")]
        public string Index(int? Car_No) {
            return _cars.getCarDetails(Car_No ?? 4567).Brand; 
        }

        //public JsonResult Details() {
        //    Car modalCar = _cars.getCarDetails(2345);
        //    return Json(modalCar);
        //}

        [Route("Index1/{Car_No?}")]
        //[Route("~/")]
        public ViewResult Index1(int? Car_No) {
            //viewdata or viewbag is a dictonary or a container contains the object here to tranfer it from controller to view
            //syntax : ViewData["Student"] = Student;
            //syntax : ViewBag.Student = Student;

            //Car modalCar = _cars.getCarDetails(2345);

            ////View Data
            //ViewData["Car"] = modalCar;
            //ViewData["Title"] = "Car Details";
            //return View();

            ////View Bag
            //ViewBag.Car = modalCar;
            //ViewBag.Title = "Car Details";
            //return View();

            ////Strongly Typed View
            //ViewBag.Car = modalCar;
            //ViewBag.Title = "Car Details";
            //return View(modalCar);

            ////View Model 1st type
            //var model1 = _cars.getCarDetails(Car_No ?? 1234);
            //return View(model1);

            ////View Model 2nd type
            HomeCarIndex1 homeCartIndex1 = new HomeCarIndex1() {
                car = _cars.getCarDetails(Car_No ?? 1234),
                Title = "Details of Paricular Car in our showroom"
            };
            if (homeCartIndex1.car == null) {
                return View("ErrorPage");
            }
            else {
                return View(homeCartIndex1); 
            }    
        }

        [Route("Index2")]
        //ViewModel with IEnumerable<> generic collection
        public ViewResult Index2() {
            HomeCarIndex1 homeCartIndex2 = new HomeCarIndex1() {
                carList = _cars.GetAllCars(),
                Title = "Details of All Cars in our showroom"
            };
            return View(homeCartIndex2);
        }

        [Route("~/")]
        [Route("Details")]
        public ViewResult Details() {
            var model = _cars.GetAllCars();
            return View(model);
        }

        [Route("Create")]
        public IActionResult Create() {
            //Car newCar = _cars.Add(Addcar);
            //return RedirectToAction("Details", new { Car_No = newCar.Car_No });
            return View();
        }

        public async Task<IActionResult> Create([Bind("Brand", "Color", "Price")] Car Addcar) {
            if (ModelState.IsValid) {
                 _cars.Add(Addcar);
                return RedirectToAction(nameof(Details));
            }
            return View(Addcar);
        }





        [Route("TagHelpers")]
        public ViewResult TagHelpers() {
            return View();
        }


        //differnce bn viewData and viewBag 
        //view bag is a wrapper around view data
        //creates a loosely typed view
        //viewdata uses string keys to store and retrive the data
        //view bag dynamically resolves in the run time
        //no compile time type checking and intellisense 
    }
}
