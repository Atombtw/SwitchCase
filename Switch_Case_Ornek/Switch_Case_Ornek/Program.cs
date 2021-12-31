using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;
            string secim;
                
            Console.Write("Birinci Sayıyı Giriniz   : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz    : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("1:Toplama 2:Çıkartma 3:Çarpma 4:Bölme = ");
            deneme1:
            secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    sonuc = sayi1 + sayi2;
                    Console.Write("Toplama işleminin sonucu = {0}", sonuc);
                    break;
                
                case "2":
                    sonuc = sayi1 - sayi2;
                    Console.Write("Çıkarma işleminin sonucu = {0}", sonuc);
                    break;
                case "3":
                    sonuc = sayi1 * sayi2;
                    Console.Write("Çarpma işleminin sonucu = {0}", sonuc);
                    break;
                case "4":
                    sonuc = sayi1 / sayi2;
                    Console.Write("Bölme işleminin sonucu = {0}", sonuc);
                    break;
                default:
                    {
                        Console.WriteLine("Lütfen doğru değer giriniz");
                        Console.Write("1:Toplama 2:Çıkartma 3:Çarpma 4:Bölme = ");
                        goto deneme1;                    
                    }
            }
            Console.ReadKey();
        }
    }
}
