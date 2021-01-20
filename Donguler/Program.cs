using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlamaya başlamak için temel kurs", "java" };
            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }

            foreach (var Kurs in Kurslar)
            {
                Console.WriteLine(Kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("naber");
        }
    }
}
