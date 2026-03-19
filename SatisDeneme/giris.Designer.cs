namespace SatisDeneme
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.lgiris = new System.Windows.Forms.Label();
            this.lkullaniciadi = new System.Windows.Forms.Label();
            this.lsifre = new System.Windows.Forms.Label();
            this.tkullaniciadi = new System.Windows.Forms.TextBox();
            this.tsifre = new System.Windows.Forms.TextBox();
            this.bGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgiris
            // 
            this.lgiris.AutoSize = true;
            this.lgiris.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgiris.Location = new System.Drawing.Point(35, 35);
            this.lgiris.Name = "lgiris";
            this.lgiris.Size = new System.Drawing.Size(0, 22);
            this.lgiris.TabIndex = 0;
            // 
            // lkullaniciadi
            // 
            this.lkullaniciadi.AutoSize = true;
            this.lkullaniciadi.BackColor = System.Drawing.Color.Black;
            this.lkullaniciadi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkullaniciadi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lkullaniciadi.Location = new System.Drawing.Point(27, 55);
            this.lkullaniciadi.Name = "lkullaniciadi";
            this.lkullaniciadi.Size = new System.Drawing.Size(158, 26);
            this.lkullaniciadi.TabIndex = 1;
            this.lkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lsifre
            // 
            this.lsifre.AutoSize = true;
            this.lsifre.BackColor = System.Drawing.Color.Black;
            this.lsifre.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lsifre.Location = new System.Drawing.Point(116, 113);
            this.lsifre.Name = "lsifre";
            this.lsifre.Size = new System.Drawing.Size(69, 26);
            this.lsifre.TabIndex = 2;
            this.lsifre.Text = "Şifre:";
            // 
            // tkullaniciadi
            // 
            this.tkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkullaniciadi.Location = new System.Drawing.Point(191, 52);
            this.tkullaniciadi.Name = "tkullaniciadi";
            this.tkullaniciadi.Size = new System.Drawing.Size(179, 29);
            this.tkullaniciadi.TabIndex = 3;
            // 
            // tsifre
            // 
            this.tsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsifre.Location = new System.Drawing.Point(191, 110);
            this.tsifre.Name = "tsifre";
            this.tsifre.PasswordChar = '*';
            this.tsifre.Size = new System.Drawing.Size(179, 29);
            this.tsifre.TabIndex = 4;
            // 
            // bGirisYap
            // 
            this.bGirisYap.BackColor = System.Drawing.Color.Black;
            this.bGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGirisYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bGirisYap.Location = new System.Drawing.Point(253, 167);
            this.bGirisYap.Margin = new System.Windows.Forms.Padding(0);
            this.bGirisYap.Name = "bGirisYap";
            this.bGirisYap.Size = new System.Drawing.Size(117, 36);
            this.bGirisYap.TabIndex = 5;
            this.bGirisYap.Text = "Giriş Yap";
            this.bGirisYap.UseVisualStyleBackColor = false;
            this.bGirisYap.Click += new System.EventHandler(this.bGirisYap_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.bGirisYap);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.tkullaniciadi);
            this.Controls.Add(this.lsifre);
            this.Controls.Add(this.lkullaniciadi);
            this.Controls.Add(this.lgiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgiris;
        private System.Windows.Forms.Label lkullaniciadi;
        private System.Windows.Forms.Label lsifre;
        private System.Windows.Forms.TextBox tkullaniciadi;
        private System.Windows.Forms.TextBox tsifre;
        private System.Windows.Forms.Button bGirisYap;
    }
}