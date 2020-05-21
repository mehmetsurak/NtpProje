using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.KutuphaneLib
{
    public class  Kitap
    {
        //public static int sayac;
        private static  int sayac;

        public static int Sayac
        {
            get { return sayac; }          
        }


        public Kitap()
        {
            sayac++;
        }
        public Kitap(DateTime basimTarihi, string kitapAdi, string yazar, string turu="Tarih")//Varsayılan yapıcı method-Default Constructor    
        {
            //Class İçinde Bulunan fieldlarımıza varsayılan değerlerini atama işlemi yaparlar.
            this.basimTarihi = basimTarihi;
            this.KitapAdi = kitapAdi;
            this.Yazar = yazar;
            this.Turu = turu;
            sayac++;
        }

    



        //public string basimTarihi
        //{
        //    get
        //    {
        //        return basimTarihi;
        //    }


        //    set
        //    {
        //        basimTarihi = value;
        //    }
        //}
        //private string basimTarihi;
        private string kitapAdi;
        private string yazar;
        private string turu;

        private DateTime basimTarihi;//field

        public DateTime BasimTarihi//Property
        {
            get
            {
                return basimTarihi;
            }
            set
            {
                basimTarihi = value;
            }
        }

    

        //public string BasimTarihi { get => basimTarihi; set => basimTarihi = value; } //Property

        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }

        public string Yazar { get => yazar; set => yazar = value.ToUpper(); }

        public string Turu { get => turu; set => turu = value; }

     
        public static void KitapKaydet(Kitap[] kitaplar)
        {
            FileStream fs = new FileStream("kitaplar.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var kitap in kitaplar)
            {
                sw.Write(kitap.KitapBilgileriGetir());
            }
            sw.Close();

        }

        public static void KitapListele()
        {
            string satir = "";
            StreamReader file = new StreamReader("kitaplar.txt");
            while ((satir = file.ReadLine()) != null)
            {
                Console.WriteLine(satir);
            }

        }

        public string KitapBilgileriGetir() => $"BasımTarihi: {this.basimTarihi} Kitap Adı: {this.KitapAdi} Yazar: {this.Yazar} Türü: {this.Turu} \n";
    }
}

