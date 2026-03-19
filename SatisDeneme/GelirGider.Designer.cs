namespace SatisDeneme
{
    partial class GelirGider
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.tNakit = new System.Windows.Forms.TextBox();
            this.tKart = new System.Windows.Forms.TextBox();
            this.tAciklama = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.bEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gelir Gider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ödeme Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nakit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(203, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT\t",
            "KART",
            "KART-NAKİT"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(43, 132);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(279, 28);
            this.cmbOdemeTuru.TabIndex = 29;
            // 
            // tNakit
            // 
            this.tNakit.Location = new System.Drawing.Point(43, 231);
            this.tNakit.Multiline = true;
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(119, 25);
            this.tNakit.TabIndex = 30;
            // 
            // tKart
            // 
            this.tKart.Location = new System.Drawing.Point(207, 231);
            this.tKart.Multiline = true;
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(115, 25);
            this.tKart.TabIndex = 31;
            // 
            // tAciklama
            // 
            this.tAciklama.Location = new System.Drawing.Point(43, 321);
            this.tAciklama.Multiline = true;
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(279, 85);
            this.tAciklama.TabIndex = 32;
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(43, 459);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(279, 26);
            this.dtTarih.TabIndex = 35;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.Location = new System.Drawing.Point(219, 509);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(103, 49);
            this.bEkle.TabIndex = 36;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 581);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.tAciklama);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.TextBox tNakit;
        private System.Windows.Forms.TextBox tKart;
        private System.Windows.Forms.TextBox tAciklama;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button bEkle;
    }
}