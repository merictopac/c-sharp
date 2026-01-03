
    class TekCift
    {
    public bool tc(int sayi)
        {
            if(sayi%2==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("bir sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            TekCift x = new TekCift();
            Console.WriteLine("sonuç:" + x.tc(a));
        }
    }
