using Core.DataAccess.EntityFrameworks;
using DataAccess.Abstracts;
using Entities.Concretes.DataTransferObjects;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDTO> RentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from a in context.Rentals
                             join b in context.Cars on a.CarId equals b.CarId
                             join c in context.Brands on b.BrandId equals c.BrandId
                             join d in context.Customers on a.CustomerId equals d.CustomerId

                             select new RentalDetailDTO
                             {
                                 RentId = a.RentId,
                                 CustomerName = d.FirstName + " " + d.LastName,
                                 CarName = c.BrandName + " - " + b.CarName,
                                 RentDate = a.RentDate,
                                 ReturnDate = a.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
