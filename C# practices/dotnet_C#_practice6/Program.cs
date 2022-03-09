using System;

namespace dotnet_C__practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak");
                    break;
                case 2:
                Console.WriteLine("Şubat");
                    break;
                case 4:
                Console.WriteLine("Nisan");
                    break;     
                case 3:
                Console.WriteLine("Mart");
                    break;                
                default:
                Console.WriteLine("Yanlış veri girişi");
                    break;
            }
                Console.WriteLine(" ayındasınız!");

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Kış ayındasınız");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("ilkbahar ayındasınız");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("yaz ayındasınız");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("sonbahar ayındasınız");
                        break;                    
                    
                    default:
                        break;
                }

        }
    }
}
