using System;
using System.Collections.Generic;
using System.Text;

namespace MuholdApp
{
    internal class KutatasiMuhold : Muhold
    {
        public int MuszerekSzama { get; set; }
        public KutatasiMuhold(string azonosito, int sulyKg, int muszerekSzama) : base(azonosito, sulyKg)
        {
            MuszerekSzama = muszerekSzama;
        }
        public override int NapiKoltseg()
        {
            return base.NapiKoltseg() + MuszerekSzama * 200;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Műszerek száma: {MuszerekSzama}";
        }
    }
}
