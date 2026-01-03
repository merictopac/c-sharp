class Sifir
{
    public int topla()
    {
        int sayi = 1,sonuc=0;
        while (sayi != 0)
        {
            Console.Write("bir sayı giriniz ");
            sayi=Convert.ToInt32(Console.ReadLine());
            sonuc = sonuc + sayi;
        }
        return sonuc;
    }
}
internal class Program
{
   static void Main(string[] args)
   {
       Sifir s = new Sifir();
        Console.WriteLine("toplam:" + s.topla());
        Console.ReadKey();


   }
}

