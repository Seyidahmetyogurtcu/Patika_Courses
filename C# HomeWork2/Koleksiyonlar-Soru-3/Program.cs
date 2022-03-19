using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.Clear();
            char[] sesliHarfler={'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
            System.Console.WriteLine("BİR CÜMLER GİRİNİZ: ");
            string cümle = System.Console.ReadLine();
            char[] cümledekiSesliHarfler= new char[cümle.Length];
            int index=0;
            foreach (var item in sesliHarfler)
            {
                if (cümle.Contains(item))
                {
                   cümledekiSesliHarfler[index]=item;
                   index++;
                }              
            }
            Array.Sort(cümledekiSesliHarfler);
            Array.Reverse(cümledekiSesliHarfler);
            for (int i=0;i<index;i++)
            {
                System.Console.WriteLine(cümledekiSesliHarfler[i]);
            }
        }
    }
}
