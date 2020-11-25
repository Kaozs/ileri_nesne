using System;

namespace Dikdörtgen_alan_ve_cevre_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double uzun, kısa;
            Dikdörtgen hesap = new Dikdörtgen();
            Console.Write("Uzun Kenarı Giriniz: ");
            uzun = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kısa Kenarı Giriniz: ");
            kısa = Convert.ToDouble(Console.ReadLine());
            hesap.Alanheaspla(uzun,kısa);
            hesap.Cevreheaspla(uzun, kısa);
        }
    }
    class Dikdörtgen
    {
        double h, b;
        public void Alanheaspla(double u,double k)
        {
            h = u * k;
            Console.WriteLine("Alanı: " + h);
        }
        public void Cevreheaspla(double u, double k)
        {
            b = (u + k) * 2 ;
            Console.WriteLine("Çevresi: " + b);
        }
    }
}
