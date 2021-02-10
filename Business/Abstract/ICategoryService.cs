using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(); //tüm listeyi çeker

        Category GetById(int categoryId); //id ye göre çeker
    }
}