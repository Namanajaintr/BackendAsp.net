using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CQRS_WEB_API.Modal;

namespace CQRS_WEB_API.Services
{
    public class CarDbContext : DbContext
    {

        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Car> car { get; set; }
    
    }
}
