﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DTOs data transformation object

            ProductTest();
           // CategoryTest();




            Console.ReadLine();
        }

        #region CategoryTest

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        #endregion


        #region ProductTest
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/"+ product.CategoryName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //foreach (var product in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //}
        }
      
      

        #endregion
    }
}