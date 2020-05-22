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
            try
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
                        Console.Write(i + 1 + ".Kitabın Adını Giriniz:");
                        ktp.KitapAdi = Console.ReadLine();
                        Console.Write(i + 1 + ".Kitabın Türünü Giriniz:");
                        ktp.Turu = Console.ReadLine();
                        Console.Write(i + 1 + ".Kitabın Yazarını Giriniz:");
                        ktp.Yazar = Console.ReadLine();

                        Console.Write("Basım Ayını Giriniz:");
                        int ay = int.Parse(Console.ReadLine());
                        Console.Write("Basım Gününü Giriniz:");
                        int gun = int.Parse(Console.ReadLine());
                        Console.Write("Basım Yılını Giriniz:");
                        int yil = int.Parse(Console.ReadLine());
                        while (yil > 2020)
                        {
                            Console.Write("Basım Yılını 2020'den Küçük Giriniz: ");
                            yil = int.Parse(Console.ReadLine());
                        }
                        DateTime basimTarihi = new DateTime(yil, ay, gun);
                        ktp.BasimTarihi = basimTarihi;
                        kitaplar[i] = ktp;
                    }
                    Kitap.KitapKaydet(kitaplar);

                    Console.WriteLine("Kitaplar Kaydedildi");
                    //Console.ReadKey();
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
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı İşlem");
            }                     
            Console.ReadKey();
        }
    }
}
