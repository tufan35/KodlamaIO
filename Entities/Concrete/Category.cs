using Core.Entities;
using System;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
    }
}