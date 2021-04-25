using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //Constants projelerde sabitleri için kullanılan class yaptık

 public static   class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountofCategoryError = "Bir Kategoride enfazla 10 ürün olabilir. ";
        public static string ProductNameAlreadyExists = "Böyle isimde bir ürün vardır." ;
        public static string CategoryLimitExceded = "Kategori Limiti aşılmıştır.";
        public  static string AuthorizationDenied="Yetkiniz Yoktur.";
    }
}
