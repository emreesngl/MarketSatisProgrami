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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEPosta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            chSAtisEkrani.Checked = false;
            chRapor.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekleme.Checked = false;
            tSifreTekrar.Clear();
        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new MarketDBEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAdi == tKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEPosta.Text;
                                    k.KullaniciAdi = tKullaniciAdi.Text;
                                    k.Sifre = tSifre.Text;
                                    k.Satis = chSAtisEkrani.Checked;
                                    k.Rapor = chRapor.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.FiyatGuncelle = chFiyatGuncelle.Checked;
                                    k.Yedekleme = chYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    Doldur();   
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                                }
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hata Oluştu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor");
                    }


                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu girişleri yapınız" + "\nAd Soyad \nTelefon \nKullanıcı \nŞifre \nŞifre Tekrar");
                }
            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lKullaniciId.Text);
                        using (var db=new MarketDBEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.EPosta = tEPosta.Text;
                            guncelle.KullaniciAdi = tKullaniciAdi.Text;
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satis = chSAtisEkrani.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("güncelleme yapıldı");
                            bKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu girişleri yapınız" + "\nAd Soyad \nTelefon \nKullanıcı \nŞifre \nŞifre Tekrar");
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();
                using (var db = new MarketDBEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEPosta.Text = getir.EPosta;
                    tKullaniciAdi.Text = getir.KullaniciAdi;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSAtisEkrani.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    chYedekleme.Checked = (bool)getir.Yedekleme;
                    bKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz");
            }
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            Doldur();
            
        }
        private void Doldur()
        {
            using (var db = new MarketDBEntities())
            {
                gridListeKullanici.DataSource = db.Kullanici.Select(x => new {x.Id, x.AdSoyad, x.KullaniciAdi, x.Telefon }).ToList();
            }
        }
    }
}
