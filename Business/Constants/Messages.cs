using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // static verdiğimizde new'lemiyoruz
   public static class Messages
    {
        //değişken isimlerini büyük yazdık çünkü public'ler Pascal Case yazılır
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç Güncellendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka Güncellendi";


        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";


        public static string CarNameInvalidAndDailyPriceInvalid = "Araba ismi ve Günlük ücret geçersiz";
        internal static string MaintenanceTime=" Arabalar Bakımda :) ";
        internal static string CarListed=" Arabalar Listelendi";
    }
}
