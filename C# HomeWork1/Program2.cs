using System;

namespace C__HomeWork
{
    class Program2
    {
        public void Q2()
        {
            bool isPositive=false;
            int n=0;
            int m=0;
            while (!isPositive)
            {
                Console.WriteLine("Write a positive number");
                 n =Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine("Write another positive number");
                 m =Convert.ToInt32(Console.ReadLine().Trim());
                isPositive = n > 0 && m>0 ? true :false;
            }
            System.Console.WriteLine($"Write {n} different number");

            int[] nArr=new int[n];
            for (int i = 0; i < n; i++)
            {
                nArr[i] = Convert.ToInt32(Console.ReadLine().Trim());           
            }
            for (int i = 0; i < n; i++)
            {
                if (nArr[i]%m==0)
                {
                    System.Console.WriteLine($"{nArr[i]} can divided by {m}");
                }
            }
        }
    }
}