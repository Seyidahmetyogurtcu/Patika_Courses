using System;

namespace C__HomeWork
{
    public class Program4
    {
        public void Q4()
        {
            bool isSentence=false;
            string sentence="";
            while (!isSentence)
            {    
                try
                {
                    Console.WriteLine("Write a sentence.");
                    sentence =Console.ReadLine();
                    isSentence= sentence!=null ? true:false;
                }
                catch (System.TypeLoadException e)
                {
                    System.Console.WriteLine(e);
                    System.Console.WriteLine("Write \"sentences\".");
                }
            }
            string[] words= sentence.Split(" ");
            string newSentence = string.Join("",words);
            char[] letter =  newSentence.ToCharArray();
            System.Console.WriteLine($"Your total word number is {words.Length}.");
            System.Console.WriteLine($"Your total letter number is {letter.Length}.");          
        }
    }
}