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

        public IResult Delete(Rental rental)
        {
            return BaseOperations(_rentalDal.Delete(rental).Success, Messages.Rental.Deleted);
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentID == id), Messages.Rental.Listed);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Rental.Listed);
        }

        public List<RentalDetailDTO> RentalDetails()
        {
            return _rentalDal.RentalDetails();
        }

        public IResult Update(Rental rental)
        {
            return BaseOperations(_rentalDal.Update(rental).Success, Messages.Rental.Updated);
        }
    }
}
