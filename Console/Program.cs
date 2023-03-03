using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var detail in carManager.GetCarByDetail())
            {
                System.Console.WriteLine(detail.CarId + "  " + detail.BrandName + "  " + detail.ColorName );
            }


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