using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        List<Rental> GetAll();
        Car Get(int id);
        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
    }


}
