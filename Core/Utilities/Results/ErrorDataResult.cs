using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    { //işlem sonucu default true vericez

        //sistemi kullanıcak kişilere versiyonları veriyoruz hangisini isterse kullanabilir.

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) //default dataya karşılık gelmektedir. 
        {

        }


        public ErrorDataResult() : base(default, false)
        {

        }


    }
}
//Bunu bir kere yazdık ve başka yerlerde de kullanabiliriz.