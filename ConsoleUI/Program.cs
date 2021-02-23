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
            CarTest();
            //BrandTest();
            //ColorTest();

        }


        private static void ColorTest()
        {

            ColorManager colorManager = new ColorManager(new EfColorDal());
            // colorManager.Add(new Color { ColorId = 4,ColorName = "Blue" });// ---------------Color EKLEME-----------
            // colorManager.Update(new Color { ColorId = 4, ColorName = "Gray" });// --------------Color GÜNCELLEME------
            // colorManager.Delete(new Color { ColorId = 4, ColorName = "Gray" });//---------------- Color SİLME----------
           // Console.WriteLine(colorManager.GetById(2).ColorName);//----------- istenilen id ye göre ColorName veriyor------
            //foreach (var color in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine(color.ColorName);
            //}
        }
         
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // brandManager.Add(new Brand { BrandId = 7,BrandName = "Superb" });//------------ Brand EKLEME-----------------
            // brandManager.Update(new Brand { BrandId = 7, BrandName = "Golf" });//---------- Brand GÜNCELLEME------------
            //brandManager.Delete(new Brand { BrandId = 7, BrandName = "R50" });// --------------Brand SİLME--------------
            Console.WriteLine(brandManager.GetById(2).Data.BrandName);//------------- istenilen id ye göre BrandName veriyor----- DATA İLE VERDİK
            //foreach (var brand in brandManager.GetAll())//            ------------------- Tümünü listeler---------------------
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            // RESULT KISMINI TEST ETME
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName+" "+ car.BrandName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }




            //carManager.Add(new Car
            //{
            //    Id = 7,
            //    BrandId = 7,
            //    ColorId = 2,
            //    ModelYear = 2015,
            //    DailyPrice = 100,
            //    Description = "Kullanımı rahat olan bir araba"
            //});// **********Car EKLEME**********
            //carManager.Update(new Car {Id = 7,BrandId=7,ColorId=2,CarName="Mini Cooper",
            // ModelYear=2019,DailyPrice=95,Description="Anlatılmaz yaşanır" });    // ************Car GÜNCELLEME ************

            // carManager.Delete(new Car {Id = 7,BrandId=7,ColorId=2,CarName="Mini Cooper",
            // ModelYear=2019,DailyPrice=95,Description="Anlatılmaz yaşanır" });    //************* Car SİLME***************

           // Console.WriteLine(carManager.GetById(2).CarName);// *******istenilen id ye göre CarName veriyor************

            //Console.WriteLine("\n" + "-----Şuan Elimizde bulunan Arabalar----" + "\n");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine( 

            //        car.CarName +" "+ car.BrandName+" "+ car.ColorName+" "+" Günlük Ücreti : "+ car.DailyPrice+ " Tl"
                    
            //        );
               // Console.WriteLine 

               //(// Aşağıda sıraladıklarım GetAll() metoduna ait

               //     "Araba id :" + car.Id + "\n" +
               //     "Araba Marka id : " + car.BrandId + "\n" +
               //     "Araba Renk id : " + car.ColorId + "\n" +
               //     "Araba Model yılı :" + car.ModelYear + "\n" +
               //     "Arabanın Günlük ücreti :  " + car.DailyPrice + "\n" +
               //     "Araba Açıklama : " + car.Description + "\n"

               //);
            }
        }
    }

