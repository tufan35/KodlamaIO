using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
  public  class Category : IEntity
    {


        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
    }
}
