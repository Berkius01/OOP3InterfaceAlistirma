using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICredictManager ihtiyaçKredi = new IhtiyaçKrediManager();
            ICredictManager taşıtKredi = new TaşıtKrediManager();
            ICredictManager konutKredi = new KonutKrediManager();

            ILoggerService databaseLogger = new DataBaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();

            BaşvuruManager başvuruManager = new BaşvuruManager();
            başvuruManager.BaşvuruYap(new EsnafKrediManager(), new SmsLoggerService()); //tek kredi hesabı

            List<ICredictManager> krediler = new List<ICredictManager>() { ihtiyaçKredi,taşıtKredi};
            //başvuruManager.KrediOnBilgilendirme(krediler); // birden fazla kredi hesabı
        }
    }
}
