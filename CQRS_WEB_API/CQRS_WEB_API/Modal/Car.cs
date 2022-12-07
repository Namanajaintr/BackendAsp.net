using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_WEB_API.Modal
{
    public class Car
    {
        [Key]
        public int Car_No { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

    }
}
