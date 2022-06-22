
int sayi1 = 10;
int sayi2 = 30; 
sayi1 = sayi2;
sayi2 = 65;
//sayi1 = ? cevap : 30


int[] sayilar1 = new int[] { 10, 20, 30, 40 };
int[] sayilar2 = new int[] { 100, 200, 300, 400 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] = ?? cevap : 999


//int, decimal, float, double, boolean ... = "değer tip" 
//array, class, abstract class, interface ... = "referans tip"
//stack ve heap

//Bir referans türü olan string ile ilgili bu konuda önemli bir istisna vardır.
// string referans türü olmasına rağmen
// metotlara geçirilirken değer tipiymiş gibi kopyalanırlar.