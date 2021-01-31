using System;
using System.Collections.Generic;

namespace IDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ekleyeceğiniz ürün miktarını yazınız");

            int arabamiktar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ekleyeceğiniz Arabanın Seri No ve Türünü Giriniz :");

            IDictionary<int, string> cars = new Dictionary<int, string>();

            for (int i = 0; i < arabamiktar; i++)
            {
                int SeriNo = Convert.ToInt32(Console.ReadLine());
                string ArabaTürü = Console.ReadLine();
                cars.Add(SeriNo,ArabaTürü);
                Console.WriteLine("{0} Seri Nolu {1} Arabası Eklendi. ", SeriNo, ArabaTürü);
                Console.WriteLine();

                if (i<arabamiktar)
                {
                    Console.WriteLine("{0}. arabayı giriniz", i + 1);
                }
            }


        }



    }
}
