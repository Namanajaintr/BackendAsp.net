using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netcoreEmpty.Modal
{
    public interface ICar
    {
        public Car getCarDetails(int Car_No);

        public IEnumerable<Car> GetAllCars();
        public Car Add(Car Addcar);
        public Car Delete(int Car_No);

        public Car Update(Car Updatecar);


    }
}
