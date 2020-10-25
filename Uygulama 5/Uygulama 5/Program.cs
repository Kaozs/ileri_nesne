using System;

namespace Uygulama_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, i;
            Console.WriteLine("Çarpmayı toplayarak yapan program\n");
            Console.Write("1. Sayıyı Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n2. Sayıyı Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= b; i++)
            {
                    c += a ;
            }
            Console.WriteLine("\n" + c);
        }
    }
}
