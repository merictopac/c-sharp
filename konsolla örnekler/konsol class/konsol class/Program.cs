class Sinifim
{
    //public int a;
 
}
class Ucgen
{
    int a, b, c;
    
    public int A
    {
        get { return a; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine(" a hatalı bilgi ");
            }
            else
            {
                a = value;
            }
        }
    }

    public int B
    {
        get { return b; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine(" b hatalı bilgi ");
            }
            else
            {
                b = value;
            }
        }
    }
    public int C
    {
        get { return c; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine(" c  hatalı bilgi ");
            }
            else
            {
                c = value;
            }
        }
    }
}
    internal class Program1
    {
        static void Main(string[] args)
        {
            /*Sinifim m1 = new Sinifim();
            m1.a = 10;
            Console.WriteLine(m1.a);*/

            Ucgen x = new Ucgen();
            x.A = -50;
            x.B = 20;
            x.C = -30;
            Console.WriteLine($"üçgenin a kenar uzunkuğu {x.A} dır");
            Console.WriteLine($"üçgenin b kenar uzunkuğu {x.B} dır");
            Console.WriteLine($"üçgenin c kenar uzunkuğu {x.C} dır");
        }
    }