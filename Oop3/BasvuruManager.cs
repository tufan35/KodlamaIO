using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //Burada Method İnjections yapıyoruz  tek bir servise göndermek için böyle yazarız
        //public void basvuruYap(IKrediManager krediManager, ILoggerService loggerService) //Buradaki verdiğimiz parametre Ikredimanagerdaki tutulan tğm kredileri buradan seçebilr !!! Önemliiiiii!!!!
        
        //Birden fazla servise göndreceğimizde
        public void basvuruYap(IKrediManager krediManager, List<ILoggerService >loggerService)
        {
            //Basvuru bilgilerini değerlendirme


         
            krediManager.Hesapla();
            foreach (var logs in loggerService)
            {
                logs.Log();

            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggerService)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
               
                   
            }
            foreach (var kayit in loggerService)
            {
                kayit.logs();
            }
        }

    }
}
