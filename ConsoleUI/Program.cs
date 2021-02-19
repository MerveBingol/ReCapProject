using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine
               (
                    "Araba iD :" + car.Id +"\n"+ 
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
