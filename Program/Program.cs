using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            //string adi = "Tufna ";
            //int yas = 27;

            //Kurs kurs1 = new Kurs()  ;
            //kurs1.Egitmen = "Rngin";
            //kurs1.IzlenmeOrani = 68;
            //kurs1.Kursadi = "c#";



            //Kurs kurs2 = new Kurs();
            //kurs1.Egitmen = "Rngin";
            //kurs1.IzlenmeOrani = 68;
            //kurs1.Kursadi = "Java#";

            //Kurs kurs3 = new Kurs();
            //kurs1.Egitmen = "Engin";
            //kurs1.IzlenmeOrani = 68;
            //kurs1.Kursadi = "python#";


            //Kurs[] Kurslar = new Kurs[] {kurs1, kurs2, kurs3 };


            //foreach (var k in Kurslar)
            //{
            //    Console.WriteLine(k.Kursadi);
            //}


            //string urunadi = "Botlar";
            //int urunayakno = 43;
            //string urunrenk = "siyah";

            urun urun1 = new urun();
            urun1.urunadi = "yuksek bot";
            urun1.urunayakno = 44;
            urun1.urunrenk = "siyah";

            urun urun2 = new urun();
            urun2.urunadi = "düsük bot";
            urun2.urunayakno = 45;
            urun2.urunrenk = "turuncu";

            urun urun3 = new urun();
            urun3.urunadi = "çizgili bot";
            urun3.urunayakno = 40;
            urun3.urunrenk = "bordo";

            urun[] bot = new urun[] { urun1,urun2, urun3 };

            Console.WriteLine("***********************for*************");
            for (int i = 0; i < bot.Length; i++)
            {
                Console.WriteLine("Ürün İsim : "  + bot[i].urunadi + " \n", "Ayakkabı Numarası : " + bot[i].urunayakno + "\n", "Renk : " + bot[i].urunrenk + "\n"  );
            }

            Console.WriteLine("***********************foreach*************");
            foreach (var botlar in bot)
            {
                Console.WriteLine(botlar.urunadi,botlar.urunayakno, botlar.urunrenk);
            }
            Console.WriteLine("***********************while*************");
            int sayi = 1;
                while(sayi <= bot.Length)
            {
                Console.WriteLine("Ürün İsim : " + bot[sayi].urunadi + " \n", "Ayakkabı Numarası : " + bot[sayi].urunayakno + "\n", "Renk : " + bot[sayi].urunrenk + "\n");
                sayi++;
            }
            Console.ReadLine();
        }



        internal class urun
        {
            public string urunadi { get; set; }
            public  int urunayakno { get; set; }
            public string urunrenk { get; set; }
        }


        class Kurs
        {
            public string Kursadi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }





        }
    }

}
