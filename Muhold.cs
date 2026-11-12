using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MuholdApp
{
    internal class Muhold
    {
        public string Azonosito { get; set; }

        protected int sulyKg;
        public int SulyKg
        {
            get { return sulyKg; }
            set
            {
                if (value <= 0)
                {
                    sulyKg = 100;
                }
                else
                {
                    sulyKg = value;
                }
            }
        }

        private static int osszesMuholdSzama;
        public static int OsszesMuholdSzama
        {
            get { return osszesMuholdSzama; }
        }

        public Muhold ( string azonosito, int sulyKg)
        {
            Azonosito = azonosito;
            SulyKg = sulyKg;

            osszesMuholdSzama++;
        }
        public virtual int NapiKoltseg()
        {
            return SulyKg * 5;
        }
        public override string ToString()
        {
            return $"Műhold {Azonosito} | Tömeg: {SulyKg} kg | Napi költség: {NapiKoltseg()} EUR";
        }
    }
}
