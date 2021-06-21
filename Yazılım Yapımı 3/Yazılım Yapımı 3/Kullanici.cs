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
        public double Bakiye { get; set; }

        public bool OnayTuru { get; set; } //true ise urun yazdır, false ise bakiye yazdır


        public List<Urun> Urunler = new List<Urun>();
        public List<Urun> AlinanUrunler = new List<Urun>();
        public List<Urun> SatilanUrunler = new List<Urun>();

        public Urun OnayBekleyenUrun = new Urun();
        public Urun AlinmayiBekleyenUrun = new Urun();
        
        public double OnayBekleyenBakiye { get; set; }
        public string OnayBekleyenParaBirimi { get; set; }
        public override string ToString()
        {
            if(OnayTuru)
            {
                return KullaniciAdi + " Kullanıcısı " + OnayBekleyenUrun.KG.ToString() + " Kg " + OnayBekleyenUrun.Ad+" "+OnayBekleyenUrun.Fiyat.ToString()+"₺";
            }
            else
            {
                string mesaj = "";
                switch(OnayBekleyenParaBirimi)
                {
                    case "Türk Lirası":
                        mesaj = KullaniciAdi + " Kullanıcısı " + OnayBekleyenBakiye.ToString() + " ₺";
                        break;
                    case "Amerikan Doları":
                        mesaj = KullaniciAdi + " Kullanıcısı " + OnayBekleyenBakiye.ToString() + " $";
                        break;
                    case "Euro":
                        mesaj = KullaniciAdi + " Kullanıcısı " + OnayBekleyenBakiye.ToString() + " €";
                        break;
                    case "Sterlin":
                        mesaj = KullaniciAdi + " Kullanıcısı " + OnayBekleyenBakiye.ToString() + " £";
                        break;
                }
                return mesaj;
            }
        }

    }
}
