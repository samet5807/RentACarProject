using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, car_rentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (car_rentContext context = new car_rentContext())
            {
                var result = from p in context.Cars
                             
                             join b in context.Brands on p.CarId equals b.BrandId
                             join cl in context.Colors on p.ColorId equals cl.ColorId
                             

                             


                             select new CarDetailDto {CarId=p.CarId,BrandName=b.BrandName,DailyPrice=p.DailyPrice,ColorName=cl.ColorName };

                return result.ToList();
            }
        }
    }


}

