using System;

namespace C__HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit=false;
            System.Console.Clear();
            System.Console.WriteLine("****Welcome to Home Work 1****");

            while(!exit)
            {      
                System.Console.Clear();
                System.Console.WriteLine("SELECT:Which Question you want to continue?(To exit: 0)");
                System.Console.WriteLine("  1   2   3   4                Exit: 0  ");
                int qNum=Convert.ToInt32(System.Console.ReadLine().Trim());
                Console.Clear();
                switch (qNum)
                {
                    case 1:
                        Program p1 =new();
                        p1.Q1();                       
                        break;
                    case 2:
                        Program2 p2 =new();
                        p2.Q2();
                        break;
                    case 3:
                        Program3 p3 =new();
                        p3.Q3();
                        break;
                    case 4:
                        Program4 p4 =new();
                        p4.Q4();
                        break;
                   case 0:
                    exit=true;
                     return;
                    default:
                        System.Console.WriteLine("Error: This Question number does not exist. Please Sellect 1,2,3 or 4. If you want to exit sellect 0");
                    break;
                }
                System.Console.WriteLine("Press a key to continue...");
                System.Console.ReadLine();
            }
        }
        void Q1()
        {
            bool isPositive=false;
            int n=0;
        while (!isPositive)
        {
            Console.WriteLine("Write a positive number: ");
             n= Convert.ToInt32(Console.ReadLine().Trim());
            isPositive = n>0 ? true :false;
        }
        System.Console.WriteLine($"Write {n} number");

        int[] nArr=new int[n];
        for (int i = 0; i < n; i++)
        {
            nArr[i] = Convert.ToInt32(Console.ReadLine().Trim());           
        }
        System.Console.WriteLine("Even numbers are:");
        foreach (int num in nArr)
        {
            if(num%2==0)
            System.Console.WriteLine(num);
        }

        }
    }
}
