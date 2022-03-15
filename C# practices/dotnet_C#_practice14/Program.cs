using System;

namespace dotnet_C__practice14
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken ="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 ="Dersimiz CSharp!";

            //Length;
            System.Console.WriteLine("Length");
            System.Console.WriteLine(degisken.Length);      

            //ToUpper , ToLower
            System.Console.WriteLine("ToUpper , ToLower");
            System.Console.WriteLine(degisken.ToUpper());      
            System.Console.WriteLine(degisken.ToLower());

            //Concat
            System.Console.WriteLine("Concat");
            System.Console.WriteLine(string.Concat(degisken,"Merhaba")); 

            //Compare ,CompareTo    
            System.Console.WriteLine("Compare ,CompareTo");
            System.Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1 if first variable equal to second 0, has much more character numb 1 ,has less character number -1 will be output.
            System.Console.WriteLine(string.Compare(degisken,degisken2,true));//true means upper lower case is important
            System.Console.WriteLine(string.Compare(degisken,degisken2,false));//true means upper lower case is important

            //Contains
            System.Console.WriteLine("Contains");
            System.Console.WriteLine(degisken.Contains(degisken2));
            System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            System.Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            System.Console.WriteLine("IndexOf");
            System.Console.WriteLine(degisken.IndexOf("CS"));//gives the first letters index, so index of "C". If no answer, output is -1
            System.Console.WriteLine(degisken.LastIndexOf("i"));
            

            //Insert
            System.Console.WriteLine("Insert");
            System.Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //Padleft,PadRight
            System.Console.WriteLine("Padleft,PadRight");
            System.Console.WriteLine(degisken+degisken2.PadLeft(30));
            System.Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            System.Console.WriteLine(degisken.PadRight(50)+degisken2);
            System.Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            System.Console.WriteLine("Remove");
            System.Console.WriteLine(degisken.Remove(10));//remove 10. index and larger
            System.Console.WriteLine(degisken.Remove(5,3));
            System.Console.WriteLine(degisken.Remove(0,1));

            //Replace
            System.Console.WriteLine("Replace");
            System.Console.WriteLine(degisken.Replace("Csharp","C#"));
            System.Console.WriteLine(degisken.Replace(" ","*"));


            //Split
            System.Console.WriteLine("Split");
            System.Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            System.Console.WriteLine("Substring");
            System.Console.WriteLine(degisken.Substring(4));
            System.Console.WriteLine(degisken.Substring(4,6));



        }
    }
}
