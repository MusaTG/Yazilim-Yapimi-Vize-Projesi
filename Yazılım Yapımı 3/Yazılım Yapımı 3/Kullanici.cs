using System;
using System.Collections.Generic;
using System.Text;

namespace Yazılım_Yapımı_3
{
    public class Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string TCKimlikNo { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public int Bakiye { get; set; }

        public bool OnayTuru { get; set; } //true ise urun yazdır, false ise bakiye yazıdr


        public List<Urun> Urunler = new List<Urun>();
        public List<Urun> AlinanUrunler = new List<Urun>();

        public Urun OnayBekleyenUrun = new Urun();
        public int OnayBekleyenBakiye { get; set; }
        public override string ToString()
        {
            if(OnayTuru)
            {
                return KullaniciAdi + " Kullanıcısı " + OnayBekleyenUrun.KG.ToString() + " Kg " + OnayBekleyenUrun.Ad+" "+OnayBekleyenUrun.Fiyat.ToString()+"₺";
            }
            else
            {
                return KullaniciAdi + " Kullanıcısı " + OnayBekleyenBakiye.ToString() + " TL";
            }
        }

    }
}
