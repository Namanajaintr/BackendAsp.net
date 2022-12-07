using CQRS_WEB_API.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_WEB_API.Repository.Modal
{
    public interface ICarRepo
    {
        public Car GetCarDetails(int Car_No);

        public IEnumerable<Car> GetAllCars();
        public Car Add(Car Addcar);
        public Car Delete(int Car_No);

        public Car Update(Car Updatecar);
       
    }
}
