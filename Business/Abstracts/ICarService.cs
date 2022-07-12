using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> Get(int id);
        IResult Add(Car car);
        IResult Delete(int carId);
        IResult Update(Car car);
    }


}
