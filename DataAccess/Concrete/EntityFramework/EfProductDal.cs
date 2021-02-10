using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    //veri tabanı operayonunu hazırdık hazırlanana ve eklenen efproductdal da kuralları belirledik ve kullanıyoruz
    public class EfProductDal : EfEntityRepositoryBase<Product, NortWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NortWindContext context = new NortWindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.CategoryId
                    select new ProductDetailDto
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        UnitsInStock = p.UnitsInStock
                    };
                return result.ToList();
            }
        }
    }
}