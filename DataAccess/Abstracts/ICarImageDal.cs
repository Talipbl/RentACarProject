using Core.DataAccess;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICarImageDal : IEntityRepository<CarImage> 
    {
        public CarImage GetFirst(Expression<Func<CarImage, bool>> filter);
    }
}
