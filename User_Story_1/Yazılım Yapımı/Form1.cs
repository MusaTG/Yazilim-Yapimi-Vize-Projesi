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
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Lbl_KayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            this.Hide();
            kayit.ShowDialog();

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
                Txt_Sifre.PasswordChar = '*';
            }
            else
            {
                Txt_Sifre.PasswordChar = '\0';
            }
        }
    }
}
