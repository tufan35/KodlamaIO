using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;  //Global Değişkendir
        
        public InMemoryProductDal()
        {
            // Veritabanlarından geliyormuş gibi yarattık
            _products = new List<Product> 
            {
                    
                new Product{ProductId=1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId=2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId=3, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2} ,
                new Product{ProductId=4, ProductName = "Klavye", UnitPrice = 155, UnitsInStock = 65},
                new Product{ProductId=5, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            //Link Kullanmadan // Elmanları dolaşıyoruz elemanları ID nolarına göre karşılaştırıp  ona göre siler
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //    productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            //}
            //_products.Remove(productToDelete);

            //LINQ LANGUE INTEGRATED QUERY // Linq ile yapılan

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
          

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product) //(Product product) kullanıcıdan gelen data veeri kaynağında bulunan dataya göre değiştiriyoruz
        {
            //Gönderdiğim ürün ID SİNE SAHİP OLAN LİSTEDEKİ ÜRÜN İD SİNİ BUL
            Product productToUpdate      = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName  = product.ProductName;
            productToUpdate.CategoryId   = product.CategoryId;
            productToUpdate.UnitPrice    = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }


        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(P => P.CategoryId == categoryId).ToList();
        }
    }
}
