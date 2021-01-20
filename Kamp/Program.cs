using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemGirisYapmismi = false;

            double dolardun = 7.35;
            double dolarBugun = 7.45;

            Console.WriteLine(faizorani);
            if (dolardun > dolarBugun)
            {
                Console.WriteLine("dolar artmış");
            }
            else if (dolardun < dolarBugun)
            {
                Console.WriteLine("dolar azalmış");
            }
            else
            {
                Console.WriteLine("dolar değişmedi");
            }

            if (sistemGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
                Console.WriteLine(ogrencisayisi);
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategorietiketi);
        }
    }
}
