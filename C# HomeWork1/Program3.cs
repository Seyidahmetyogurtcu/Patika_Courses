using System;

namespace C__HomeWork
{
    class Program3
    {
        public void Q3()
        {
            bool isPositive=false;
            int n=0;
            while (!isPositive)
            {
                Console.WriteLine("Write a positive number");
                 n =Convert.ToInt32(Console.ReadLine().Trim());

                isPositive = n > 0  ? true :false;
            }
            System.Console.WriteLine($"Write {n} different number");

            int[] nArr=new int[n];
            for (int i = 0; i < n; i++)
            {
                nArr[i] = Convert.ToInt32(Console.ReadLine().Trim());           
            }
            System.Console.WriteLine("Numbers are reversed:");
            for (int i = n - 1; i >= 0 ; i--)
            {
                System.Console.WriteLine(nArr[i]);
            }
        }
    }
}