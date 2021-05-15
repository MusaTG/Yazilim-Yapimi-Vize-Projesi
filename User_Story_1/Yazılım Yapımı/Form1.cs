using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Yapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Kullanici> kullanicilar = new List<Kullanici>();
        public List<Admin> admins = new List<Admin>();
        public Kullanici kullanici = new Kullanici();



        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
            Txt_Sifre.PasswordChar = '*';
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {

            foreach(Admin x in admins)
            {
                if(x.KullaniciAdi == Txt_KullaniciAdi.Text && x.Password == Txt_Sifre.Text)
                {
                    //Admin Girisi
                }
            }

            foreach(Kullanici x in kullanicilar)
            {
                if(x.KullaniciAdi == Txt_KullaniciAdi.Text && x.Password == Txt_Sifre.Text)
                {
                    //Giris
                }
                else
                {
                    MessageBox.Show("Kullanici Adi veya Sifre Yanlis!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Txt_Sifre.PasswordChar = '\0';
            }
            else
            {
                Txt_Sifre.PasswordChar = '*';
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            panelGiris.BringToFront();
            btnGirisYap.BackColor = Color.FromArgb(146, 240, 252);
            btnKayitOl.BackColor = Color.FromArgb(41, 149, 163);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            panelKayıtOl.BringToFront();
            btnKayitOl.BackColor = Color.FromArgb(146, 240, 252);
            btnGirisYap.BackColor = Color.FromArgb(41, 149, 163);
        }

        private void Btn_KayitOl_Click(object sender, EventArgs e)
        {
            kullanici.Ad = Txt_Ad.Text;
            kullanici.Soyad = TxtSoyad.Text;
            kullanici.KullaniciAdi = Txt_KullaniciAdi.Text;
            kullanici.Password = Txt_Password.Text;
            kullanici.TCKimlikNo = Txt_TCKimlikNo.Text;
            kullanici.Telefon = Txt_Telefon.Text;
            kullanici.Email = Txt_Email.Text;
            kullanici.Adres = Txt_Adres.Text;

            kullanicilar.Add(kullanici);
            MessageBox.Show("Başarıyla Kayıt Olundu...");
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
