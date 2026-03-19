using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void bGirisYap_Click(object sender, EventArgs e)
        {
            if (tkullaniciadi.Text != "" && tsifre.Text != "")
            {
                try
                {
                    using (var db = new MarketDBEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAdi == tkullaniciadi.Text && x.Sifre == tsifre.Text).FirstOrDefault();

                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                AnaMenu f = new AnaMenu();
                                f.bSatisİslemi.Enabled = (bool)bak.Satis;
                                f.bRapor.Enabled = (bool)bak.Rapor;
                                f.bStokTakibi.Enabled = (bool)bak.Stok;
                                f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                                f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                                f.bFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                                f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                                f.lKullanici.Text = bak.AdSoyad;
                                f.Show();
                                this.Hide();
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş!");
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
            }

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
