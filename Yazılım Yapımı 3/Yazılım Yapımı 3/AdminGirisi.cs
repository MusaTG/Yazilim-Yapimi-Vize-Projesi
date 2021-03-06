using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Yazılım_Yapımı_3
{
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }
        

        public List<Kullanici> kullanicilar = new List<Kullanici>();
        Kullanici kullanici = new Kullanici();

        double dolar, euro, sterlin;

        private void AdminGirisi_Load(object sender, EventArgs e)
        {

            //Döviz Kurları

            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();

            xmldoc.Load(bugun);

            string USD = xmldoc.SelectSingleNode("//Currency [@Kod = 'USD']/BanknoteSelling").InnerXml;
            string EUR = xmldoc.SelectSingleNode("//Currency [@Kod = 'EUR']/BanknoteSelling").InnerXml;
            string GBP = xmldoc.SelectSingleNode("//Currency [@Kod = 'GBP']/BanknoteSelling").InnerXml;

            dolar = Convert.ToDouble(USD);
            euro = Convert.ToDouble(EUR);
            sterlin = Convert.ToDouble(GBP);

            dolar = Math.Round(dolar, 2);
            euro = Math.Round(euro, 2);
            sterlin = Math.Round(sterlin, 2);

            Lbl_Dolar.Text = dolar.ToString();
            Lbl_Euro.Text = euro.ToString();
            Lbl_Sterlin.Text = sterlin.ToString();

            foreach (Kullanici x in kullanicilar)
            {
                if(x.OnayBekleyenBakiye !=0)
                {
                    x.OnayTuru = false;
                    LB_Bakiye.Items.Add(x);
                }
                if(x.OnayBekleyenUrun.KG != 0)
                {
                    x.OnayTuru = true;
                    LB_Urun.Items.Add(x);
                }
            }
        }

        private void Btn_UrunOnayla_Click(object sender, EventArgs e)
        {
            kullanici = (Kullanici)LB_Urun.SelectedItem;
            bool flag = false;

            foreach(Kullanici x in kullanicilar)
            {
                if(kullanici.KullaniciAdi == x.KullaniciAdi)
                {
                    foreach(Urun y in x.Urunler)
                    {
                        if(y.Ad == kullanici.OnayBekleyenUrun.Ad)
                        {
                            y.KG = y.KG + kullanici.OnayBekleyenUrun.KG;
                            flag = true;
                        }
                    }
                    if(flag == false)
                        x.Urunler.Add(new Urun { Ad = x.OnayBekleyenUrun.Ad, KG = x.OnayBekleyenUrun.KG,Fiyat=x.OnayBekleyenUrun.Fiyat,UrunKod=x.OnayBekleyenUrun.UrunKod});

                    x.OnayBekleyenUrun.Ad = "";
                    x.OnayBekleyenUrun.KG = 0;
                    x.OnayBekleyenUrun.UrunKod = 0;
                    x.OnayBekleyenUrun.Fiyat = 0;
                    LB_Urun.Items.Remove(LB_Urun.SelectedItem);
                    MessageBox.Show("Urun Onaylandı!");
                    break;
                }
            }
        }

        private void Btn_BakiyeOnayla_Click(object sender, EventArgs e)
        {
            kullanici = (Kullanici)LB_Bakiye.SelectedItem;

            foreach(Kullanici x in kullanicilar)
            {
                if(kullanici.KullaniciAdi == x.KullaniciAdi)
                {
                    switch (x.OnayBekleyenParaBirimi)
                    {
                        case "Türk Lirası":
                            x.Bakiye += x.OnayBekleyenBakiye;
                            break;
                        case "Amerikan Doları":
                            x.Bakiye += x.OnayBekleyenBakiye * dolar;
                            break;
                        case "Euro":
                            x.Bakiye += x.OnayBekleyenBakiye * euro;
                            break;
                        case "Sterlin":
                            x.Bakiye += x.OnayBekleyenBakiye * sterlin;
                            break;
                    }
                    x.OnayBekleyenBakiye = 0;
                    LB_Bakiye.Items.Remove(LB_Bakiye.SelectedItem);
                    MessageBox.Show("Bakiye Onaylandı!");
                    break;
                }
            }
        }

        private void Btn_UrunReddet_Click(object sender, EventArgs e)
        {
            kullanici = (Kullanici)LB_Urun.SelectedItem;

            foreach(Kullanici x in kullanicilar)
            {
                if(kullanici.KullaniciAdi == x.KullaniciAdi)
                {
                    x.OnayBekleyenUrun.Ad = "";
                    x.OnayBekleyenUrun.KG = 0;
                    x.OnayBekleyenUrun.UrunKod = 0;
                    x.OnayBekleyenUrun.Fiyat = 0;
                    LB_Urun.Items.Remove(LB_Urun.SelectedItem);
                    MessageBox.Show("Ürün Reddedildi!");
                    break;
                }
            }
        }

        private void Btn_BakiyeReddet_Click(object sender, EventArgs e)
        {
            kullanici = (Kullanici)LB_Bakiye.SelectedItem;

            foreach(Kullanici x in kullanicilar)
            {
                if(kullanici.KullaniciAdi == x.KullaniciAdi)
                {
                    x.OnayBekleyenBakiye = 0;
                    LB_Bakiye.Items.Remove(LB_Bakiye.SelectedItem);
                    MessageBox.Show("Bakiye Reddedildi!");
                    break;
                }
            }
        }

        
    }
}
