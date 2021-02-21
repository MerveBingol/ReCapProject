using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Color> _colors;
        List<Brand> _brands;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=300,Description="Harikaaa" },
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=150,Description="aşırıııı waaooow"},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2010,DailyPrice=60,Description="Tam bir aile aracı" },
                new Car{Id=4,BrandId=6,ColorId=3,ModelYear=2015,DailyPrice=200,Description="uçak mübarek" },
                new Car{Id=5,BrandId=5,ColorId=1,ModelYear=2021,DailyPrice=50,Description="iyi" },
                new Car{Id=6,BrandId=4,ColorId=1,ModelYear=2000,DailyPrice=50,Description="En en en en güzel araçlardan " },
            
            
            
            };

            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="Black" },
                new Color{ColorId=2,ColorName="Red" },
                new Color{ColorId=3,ColorName="White" },
            };


            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Lamborghini" },
                new Brand{BrandId=2,BrandName="BMW" },
                new Brand{BrandId=3,BrandName="Audi" },
                new Brand{BrandId=4,BrandName="Tofaş" },
                new Brand{BrandId=5,BrandName="Volvo" },
                new Brand{BrandId=6,BrandName="Volkswagen" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          
           Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
           
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public List<Car> GetAllColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

      

        public void Update(Car car)
        {
            // Gönderdiğim araba id 'sine sahip olan  listedeki arabayı bul ve güncelle
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
