using System;

namespace dotnet_C__practice3
{
    class Program
    {
        static void Main(string[] args)
        {
             //implicit conversion
            byte a=5;
            sbyte b=5;
            short c=5;

            int d=a+b+c;

            long h=d;

            float i=h;
            
            string e= "ahmet";
            char f='k';
            object g=e+f+d+i;

            
             //explicit conversion
            int x=5;
            byte y=(byte)x;

            int z=100;
            byte t=(byte)z;

            float w=10.3f;
            byte v=(byte)w;

            //ToString Method
            int xx=6;
            string yy=xx.ToString();

            string zz= 12.5f.ToString();

            //System.Convert
            string s1="10",s2="20";
            int sayi1,sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);

            toplam =sayi1+sayi2;
            //Parse
            ParseMethod();
        

        }
       public static void ParseMethod()
        {
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);

        }
    }
}
