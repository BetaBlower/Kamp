using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] meyveler = { "Elma", "Muz", "Armut", "Vişne" };

            //Console.WriteLine(meyveler[0]);
            //Console.WriteLine(meyveler[1]);
            //Console.WriteLine(meyveler[2]);
            //Console.WriteLine(meyveler[3]);
            
            List<string> meyveler2 = new List<string> {"Elma","Muz","Armut","Vişne" };

            Console.WriteLine(meyveler2[0]);
            Console.WriteLine(meyveler2[1]);
            Console.WriteLine(meyveler2[2]);
            Console.WriteLine(meyveler2[3]);
            meyveler2.Add("Kayısı");
            Console.WriteLine(meyveler2[4]);


        }
    }
}
