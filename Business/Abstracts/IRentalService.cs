using Entities.Concretes.DataTransferObjects;
using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        List<Rental> GetAll();
        Rental Get(int id);
        List<RentalDetailDTO> RentalDetails();
        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
    }


}
