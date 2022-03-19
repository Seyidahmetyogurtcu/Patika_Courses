using System;
using System.Collections;
using System.Collections.Generic;
namespace dotnet_C__practice17
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList arrayList = new();
            // arrayList.Add("Ali");
            // arrayList.Add(2);
            // arrayList.Add(true);
            // arrayList.Add('a');

            // //içerisindeki verilere erişim
            // foreach (var item in arrayList)
            //     System.Console.WriteLine(item);
            

            //AddRange
            System.Console.WriteLine("******* Add Range ********");
            //string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayilar =new List<int>{1,8,3,7,9,92,5};
            //arrayList.AddRange(renkler);
            arrayList.AddRange(sayilar);
            foreach (var item in arrayList)
                System.Console.WriteLine(item);

            //Sort
            System.Console.WriteLine("******* Sort ********");
            arrayList.Sort(); //to sort you need to have same type in it
             foreach (var item in arrayList)
                System.Console.WriteLine(item);

            System.Console.WriteLine("*********  Binary Seach **********");
            //Binary Search
            System.Console.WriteLine(arrayList.BinarySearch(1));
            System.Console.WriteLine(arrayList.BinarySearch(3));
            System.Console.WriteLine(arrayList.BinarySearch(5));
            System.Console.WriteLine(arrayList.BinarySearch(7));
            System.Console.WriteLine(arrayList.BinarySearch(8));
            System.Console.WriteLine(arrayList.BinarySearch(9));//9 un indexini getiriyor(zero based index:indexler sıfırıncı indexten başlıyor).sort ettikten sonraki hali ile.
            System.Console.WriteLine(arrayList.BinarySearch(92));


            //Reverse
            System.Console.WriteLine("*********   Reverse **********");
            arrayList.Reverse();
              foreach (var item in arrayList)
                System.Console.WriteLine(item);

            //Clear
            System.Console.WriteLine("*********   Reverse **********");
            arrayList.Clear();
            foreach (var item in arrayList)
                System.Console.WriteLine(item);
        }
    }
}
