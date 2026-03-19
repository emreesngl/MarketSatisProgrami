using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    internal class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, System.Globalization.NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out sonuc); // başka cihazda uyum sağlaması için
            return Math.Round(sonuc, 2);
        }

        public static void StokAzalt(string barkod, double miktar)
        {
            using (var db = new MarketDBEntities())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar -= miktar;
                db.SaveChanges();
            }
        }

        public static void StokArtir(string barkod, double miktar)
        {
            using (var db = new MarketDBEntities())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar += miktar;
                db.SaveChanges();
            }
        }

        public static void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "UrunId":
                            dgv.Columns[i].HeaderText = "UrunNo"; break;
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu"; break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyat"; 
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;



                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı"; 
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "KDV Oranı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "Birim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "Miktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "Kart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "KDV Tutarı"; 
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;




                    }
                    
                }
            }
        }

        public static void StokHareket(string barkod, string urunad, string birim, string miktar, string urungrup, string kullanici)
        {
            using (var db = new MarketDBEntities())
            {
                StokHareket sh = new StokHareket();
                sh.Barkod = barkod;
                sh.UrunAd = urunad;
                sh.Birim = birim;
                sh.Miktar = Convert.ToDouble(miktar);
                sh.UrunGrup = urungrup;
                sh.Kullanici=kullanici;
                sh.Tarih=DateTime.Now;
                db.StokHareket.Add(sh);
                db.SaveChanges();

            }
        }
    }
}
