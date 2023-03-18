using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //User user = new User {UserId = 1, FirstName = "Kerem", LastName = "Bozkurt", Email = "abc@gmail.com", Password = "123" };
            //UserManager userManager = new UserManager(new EFUserDal());
            //userManager.Add(user);
            //foreach (var item in userManager.GetAll().Data)
            //{
            //    System.Console.WriteLine(item.FirstName);
            //}



            Car car = new Car { CarId = 1, ColorId = 2, BrandId = 3, DailyPrice= 20000, ModelYear=2018, Description="YENİ EKLENEN ARABA" };
            CarManager carManager = new CarManager(new EFCarDal());
            carManager.Add(car);
            foreach (var item in carManager.GetAll().Data)
            {
                System.Console.WriteLine(item);
            }




            //CarManager carManager = new CarManager(new EFCarDal());

            //var result = carManager.GetAll();

            //if (result.Success== true)
            //{
            //    foreach (var car in carManager.GetAll().Data)
            //    {
            //        System.Console.WriteLine(car.BrandId + " / " + car.Description);
            //    }

            //}
            //else
            //{
            //    System.Console.WriteLine(result.Message);
            //}


            //BrandManager brandManager = new BrandManager(new EFBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //   System.Console.WriteLine(brand.BrandName );
            //}

            //CarManager carManager = new CarManager(new EFCarDal());

            //foreach (var item in carManager.GetAll())

            //{
            //    System.Console.WriteLine(item.Description);
            //}
        }
    }
}