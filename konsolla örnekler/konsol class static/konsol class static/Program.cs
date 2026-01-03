class sininifim
{
        public static void selamla()
        {
            Console.WriteLine("merhaba");
        }
        public  void sselamla()
        {
            Console.WriteLine("10-ATP");
        }
}
internal class Program
{
    static void Main(string[] args)
    {
        sininifim.selamla();
        sininifim m1 = new sininifim();
        m1.sselamla();
    
    }
}