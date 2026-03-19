namespace SatisDeneme
{
    partial class Stok
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lIslemTuru = new System.Windows.Forms.Label();
            this.cmIslemTuru = new System.Windows.Forms.ComboBox();
            this.bAra = new System.Windows.Forms.Button();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lBitisTarihi = new System.Windows.Forms.Label();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lBaslangicTarihi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lUrunGrubu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lKullanici = new System.Windows.Forms.Label();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.lUrunAra = new System.Windows.Forms.Label();
            this.gridListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 665);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lIslemTuru);
            this.panel4.Controls.Add(this.cmIslemTuru);
            this.panel4.Location = new System.Drawing.Point(16, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 67);
            this.panel4.TabIndex = 34;
            // 
            // lIslemTuru
            // 
            this.lIslemTuru.AutoSize = true;
            this.lIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lIslemTuru.Location = new System.Drawing.Point(9, 6);
            this.lIslemTuru.Name = "lIslemTuru";
            this.lIslemTuru.Size = new System.Drawing.Size(93, 20);
            this.lIslemTuru.TabIndex = 27;
            this.lIslemTuru.Text = "İşlem Türü";
            // 
            // cmIslemTuru
            // 
            this.cmIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmIslemTuru.FormattingEnabled = true;
            this.cmIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmIslemTuru.Location = new System.Drawing.Point(13, 29);
            this.cmIslemTuru.Name = "cmIslemTuru";
            this.cmIslemTuru.Size = new System.Drawing.Size(242, 28);
            this.cmIslemTuru.TabIndex = 28;
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Tomato;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.Location = new System.Drawing.Point(147, 446);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(124, 71);
            this.bAra.TabIndex = 25;
            this.bAra.Text = "Ara";
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitisTarihi);
            this.panelTarihler.Controls.Add(this.lBitisTarihi);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Controls.Add(this.lBaslangicTarihi);
            this.panelTarihler.Location = new System.Drawing.Point(16, 259);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(258, 184);
            this.panelTarihler.TabIndex = 34;
            // 
            // dateBitisTarihi
            // 
            this.dateBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitisTarihi.Location = new System.Drawing.Point(13, 122);
            this.dateBitisTarihi.Name = "dateBitisTarihi";
            this.dateBitisTarihi.Size = new System.Drawing.Size(242, 26);
            this.dateBitisTarihi.TabIndex = 36;
            // 
            // lBitisTarihi
            // 
            this.lBitisTarihi.AutoSize = true;
            this.lBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBitisTarihi.Location = new System.Drawing.Point(9, 99);
            this.lBitisTarihi.Name = "lBitisTarihi";
            this.lBitisTarihi.Size = new System.Drawing.Size(93, 20);
            this.lBitisTarihi.TabIndex = 35;
            this.lBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(13, 51);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(242, 26);
            this.dateBaslangic.TabIndex = 34;
            // 
            // lBaslangicTarihi
            // 
            this.lBaslangicTarihi.AutoSize = true;
            this.lBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBaslangicTarihi.Location = new System.Drawing.Point(9, 28);
            this.lBaslangicTarihi.Name = "lBaslangicTarihi";
            this.lBaslangicTarihi.Size = new System.Drawing.Size(136, 20);
            this.lBaslangicTarihi.TabIndex = 33;
            this.lBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmUrunGrubu);
            this.panel2.Controls.Add(this.lUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(16, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 71);
            this.panel2.TabIndex = 32;
            // 
            // cmUrunGrubu
            // 
            this.cmUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmUrunGrubu.FormattingEnabled = true;
            this.cmUrunGrubu.Location = new System.Drawing.Point(13, 27);
            this.cmUrunGrubu.Name = "cmUrunGrubu";
            this.cmUrunGrubu.Size = new System.Drawing.Size(242, 28);
            this.cmUrunGrubu.TabIndex = 33;
            // 
            // lUrunGrubu
            // 
            this.lUrunGrubu.AutoSize = true;
            this.lUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUrunGrubu.Location = new System.Drawing.Point(9, 4);
            this.lUrunGrubu.Name = "lUrunGrubu";
            this.lUrunGrubu.Size = new System.Drawing.Size(103, 20);
            this.lUrunGrubu.TabIndex = 32;
            this.lUrunGrubu.Text = "Urun Grubu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdUrunGrubunaGore);
            this.panel1.Controls.Add(this.rdTumu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 100);
            this.panel1.TabIndex = 31;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(13, 63);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(118, 17);
            this.rdUrunGrubunaGore.TabIndex = 31;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Location = new System.Drawing.Point(13, 30);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(52, 17);
            this.rdTumu.TabIndex = 30;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filtreleme Türü";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lUrunAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(714, 665);
            this.splitContainer2.SplitterDistance = 75;
            this.splitContainer2.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKullanici.Location = new System.Drawing.Point(505, 32);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(116, 22);
            this.lKullanici.TabIndex = 35;
            this.lKullanici.Text = "KULLANICI";
            this.lKullanici.Visible = false;
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(102, 28);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(292, 30);
            this.tUrunAra.TabIndex = 29;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lUrunAra
            // 
            this.lUrunAra.AutoSize = true;
            this.lUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUrunAra.Location = new System.Drawing.Point(15, 35);
            this.lUrunAra.Name = "lUrunAra";
            this.lUrunAra.Size = new System.Drawing.Size(81, 20);
            this.lUrunAra.TabIndex = 28;
            this.lUrunAra.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.Size = new System.Drawing.Size(714, 586);
            this.gridListe.StandardTab = true;
            this.gridListe.TabIndex = 1;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Stok";
            this.Text = "Stok Ekranı";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label lIslemTuru;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cmUrunGrubu;
        public System.Windows.Forms.Label lUrunGrubu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdTumu;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmIslemTuru;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dateBitisTarihi;
        public System.Windows.Forms.Label lBitisTarihi;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        public System.Windows.Forms.Label lBaslangicTarihi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bAra;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.Label lUrunAra;
        public System.Windows.Forms.TextBox tUrunAra;
        public System.Windows.Forms.DataGridView gridListe;
        internal System.Windows.Forms.Label lKullanici;
    }
}