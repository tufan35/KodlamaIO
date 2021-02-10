using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Musteri musteri1 = new Musteri { Adi = "Tufan", Soyadi= "Cevik", Id = 1, TcNo = 21161139330, MusteriNo = "?", VergiNo = "?"  }
            //gerçek müşteri ile tüzel müşteri birbirinden farklıdır   

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Tufan";
            musteri1.Soyadi = "Cevik";
            musteri1.Id = 1;
            musteri1.TcNo = 21161139330;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "005";
            musteri2.MusteriNo = "Kodlama.io";
            musteri2.VergiNo = "006";

            Musteri musteri3 = new GercekMusteri(); //bunlar referanslardır       // Musteri hem tuzel hem de gerçek musterileri tutabilir
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
