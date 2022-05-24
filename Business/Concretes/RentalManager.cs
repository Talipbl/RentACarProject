using Business.Abstracts;
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
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public Rental Get(int id)
        {
            return _rentalDal.Get(p => p.RentID == id);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<RentalDetailDTO> RentalDetails()
        {
            return _rentalDal.RentalDetails();
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }




}
