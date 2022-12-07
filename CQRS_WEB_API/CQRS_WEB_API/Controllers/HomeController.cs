using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_WEB_API.Repository;
using CQRS_WEB_API.Repository.Modal;
using CQRS_WEB_API.Modal;
using LoggerService;
using System.Web.Http.Cors;
using Microsoft.Extensions.Logging;
using CQRS_WEB_API.Controllers;
using CQRS_WEB_API.Services;


namespace CQRS_WEB_API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {
        private ILoggerManager _logger;
        public HomeController(ILoggerManager logger) {
            _logger = logger;
        }


        public readonly ICarRepo CarRepo;
        public HomeController(ICarRepo carRepo) {
            CarRepo = carRepo;
        }

        [HttpGet]
        [Route("Test/Get")]
        public int Index() {
            return 20;
        }


        [DisableCors]
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Car> GetAllCars() {
            try {
                ////return CarRepo.GetAllCars();
                //throw new Exception("Some unkown error occured");
                //return StatusCode(200);

                _logger.LogInfo("Fetching all the Cars from the storage");
                var cars = CarRepo.GetAllCars(); //simulation for the data base access
                _logger.LogInfo($"Returning {cars} cars.");
                return (IEnumerable<Car>)Ok(cars);
                throw new Exception("Some unkown error occured");

            }
            catch (Exception ex) {
                _logger.LogError($"Something went wrong: {ex}");
                return (IEnumerable<Car>)StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("Home/Get/{Car_No}")]
        public Car GetCarById(int Car_No) {
            return CarRepo.GetCarDetails(Car_No);
        }

        [HttpPost]
        [Route("Home/Post")]
        public Car AddNewCar(Car Addcar) {
            var newcar= CarRepo.Add( Addcar);
            return newcar;
        }

        [HttpDelete]
        [Route("Home/Delete/{Car_No}")]
        public Car DeleteCar(int Car_No) {
            var oldcar= CarRepo.Delete(Car_No);
            return oldcar;
        }
    }
}
