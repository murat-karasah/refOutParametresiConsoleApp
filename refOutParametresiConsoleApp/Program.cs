using System;

namespace refOutParametresiConsoleApp
{
    class Program
    {
       // static int s1 = 0;

        static void Main(string[] args)
        {
            //Sayının Karesi ve küp alma
            int x = 5, c;
            Console.WriteLine("Sayı : "+x);
            Console.WriteLine("Sayının karesi : "+kare(x,out c) );
            Console.WriteLine("Sayının küpü : "+c);
            //Sayının Karesi ve küp alma son

            //Metinlerin En uzun olanını ve karakter sayısını bulma 
            //string metMax;
            //Console.WriteLine("Lütfen Bir Metin1 Giriniz:");
            //string metin1 = Console.ReadLine();
            //Console.WriteLine("Lütfen Bir Metin2 Giriniz:");
            //string metin2 = Console.ReadLine();
            //metinhesapla(metin1, metin2, out metMax,out s1);
            //Console.WriteLine($"Metinlerin en büyüğü {metMax} {s1}");
            //Metinlerin En uzun olanını ve karakter sayısını bulma Son


            //Sayıların En büyüğünü ve En küçüğünü Bulma
            //int a = 50, b = 40, max,min;
            //buyukgetir(a,b, out max);
            //kucukgetir(a, b, out min);
            //Console.WriteLine($"Sayıların en büyüğü {max},Sayıların en küçüğü {min}");
            //Sayıların En büyüğünü ve En küçüğünü Bulma Son



        }
        //Sayının Karesi ve küp alma
        private static int kare(int a,out int y)
        {
            int k;
            k = a * a;
            y = a * a * a;
            return k;
        }
        //Sayının Karesi ve küp alma son


        //Metinlerin En uzun olanını ve karakter sayısını bulma Başlangıç
        //private static void metinhesapla(string metin1, string metin2, out string metMax, out int s1)
        //{

        //    if (metin1.Length>metin2.Length)
        //    {
        //        metMax = metin1;
        //        s1 = metin1.Length;
        //    }
        //    else
        //    {
        //        metMax = metin2;
        //        s1 = metin2.Length;
        //    }
        //    }
        //Metinlerin En uzun olanını ve karakter sayısını bulma Son


        //Sayıların En büyüğünü ve En küçüğünü Bulma Başlangıç
        //private static void kucukgetir(int a, int b, out int min)
        //{
        //    if (a < b)
        //    {
        //        min = a;
        //    }
        //    else
        //    {
        //        min = b;
        //    }
        //}
        //private static void buyukgetir(int a, int b, out int max)
        //{
        //    if (a>b)
        //    {
        //        max = a;
        //    }
        //    else
        //    {
        //        max = b;
        //    }
        //}
        //Sayıların En büyüğünü ve En küçüğünü Bulma Son

    }
}
