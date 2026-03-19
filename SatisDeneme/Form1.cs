using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            bBesTl.Text = 5.ToString("C2");
            bOntl.Text = 10.ToString("C2");
            bYirmiTl.Text = 20.ToString("C2");
            bElliTl.Text = 50.ToString("C2");
            bYuzTl.Text = 100.ToString("C2");
            bIkiYuztl.Text = 200.ToString("C2");
        }
        private void HizliButonDoldur() // hızlı ürünlerin görünüFşü
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach (var item in hizliurun)
            {
                Button bHizli = this.Controls.Find("bHizli" + item.Id, true).FirstOrDefault() as Button;
                if (bHizli != null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    bHizli.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }

            }
        }
        private void HizliButonClick(object sender, EventArgs e) // hızlı butonalrdan alınan bilgiler buraya geliyor
        {
            Button b = (Button)sender;
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(6, b.Name.Length - 6)); // butonların id sini alıp ürünü çekiyoruz
            if (b.Text.ToString().StartsWith("-"))
            {
                HizliUrunEkleme f = new HizliUrunEkleme();
                f.lButonId.Text = butonid.ToString();
                f.ShowDialog();
            }
            else
            {

                var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault(); // sadece barkodu seçtik
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(tbMiktar.Text)); // aldığı barkodu tBarkoda aktardı o da ürün listesine ekledi
                GenelToplam();

            }

        }



        MarketDBEntities db = new MarketDBEntities(); // SQL
        private void tBarkod_KeyDown(object sender, KeyEventArgs e) // barkod textine enter atadık
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim(); // barkod kısmına 2 veya daha az basamak girerse miktar olara algılıyor
                if (barkod.Length <= 2)
                {
                    tbMiktar.Text = barkod;
                    tBarkod.Clear(); // her enterdan sonra barkodu temizliyor
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod)) // okutulan barkod normal ürün tablosunda var mı onu kontrol ediyor
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault(); // varsa nerde
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(tbMiktar.Text));
                    }
                    else // yoksa teraziden gelen barkodu kontrol ediyor 
                    {
                        int onek = Convert.ToInt16(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onek)) // onek 27 
                        {
                            string teraziurunno = barkod.Substring(2, 5); // 2. karakterden sonra 5. karakter olan kısım ürün kodu
                            if (db.Urun.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = db.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000; // 7. karakterden sonra 5 karakter ekliyor orası da kg kısmı
                                UrunGetirListeye(urunterazi, teraziurunno, miktarkg);
                            }
                            else // ürün ekleme sayfası olunca devam edilecek
                            {
                                Console.Beep(900, 700);
                                MessageBox.Show("Manav Ürünü Ekleme Sayfası");

                            }
                        }
                        else
                        {
                            Console.Beep(900, 700);
                            UrunEkleme f = new UrunEkleme();
                            f.tBarkod.Text = barkod;
                            f.ShowDialog();
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
            }
        }

        private void UrunGetirListeye(Urun urun, string barkod, double miktar) // okutulan barkodları listeye getiriyor
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            //double miktar = Convert.ToDouble(tbMiktar.Text);
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++) // okutulan ürünleri yeni satıra getiriyor 
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod) // varsa üstüne ekliyor
                    {
                        gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi) // yoksa yeni satıra geçiriyor
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyati"].Value = urun.AlisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["KDVTutari"].Value = urun.KdvTutari;
            }
        }
        private void GenelToplam() // ürün toplamlarını genel toplam textine getiriyor 
        {

            double toplam = 0;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
            }
            tbGenelToplam.Text = toplam.ToString("C2"); // C2 TL  ibaresi
            tbMiktar.Text = "1";
            tBarkod.Clear();
            tBarkod.Focus();

        }

        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e) // listeden silme işlemi
        {

            {

                gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow); // geçerli satırı sil
                gridSatisListesi.ClearSelection();
                GenelToplam(); // genel toplamdan silinen ürünün fiyatı eksililyor
                tBarkod.Focus();

            }
        }


        private void b1_Click(object sender, EventArgs e)
        {

        }
        private void TusTakimi(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tTusTakimi.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tTusTakimi.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tTusTakimi.Text.Length > 0)
                {
                    tTusTakimi.Text = tTusTakimi.Text.Substring(0, tTusTakimi.Text.Length - 1);
                }
            }
            else
            {
                tTusTakimi.Text += b.Text;
            }

        }

        private void bhizli_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(6, b.Name.Length - 6));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bHizli" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + "0" + fiyat.ToString("C2");
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tTusTakimi.Text != "")
            {
                tbMiktar.Text = tTusTakimi.Text;
                tTusTakimi.Clear();
                tBarkod.Clear();
                tBarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tTusTakimi.Text != "")
            {
                double sonuc = Islemler.DoubleYap(tTusTakimi.Text) - Islemler.DoubleYap(tbGenelToplam.Text);
                tbParaUstu.Text = sonuc.ToString();
                tbOdenen.Text = Islemler.DoubleYap(tTusTakimi.Text).ToString("C2");
                tTusTakimi.Clear();
                tBarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {

        }
        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(tbGenelToplam.Text);
            tbOdenen.Text = Islemler.DoubleYap(b.Text).ToString("C2");
            tbParaUstu.Text = sonuc.ToString("C2");
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (tTusTakimi.Text != "")
            {
                int satirsayisi = gridSatisListesi.RowCount;
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tTusTakimi.Text);
                gridSatisListesi.Rows[satirsayisi].Cells["KDVTutari"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tTusTakimi.Text);
                tTusTakimi.Text = "";
                GenelToplam();
                tBarkod.Focus();

            }
        }

        private void biade_Click(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Checked = false;
                chSatisIadeIslemi.Text = "Satış Yapılıyor";
            }
            else
            {
                chSatisIadeIslemi.Checked = true;
                chSatisIadeIslemi.Text = "İade Yapılıyor";
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void Temizle()
        {
            tbMiktar.Text = "1";
            tBarkod.Clear();
            tbOdenen.Clear();
            tbParaUstu.Clear();
            tbGenelToplam.Clear();
            chSatisIadeIslemi.Checked = false;
            tTusTakimi.Clear();
            tTusTakimi.Text = "0";
            gridSatisListesi.Rows.Clear();
            tBarkod.Clear();
            tBarkod.Focus();
        }
        public void SatisYap(string odemesekli)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            bool satisiade = chSatisIadeIslemi.Checked;
            double alisfiyattoplam = 0;
            if (satirsayisi > 0)
            {
                int? islemno = db.Islem.First().IslemNo;
                Satis satis = new Satis();
                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemno;
                    satis.UrunAd = gridSatisListesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.UrunGrup = gridSatisListesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = gridSatisListesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyati"].Value.ToString());
                    satis.SatisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KDVTutari = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["KDVTutari"].Value.ToString()) * Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.OdemeSekli = odemesekli;
                    satis.Iade = satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;
                    db.Satis.Add(satis);
                    db.SaveChanges();


                    if (!satisiade)
                    {
                        Islemler.StokAzalt(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));

                    }
                    else
                    {
                        Islemler.StokArtir(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));

                    }
                    alisfiyattoplam += Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyati"].Value.ToString()) * Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                }

                IslemOzet io = new IslemOzet();
                io.IslemNo = islemno;
                io.Iade = satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                if (satisiade)
                {
                    io.Aciklama = "İade İşlemi(" + odemesekli + ")";
                }
                else
                {
                    io.Aciklama = odemesekli + "Satış";
                }
                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;
                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = Islemler.DoubleYap(tbGenelToplam.Text);
                        io.Kart = 0; break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = Islemler.DoubleYap(tbGenelToplam.Text); break;
                    case "Kart-Nakit":
                        io.Nakit = Islemler.DoubleYap(lNakit.Text);
                        io.Kart = Islemler.DoubleYap(lKart.Text); break;
                }
                db.IslemOzet.Add(io);
                db.SaveChanges();

                var islemnoartir = db.Islem.First();
                islemnoartir.IslemNo += 1;
                db.SaveChanges();
                MessageBox.Show("yazdır");
                Temizle();
            }
        }

        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void bKrediKarti_Click(object sender, EventArgs e)
        {
            SatisYap("Kredi Kartı");
        }

        private void bKrediNakit_Click(object sender, EventArgs e)
        {
            NakitKart f = new NakitKart();
            f.ShowDialog();
        }

        private void tBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tTusTakimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SatisYap("Nakit");
            if (e.KeyCode == Keys.F2)
                SatisYap("Kredi Kartı");
            if (e.KeyCode == Keys.F3)
            {
                NakitKart f = new NakitKart();
                f.ShowDialog();
            }
        }

        private void chSatisIadeIslemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Text = "İade yapılıyor";
            }
            else
            {
                chSatisIadeIslemi.Text = "satış yapılıyor";
            }
        }

        private void lKullanici_Click(object sender, EventArgs e)
        {

        }
    }
}
