using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Id = "18293847";
musteri1.Isim = "Safiye";
musteri1.Soyisim = "Aydın";
musteri1.Bakiye = 500;

Musteri musteri2 = new Musteri();
musteri2.Id = "38493829";
musteri2.Isim = "Ahmet";
musteri2.Soyisim = "Yılmaz";
musteri2.Bakiye = 1500;

Musteri musteri3 = new Musteri();
musteri3.Id = "19382910";
musteri3.Isim = "Suat";
musteri3.Soyisim = "Yanyatan";
musteri3.Bakiye = 6500;


Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


foreach (Musteri musteri in Musteriler)
{
    Console.WriteLine("ID: " + musteri.Id +" Ad: " + musteri.Isim + " Soyad: " + musteri.Soyisim + " Bakiye: " + musteri.Bakiye);
}

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);

musteriManager.Sil(musteri3);

musteriManager.bakiyeEkle(musteri1, 300);

musteriManager.bakiyeSorgulama(musteri1);

musteriManager.bakiyeCikar(musteri2, 400);
musteriManager.bakiyeCikar(musteri2, 1200);


