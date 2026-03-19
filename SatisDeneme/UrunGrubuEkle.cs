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
    public partial class UrunGrubuEkle : Form
    {
        public UrunGrubuEkle()
        {
            InitializeComponent();
        }
        MarketDBEntities db = new MarketDBEntities();
        private void UrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text != "")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                MessageBox.Show("oldu");

                UrunEkleme f = (UrunEkleme)Application.OpenForms["UrunEkleme"];
                if (f != null)
                {
                    f.GrupDoldur();
                }



            }
            else
            {
                MessageBox.Show("olmadı");
            }
        }
        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad+"grubu silmek istiyor musun?","silme işlemi",MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupad+" silindi");
                UrunEkleme f = (UrunEkleme)Application.OpenForms["UrunEkleme"];
                f.GrupDoldur();
            }
        }

        private void listUrunGrup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
