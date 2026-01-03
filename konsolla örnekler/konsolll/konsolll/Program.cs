/*Console.WriteLine("KIRKLARELİ"); 
Console.WriteLine("TEKİRDAĞ"); 
Console.Write("SAKARYA ADANA YALOVA");
Console.WriteLine(" ");
Console.WriteLine("BİLECEİK İZMİT");
int a = 25, b = 50;
Console.WriteLine(" a değişkenin değeri={0}, b değişkenin değeri={1}", a, b);
Console.WriteLine(" a değişkenin değeri=" + a + ", b değişkenin değeri=" + b);

int x;
Console.Write("bir sayı girin ");
x = Console.Read();
Console.WriteLine("ASCI KOD KARŞILIĞI " + x);

string ad;
Console.Write("adınız girin ");
ad = Console.ReadLine();
Console.WriteLine("merhaba " + ad);

int sayi1, sayi2;
Console.Write("bir sayı giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi1 + sayi2;
int carp = sayi1 * sayi2;
Console.WriteLine("sayıların toplamı=" + toplam);
Console.WriteLine("sayıların carpımı=" + carp);

Console.Write("bir sayı girin");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi == 0)
{
    Console.WriteLine("bu sayı sıfırdır");
}
else if (sayi > 0)
{
    Console.WriteLine("bu sayı pozitiftir");
}
else
{
    Console.WriteLine("bu sayı negatiftir");
}*/

 

// Basit bir hesap makinesi uygulaması
Console.Write("Bir sayı giriniz: ");
 int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Bir başka sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
int cikarma = sayi1 - sayi2;
int carpma = sayi1 * sayi2;
double bolum = (double)sayi1 / sayi2;
Console.WriteLine("");
Console.WriteLine("İşlem seçiniz: ");
Console.WriteLine("Toplama için --- t");
Console.WriteLine("Çıkarma için --- c");
Console.WriteLine("Çarpma için --- x");
Console.WriteLine("Bölme için --- b");
Console.WriteLine("");
string secim = Console.ReadLine();

if (secim == "t")
{
    Console.WriteLine(toplam);
}
else if (secim == "c")
{
    Console.WriteLine(cikarma);
}
 else if (secim == "x")
{
    Console.WriteLine(carpma);
}
else if (secim == "b")
{
if (sayi2 != 0)
    Console.WriteLine(bolum);
else
    Console.WriteLine("Sıfıra bölme hatası!");
}
else
{
    Console.WriteLine("Geçersiz seçim!");
} 
Console.ReadKey();
 


