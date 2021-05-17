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

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            LBL_Bakiye.Text = kullanici.Bakiye.ToString();

            foreach(Urun x in kullanici.Urunler)
            {
                switch(x.Ad)
                {
                    
                    case "Bugday":
                        Lbl_Bugday.Visible = true;
                        Lbl_BugdayKG.Visible = true;
                        Lbl_BugdayKG.Text = x.KG.ToString() + " Kg";
                        break;
                    case "Arpa":
                        Lbl_Arpa.Visible = true;
                        LBL_ArpaKG.Visible = true;
                        LBL_ArpaKG.Text = x.KG.ToString() + " Kg";
                        break;
                    case "Yulaf":
                        Lbl_Yulaf.Visible = true;
                        LBL_YulafKG.Visible = true;
                        LBL_YulafKG.Text = x.KG.ToString() + " Kg";
                        break;
                    case "Petrol":
                        Lbl_Petrol.Visible = true;
                        LBL_PetrolKG.Visible = true;
                        LBL_PetrolKG.Text = x.KG.ToString() + " Kg";
                        break;
                    case "Pamuk":
                        Lbl_Pamuk.Visible = true;
                        Lbl_PamukKG.Visible = true;
                        Lbl_PamukKG.Text = x.KG.ToString() + " Kg";
                        break;
                    default:
                        MessageBox.Show("!");
                        break;
                }
            }

        }

        private void Btn_BakiyeOnay_Click(object sender, EventArgs e)
        {
            if(kullanici.OnayBekleyenBakiye !=0)
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
            if(kullanici.OnayBekleyenUrun.KG != 0)
            {
                MessageBox.Show("Lütfen Gönderdiğiniz Ürünün Onay İşleminin Sonuçlanmasını Bekleyiniz!");
            }
            else
            {
                kullanici.OnayBekleyenUrun.Ad = ChckB_UrunTipii.Text;
                kullanici.OnayBekleyenUrun.KG = Convert.ToInt32(Txt_Kg.Text);
                MessageBox.Show("Onaya Gönderildi!");
            }
            
        }

        
    }
}
