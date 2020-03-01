using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Form_gyakorlas
{
    
    public partial class Form1 : Form
    {
        private static List<Tavak> TavakList;
        public Form1()
        {
            InitializeComponent();
        }

        private void btBeolvas_Click(object sender, EventArgs e)
        {
            TavakList = new List<Tavak>();
            var sr = new StreamReader(@"tavak.csv", Encoding.UTF8);
            int db = 0;
            while(!sr.EndOfStream)
            {
                TavakList.Add(new Tavak(sr.ReadLine()));
                db++;
            }
            string Eredmeny1 = "Sikeres beolvasás";
            string Eredmeny2="Sikertelen beolvasás";
            if(db>0)
            {
                txbEredmeny.Text = Eredmeny1.ToString()+" "+db.ToString();
            }
            else
            {
                txbEredmeny.Text = Eredmeny2.ToString();
            }
        }

        private void btmFeltolt_Click(object sender, EventArgs e)
        {
            foreach (var t in TavakList)
            {
                dataGridView1.Rows.Add(t.Nev, t.Terulet, t.Orszagok);
            }
        }

        private void btnLEgnagyobb_Click(object sender, EventArgs e)
        {
            double MaxTerulet = double.MinValue;
            string MaxToNEv = "Cica";
            foreach (var t in TavakList)
            {
                if(MaxTerulet<t.Terulet)
                {
                    MaxTerulet = t.Terulet;
                    MaxToNEv = t.Nev;
                }
            }
            txtbNev.Text = MaxToNEv.ToString();
            txtbMaxTer.Text = MaxTerulet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MinTerulet = double.MaxValue;
            string MinToNav = "Cica";
            foreach (var t in TavakList)
            {
                if(MinTerulet>t.Terulet)
                {
                    MinTerulet = t.Terulet;
                    MinToNav = t.Nev;
                }
            }
            txtbMinNev.Text = MinToNav.ToString();
            txtbMinTer.Text = MinTerulet.ToString();
        }

        private void Atlag_Click(object sender, EventArgs e)
        {
            double Atlag = 0;
            double Osszeg = 0;
            foreach (var t in TavakList)
            {
                Osszeg += t.Terulet;
                Atlag = Osszeg / TavakList.Count;
            }
            txtbAtlag.Text = Atlag.ToString();
        }
    }
}
