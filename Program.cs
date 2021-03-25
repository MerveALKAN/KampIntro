using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            //IhtiyacKrediManager,TasitKrediManager,KonutKrediManager yerine IKrediManager kullansaydık bile aynı sonuç gelirdi.
            //Çünkü interfacelerde o interfaceyi implement eden classın referans numarasını tutabiliyor.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        // interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        
        }



    }
}
