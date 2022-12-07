using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netcoreEmpty.Modal;

namespace Asp.netcoreEmpty.ViewModel
{
    public class HomeCarIndex1
    {
        //VIEWMODEL : The view which binds to a specific type of view model is strongly typed view
        public Car car { get; set; }
        public  IEnumerable<Car> carList{ get; set; }
        public string Title { get; set; }

    }
}
