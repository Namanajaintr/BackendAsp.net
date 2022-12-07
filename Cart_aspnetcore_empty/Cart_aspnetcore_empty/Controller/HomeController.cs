using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cart_aspnetcore_empty.Modal;
using Cart_aspnetcore_empty.ViewModal;

namespace Cart_aspnetcore_empty.controller
{
    public class HomeController : Controller
    {
        //Constructor Dependency Injection
        //Injecting the interface to the constructor as a parameter
        public ICart _carts;
        public HomeController(ICart cart) {
            _carts = cart;
        }
        public ViewResult Index() {
            Cart mockCart = _carts.getCartDetails(123);
            ViewBag.Cart = mockCart;
            ViewBag.Title = "Cart Details";
            return View();
        }

        public ViewResult Index1() {
            //var modal = _carts.GetAllCars();
            //return View(modal);

            HomeIndex1ViewModal homeIndex1ViewModal = new HomeIndex1ViewModal() {
                Cart = _carts.GetAllCarts(),
                Title = "Details of Employee"
            };
            return View(homeIndex1ViewModal);
        }
    }
}
