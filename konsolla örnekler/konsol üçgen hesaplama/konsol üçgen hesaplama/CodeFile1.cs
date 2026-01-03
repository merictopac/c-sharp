class islem
{
    public void kontrol(int a, int b,int c)
    {
        if (a == b && b == c)
        {
            Console.WriteLine("eşkanar ");
        }
        else if (a == b || b == c||a==c)
        {
            Console.WriteLine("ikizkenar ");
        }
        else
        {
            Console.WriteLine("çeşitkenar ");
        }
    }
}
internal class program
{
    static void Main(string[] args)
    {
        Console.Write("bir sayı giriniz ");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Write("ikinci sayı giriniz ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("üçüncü sayı giriniz ");
        int z = Convert.ToInt32(Console.ReadLine());
        islem m1= new islem();
        m1.kontrol(x,y,z);
    }
}