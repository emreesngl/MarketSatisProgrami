using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }


        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new MarketDBEntities())
            {
                if (cmIslemTuru.Text != "")
                {
                    string urungrubu = cmUrunGrubu.Text;
                    if (cmIslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("fitreleme türünü seçiniz");
                        }
                    }
                    else if (cmIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitisTarihi.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("fitreleme türünü seçiniz");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("işlem türünü seçiniz");
                }
            }
            Islemler.GridDuzenle(gridListe);
        }
        MarketDBEntities dbx = new MarketDBEntities();
        private void Stok_Load(object sender, EventArgs e)
        {
            cmUrunGrubu.DisplayMember = "UrunGrupAd";
            cmUrunGrubu.ValueMember = "Id";
            cmUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                using (var db = new MarketDBEntities())
                {
                    if (cmIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }
    }
}
