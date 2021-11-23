using System;

namespace Datetime_ve_Math
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(DateTime.Now);
           Console.WriteLine(DateTime.Now.Date);
           Console.WriteLine(DateTime.Now.Day);
           Console.WriteLine(DateTime.Now.Month);
           Console.WriteLine(DateTime.Now.Year);
           Console.WriteLine(DateTime.Now.Hour);
           Console.WriteLine(DateTime.Now.Minute);
           Console.WriteLine(DateTime.Now.Second);

           Console.WriteLine(DateTime.Now.DayOfWeek);
           Console.WriteLine(DateTime.Now.DayOfYear);

           Console.WriteLine(DateTime.Now.ToLongDateString());
           Console.WriteLine(DateTime.Now.ToShortDateString());
           Console.WriteLine(DateTime.Now.ToLongTimeString());
           Console.WriteLine(DateTime.Now.ToShortTimeString());

           Console.WriteLine(DateTime.Now.AddDays(2));
           Console.WriteLine(DateTime.Now.AddHours(3));
           Console.WriteLine(DateTime.Now.AddSeconds(30));
           Console.WriteLine(DateTime.Now.AddMonths(2));
           Console.WriteLine(DateTime.Now.AddYears(3));

           //datetime format

           Console.WriteLine(DateTime.Now.ToString("dd"));// günü sayı olarak getirir
           Console.WriteLine(DateTime.Now.ToString("ddd"));// günü 3 harfli kısaltır  getirir
           Console.WriteLine(DateTime.Now.ToString("dddd"));// günü yazı olarak getirir

           //ay
           Console.WriteLine(DateTime.Now.ToString("MM"));
           Console.WriteLine(DateTime.Now.ToString("MMM"));
           Console.WriteLine(DateTime.Now.ToString("MMMM"));

           //yıl
           Console.WriteLine(DateTime.Now.ToString("yy"));//21
           Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

           //Math kütüphanesi
           Console.WriteLine("*****Math Kütüphanesi*****");
           Console.WriteLine(Math.Abs(-5));// mutlak değer alır +5 döner
           Console.WriteLine(Math.Sin(30));// sinüs alır aynı şekilde cos ve tan da var
           
           Console.WriteLine(Math.Ceiling(5.4));// 6
           Console.WriteLine(Math.Round(30.4));//30
           Console.WriteLine(Math.Round(30.6));//31
           Console.WriteLine(Math.Floor(30.6));//30

           Console.WriteLine(Math.Max(30,4));//30
           Console.WriteLine(Math.Min(30,4));//4

           Console.WriteLine(Math.Pow(2,4)); // 2 üzeri 4
           Console.WriteLine(Math.Sqrt(25)); // karekök sonuc 5
           Console.WriteLine(Math.Log(30)); // 30 UN e tabanındaki karşılığını çıkarır
           Console.WriteLine(Math.Exp(30)); // e üzeri 30 u verir
           Console.WriteLine(Math.Log10(100));// 100 ün log 10 tabanındaki karşılığını verir

        }
    }
}
