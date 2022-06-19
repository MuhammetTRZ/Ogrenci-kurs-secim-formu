using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Öğrenci
    {
        public string ad;
        public string SoyAd;
        public string Ders;
        public string Yeni;

        public void Düzenle()
        {
            Yeni = "Öğrencinin adı=" + ad + ", "+ " SoyAdı = " + SoyAd + "İstediği Ders= " + Ders;
        }
    }
}
