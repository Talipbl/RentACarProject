using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> Get(int id);
        IResult Add(Color color);
        IResult Delete(int colorId);
        IResult Update(Color color);
    }

}
