using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Sifre.PasswordChar = '*';
        }

        public List<Kullanici> kullanicilar = new List<Kullanici>();

        private void CB_SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SifreGoster.Checked)
            {
                Txt_Sifre.PasswordChar = '\0';
            }
            else
            {
                Txt_Sifre.PasswordChar = '*';
            }
        }
        KullaniciKayit KayitEkrani = new KullaniciKayit();
        private void LBL_Kaydol_Click(object sender, EventArgs e)
        {
            
            KayitEkrani.ShowDialog();
            kullanicilar.Add(new Kullanici {
                                                Ad = KayitEkrani.kullanici.Ad,
                                                Soyad = KayitEkrani.kullanici.Soyad,
                                                KullaniciAdi = KayitEkrani.kullanici.KullaniciAdi,
                                                Sifre = KayitEkrani.kullanici.Sifre,
                                                TCKimlikNo = KayitEkrani.kullanici.TCKimlikNo,
                                                Telefon = KayitEkrani.kullanici.Telefon,
                                                Email = KayitEkrani.kullanici.Email,
                                                Adres = KayitEkrani.kullanici.Adres
            });
                
            
            return;

        }

        

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (Txt_KullaniciAdi.Text == "admin" && Txt_Sifre.Text == "admin")
            {
                AdminGirisi AdminEkrani = new AdminGirisi();
                AdminEkrani.kullanicilar = this.kullanicilar;
                this.Hide();
                AdminEkrani.ShowDialog();
                return;
            }
            if (kullanicilar.Count == 0)
            {
                MessageBox.Show("Henüz Kayıtlı Bir Kullanıcı Yok!");
                return;
            }
            else
            {
                foreach(Kullanici x in kullanicilar)
                {
                    if(Txt_KullaniciAdi.Text == x.KullaniciAdi && Txt_Sifre.Text == x.Sifre)
                    {
                        KullaniciGirisi KullaniciEkrani = new KullaniciGirisi();
                        KullaniciEkrani.kullanici = x;
                        KullaniciEkrani.ShowDialog();
                        flag = true;
                        return;
                    }
                    
                }
                if(flag == false)
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }
        }

        
    }
}
