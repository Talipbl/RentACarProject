using Core.Utilities.Results.Abstracts;
using Entities.Concretes.DataTransferObjects;
using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int id);
        IDataResult<List<RentalDetailDTO>> RentalDetails();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }


}
