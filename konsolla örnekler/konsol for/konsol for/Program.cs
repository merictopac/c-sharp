#region
/*
Console.Write(" bir sayı giriniz ");
    int sayi=Convert.ToInt32(Console.ReadLine());
    int toplam = 0, carpım = 1;

    for(int i = 1; i < sayi; i++) 
    {
         toplam = i + toplam;
         carpım = i * carpım;
    }
    Console.WriteLine($"{toplam} toplam");
    Console.WriteLine($"{carpım} çarpım");//*/
#endregion
#region
/*
int sayi = 1, toplam = 0;
while(sayi!=0)
{
    Console.Write("bir sayı giriniz=");
    sayi=Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi;
}
Console.WriteLine($"sayıların toplamı {toplam} dır");//*/
#endregion
#region
/*
int toplam = 0, sayac = 0;
while (toplam < 100)
{
    Console.WriteLine("bir sayı giriniz");
    int sayi=Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi;sayac++;

    
}
Console.WriteLine($"{sayac} kez çalıştı");
Console.WriteLine($"sayıların toplamı {toplam} dır");//*/
#endregion
#region
internal class program
{
    private static void ekranayaz(string mesaj)
    {
        Console.WriteLine(mesaj);
    }
    
    static void Main(string[] args)
    {
        Console.Write("bir mesaj yazınız ");
        var x=Console.ReadLine();
        ekranayaz(x);
        Console.ReadKey();
    }
    
}
#endregion
