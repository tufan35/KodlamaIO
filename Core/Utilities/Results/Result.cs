﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class Result : IResult
    {
       
        // 

        public Result(bool success, string message):this(success) //this demek classın kendisi demek aşağıdaki metodu da burada kullanabiliyoruz
        {
            Message = message;
    
        }
        
        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
