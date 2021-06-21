using System;
using System.Collections.Generic;
using System.Text;

namespace Yazılım_Yapımı_3
{
    public class Muhasebe
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public double Bakiye { get; set; }

        public List<Kullanici> aracilikUrun = new List<Kullanici>();
    }
}
