using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color Get(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }

}
