using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] enBüyükSayilar = new int[3];
            int[] enKüçükSayilar = new int[3];
            int[] sayilar= new int[20];
    
            System.Console.WriteLine("Enter 20 positive number: ");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    sayilar[i]= Convert.ToInt32(System.Console.ReadLine().Trim()); 
                    if (sayilar[i]<0)
                   {
                       System.Console.WriteLine("!!! Enter a valid positive number !!!");
                       i--;
                       continue;
                   }                 
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                    i--;
                    continue;
                }            
            }
           Array.Sort(sayilar);
           for (int i = 0; i < 3; i++)
           {
               enKüçükSayilar[i] = sayilar[i];
               enBüyükSayilar[i] = sayilar[i+17];    
           }

            int enKüçükTotal=0;
            int enBüyükTotal=0;


             foreach (var item in enBüyükSayilar)
            {
               enBüyükTotal+= item;
            }
            foreach (var item in enKüçükSayilar)
            {
               enKüçükTotal+= item;
            }

            int enKüçükOrt=enKüçükTotal/3;
            int enBüyükOrt=enBüyükTotal/3;
            System.Console.WriteLine($"En Küçük 3 sayı Ortalaması: {enKüçükOrt}");
            System.Console.WriteLine($"En Büyük 3 sayı Ortalaması: {enBüyükOrt}");
            System.Console.WriteLine($"En  Küçük ve  En Büyük 3 sayı Ortalama Toplamı: {(enKüçükOrt)+(enBüyükOrt)}");
        } 
    }
}
