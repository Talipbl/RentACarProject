using Business.Abstracts;
using Business.Constanst;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.DataTransferObjects;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;

namespace Business.Concretes
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }
        public IResult Add(Rental rental)
        {
            return BaseOperations(_rentalDal.Add(rental).Success, Messages.Rental.Added);
        }

        public IResult Delete(int rentalId)
        {
            return BaseOperations(_rentalDal.Delete(new Rental { RentId = rentalId}).Success, Messages.Rental.Deleted);
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentId == id), Messages.Rental.Listed);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Rental.Listed);
        }

        public IDataResult<List<RentalDetailDTO>> RentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_rentalDal.RentalDetails(),Messages.Rental.Listed);
        }

        public IResult Update(Rental rental)
        {
            return BaseOperations(_rentalDal.Update(rental).Success, Messages.Rental.Updated);
        }
    }
}
