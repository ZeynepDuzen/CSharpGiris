using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello world");

            int number1 = 10;
            //Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number1 is : " + number1);

            int minIntDegeri = int.MinValue;
            int maxIntDegeri = int.MaxValue;
            Console.WriteLine("int min deger : " + int.MinValue);
            Console.WriteLine("int max deger : " + int.MaxValue);

            long minValue = long.MinValue;
            long maxValue = long.MaxValue;
            Console.WriteLine("long min value : " + long.MinValue);
            Console.WriteLine("long max value : " + long.MaxValue);

            short minShortDegeri = short.MinValue;
            short maxShortDegeri = short.MaxValue;
            Console.WriteLine("short min deger : " + short.MinValue);
            Console.WriteLine("short max deger : " + short.MaxValue);

            byte minByteDegeri = byte.MinValue;
            byte maxByteDegeri = byte.MaxValue;
            Console.WriteLine("byte min deger : " + byte.MinValue);
            Console.WriteLine("byte max deger  : " + byte.MaxValue);

            char karakter = 'b';
            //Console.WriteLine("karakter : {0}", karakter);
            Console.WriteLine("karakter : " +karakter);

            //char veri tipine assign ettigimiz degeri int veri tipine donusturebiliriz:
            Console.WriteLine("karakterin sayisal karsiligi : " + (int)karakter);

            double doubleSayi2 = 25.4;
            Console.WriteLine("double ondalikli sayi ornegi : " + doubleSayi2);

            Console.WriteLine(Days.Wednesday);
            Console.WriteLine((int)Days.Wednesday);

            var num1 = 10;
            Console.WriteLine("num1 : " + num1); //var degiskeni bir int deger tutuyor
            var isim = "zeynep";
            Console.WriteLine("isim : " + isim); //var degiskeni bir string deger tutuyor
                 

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
