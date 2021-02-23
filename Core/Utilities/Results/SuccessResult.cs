using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base: inheritance ettiğimiz Result
        public SuccessResult(string message) : base(true, message)
        { 
        
        }
        public SuccessResult():base(true)//mesaj vermeyebilir - base nin tek parametreli olanını çalıştır
        {
        
        }

    }
}
