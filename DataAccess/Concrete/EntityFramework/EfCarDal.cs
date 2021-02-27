using Core.DataAccess.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
       public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext contex=new RentACarContext())
            {
                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId
                             join col in contex.Colors
                             on c.ColorId equals col.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList(); 
                         
                         
            }
         
        }

       
    }
}
