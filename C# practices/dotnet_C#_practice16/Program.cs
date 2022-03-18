using System;
using System.Collections.Generic;
namespace dotnet_C__practice16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new();
            sayiListesi.Add(5);
            sayiListesi.Add(4);
            sayiListesi.Add(3);
            sayiListesi.Add(12);
            sayiListesi.Add(8);
            sayiListesi.Add(9);
            sayiListesi.Add(7);
            sayiListesi.Add(1);
            sayiListesi.Add(0);
            sayiListesi.Add(55);
            sayiListesi.Add(54);
            sayiListesi.Add(32);
            sayiListesi.Add(52);

            List<string> renkListesi = new();
            renkListesi.Add("siyah");
            renkListesi.Add("kırmızı");
            renkListesi.Add("mor");
            renkListesi.Add("yeşil");
            renkListesi.Add("mavi");


            //count
            System.Console.WriteLine(renkListesi.Count);         
            System.Console.WriteLine(sayiListesi.Count);
            
            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(renkListesi);         
            }
            foreach (var item in sayiListesi)
            {              
                System.Console.WriteLine(sayiListesi);
            }

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(54);
            renkListesi.Remove("mavi");

            sayiListesi.RemoveAt(4);
            renkListesi.RemoveAt(2);


            //Liste içerisinde Arama
            if(sayiListesi.Contains(99))
                System.Console.WriteLine("99 liste içinde bulundu");
            
            //Eleman ile index erişme
            System.Console.WriteLine(renkListesi.BinarySearch("yeşil"));


            //Diziyi listeye çecirme
            string[] hayvanlar = {"kedi","köpek", "ari"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear();


            //List içerisinde nesne tutmak
            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();            

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="ahmet";

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Fatih";

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);
            
            List<Kullanicilar> yeniListe = new();
            yeniListe.Add(new Kullanicilar(){Isim="Mehmet",Soyisim="AliErbil"});

            foreach (Kullanicilar kullanici in kullanicilarListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı: "+ kullanici.Isim);
                System.Console.WriteLine("Kullanıcı SoyAdı: "+ kullanici.Soyisim);
                System.Console.WriteLine("Kullanıcı yaşı: "+ kullanici.Yas);
            }

            //yeniListe.Clear();
        }

        public class Kullanicilar 
        {
            
            string isim;
            string soyisim;
            int yas;    

            public string Isim { get; set; }
            public string Soyisim { get;  set; }
            public int Yas { get;  set; }
        }
    }
}
