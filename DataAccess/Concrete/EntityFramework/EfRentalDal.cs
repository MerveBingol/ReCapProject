using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext contex = new RentACarContext())
            {
                var result = from r in  contex.Rentals
                             join c in contex.Cars
                             on r.CarId equals c.CarId
                             join cus in contex.Customers
                             on r.CustomerId equals cus.CustomerId
                             join us in contex.Users
                             on cus.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 RentalId=r.RentalId,
                                 CarName=c.CarName,
                                 FirstName=us.FirstName,
                                 LastName=us.LastName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             
                             };

                return result.ToList();           
            }

        }

       
    }
}
