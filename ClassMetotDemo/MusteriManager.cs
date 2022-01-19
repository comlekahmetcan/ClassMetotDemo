using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.TcNo + " " + musteri.Sehir + " " + musteri.Adres + " " + musteri.Eposta + ": Belirtilen Müşteri Eklenmiştir.!\n");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.TcNo + " " + musteri.Sehir + " " + musteri.Adres + " " + musteri.Eposta + ": Belirtilen Müşteri Silinmiştir.!\n");
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müsteriler Listelendi.!");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
