namespace SatisDeneme
{
    partial class UrunEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lKullanici = new System.Windows.Forms.Label();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bIptal = new System.Windows.Forms.Button();
            this.bBarkodOlustur = new System.Windows.Forms.Button();
            this.tUrunSayisi = new System.Windows.Forms.TextBox();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bUrunGrubuEkle = new System.Windows.Forms.Button();
            this.tkdvOrani = new System.Windows.Forms.TextBox();
            this.tMiktar = new System.Windows.Forms.TextBox();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tUrunAdi = new System.Windows.Forms.TextBox();
            this.tBarkod = new System.Windows.Forms.TextBox();
            this.cmUrunGrubu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.BackgroundImage = global::SatisDeneme.Properties.Resources.indir;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.bKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.bIptal);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkodOlustur);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubuEkle);
            this.splitContainer1.Panel1.Controls.Add(this.tkdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.cmUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1411, 897);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 1;
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatisFiyati.Location = new System.Drawing.Point(780, 110);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(173, 30);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(186, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "standart";
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKullanici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lKullanici.Location = new System.Drawing.Point(83, 23);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(97, 24);
            this.lKullanici.TabIndex = 25;
            this.lKullanici.Text = "Kullanıcı:";
            this.lKullanici.Visible = false;
            this.lKullanici.Click += new System.EventHandler(this.lKullanici_Click);
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.Tomato;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bKaydet.Image = global::SatisDeneme.Properties.Resources.save24;
            this.bKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bKaydet.Location = new System.Drawing.Point(1001, 160);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(142, 71);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bIptal
            // 
            this.bIptal.BackColor = System.Drawing.Color.LightCoral;
            this.bIptal.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.bIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bIptal.Image = global::SatisDeneme.Properties.Resources.remove1;
            this.bIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bIptal.Location = new System.Drawing.Point(1001, 60);
            this.bIptal.Margin = new System.Windows.Forms.Padding(0);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(142, 71);
            this.bIptal.TabIndex = 9;
            this.bIptal.Text = "İptal";
            this.bIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bIptal.UseVisualStyleBackColor = false;
            this.bIptal.Click += new System.EventHandler(this.bIptal_Click);
            // 
            // bBarkodOlustur
            // 
            this.bBarkodOlustur.BackColor = System.Drawing.Color.RosyBrown;
            this.bBarkodOlustur.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.bBarkodOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodOlustur.Image = global::SatisDeneme.Properties.Resources.barcode4832;
            this.bBarkodOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bBarkodOlustur.Location = new System.Drawing.Point(316, 187);
            this.bBarkodOlustur.Margin = new System.Windows.Forms.Padding(0);
            this.bBarkodOlustur.Name = "bBarkodOlustur";
            this.bBarkodOlustur.Size = new System.Drawing.Size(142, 100);
            this.bBarkodOlustur.TabIndex = 11;
            this.bBarkodOlustur.Text = "Barkod Oluştur";
            this.bBarkodOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bBarkodOlustur.UseVisualStyleBackColor = false;
            this.bBarkodOlustur.Click += new System.EventHandler(this.bBarkodOlustur_Click);
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunSayisi.Location = new System.Drawing.Point(780, 267);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.Size = new System.Drawing.Size(173, 30);
            this.tUrunSayisi.TabIndex = 20;
            this.tUrunSayisi.TabStop = false;
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(166, 304);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(292, 30);
            this.tUrunAra.TabIndex = 12;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(660, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ürün Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(54, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ürün Ara";
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.Color.IndianRed;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubuEkle.Image = global::SatisDeneme.Properties.Resources.Ekle241;
            this.bUrunGrubuEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(166, 187);
            this.bUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(142, 100);
            this.bUrunGrubuEkle.TabIndex = 10;
            this.bUrunGrubuEkle.Text = "Ürün Grubu Ekle";
            this.bUrunGrubuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // tkdvOrani
            // 
            this.tkdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkdvOrani.Location = new System.Drawing.Point(780, 207);
            this.tkdvOrani.Name = "tkdvOrani";
            this.tkdvOrani.Size = new System.Drawing.Size(173, 30);
            this.tkdvOrani.TabIndex = 7;
            this.tkdvOrani.Text = "8";
            this.tkdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tMiktar.Location = new System.Drawing.Point(780, 152);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(173, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlisFiyati.Location = new System.Drawing.Point(780, 63);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(173, 30);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(674, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kdv Oranı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(702, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(663, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(674, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alış Fiyatı";
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAdi.Location = new System.Drawing.Point(168, 108);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(292, 30);
            this.tUrunAdi.TabIndex = 1;
            // 
            // tBarkod
            // 
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBarkod.Location = new System.Drawing.Point(168, 64);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(292, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // cmUrunGrubu
            // 
            this.cmUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmUrunGrubu.FormattingEnabled = true;
            this.cmUrunGrubu.Location = new System.Drawing.Point(168, 148);
            this.cmUrunGrubu.Name = "cmUrunGrubu";
            this.cmUrunGrubu.Size = new System.Drawing.Size(292, 28);
            this.cmUrunGrubu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Grubu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.Size = new System.Drawing.Size(1411, 485);
            this.gridUrunler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // UrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::SatisDeneme.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(1411, 897);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UrunEkleme";
            this.Text = "UrunEkleme";
            this.Load += new System.EventHandler(this.UrunEkleme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bIptal;
        private System.Windows.Forms.Button bBarkodOlustur;
        private System.Windows.Forms.TextBox tUrunSayisi;
        private System.Windows.Forms.TextBox tUrunAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bUrunGrubuEkle;
        private System.Windows.Forms.TextBox tkdvOrani;
        private System.Windows.Forms.TextBox tMiktar;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBarkod;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmUrunGrubu;
        internal System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.Label lKullanici;
    }
}