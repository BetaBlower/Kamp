using System;

namespace Odevler
{
    public enum Renk { kırmızı, yeşil, mavi }
    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Odevler
        {
            /// <summary>
            /// veri türleri nelerdir
            /// </summary>
            public static void Odev2_1()
            {
                byte a = 100; // uzunluğu 1 byte 0 ile 255 arasında
                Console.WriteLine("byte a = {0}; // uzunluğu 1 byte 0 ile 255 arasında\n", a);

                sbyte b = -1; // uzunluğu 1 byte -128 ile 127 arasında
                Console.WriteLine("sbyte b = {0}; // uzunluğu 1 byte -128 ile 127 arasında\n", b);

                short c = -32000; // uzunluğu 2 byte -32768 ile 32767 arasında yer alır
                Console.WriteLine("short c = {0}; // uzunluğu 2 byte -32768 ile 32767 arasında yer alır\n", c);

                ushort d = 65000; // uzunluğu 2 byte 0 ile 65535 arasında
                Console.WriteLine("ushort d = {0}; // uzunluğu 2 byte 0 ile 65535 arasında\n", d);

                int e = -2000000000; // uzunluğu 4 byte -2.147.483.648 ile 2.147.483.648 arasında
                Console.WriteLine("int e = {0}; // uzunluğu 4 byte -2.147.483.648 ile 2.147.483.648 arasında\n", e);

                uint f = 4000000000; // uzunluğu 4 byte  0 ile 4.294.967.295 arasında 
                Console.WriteLine("uint f = {0}; // uzunluğu 4 byte  0 ile 4.294.967.295 arasında \n", f);

                long g = -1000000000000; // uzunluğu 8 byte -10 üzeri20 ile 10 üzeri20 arasında
                Console.WriteLine("long g = {0}; // uzunluğu 8 byte -10 üzeri20 ile 10 üzeri20 arasında \n", g);

                ulong h = 1000000000000; // Uzunluğu 8 byte 0 ile 2 x 10 üzeri 20 arasında
                Console.WriteLine("ulong h = {0}; //Uzunluğu 8 byte 0 ile 2 x 10 üzeri 20 arasında\n", h);

                float i = 10.2F; // Uzunluğu 4 byte 1.5 x 10üzeri-45 ile 3.4 x 10üzeri38 arasında 
                Console.WriteLine("float i = {0}; // Uzunluğu 4 byte 1.5 x 10üzeri-45 ile 3.4 x 10üzeri38 arasında \n", i);

                double I = 1901.11; // Uzunluğu 8 byte 5.0 x 10 üzeri -324 ile 1.7 x 10 üzeri 308 arasında 
                Console.WriteLine("double I = {0}; // Uzunluğu 8 byte 5.0 x 10 üzeri -324 ile 1.7 x 10 üzeri 308 arasında\n", I);

                //demical Uzunluğu 12 byte ±1.0 x 10 üzeri-28 ile ±7.9 x 10 üzeri 28 arasında
                Console.WriteLine("decimal J; // Uzunluğu 12 byte ±1.0 x 10 üzeri-28 ile ±7.9 x 10 üzeri 28 arasında\n");

                char K = '$'; // Uzunluğu 2 byte Bütün ınicode karakterleri kapsar
                Console.WriteLine("char K = {0}; // Uzunluğu 2 byte Bütün ınicode karakterleri kapsar\n",K);

                string L = "Yazı alanı"; // Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır
                Console.WriteLine("string L = {0}; // Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır\n",L);

                bool M = true; // uzunluğu 1 byte True – false değer tutan tiptir.
                Console.WriteLine("bool M = {0}; // uzunluğu 1 byte True – false değer tutan tiptir.",M);



            }
            /// <summary>
            /// ternary (koşul) operatörü nedir 
            /// </summary>
            public static void Odev2_2()
            {
                Console.WriteLine("bir sayı değeri girin");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} değeri {1} bir sayıdır", a, a > 0 ? "pozitif" : "negatif");
            }
            /// <summary>
            /// switch-case şart blokları nasıl çalışır
            /// </summary>
            public static void Odev2_3()
            {
                Renk c = (Renk)(new Random().Next(0, 2));
                switch (c)
                {
                    case Renk.kırmızı:
                        Console.WriteLine("renk kırmızı");
                        break;
                    case Renk.yeşil:
                        Console.WriteLine("renk yeşil");
                        break;
                    case Renk.mavi:
                        Console.WriteLine("renk mavi");
                        break;
                    default:
                        break;
                }
            }
            /// <summary>
            /// While döngüsü
            /// </summary>
            public static void Odev2_4()
            {
                Console.WriteLine("teker teker sayıları yazdırır bir sayı seçin");
                int a = 0;
                int b = Convert.ToInt32(Console.ReadLine());
                while (a < b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }


        }
    }
}
