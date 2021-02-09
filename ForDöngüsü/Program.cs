using System;

namespace ForDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {


            // for döngüsü 3 paremetre alır 1-başlangıç,2-bitiş ve 3-artış miktarı
            //1.alternatif yazım
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Hello");
            //}
            //2.alternatif yazım
            //int a;
            //for(a=1;a<=10; a++)
            //{
            //    Console.WriteLine("Hello World");
            //}


            // 1'den n 'e kadar olan sayıları toplama
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i;               
            //}
            //Console.WriteLine("Toplam=" + toplam);


            // Çift sayıları toplama

            int toplam1 = 0;
            for (int b = 0; b <= 10; b+=2)
            {
                toplam1 = toplam1 + b;
            }
            Console.WriteLine( "Toplam="+toplam1);
        }
    }
}
