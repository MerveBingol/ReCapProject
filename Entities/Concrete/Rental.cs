using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    //Araba kiralanma bilgisi
   public class Rental:IEntity
    {
        
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }// kiralama tarihi
        public DateTime? ReturnDate { get; set; }// teslim Tarihi
    }
}
