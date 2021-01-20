using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            {
                urun1.Adi = "elma";
                urun1.Fiyati = 15;
                urun1.Aciklama = "amasya elması";
            }
            

            Urun urun2 = new Urun();
            {
                urun2.Adi = "karpuz";
                urun2.Fiyati = 80;
                urun2.Aciklama = "diyarbakır karpuzu";
            }
            

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");


            }

            Console.WriteLine("..................Metotlar..........................");
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

            sepet.Ekle2("armut", "yesil armut", 12);
        }
    }
}
