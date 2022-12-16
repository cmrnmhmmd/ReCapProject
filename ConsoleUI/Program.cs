using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.Add(new User { FirstName = "Elif Lina", LastName = "Çimrin", Email = "elif@gmail.com", Password = "elif123" }).Message;

             
            




            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarDetail())
            //{
            //    Console.WriteLine(car.BrandName +" "+ car.Description+" "+car.ColorName+" "+car.DailyPrice);

            //}

            //foreach (var cars in carManager.GetAll())
            //{
            //   Console.WriteLine(cars.CarId+" "+cars.ColorId+" "+cars.Description);

            //}


            //foreach (var car in carManager.GetByDailyPrice(65000,125000))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //var result = carManager.Add(new Car { BrandId = 3, ColorId = 3, DailyPrice = 210000, Description = "A", ModelYear = 2021 }).Message;

            




            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId+" "+brand.BrandName);

            //}

            //brandManager.Add(new Entities.Concrete.Brand {BrandName="McLaren" });

            //brandManager.Delete(new Brand { BrandId = 3002 });

            // brandManager.Update(new Brand { BrandId = 2002, BrandName = "Jeep", });


            ColorManager colorManager = new ColorManager(new EfColorDal());



           
        }
    }
}
