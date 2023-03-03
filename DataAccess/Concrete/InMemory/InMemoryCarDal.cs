using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        public InMemoryCarDal()
        {
            _cars= new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=25000,Description="sedan" },
                new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2018,DailyPrice=30000,Description="ticari" },
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=35000,Description="spor " },
                new Car{CarId=4,BrandId=2,ColorId=3,ModelYear=2015,DailyPrice=28000,Description="makam" },
                new Car{CarId=5,BrandId=3,ColorId=4,ModelYear=2005,DailyPrice=16000,Description="suv" },

            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            

             Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

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

        public List<Car> GetAllByBrandId(int BrandId)
        {
           return _cars.Where(c=>c.BrandId==BrandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            
            carToUpdate.CarId= car.CarId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.Description= car.Description;

        }
    }
}
