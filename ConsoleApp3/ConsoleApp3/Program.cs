using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Televizyon
    {
        public void kanallar()
        {
            
        c:     
            Console.WriteLine("Tv8  acmak için 1'e Basınız");
            Console.WriteLine("Show acmak için 2'e Basınız");
            Console.WriteLine("Star acmak için 3'e Basınız");
            Console.WriteLine("Fox  acmak için 4'e Basınız");
            Console.WriteLine("Trt2 acmak için 5'e Basınız");
            Console.WriteLine("Kanal Menüsünü acmak için 6'a Basınız");
            int kanal = Convert.ToInt32(Console.ReadLine());
            if (kanal==1)
            {
                Console.WriteLine("Tv8 Açılıyor");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| Televizyon                                                1.Kanal  |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                          Tv8 Oynatılıyor                           |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
                Thread.Sleep(3000);
                goto c;
            }
            if (kanal == 2)
            {
                Console.WriteLine("Show Açılıyor");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| Televizyon                                                2" +
                    ".Kanal  |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                          Show Oynatılıyor                          |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
                Thread.Sleep(3000);
                goto c;
            }
            if (kanal == 3)
            {
                Console.WriteLine("Star Açılıyor");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| Televizyon                                                3.Kanal  |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                          Star Oynatılıyor                          |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
                Thread.Sleep(3000);
                goto c;
            }
            if (kanal == 4)
            {
                Console.WriteLine("Fox Açılıyor");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| Televizyon                                                4.Kanal  |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                          Fox Oynatılıyor                           |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
                Thread.Sleep(3000);
                goto c;
            }
            if (kanal == 5)
            {
                Console.WriteLine("Trt2 Açılıyor");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| Televizyon                                                5.Kanal  |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                          Trt2 Oynatılıyor                          |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
                Thread.Sleep(3000);
                goto c;
            }
            if (kanal == 6)
            {
                Console.WriteLine("Tv Kapanıyor.....");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("|                            Televizyon                              |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                             Philips                                |");
                Console.WriteLine("----------------------------------------------------------------------");
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            a:  
            Console.Clear();
            Televizyon televizyon1 = new Televizyon();
            Console.WriteLine("Televizyonu Açmak İçin 1'e Basınız");
            int bas =Convert.ToInt32(Console.ReadLine());   
            if(bas==1)
            {
                Console.WriteLine("Giriş Yapılıyo");
            }
            else  
            {
                Console.WriteLine("Yanlıs Birseyler Yapmısınız");
                Thread.Sleep(1000);
                goto a;
            }
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| Televizyon                                                5 Kanal  |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                             Philips                                |");
            Console.WriteLine("----------------------------------------------------------------------");

            televizyon1.kanallar();
            Console.ReadKey();
        }
    }
}
