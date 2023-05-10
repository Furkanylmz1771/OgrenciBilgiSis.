using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgi
{
    public class Program
    {

        static int say = 0;
        static int x = 0;
        
        static string[] num = new string[100];
        static string[] adsoyad = new string[100];
        static string[] bolum = new string[100];
        static string[] adres = new string[100];
        static string[] tel = new string[100];


        static void giris()
        {
            if (say == 10)
            {
                Console.WriteLine("Daha fazla bilgi girişi yapamazsınız !!");
                Console.ReadKey();
            }

            else
            {
                Console.Write("\n Yeni bilgi girişi \n");
                Console.Write("Numara : "); num[say] = Console.ReadLine();
                Console.Write("Ad Soyad : "); adsoyad[say] = Console.ReadLine();
                Console.Write("Bölüm : "); bolum[say] = Console.ReadLine();
                Console.Write("Adres : "); adres[say] = Console.ReadLine();
                Console.Write("Telefon : "); tel[say] = Console.ReadLine();

                Console.WriteLine("Kayıt başarıyla oluşturuldu.");
                Console.ReadKey();
                say++;

            }
        }

        static void listele()
        {
            int s = 0;  // Görüntülenecek kişi sayısı
            Console.Write("\n \n Ad Soyad               Bölüm           Telefon \n");

            Console.Write("....................\n");

            for (int x = 0; x < say; x++)
            {
                Console.WriteLine("{0, -30} {1,-15} {2,-15}",
                    adsoyad[x], bolum[x], tel[x]);
            }
            s++;

            // Sayfa kontrolü

            if (s % 20 == 0)
            {
                Console.WriteLine("Diğer sayfa için bir tuşa basınız");
                Console.ReadKey();
            }
            Console.WriteLine("Listelenecek kayıtlar bitti");
            Console.ReadKey();
        
    }



        static void yaz()
        {
            Console.WriteLine("Öğrencinin : ");
            Console.WriteLine("Numara : {0}", num[x]);
            Console.WriteLine("Ad soyad : {0}", adsoyad[x]);
            Console.WriteLine("Bölüm : {0}", bolum[x]);
            Console.WriteLine("Adres : {0}", adres[x]);
            Console.WriteLine("Telefon : {0}", tel[x]);
        }



        static void arama()
        {
            string ara;
            int evet = 0;
            char cc;
            Console.Write("Aranan ad soyadı : "); ara = Console.ReadLine();

            for (x = 0; x < say; x++)
            {
                if (adsoyad[x] == ara)
                {
                    yaz();  // Bilgileri görüntüler

                    Console.Write("Aradığınız bilgi bu mu [E/H]");
                }
                do
                {
                    cc = Convert.ToChar(Console.ReadLine());
                } while (!(cc == 'h' || cc == 'H' || cc == 'e' || cc == 'E'));

                if(cc =='e'|| cc == 'E')
                {
                    evet = 1;
                    break;
                }

            }

            if (evet == 0)
                Console.WriteLine("\n Aradığınız kişi kayıtlı degıl");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey(); 
        }



         static void silme()
        {
            int y;
            string ara;
            int evet = 0;
            char cc;
            Console.Write("Silinecek ad soyadı : "); ara = Console.ReadLine();

            for (x = 0; x < say; x++)
            {
                if (adsoyad[x] == ara)
                {
                    yaz();  // Bilgileri görüntüler

                    Console.Write("Silinecek bilgi bu mu [E/H]");
                }
                do
                {
                    cc = Convert.ToChar(Console.ReadLine());
                } while (!(cc == 'h' || cc == 'H' || cc == 'e' || cc == 'E'));

                if (cc == 'e' || cc == 'E')
                {
                    for (y = x; y < say; y++)
                    {
                        num[y] = num[y + 1];
                        adsoyad[y] = adsoyad[y + 1];
                        bolum[y] =bolum[y + 1];
                        adres[y] = adres[y + 1];
                        tel[y] =tel[y + 1];
                    }
                    say--;
                    Console.WriteLine("Silme başarılı");
                    evet = 1;
                    break;
                }

            }

            if (evet == 0)
                Console.WriteLine("\n Aradığınız kişi kayıtlı degıl");
            Console.ReadKey();
        }







        static void Main(string[] args)
        {

            char c;

            do
            {
                do
                {
                    Console.WriteLine("Ana Menü");
                    Console.WriteLine("1 - Bilgi girişi");
                    Console.WriteLine("2 - Bilgi listesi");
                    Console.WriteLine("3 - Bilgi arama");
                    Console.WriteLine("4- Bilgi silme");
                    Console.WriteLine("5- Program sonu");
                    Console.WriteLine("Seçiminiz [1-5] : ");

                    c = Convert.ToChar(Console.ReadLine());

                    if (c == '1') giris();
                    if (c == '2') if (say > 0) listele();
                    if (c == '3') if (say > 0) arama();
                    if (c == '4') if (say > 0) silme();
                }


                while (c != '5');

                Console.Write("/nÇıkmak istediğinizden emin misiniz ???  E/H : "); 

                do
                {
                    c = Convert.ToChar(Console.ReadLine());
                }

                while (!(c == 'h' || c == 'H' || c == 'e' || c == 'E'));
            }

            while (!(c == 'E' || c == 'e'));

        }
    }
}
