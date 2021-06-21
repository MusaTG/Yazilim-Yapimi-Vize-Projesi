using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yazılım_Yapımı_3
{
    public partial class MuhasebeGirisi : Form
    {
        public MuhasebeGirisi()
        {
            InitializeComponent();
        }

        public List<Kullanici> kullanicis = new List<Kullanici>();
        public List<Kullanici> onayKullanici = new List<Kullanici>();
        private void button1_Click(object sender, EventArgs e)
        {
            urunOnay();
            MessageBox.Show("İşlem başarıyla geçti");
        }

        private void urunOnay()
        {
            foreach (var x in kullanicis)
                if (cmbSatici.SelectedItem.ToString() == x.KullaniciAdi)
                    foreach (var u in x.Urunler)
                        if (cmbUrun.SelectedItem.ToString() == cmbUrun.SelectedItem.ToString())
                            onayKullanici.Add(x);
        }

        private void cmbKisiListele()
        {
            cmbSatici.Items.Clear();
            foreach (var x in kullanicis)
                cmbSatici.Items.Add(x.KullaniciAdi);
        }

        private void cmbUrunListele()
        {
            cmbUrun.Items.Clear();
            foreach (var x in kullanicis)
                if (cmbSatici.SelectedItem.ToString() == x.KullaniciAdi)
                    foreach (var u in x.Urunler)
                        cmbUrun.Items.Add(u.Ad);
        }

        private void MuhasebeGirisi_Load(object sender, EventArgs e)
        {
            cmbKisiListele();
        }

        private void cmbSatici_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbUrunListele();
        }
    }
}
