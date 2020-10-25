using System;

namespace Uygulama_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("1.Sayıyı Girin");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Girin");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.Write("Sayılar birbirine eşit " + a + " = " + b);
            }
            else
            {
                if (a > b)
                {
                    Console.Write("Büyük olan sayı = " + a);
                }
                else
                {
                    Console.Write("Büyük olan sayı = " + b);
                }
            }
            Console.ReadKey();
        }
    }
}
