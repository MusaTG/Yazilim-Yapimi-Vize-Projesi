using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            cmbUrunleriListele();
            LBL_Bakiye.Text = kullanici.Bakiye.ToString();
            UrunListele();
        }
        private void UrunListele()
        {
            listSiparis.Items.Clear();
            listUrunler.Items.Clear();
            foreach (Urun urun in kullanici.Urunler)
            {
                if(urun.KG !=0)
                    listUrunler.Items.Add(urun.Ad + " KG: " + urun.KG.ToString() + " Fiyat: " + urun.Fiyat.ToString());
            }
                
            foreach (Urun urun in kullanici.AlinanUrunler)
            {
                listSiparis.Items.Add(urun.Ad + " KG: " + urun.KG.ToString() + " Fiyat: " + urun.Fiyat.ToString());
            }
                
        }
        private void Btn_BakiyeOnay_Click(object sender, EventArgs e)
        {
            if (kullanici.OnayBekleyenBakiye != 0)
            {
                MessageBox.Show("Lütfen Gönderdiğiniz Bakiyenin Onay İşleminin Sonuçlanmasını Bekleyiniz!");
            }
            else
            {
                kullanici.OnayBekleyenBakiye = Convert.ToInt32(Txt_TL.Text);
                MessageBox.Show("Onaya Gönderildi!");
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
            foreach (var uKullanici in urunIcin)
            {
                if (!(uKullanici.KullaniciAdi == kullanici.KullaniciAdi))
                    foreach (var urun in uKullanici.Urunler)
                        if (!(ChckB_UrunAdi.Items.Contains(urun.Ad)))
                            ChckB_UrunAdi.Items.Add(urun.Ad);
            }
        }

        List<int> fiyatlar = new List<int>();
        int enucuz;
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
        private void enDusukFiyat()
        {
            fiyatListele();
            foreach (var fiyat in fiyatlar)
                if (enucuz > fiyat)
                    enucuz = fiyat;
        }
        private void satinAl()
        {
            int miktar, tKg = 0, para = 0;
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
