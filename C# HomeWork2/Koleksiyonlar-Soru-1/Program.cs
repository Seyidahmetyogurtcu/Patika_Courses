using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ArrayList asalSayilar = new();
            ArrayList asalOlmayanSayilar = new();
    
            System.Console.WriteLine("Enter 20 positive number: ");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    bool asalMı=true;
                    int? sayi= Convert.ToInt32(System.Console.ReadLine().Trim()); 
                    if (sayi<0 && sayi!=null)
                   {
                    System.Console.WriteLine("invalid character");
                       System.Console.WriteLine("!!! Enter a valid positive number !!!");
                       i--;
                       continue;
                   }

                    for (int j = 2; j < sayi/2; j++)
                    {
                        if (sayi<2 || sayi % j == 0 )
                        {
                            asalOlmayanSayilar.Add(sayi);
                            asalMı=false;
                            break;
                        }
                    } 
                    if(asalMı)   
                        asalSayilar.Add(sayi);                   
                }
 

                catch (System.Exception e)
                {                   
                    System.Console.WriteLine(e);
                    i--;
                    continue;
                }                          
            }

            asalOlmayanSayilar.Sort();
            asalSayilar.Sort();

            System.Console.WriteLine("AsalOlmayanSayilar:");
            foreach (var item in asalOlmayanSayilar)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("AsalSayilar:");
            foreach (var item in asalSayilar)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine($"AsalOlmayanSayilar eleman sayısı: {asalOlmayanSayilar.Count}");
            System.Console.WriteLine($"AsalSayilar eleman sayısı: {asalSayilar.Count}");

        }
    }
}
