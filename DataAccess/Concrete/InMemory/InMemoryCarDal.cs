using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car { CarId = 1, BrandId = 1, ColorId = 3, DailyPrice = 45000, Description = "Ultra Hızlı", ModelYear = 2022 },
                new Car { CarId = 2, BrandId = 1, ColorId = 4, DailyPrice = 75000, Description = "Geniş Aile Aracı", ModelYear = 2019 },
                new Car { CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 28000, Description = "Arazı Arabası", ModelYear = 2020 },
                new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 74000, Description = "Güçlü Motor", ModelYear = 2018 },
                new Car { CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 98000, Description = "Gösterişli", ModelYear = 2017 },
                new Car { CarId = 6, BrandId = 3, ColorId = 3, DailyPrice = 14000, Description = "Hızlı", ModelYear = 2022 },
                new Car { CarId = 7, BrandId = 4, ColorId = 4, DailyPrice = 39000, Description = "Spor araba", ModelYear = 2020 },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete=_cars.SingleOrDefault(c =>c.CarId==car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();


        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
