using System;

namespace dotnet_C__practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("bir sayı girin:");
            int sayi =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bir sayı girin::"+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı!");
            // }
            try
            {
               // int a=int.Parse(null);    
                //int a=int.Parse("test");    
                int a=int.Parse("-12345678910");    


            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veye çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı!");
            }
        }
    }
}
