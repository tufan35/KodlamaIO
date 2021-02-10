using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde o interfaceyi implemente eden classın referans numarasını tutabili r
            IKrediManager  ihtiyacKrediManager = new IhtiyacKrediManager();
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
      

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
    

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //****Esnaf Kredisi.cs Sonradan eklendi
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            //******************************** Servis loglamada bunu kullanıyoruz
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //** sms gönderme servisi sonradan eklendi sistem bozulmadan eklenebiliyor
            ILoggerService smsLoggerService = new SmsLogger();

            //**Kredi Basvuru Ekranı
            BasvuruManager basvuruManager = new BasvuruManager();

            //tek bir log servise göndereceksek böyle yapılıyor
            //basvuruManager.basvuruYap(konutKrediManager, fileLoggerService);

            //Alternatifi instanda oluşturmadan
            //   basvuruManager.basvuruYap(new EsnafKredisiManager(),fileLoggerService);

            //**sms gönderme ve esnaf kredisi için
            // basvuruManager.basvuruYap(new EsnafKredisiManager(), new SmsLogger());

            //** Birden fazla servis listeye alma

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, fileLoggerService, smsLoggerService };
            //**Alternatifi
            List<ILoggerService> loggerss = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SmsLogger() };

            


            //*************Birden fazla servise kayıt yapcaz ve kayıt göndermek için 
            Console.WriteLine("********************* Birden fazla loglama ***************");
            //basvuruManager.basvuruYap(esnafKrediManager, new List<ILoggerService> { databaseLoggerService, fileLoggerService, smsLoggerService });
            //alternatifi
            // basvuruManager.basvuruYap(esnafKrediManager, loggerss);



            //Birden fazla seçim yapabilmek için list yöntine başvurulur
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggers);
            //Yedek veritabanına kayıt
            basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggerss );

            Console.ReadLine();
        }
    }
}
/////İnterfaceler birbiririnin alternatifi olan ama kod içeriklerini farklı olan durumlar için kullanırıız