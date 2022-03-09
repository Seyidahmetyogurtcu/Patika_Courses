using System;

namespace dotnet_C__practice7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz: ");
            int sayac =int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {           
            Console.WriteLine(i);
            }

            int tekToplam=0;
            int çiftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam+=1;
                }
                else
                {
                    çiftToplam+=1;
                }
            }
            Console.WriteLine("Tek toplam: "+tekToplam);
            Console.WriteLine("Çift toplam: "+çiftToplam);
            for (int j = 0; j < 10; j++)
            {            
                for (int i = 0; i < 10; i++)
                {
                    if (i==4)
                    {
                        continue;
                    }
                    if (j==2&& i==5)
                    {
                        break;
                    }
                Console.WriteLine(i);
                }
                Console.WriteLine(j);
            }
        }
    }
}
