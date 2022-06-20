//Dont repeat yourself! - DRY

using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

//type safety
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------");
}
Console.WriteLine("---------------metotlar--------------");

//encapsulation

SepetManager sepetManager = new SepetManager(); //instance-örnek
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);






