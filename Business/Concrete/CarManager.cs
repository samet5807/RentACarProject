using Business.Abstract;
using Business.Constansts;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult< List<Car>> GetAll()
        {
            if (DateTime.Now.Hour <= 16.00)
            {
                return new ErrorDataResult<List<Car>>(Messages.SiteBakımda);
            }
            
            
             return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ÜrünListelemeBaşarılı);

            

            
        }

        public IDataResult< List<CarDetailDto>> GetCarByDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

         public IResult Add(Car car)
        {

            if (car.ModelYear<=2010 && car.DailyPrice>0)
            {
                return new ErrorResult(Messages.CarAddedFalse);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAddedTrue);
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<Car> GetById(int CarId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.CarId==CarId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.UpdateT);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedT);
        }
    }
    
}
