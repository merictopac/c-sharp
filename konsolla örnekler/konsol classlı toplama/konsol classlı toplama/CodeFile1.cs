internal class Program
{
    static void Main(string[] args)
    {
        Toplama x = new Toplama();
        Console.Write("birinci sayı:");
        int sayı1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("ikinci sayı:");
        int sayı2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("toplam:" + x.top(sayı1, sayı2));

    }
}