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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        MarketDBEntities db = new MarketDBEntities();
        private void bSatisİslemi_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void bRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Rapor f = new Rapor();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();

        }

        private void bUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            UrunEkleme f = new UrunEkleme();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
        }

        private void bStokTakibi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Stok f = new Stok();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
        }

        private void bAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar f = new Ayarlar();
            f.Show();
        }

        private void bRapor_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Rapor f = new Rapor();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
        }

        private void bCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
