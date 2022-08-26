using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BankaMusteriTakip_
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarılı Bir Şekilde Eklendi");
            Console.WriteLine("Müşteri Adı Ve Soyadı : " + musteri.Adi + " "+ musteri.Soyadi);
            Console.WriteLine("Müşteri HesapNo: "+ musteri.Hesapno);
            Console.WriteLine("-------------------------------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarılı Bir Şekilde Silindi");
            Console.WriteLine("Müşteri Adı Ve Soyadı : " + musteri.Adi +" "+ musteri.Soyadi);
            Console.WriteLine("Müşteri HesapNo: " + musteri.Hesapno);
            Console.WriteLine("-------------------------------------");
        }

    }
}
