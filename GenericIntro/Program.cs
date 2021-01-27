using System;
using System.Collections.Generic;

namespace GenericIntro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<int> isimler = new MyList<int>();
            isimler.Add(1);
            isimler.Add(10);

            Console.WriteLine(isimler);



            List<string> meyveler = new List<string>();
            meyveler.Add("armut");
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }
            Console.WriteLine(meyveler);
        }
    }
}
