using System;

namespace dotnet_C__practice9
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler= new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi =new int[5];


            //diziler değer atama
            renkler[0]= "mavi";
            Console.WriteLine(hayvanlar[1]);

            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngüler dizi kullanımı
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi= new int[diziUzunlugu];
            for(int i=0;i<diziUzunlugu;i++)
            {
                Console.WriteLine("Lütfen {0}",i+1);
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+=sayi;
            }
            Console.WriteLine("Ortalama " + toplam/diziUzunlugu);
        }
    }
}
