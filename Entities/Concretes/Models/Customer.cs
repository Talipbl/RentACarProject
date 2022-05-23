using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Models
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoPath { get; set; }

        public virtual List<Rental> Rentals { get; set; }
    }
}
