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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        Form1 frm = new Form1();
        public Kullanici k = new Kullanici();

        private void Btn_KayitOl_Click(object sender, EventArgs e)
        {
            k.Ad = Txt_Ad.Text;
            k.Soyad = TxtSoyad.Text;
            k.KullaniciAdi = Txt_KullaniciAdi.Text;
            k.Password = Txt_Password.Text;
            k.TCKimlikNo = Txt_TCKimlikNo.Text;
            k.Telefon = Txt_Telefon.Text;
            k.Email = Txt_Email.Text;
            k.Adres = Txt_Adres.Text;

            frm.kullanicilar.Add(k);

            this.Hide();
            frm.ShowDialog();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
    }
}
