using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
   public  interface ICacheManager
    {
//hangi tiple çalıştuğımızı hangi tipe dönüştüreceğimizi söyleyeceğiz.(mesela GetAll() ile bir liste isteyeceğiz , GetById() ile tek bir şey)
        T Get<T>(string key);
        object Get(string key);// generic olmayan versiyon
        void Add(string key, object value,int duration);
        bool IsAdd(string key);// Cache de var mı
        void Remove(string key);// cache den uçurma
        void RemoveByPattern(string pattern);// örn ismi Get ile başlayanları uçur ya da isminde category olanları uçur

    }
}
