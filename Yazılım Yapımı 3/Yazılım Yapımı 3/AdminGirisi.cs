using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void AdminGirisi_Load(object sender, EventArgs e)
        {
            foreach(Kullanici x in kullanicilar)
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
                        x.Urunler.Add(new Urun { Ad = x.OnayBekleyenUrun.Ad, KG = x.OnayBekleyenUrun.KG});

                    x.OnayBekleyenUrun.Ad = "";
                    x.OnayBekleyenUrun.KG = 0;
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
                if (kullanici.KullaniciAdi == x.KullaniciAdi)
                {
                    x.Bakiye = x.Bakiye + x.OnayBekleyenBakiye;
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
                    x.OnayBekleyenUrun = null;
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
