using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();
            IloggerService dataBaseLoggerService = new DataBaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager,fileLoggerService);

            Console.WriteLine("");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,taşıtKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
        

       
    }
}
