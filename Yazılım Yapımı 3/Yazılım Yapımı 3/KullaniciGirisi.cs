using Ganss.Excel;
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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        public Kullanici kullanici = new Kullanici();
        public List<Kullanici> urunIcin = new List<Kullanici>();
        public AdminGirisi adminEkrani = new AdminGirisi();
        public List<Muhasebe> muhasebes = new List<Muhasebe>();
        public List<Urun> excelList;

        double dolar, euro, sterlin;

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            AlinmakIstenenUrun();
            cmbUrunleriListele();

            kullanici.Bakiye = Math.Round(kullanici.Bakiye, 2);

            LBL_Bakiye.Text = kullanici.Bakiye.ToString();
            UrunListele();

            if(kullanici.AlinmayiBekleyenUrun.Ad != null)
            {
                timer1.Enabled = true;
            }

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
        }
        private void UrunListele()
        {
            listSiparis.Items.Clear();
            listUrunler.Items.Clear();
            listSatis.Items.Clear();
            foreach (Urun urun in kullanici.Urunler)
            {
                if(urun.KG !=0)
                    listUrunler.Items.Add(urun.Ad + " KG: " + urun.KG.ToString() + " Fiyat: " + urun.Fiyat.ToString());
            }
                
            foreach (Urun urun in kullanici.AlinanUrunler)
            {
                listSiparis.Items.Add(urun.Ad + " KG: " + urun.KG.ToString() + " Fiyat: " + urun.Fiyat.ToString());
                excelList.Add(new Urun() { Ad = urun.Ad, KG = urun.KG, Fiyat = urun.Fiyat, AlisTarih = urun.AlisTarih });
            }
            foreach (Urun satis in kullanici.SatilanUrunler)
            {
                listSatis.Items.Add(satis.Ad + " KG: " + satis.KG.ToString() + " Fiyat: " + satis.Fiyat.ToString() + " Tarih: " + satis.AlisTarih.ToString("d"));
                excelList.Add(new Urun() { Ad = satis.Ad, KG = satis.KG, Fiyat = satis.Fiyat, AlisTarih = satis.AlisTarih });
            }
        }
        private void Btn_BakiyeOnay_Click(object sender, EventArgs e)
        {
            switch(CB_ParaBirimi.Text)
            {
                case "Türk Lirası":
                    if(kullanici.OnayBekleyenBakiye != 0)
                    {
                        MessageBox.Show("Lütfen Gönderdiğiniz Bakiyenin Onay İşleminin Sonuçlanmasını Bekleyiniz!");
                    }
                    else
                    {
                        kullanici.OnayBekleyenBakiye = Convert.ToDouble(Txt_ParaMiktari.Text);
                        kullanici.OnayBekleyenParaBirimi = "Türk Lirası";
                        MessageBox.Show("Onaya Gönderildi!");
                    }
                    break;

                case "Amerikan Doları":
                    if(kullanici.OnayBekleyenBakiye !=0)
                    {
                        MessageBox.Show("Lütfen Gönderdiğiniz Bakiyenin Onay İşleminin Sonuçlanmasını Bekleyiniz!");
                    }
                    else
                    {
                        kullanici.OnayBekleyenBakiye = Convert.ToDouble(Txt_ParaMiktari.Text);
                        kullanici.OnayBekleyenParaBirimi = "Amerikan Doları";
                        MessageBox.Show("Onaya Gönderildi!");
                    }
                    break;

                case "Euro":
                    if (kullanici.OnayBekleyenBakiye != 0)
                    {
                        MessageBox.Show("Lütfen Gönderdiğiniz Bakiyenin Onay İşleminin Sonuçlanmasını Bekleyiniz!");
                    }
                    else
                    {
                        kullanici.OnayBekleyenBakiye = Convert.ToDouble(Txt_ParaMiktari.Text);
                        kullanici.OnayBekleyenParaBirimi = "Euro";
                        MessageBox.Show("Onaya Gönderildi!");
                    }
                    break;
                case "Sterlin":
                    if (kullanici.OnayBekleyenBakiye != 0)
                    {
                        MessageBox.Show("Lütfen Gönderdiğiniz Bakiyenin Onay İşleminin Sonuçlanmasını Bekleyiniz!");
                    }
                    else
                    {
                        kullanici.OnayBekleyenBakiye = Convert.ToDouble(Txt_ParaMiktari.Text);
                        kullanici.OnayBekleyenParaBirimi = "Sterlin";
                        MessageBox.Show("Onaya Gönderildi!");
                    }
                    break;

                default:
                    MessageBox.Show("Lütfen Bir Para Birimi Seçiniz!");
                    break;

            }

        }

        private void Btn_UrunOnay_Click(object sender, EventArgs e)
        {
            if(ChckB_UrunTipii.Text == "" || Txt_Kg.Text == "" || Txt_Fiyat.Text == "" || Txt_Kod.Text == "" 
               || Convert.ToInt32(Txt_Kg.Text) == 0 || Convert.ToInt32(Txt_Fiyat.Text) == 0 || Convert.ToInt32(Txt_Kod.Text) == 0)
            {
                MessageBox.Show("Lütfen Geçerli Değerler Giriniz!");
                return;
            }

            if (kullanici.OnayBekleyenUrun.KG != 0)
            {
                MessageBox.Show("Lütfen Gönderdiğiniz Ürünün Onay İşleminin Sonuçlanmasını Bekleyiniz!");
            }
            else
            {
                kullanici.OnayBekleyenUrun.Ad = ChckB_UrunTipii.Text;
                kullanici.OnayBekleyenUrun.KG = Convert.ToInt32(Txt_Kg.Text);
                kullanici.OnayBekleyenUrun.Fiyat = Convert.ToInt32(Txt_Fiyat.Text);
                kullanici.OnayBekleyenUrun.UrunKod = Convert.ToInt32(Txt_Kod.Text);
                MessageBox.Show("Onaya Gönderildi!");
            }

        }

        private void Btn_SatinAl_Click(object sender, EventArgs e)
        {
            satinAl();
        }
        private void cmbUrunleriListele()
        {
            ChckB_UrunAdi.Items.Clear();
            foreach (var uKullanici in urunIcin)
            {
                if (!(uKullanici.KullaniciAdi == kullanici.KullaniciAdi))
                    foreach (var urun in uKullanici.Urunler)
                        if (!(ChckB_UrunAdi.Items.Contains(urun.Ad)))
                            ChckB_UrunAdi.Items.Add(urun.Ad);
            }
        }

        List<double> fiyatlar = new List<double>();
        double enucuz;
        void fiyatListele()
        {
            fiyatlar.Clear();
            foreach (var uKullanici in urunIcin)
                if (uKullanici.KullaniciAdi != kullanici.KullaniciAdi)
                {
                    var product = uKullanici.Urunler;
                    foreach (var urun in product)
                        if (!(fiyatlar.Contains(urun.Fiyat)))
                            fiyatlar.Add(enucuz = urun.Fiyat);
                }
        }
        private void AlinmakIstenenUrun()
        {
            int miktar, kmiktar;
            double para = 0;
            foreach (var k in urunIcin)
                if (!(k.KullaniciAdi == kullanici.KullaniciAdi))
                {
                    foreach (var u in k.Urunler)
                        if (u.Fiyat <= kullanici.AlinmayiBekleyenUrun.Fiyat && u.KG >= kullanici.AlinmayiBekleyenUrun.KG)
                        {
                            miktar = kullanici.AlinmayiBekleyenUrun.KG;
                            para += miktar * u.Fiyat;
                            kmiktar = miktar - u.KG;
                            if (kullanici.Bakiye < para)
                            {
                                MessageBox.Show("Bakiye Yetersiz.");
                                break;
                            }
                            kullanici.Bakiye -= para;
                            k.Bakiye += para;
                            kullanici.AlinanUrunler.Add(new Urun() { Ad = u.Ad, KG = miktar, Fiyat = para, AlisTarih = DateTime.Now.Date });
                            k.SatilanUrunler.Add(new Urun() { Ad = u.Ad, KG = miktar, Fiyat = para, AlisTarih = DateTime.Now.Date });
                            LBL_Bakiye.Text = k.Bakiye.ToString();
                            u.KG = kmiktar;
                            MessageBox.Show("İstenilen Ürün Başarıyla Alındı");
                            break;
                        }
                    UrunListele();
                }
        }
        private void btnIstenilen_Click(object sender, EventArgs e)
        {
            kullanici.AlinmayiBekleyenUrun.Ad = cmbIstenenURun.SelectedItem.ToString();
            kullanici.AlinmayiBekleyenUrun.Fiyat = Convert.ToInt32(txtIstenenFiyat.Text);
            kullanici.AlinmayiBekleyenUrun.KG = Convert.ToInt32(txtIstenenMiktari.Text);
            MessageBox.Show("Başarıyla Sisteme Eklendi...");
            AlinmakIstenenUrun();
        }

        private void Btn_ExcelAktar_Click(object sender, EventArgs e)
        {
            UrunListele();
            foreach (var urun in excelList.ToArray())
            {
                if (DateTime.Compare(urun.AlisTarih, this.date_Baslangic.Value.Date) != 1 || DateTime.Compare(urun.AlisTarih, this.date_Bitis.Value.Date) != -1)
                    excelList.Remove(urun);
            }
            ExcelMapper mapper = new ExcelMapper();
            mapper.Save(@"urun.xlsx", excelList, "Sheetname", true);
        }

        private void enDusukFiyat()
        {
            fiyatListele();
            foreach (var fiyat in fiyatlar)
                if (enucuz > fiyat)
                    enucuz = fiyat;
        }
        private void satinAl()
        {
            int miktar, tKg = 0;
            double para = 0;
            foreach (var uKullanici in urunIcin)
                if (!(uKullanici.KullaniciAdi == kullanici.KullaniciAdi))
                {
                yeniden:
                    var urunler = uKullanici.Urunler;
                    enDusukFiyat();
                    foreach (var urun in urunler)
                        if (urun.Ad == ChckB_UrunAdi.SelectedItem.ToString())
                        {
                            miktar = urun.KG;
                            if (urun.Fiyat == enucuz)
                            {
                                miktar -= Convert.ToInt32(Txt_Miktar.Text);
                                para += (Convert.ToInt32(Txt_Miktar.Text) * urun.Fiyat);
                                if (miktar < 0)
                                {
                                    if (urunler.Count == 1)
                                        if (miktar < Convert.ToInt32(Txt_Miktar.Text))
                                        {
                                            MessageBox.Show("Ürün Miktarı Yetersiz.");
                                            break;
                                        }
                                    Txt_Miktar.Text = (-1 * miktar).ToString();
                                    miktar = 0;
                                    urunler.RemoveAll(sil => (sil.UrunKod == urun.UrunKod));
                                    enDusukFiyat();
                                    goto yeniden;
                                }
                                if (kullanici.Bakiye < para)
                                {
                                    MessageBox.Show("Bakiye Yetersiz.");
                                    break;
                                }
                                tKg += Convert.ToInt32(Txt_Miktar.Text);
                                kullanici.Bakiye -= para;
                                uKullanici.Bakiye += para;
                                kullanici.AlinanUrunler.Add(new Urun() { Ad = urun.Ad, KG = tKg, Fiyat = para });
                                LBL_Bakiye.Text = kullanici.Bakiye.ToString();
                                urun.KG = miktar;
                                MessageBox.Show("Ürün Satın Alındı.");
                                break;
                            }
                        }
                    UrunListele();
                    cmbUrunleriListele();
                }
        }
    }
}
