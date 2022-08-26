using System;

namespace Odev_BankaMusteriTakip_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Can";
            musteri1.Soyadi="Tüer";
            musteri1.Hesapno = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Nazlı";
            musteri2.Soyadi = "Tüer";
            musteri2.Hesapno = 222;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Şükufe";
            musteri3.Soyadi = "Nazlı";
            musteri3.Hesapno = 111;

            Musteri[] musteriler=new Musteri[] { musteri1, musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri3);

        }
    }
}
