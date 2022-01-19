using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "AhmetCan";
            musteri1.Soyad = "Comlek";
            musteri1.TcNo = "12345678910";
            musteri1.Sehir = "Manisa";
            musteri1.Eposta = "ahmetcan@gmail.com";
            musteri1.Adres = "Adres Ahmetcan";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Caner";
            musteri2.Soyad = "Comlek";
            musteri2.TcNo = "01234678910";
            musteri2.Sehir = "İstanbul";
            musteri2.Eposta = "caner@gmail.com";
            musteri2.Adres = "Adres Caner";

            MusteriManager musteriIslem = new MusteriManager();
            musteriIslem.MusteriEkleme(musteri1);
            musteriIslem.MusteriSilme(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriIslem.MusteriListeleme(musteriler);
        }
    }
}
