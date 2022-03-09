using System;

namespace dotnet_C__practice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı girin: ");
            int sayi =int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            char character='a';
            while (character<='z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] arabalar={"BMV","Mercedes","Ford"};
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
