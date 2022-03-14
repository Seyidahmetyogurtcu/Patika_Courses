using System;

namespace dotnet_C__practice12
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";
            int outSayi;
            bool sunuc = int.TryParse(sayi,out outSayi);//string değer doğru olmayabilir, cevirip çeviremedeiğini kontrol ediyoruz.

            if(sunuc)
            {
                System.Console.WriteLine("Başarili!");                
                System.Console.WriteLine(outSayi);            
            }
            else
            {
                System.Console.WriteLine("Başarisiz!");
            }

            Methodlar instance =new Methodlar();
            instance.Topla(4,5,out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

        //Methodlar aşırı yüklenme Overloading
        int ifade=999;
        instance.EkranaYazdır(Convert.ToString(ifade));
        instance.EkranaYazdır(ifade);
        instance.EkranaYazdır("seyid","ahmet");

    //Method imzası: MethodAdı+parametre sayısı+parametre
        }
    }
    class Methodlar
    {
        public void Topla(int a,int b, out int toplam)
        {
            toplam=a+b;
        }
                
        public void EkranaYazdır(string veri)
        {
           System.Console.WriteLine(veri);
        }             
         public void EkranaYazdır(string veri,string veri2)
        {
           System.Console.WriteLine(veri+" "+ veri2);
        }      
        public void EkranaYazdır(int veri)
        {
          System.Console.WriteLine(veri);
        }       
    }
}
