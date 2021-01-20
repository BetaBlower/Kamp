using System;

namespace ClassGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "engin demirog";
            kurs1.IzlenmeOrani = 68;
            kurs1.EgitmenYasi = 28;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "php";
            kurs2.EgitmenAdi = "ali";
            kurs2.IzlenmeOrani = 40;
            kurs2.EgitmenYasi = 26;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.EgitmenAdi = "emre";
            kurs3.EgitmenYasi = 20;
            kurs3.IzlenmeOrani = 50;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs adı = {0}\nEğitmen Adı = {1}\nEğitmen Yaşı = {2}\nizlenme oranı = {3}\n",kurs.KursAdi,kurs.EgitmenAdi,kurs.EgitmenYasi,kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int IzlenmeOrani { get; set; }
        public int EgitmenYasi { get; set; }
       
    }
}
