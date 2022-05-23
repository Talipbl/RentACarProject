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
        List<Car> GetAll();
        Car Get(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }


}
