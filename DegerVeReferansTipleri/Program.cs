using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int Sayi1 = 10;
            int Sayi2 = 30;
            Sayi1 = Sayi2;
            Sayi2 = 65;


            int[] Sayilar1 = new int[] { 10, 20, 30 };
            int[] Sayilar2 = new int[] { 100, 200, 300 };
            Sayilar2[0] = 999;

        }
    }
}