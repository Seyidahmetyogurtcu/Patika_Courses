using System;

namespace dotnet_C__practice13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekülsif -Öz yinelemeli
            int result =1;
            for(int i=1;i<5;i++)
            {
                result=result*3;
            }
        Islemler instance =new();
        System.Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar
        string ifade = "Seyid Ahmet Yoğurtcu";
        bool sonuc =ifade.CheckSpaces();
        System.Console.WriteLine(sonuc);
        if(sonuc)
            System.Console.WriteLine(ifade.RemoveWhiteSpaces());
        System.Console.WriteLine(ifade.MAkeUpperCase());
        System.Console.WriteLine(ifade.MAkeLowerCase());

        int[] dizi ={1,9,2,3,8,5,2,3,5,6,7,7,2,3,85,4,1,0};
        dizi.SortArray();
        dizi.WriteToScene();

        int sayi= 5;
        System.Console.WriteLine(sayi.IsEvenNumber());

        System.Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4);
        //Expo(3,3) * 3;
        //Expo(3,2)*3 *3;
        //Expo(3-1)*3*3 *3;
        //3*3*3*3 = 3^4;

    }

    public static class Extension
    {
        //input veri tipi ne ise, extention o tip için yazılmış demektir
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");//bu stringi boşluklarından ayır ve herbirini diziye at.
            return string.Join("*",dizi);//this chance " " to "" .
        }
        public static string MAkeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MAkeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void WriteToScene(this int[] param)
        {
            foreach (int item in param)
                System.Console.WriteLine(item); 
        }

        public static bool IsEvenNumber(this int param)
        {
            return param ==0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
