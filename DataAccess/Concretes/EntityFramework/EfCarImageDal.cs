using Core.DataAccess.EntityFrameworks;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapContext>, ICarImageDal
    {
        public CarImage GetFirst(Expression<Func<CarImage, bool>> filter)
        {
            using(ReCapContext context = new ReCapContext())
            {
                return context.Set<CarImage>().FirstOrDefault(filter);
            }
        }
    }
}
