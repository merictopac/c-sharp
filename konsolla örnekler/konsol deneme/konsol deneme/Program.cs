using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KIRKLARELİ");
            Console.WriteLine("TEKİRDAĞ");
            Console.Write("SAKARYA ADANA YALOVA");
            Console.WriteLine(" ");
            Console.WriteLine("BİLECEİK İZMİT");
            int a=25,b=50;
            Console.WriteLine(" a değişkenin değeri={0}, b değişkenin değeri={1}",a,b);
            Console.WriteLine(" a değişkenin değeri="+a+", b değişkenin değeri="+b); 
            
            int x;
            Console.Write("bir sayı girin ");
            x=Console.Read();
            Console.WriteLine("ASCI KOD KARŞILIĞI "+x);

            string ad;
            Console.Write("adınız girin ");
            ad = Console.ReadLine();
            Console.WriteLine("merhaba "+ad);
            
            int sayi1, sayi2;
            Console.Write("bir sayı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz");
            sayi2= Convert.ToInt32(Console.ReadLine());
            int toplam=sayi1+ sayi2;
            int carp = sayi1 * sayi2;
            Console.WriteLine("sayıların toplamı="+toplam);
            Console.WriteLine("sayıların carpımı=" + carp);
            
            Console.Write("bir sayı girin");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine("bu sayı sıfırdır");
            }
            else if(sayi>0)
            {
                Console.WriteLine("bu sayı pozitiftir");
            }
            else
            {
                Console.WriteLine("bu sayı negatiftir");
            }
            /*

            Console.Write("bir sayı girin=");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.Write("bir sayı girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("işleminizi seçin");*/
            


        }
    }
}
