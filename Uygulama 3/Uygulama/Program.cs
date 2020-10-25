using System;

namespace Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, f, o;
            Console.Write("Vize Notunuzu Giriniz: ");
            v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunuzu Giriniz: ");
            f = Convert.ToDouble(Console.ReadLine());
            o = (v * 0.4) + (f * 0.6);
            Console.WriteLine("Ortalamanız: " + o);
            Console.ReadKey();
        }
    }
}
