using System;

namespace Uygulama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i,j;
            Console.WriteLine("--------------Çarpım Tablosunu Açtınız--------------\n");
            for(i=1;i <=10; i++)
            {
               for(j = 1; j <= 10; j++)
                {
                   a = i * j;
                   Console.Write("{0}*{1}={2}\t", j, i, a);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
