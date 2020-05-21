using Gazi.KazanMyo.KutuphaneLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpProje
{
    class Program
    {
        static void Main(string[] args)
        {
       

            char secim = '0';

            Console.WriteLine("1- Kitap ekleme işlemi");
            Console.WriteLine("2- Kitapevindeki kitapların listesini görüntüleme");
            Console.WriteLine("Seçiminizi Yapınız:[1,2]");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == '1')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:1");
                Console.WriteLine("Kaç kitap eklenecek?");
                int kackitap = Int32.Parse(Console.ReadLine());
                Kitap[] kitaplar = new Kitap[kackitap];

                for (int i = 0; i < kackitap; i++)
                {
                    Kitap ktp = new Kitap();
                    Console.WriteLine(i + ". Kitabın adını giriniz:");
                    ktp.KitapAdi = Console.ReadLine();
                    Console.WriteLine(i +". Kitabın türünü giriniz:");
                    ktp.Turu = Console.ReadLine();
                    Console.WriteLine(i+ ".Kitabın yazarını giriniz:");
                    ktp.Yazar = Console.ReadLine();

                    Console.Write("Basım Ayı: ");
                    int ay = int.Parse(Console.ReadLine());
                    Console.Write("Basım Günü: ");
                    int gun = int.Parse(Console.ReadLine());
                    Console.Write("Basım Yılı: ");
                    int yil = int.Parse(Console.ReadLine());
                    while(yil > 2020)
                    {
                        Console.Write("Basım Yılını 2020'den küçük giriniz: ");
                        yil = int.Parse(Console.ReadLine());
                    }
                    DateTime basimTarihi = new DateTime(yil, ay, gun);
                    ktp.BasimTarihi = basimTarihi;
                    kitaplar[i] = ktp;
                }


                Kitap.KitapKaydet(kitaplar);

                Console.WriteLine("Kitaplar kaydedildi");
                Console.ReadKey();


            }
            else if (secim == '2')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:2");

                Kitap.KitapListele();
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Çıkış");
            }


            //Console.WriteLine(kitaplarim.KitapBilgileriGetir());
            Console.ReadKey();

        }



    }
}
