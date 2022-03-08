using System;

namespace ConsolePratik1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            byte b=5; //1 byte
            sbyte sb=5;//1 byte

            short s=5;//2 byte
            ushort us=5;//2 byte


            Int16 i16=5;//2 byte
            int i=5;//4 byte
            Int32 i32=5;//4 byte
            Int64 i64=5;//8 byte

            uint ui=5;//4 byte
            long l=5;//8 byte
            ulong ul=5;//8 byte

            float f=5.0f;//4 byte
            double d=5.0f;//8 byte
            decimal de=5;//16 byte

            bool condition=true;


            char ch='a'; // 2byte
            string str="yazı"; //infinite

            DateTime dt=DateTime.Now;

            object sayi=5;
            object yazı="Ali";

           // int cevir = Convert.ToInt32(str);;

            string isim =Console.ReadLine();
            Console.WriteLine("Merhaba "+isim+" bu benim test yazım.");
            Console.ReadLine();



        }
    }
}
