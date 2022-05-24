using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Models
{
    public class Car : IEntity
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public Decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual List<Rental>Rentals { get; set; }

    }
}
