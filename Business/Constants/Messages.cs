﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";


        public static string RentalAdded = "Yeni bir Araç Kiralama Eklendi";
        public static string RentalInvalid = "Araba teslim edilmediği için kiralanamaz";
        public static string RentalDeleted = "Araç Kiralama  silindi";
        public static string RentalUpdated = "Araç Kiralama  Güncellendi";


        public static string CarNameInvalidAndDailyPriceInvalid = "Araba ismi ve Günlük ücret geçersiz";
        public static string MaintenanceTime=" Arabalar Bakımda :) ";
        public static string CarListed=" Arabalar Listelendi";
        public static string CarImageAdded="Fotoğraf eklendi";
        public static string ChecImageLimitExceeded="fotoğraf limiti dolu";
        public static string AuthorizationDenied="Heyy Genç ! Yetkin yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola Hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
