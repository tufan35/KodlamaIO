using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = new string[] { "tufan", "engin", "ahmet", "hamit" };
            //liste metodu olmadan new olarka eklersek adresler farklı oldupğu için tuttuğumnuz referans verileri kayp olarka 
            //listeye ekleyemiyoruz bu yüzden list metodunu yani  koleksiyon metodunyu kullanıyoruz
            List<string> isimler2 = new List<string> { "tufan", "engin", "ahmet", "hamit" };


            isimler2.Add("ilker");

            foreach (var ts in isimler2)
            {
                Console.WriteLine(ts);
            }




        }
    }
}
