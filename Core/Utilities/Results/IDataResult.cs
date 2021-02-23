using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IDataResult : mesaj içersin ,işlem sonucu içersin ve aynı zamanda data içersin
    // Ama mesaj ve işlem sonucunu IResult içeriyor zaten dolayısıyla implemente ediyoruz.
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
