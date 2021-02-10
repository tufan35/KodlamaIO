using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Gönderildi");
        }

        public void logs()
        {
            Console.WriteLine("Yedek Sms Veritabanına Loglandı");
        }
    }
}
