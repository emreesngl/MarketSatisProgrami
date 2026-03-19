using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        public void bGöster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dtBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new MarketDBEntities())
            {
                if (listFiltrelemeTürü.SelectedIndex == 0) // tümünü getir
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;

                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarisatis = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.KDVTutari).ToString());
                    double kdvtutariiade = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.KDVTutari).ToString());
                    tKdvToplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");
                }
                else if (listFiltrelemeTürü.SelectedIndex == 1) // satışlar
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }
                else if (listFiltrelemeTürü.SelectedIndex == 2)//iadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listFiltrelemeTürü.SelectedIndex == 3)//gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (listFiltrelemeTürü.SelectedIndex == 2)//giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
            }
            Islemler.GridDuzenle(gridListe);
            Cursor.Current = Cursors.Default;
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTürü.SelectedIndex = 0;
            //bGöster_Click(null, null);
        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet:" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }
     }
}
