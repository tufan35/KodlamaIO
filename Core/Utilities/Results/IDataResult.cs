using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //hangi tipi bana döndüreceğini bana söyle (Generic)
    {
        T Data { get; }

    }
}
