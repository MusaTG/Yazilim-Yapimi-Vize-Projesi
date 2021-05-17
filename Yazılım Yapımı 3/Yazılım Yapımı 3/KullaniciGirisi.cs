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
        public AdminGirisi adminEkrani = new AdminGirisi();

        private void Btn_BakiyeOnay_Click(object sender, EventArgs e)
        {
            kullanici.OnayBekleyenBakiye = Convert.ToInt32(Txt_TL.Text);
            MessageBox.Show("Onaya Gönderildi!");
        }

        private void Btn_UrunOnay_Click(object sender, EventArgs e)
        {
            kullanici.OnayBekleyenUrun.Ad = ChckB_UrunTipi.ToString();
            kullanici.OnayBekleyenUrun.KG = Convert.ToInt32(Txt_Kg.Text);
            MessageBox.Show("Onaya Gönderildi!");
        }
    }
}
