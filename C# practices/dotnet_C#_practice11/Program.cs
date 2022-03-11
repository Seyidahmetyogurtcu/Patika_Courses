using System;
using System.Collections.Generic;
using System.Linq;
namespace dotnet_C__practice11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2;
            int b=3;

            //statik bir class içerisinden sadece statik değerler erişilebilir.
            int sonuc =Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek =new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 =ornek.ArttırVeTopla(ref a,ref b);
            Console.WriteLine(sonuc);

        }
         static int Topla(int deger1, int deger2)
        {
            return deger1+deger2;
        }
    }

    class Metotlar
    {    
        public void EkranaYazdır(string veri)
        {   
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
