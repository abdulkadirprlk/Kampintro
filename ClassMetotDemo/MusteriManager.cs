using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    internal class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi : " + musteri.Isim);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi : " + musteri.Isim);
        }

        public void bakiyeSorgulama(Musteri musteri)
        {
            Console.WriteLine("Bakiyeniz : " + musteri.Bakiye);
        }

        public void bakiyeEkle(Musteri musteri, int tutar)
        {
            musteri.Bakiye = musteri.Bakiye + tutar;
           
            Console.WriteLine("Yeni Bakiye : " + musteri.Bakiye);
        }
        public void bakiyeCikar(Musteri musteri, int tutar)
        {
            if (musteri.Bakiye >= tutar)
            {
                musteri.Bakiye = musteri.Bakiye - tutar;
                Console.WriteLine("Yeni Bakiye : " + musteri.Bakiye);
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye!"+ " Bakiye : " + musteri.Bakiye);
           
            }

        }
    }
}
