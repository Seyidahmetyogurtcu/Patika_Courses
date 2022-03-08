using System;

namespace dotnet_C__practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve işlemli atama oparatörleri !");
            int x =3;
            int y =3;

            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //mantıksal oparatörler
            Console.WriteLine("\nMantıksal atama oparatörleri !");

            bool isSuccess= true;
            bool isCompleted= true;
            if(isSuccess && isCompleted)
              Console.Write("Perfect!");
            if(isSuccess || isCompleted)
              Console.Write("Great!");           
             if(isSuccess && !isCompleted)
              Console.Write("Fine");

              //ilişkisel operatörler
            Console.WriteLine("\nilişkisel atama oparatörleri !");
              
              int a=3;
              int b=4;
              bool sonuç=a<b;
              Console.Write(sonuç);
              sonuç=a<b;
              Console.Write(sonuç);
              sonuç=a>b;
              Console.Write(sonuç);
              sonuç=a<=b;            
              Console.Write(sonuç);
              sonuç=a>=b;
              Console.Write(sonuç);
              sonuç=a==b;
              Console.Write(sonuç);
              sonuç=a!=b;
            Console.WriteLine("\nAritmatik atama oparatörleri !");
            int i=3+5*2-1;
              Console.Write(i);

        }
    }
}
