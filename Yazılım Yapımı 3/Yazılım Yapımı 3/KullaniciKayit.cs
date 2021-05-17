using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yazılım_Yapımı_3
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        public Kullanici kullanici = new Kullanici();

        private void Btn_Kaydol_Click(object sender, EventArgs e)
        {
            
            kullanici.Ad = Txt_Ad.Text;
            kullanici.Soyad = Txt_Soyad.Text;
            kullanici.KullaniciAdi = Txt_KullaniciAdi.Text;
            kullanici.Sifre = Txt_Sifre.Text;
            kullanici.TCKimlikNo = Txt_TCKimlikNo.Text;
            kullanici.Telefon = Txt_Telefon.Text;
            kullanici.Email = Txt_Email.Text;
            kullanici.Adres = Txt_Adres.Text;
            MessageBox.Show("Kayıt Başarılı!");
            this.Close();
        }
    }
}
