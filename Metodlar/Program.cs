using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

           

         


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Siyah Elma";
            urun1.stokAdedi = 35;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Adana Karpuzu";
            urun2.stokAdedi = 30;

            Product[] urunler = new Product[] {urun1, urun2 };



            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.stokAdedi);
            }


            Console.WriteLine("********************");

            // İnstance
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("********************");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 10, 20);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 10, 20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 10, 20);
        }
    }
}
