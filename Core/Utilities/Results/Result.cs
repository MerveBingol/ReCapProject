using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      
        // this : classın kendisi (Result)
        public Result(bool success, string message):this(success)// bu çift parametreli consructors çalıştığında bir de onu kapsayan
                                                                 //  tek paramettreli consructoru da çalıştır.
        {
            Message = message;
        
        }
        public Result(bool success)//overloading - aşırı yükleme
        {
           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }// getter readonly dir ve Consructors ta set edilebilirler
    }
}
