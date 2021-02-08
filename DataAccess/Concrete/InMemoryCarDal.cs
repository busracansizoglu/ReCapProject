using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=11 ,ColorId=125,ModelYear=2017,DailyPrice=1800,Description="Volkswagen Scirocco" },
                new Car {Id=2,BrandId=21 ,ColorId=987,ModelYear=2019,DailyPrice=1600,Description="Fiat Doblo Cargo" },
                new Car {Id=3,BrandId=10 ,ColorId=698,ModelYear=2021,DailyPrice=3000,Description="BMW 7 Serisi" },
                new Car {Id=4,BrandId=15 ,ColorId=719,ModelYear=2016,DailyPrice=1500,Description="Ford Transit Courier" },
                new Car {Id=5,BrandId=32 ,ColorId=256,ModelYear=2020,DailyPrice=2500,Description="Audi Q2" },

            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdater = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdater.ModelYear = car.ModelYear;
            carToUpdater.Description = car.Description;
            carToUpdater.DailyPrice = car.DailyPrice;
            carToUpdater.ColorId = car.ColorId;
            carToUpdater.BrandId = car.BrandId;
        }
    }
}
