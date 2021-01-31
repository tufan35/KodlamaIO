using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new[] {"python", "Java", "C#"};


            //for (int i = 0; i <kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurslar);
            }
        }
    }
}
