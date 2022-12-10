using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarId+" "+cars.ColorId+" "+cars.Description);

            }
            Console.WriteLine("*******************************");

            foreach (var car in carManager.GetByDailyPrice(65000,125000))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("***********************");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId+" "+brand.BrandName);

            }




           
        }
    }
}
