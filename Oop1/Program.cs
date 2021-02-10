using System;

namespace Oop1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.CategoryId = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
          
          //Steak               //Heap
           Product product2 = new Product { Id = 1, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 6, UnitPrice = 35 };



            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           
          }

    }
}
