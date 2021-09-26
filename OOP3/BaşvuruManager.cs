using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BaşvuruManager
    {
        //tek hesab 
        public void BaşvuruYap(ICredictManager krediManager,ILoggerService loggerService)
        {
            krediManager.Calculate();
            loggerService.Log();
        }

        //liste hesabı
        public void KrediOnBilgilendirme(List<ICredictManager> krediler, ILoggerService loggerService)
        {
            foreach(ICredictManager kredi in krediler)
            {
                kredi.Calculate();
                loggerService.Log();
            }
        }
    }
}
