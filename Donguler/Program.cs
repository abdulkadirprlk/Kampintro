
string kurs1 = "java kursu";
string kurs2 = "python kursu";
string kurs3 = "c# kursu";

//arrays -- diziler

string[] kurslar = new string[] { "java kursu",   //syntax ilginçmiş
    "python kursu",
    "c# kursu","c++ kursu" };

for (int i = 0; i<kurslar.Length; i++) //pythondaki while gibi
{
    Console.WriteLine(kurslar[i]); 
}

Console.WriteLine("for bitti");

foreach (string kurs in kurslar) //pythondaki for gibi
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu");

