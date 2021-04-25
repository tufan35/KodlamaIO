using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); //işlem sonucu ve veri döndürüyoruz "Product

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IDataResult<Product> GetbyId(int productId); //tek başına ürün döndürüyor ürün özelliğini gösterme gibi

        IResult Add(Product product); //void yerine ıresult yaptık 

        IResult Update(Product product);
    }
}