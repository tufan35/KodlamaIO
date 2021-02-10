using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    //gömülü sorgu parametreleridir.
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName =  "bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 gb ram", UnitInStock = 500, UnitPrice = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 gb ram", UnitInStock = 400, UnitPrice = 4},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "32 gb ram", UnitInStock = 300, UnitPrice = 6},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "32 gb ram", UnitInStock = 200, UnitPrice = 7},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "32 gb ram", UnitInStock = 100, UnitPrice = 8},

            };
            Console.WriteLine("******aAlgoritmik");
            foreach (var product in products)
            {
                if (product.UnitPrice >5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            
       Console.WriteLine("********Linq");

       var result = products.Where(p => p.UnitPrice > 5);
       foreach (var r in result)
       {
        Console.WriteLine(r.ProductName);   
       }
       //LİNQ İLE YAZILAN FİLTRELEME SORGUSU

       static List<Product> GetProductsLinq(List<Product> products)
       {
           return products.Where(product => product.UnitPrice > 5).ToList();
       }


        Console.ReadLine();
        }
    }


    class Product
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }



    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
