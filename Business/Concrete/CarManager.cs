using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; // veri erişim yöntemlerinin her birini tutabilecek referans
 
        public CarManager(ICarDal carDal)// oluşturma anında bir veri erişim yöntemi istiyor.
        {
            _carDal = carDal;
            
        }
       
        public void Add(Car car)
        {

            if ( car.Description.Length >=2 ) 
            {
                if (car.DailyPrice > 0 )
                { 
                _carDal.Add(car);
                Console.WriteLine("\n" + "Yeni Arabamız eklenmiştiiir" + "\n");
               }
                else
                {
                    Console.WriteLine("\n" + " Günlük fıyatı 0'dan büyük olmalıdır." + "\n");

                }

            }
                else
                {
                    Console.WriteLine("\n" + "Araba Açıklması en az 2 karakterden oluşmalıdır" + "\n");
               
              }
  
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

    }
}
