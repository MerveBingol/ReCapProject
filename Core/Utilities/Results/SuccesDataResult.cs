using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccesDataResult<T>:DataResult<T>
    {
        public SuccesDataResult(T data,string message):base(data,true,message)
        {

        }
        public SuccesDataResult(T data):base(data,true)
        {

        }
        public SuccesDataResult(string message):base(default,true,message)
        {

        }
        public SuccesDataResult():base(default,true)
        {

        }

    }
}
