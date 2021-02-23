using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Result 'ı inheritance(kalıtım ) yaparak işlem sonucu ve mesajı verdik IDataResult 'a
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Resulttan tek farkı data var çünkü Result sadece voidler için
        // base(succes,message ) yazmamızın nedeni ise o kodları(Resultta bulunan) tekrar yazmayalım diye
        public DataResult(T data,bool success,string message) :base(success,message)           
        {
            Data = data;
        }
        public DataResult(T data,bool succes):base(succes)
        {
            Data = data;
        }
       
        public T Data { get; }
    }
}
