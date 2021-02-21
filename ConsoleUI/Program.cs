using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle 
    //yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın (InMemoryCarDal ---> EfCarDal)
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 7,
                BrandId = 7,
                ColorId = 2,
                ModelYear = 2015,
                DailyPrice = 100,
                Description = "Kullanımı rahat olan bir araba"
            });
            Console.WriteLine("//////////////////////////////////////////////////////////////////");

            Console.WriteLine("\n" + "-----Şuan Elimizde bulunan Arabalar----" + "\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine
               (
                  
                    "Araba id :" + car.Id +"\n"+ 
                    "Araba Marka id : "+car.BrandId + "\n" +
                    "Araba Renk id : "+car.ColorId + "\n" +
                    "Araba Model yılı :"+ car.ModelYear + "\n" +
                    "Arabanın Günlük ücreti :  "+car.DailyPrice + "\n" +
                    "Araba Açıklama : "+car.Description + "\n" 

               );
            }
          
         





        }
    }
}
