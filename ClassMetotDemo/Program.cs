using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("---------------");

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdSoyad = "Ahmet Kalkan";
            musteri1.MusteriTcNo = 123456786;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdSoyad = "Mehmet Yılmaz";
            musteri2.MusteriTcNo = 420456798;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdSoyad = "Melis Temel";
            musteri3.MusteriTcNo = 801466782;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.MusteriId);
                Console.WriteLine("Müşteri Adı-Soyadı: " + musteri.MusteriAdSoyad);
                Console.WriteLine("Müşteri TC No: " + musteri.MusteriTcNo);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("Müşteri İşlemleri");
            Console.WriteLine("-----------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri1);


        }   
    }
}
