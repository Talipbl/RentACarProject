using Core.DataAccess;
using Entities.Concretes.DataTransferObjects;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IRentalDal: IEntityRepository<Rental>
    {
        List<RentalDetailDTO> RentalDetails();
    }
}
