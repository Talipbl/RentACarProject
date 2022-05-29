using Business.Abstracts;
using Business.Constanst;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }
        public IResult Add(Car car)
        {
            return BaseOperations(_carDal.Add(car).Success, Messages.Car.Added);
        }

        public IResult Delete(Car car)
        {
            return BaseOperations(_carDal.Delete(car).Success, Messages.Car.Deleted);
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == id), Messages.Car.Listed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Car.Listed);
        }

        public IResult Update(Car car)
        {
            return BaseOperations(_carDal.Update(car).Success, Messages.Car.Updated);
        }
    }
}
