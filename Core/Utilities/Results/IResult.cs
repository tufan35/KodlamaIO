using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
   public interface IResult
    {





        bool Success { get;  }  //sadece okunabilir olan get yazma olan settir kullanıcın yaptığı işle mtrue yad afalse olarka döner

        string Message { get; } //kullanıcıya gidecek olan mesaj
    }
}
