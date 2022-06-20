

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.izlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Mehmet Koyuncu";
kurs2.izlenmeOrani = 54;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Ahmet Bozok";
kurs3.izlenmeOrani = 78;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "Php";
kurs4.Egitmen = "Faruk Bilgin";
kurs4.izlenmeOrani = 100;


Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : "+kurs.Egitmen+ " oran: " +kurs.izlenmeOrani);
}

class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int izlenmeOrani { get; set; }

}