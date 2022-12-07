using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_WEB_API.Repository.Modal;
using CQRS_WEB_API.Modal;

namespace CQRS_WEB_API.Services
{
    public class MockCarRepo : ICarRepo
    {
        private List<Car> carslist = new List<Car>();

        public MockCarRepo() {
            carslist.Add(new Car() { Car_No = 1234, Brand = "Ferrori", Price = 220000, Color = "Red" });
            carslist.Add(new Car() { Car_No = 2345, Brand = "Royce", Price = 2500000, Color = "Cream" });
            carslist.Add(new Car() { Car_No = 3456, Brand = "Eritiga", Price = 120000, Color = "White" });
            carslist.Add(new Car() { Car_No = 4567, Brand = "Kia", Price = 2260000, Color = "Beach" });
        }

        Car ICarRepo.GetCarDetails(int number) {
            return this.carslist.FirstOrDefault(e => e.Car_No == number);
        }

        public IEnumerable<Car> GetAllCars() {
            return carslist;
        }

        public Car Add(Car Addcar) {
            Addcar.Car_No = carslist.Max(e => e.Car_No) + 1;
            carslist.Add(Addcar);
            return Addcar;
        }

        public Car Delete(int id) {
            Car Dltcar = carslist.FirstOrDefault(e => e.Car_No == id);
            if (Dltcar != null) {
                carslist.Remove(Dltcar);
            }
            return Dltcar;
        }

        public Car Update(Car UpdateNewcar) {
            Car UpdOldcar = carslist.FirstOrDefault(e => e.Car_No == UpdateNewcar.Car_No);
            if (UpdOldcar != null) {
                UpdOldcar.Brand = UpdateNewcar.Brand;
                UpdOldcar.Color = UpdateNewcar.Color;
                UpdOldcar.Price = UpdateNewcar.Price;

            }
            return UpdOldcar;
        }
    }
}

