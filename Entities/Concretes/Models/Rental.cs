using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Models
{
    public class Rental : IEntity
    {
        [Key]
        public int RentId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public short TotalDay { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }


    }
}
