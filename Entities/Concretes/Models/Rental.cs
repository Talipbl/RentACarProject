using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Models
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public short TotalDay { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }


    }
}
