using System;

namespace dotnet_C__practice10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi= {55,13,15,35,45,98,3,5,78,12};
            Console.WriteLine("****Sırasız  dizi******");
            foreach (var sayı in dizi)
            {
                Console.WriteLine(sayı);              
            }

            Console.WriteLine("\n*****Sıralı dizi******");
            Array.Sort(dizi);
            foreach (var sayı in dizi)
            {
                Console.WriteLine(sayı);                    
            }


            Console.WriteLine("\n*****Array clear******");
            //dizi dizisini kullanarak 2. elemandan itbaren 2 elemanın değerini sıfır yap
            Array.Clear(dizi,2,2);
            foreach (var sayı in dizi)
            {
                Console.WriteLine(sayı);                       
            }


            Console.WriteLine("\n*****Array Reverse******");
            Array.Reverse(dizi);
            foreach (var sayı in dizi)
            {
                Console.WriteLine(sayı);                             
            }


            Console.WriteLine("\n*****Array IndexOf******");
            Console.WriteLine(Array.IndexOf(dizi,15));              
            

            Console.WriteLine("\n*****Array Resize ******");
            Array.Resize<int>(ref dizi,11);
            dizi[10]=121;
            foreach (var sayı in dizi)
            {
                Console.WriteLine(sayı);              
            }
        }
    }
}
