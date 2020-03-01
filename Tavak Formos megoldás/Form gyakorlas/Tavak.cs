using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_gyakorlas
{
    class Tavak
    {
        // Név;Terület(km?); Ország(ok)
        public string Nev;
        public string TeruletSzoveg;
        public double Terulet;
        public double TeruletMin;
        public double TeruletMax;
        public string Orszagok;

        public Tavak(string sor)
        {
            var dbok = sor.Split(';');
            this.Nev = dbok[0];
            this.TeruletSzoveg = dbok[1];
            if (TeruletSzoveg.Contains('-'))
            {
                var dbok2 = TeruletSzoveg.Split('-');
                this.TeruletMin = double.Parse(dbok2[0]);
                this.TeruletMax = double.Parse(dbok2[1]);
                this.Terulet = (TeruletMax + TeruletMin) / 2;
            }
            else
            {
                this.Terulet = double.Parse(TeruletSzoveg);
            }
            this.Orszagok = dbok[2];
        }
    }
}
