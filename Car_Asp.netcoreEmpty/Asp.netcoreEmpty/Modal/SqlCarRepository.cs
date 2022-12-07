﻿using System.Collections.Generic;

namespace Asp.netcoreEmpty.Modal
{
    public class SqlCarRepository : ICar
    {

        private readonly CarDbContext context;
        public SqlCarRepository(CarDbContext context) {
            this.context = context;
        }

        public Car getCarDetails(int Car_No) {
            return context.car.Find(Car_No);
        }
        public IEnumerable<Car> GetAllCars() {
            return context.car;
        }
        
        public Car Add(Car Addcar) {
            context.Add(Addcar);
            context.SaveChanges();
            return Addcar;
        }

        Car ICar.Delete(int Car_No) {
            Car car = context.car.Find(Car_No);
            if (car != null) {
                context.car.Remove(car);
                context.SaveChanges();
            }
            return car;
        }

        public Car Update(Car Updatecar) {
            var car = context.car.Attach(Updatecar);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            car.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Updatecar;
        }

       
    }
}
