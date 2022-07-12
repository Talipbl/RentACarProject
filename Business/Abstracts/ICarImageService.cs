using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarImageService
    {
        IResult Add(IFormFile formFile, int carId);
        IResult Update(CarImage carImage);
        IResult Delete(int imageId);
        IDataResult<CarImage> GetFirst(int id);
        IDataResult<List<CarImage>> GetAll(int carId);
    }
}
