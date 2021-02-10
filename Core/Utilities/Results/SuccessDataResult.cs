using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public  class SuccessDataResult<T>:DataResult<T>
    { //işlem sonucu default true vericez

        //sistemi kullanıcak kişilere versiyonları veriyoruz hangisini isterse kullanabilir.

        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data, true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message) //default dataya karşılık gelmektedir. 
        {

        }


        public SuccessDataResult():base(default, true)
        {

        }


    }
}
