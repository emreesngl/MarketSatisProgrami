using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class NakitKart : Form
    {
        public NakitKart()
        {
            InitializeComponent();
        }
        Form1 a = new Form1();
        private void tNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (tNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Hesapla();
                }

            }
        }


        private void TusTakimi(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNakit.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tNakit.Text.Length > 0)
                {
                    tNakit.Text = tNakit.Text.Substring(0, tNakit.Text.Length - 1);
                }
            }
            else
            {
                tNakit.Text += b.Text;
            }

        }
        private void Hesapla()
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            double nakit = Islemler.DoubleYap(tNakit.Text);
            double geneltoplam = Islemler.DoubleYap(f.tbGenelToplam.Text);
            double kart = geneltoplam - nakit;
            f.lNakit.Text = nakit.ToString("C2");
            f.lKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (tNakit.Text != "")
            {
                Hesapla();
            }
        }

        private void tNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }
    }
}
