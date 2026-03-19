namespace SatisDeneme
{
    partial class HizliUrunEkleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lButonNumarasi = new System.Windows.Forms.Label();
            this.lButonId = new System.Windows.Forms.Label();
            this.chTümü = new System.Windows.Forms.CheckBox();
            this.lÜrünAra = new System.Windows.Forms.Label();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lButonNumarasi);
            this.splitContainer1.Panel1.Controls.Add(this.lButonId);
            this.splitContainer1.Panel1.Controls.Add(this.chTümü);
            this.splitContainer1.Panel1.Controls.Add(this.lÜrünAra);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(883, 503);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // lButonNumarasi
            // 
            this.lButonNumarasi.AutoSize = true;
            this.lButonNumarasi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lButonNumarasi.Location = new System.Drawing.Point(12, 9);
            this.lButonNumarasi.Name = "lButonNumarasi";
            this.lButonNumarasi.Size = new System.Drawing.Size(149, 22);
            this.lButonNumarasi.TabIndex = 7;
            this.lButonNumarasi.Text = "Buton Numarası:";
            // 
            // lButonId
            // 
            this.lButonId.AutoSize = true;
            this.lButonId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lButonId.Location = new System.Drawing.Point(195, 9);
            this.lButonId.Name = "lButonId";
            this.lButonId.Size = new System.Drawing.Size(88, 22);
            this.lButonId.TabIndex = 6;
            this.lButonId.Text = "Buton No";
            // 
            // chTümü
            // 
            this.chTümü.AutoSize = true;
            this.chTümü.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chTümü.Location = new System.Drawing.Point(324, 90);
            this.chTümü.Name = "chTümü";
            this.chTümü.Size = new System.Drawing.Size(151, 26);
            this.chTümü.TabIndex = 5;
            this.chTümü.Text = "Hepsini Göster";
            this.chTümü.UseVisualStyleBackColor = true;
            this.chTümü.CheckedChanged += new System.EventHandler(this.chTümü_CheckedChanged);
            // 
            // lÜrünAra
            // 
            this.lÜrünAra.AutoSize = true;
            this.lÜrünAra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lÜrünAra.Location = new System.Drawing.Point(12, 47);
            this.lÜrünAra.Name = "lÜrünAra";
            this.lÜrünAra.Size = new System.Drawing.Size(86, 22);
            this.lÜrünAra.TabIndex = 4;
            this.lÜrünAra.Text = "Ürün Ara";
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(16, 81);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(292, 38);
            this.tUrunAra.TabIndex = 3;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.Height = 32;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(883, 368);
            this.gridUrunler.TabIndex = 2;
            this.gridUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrunler_CellContentDoubleClick);
            // 
            // HizliUrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HizliUrunEkleme";
            this.Text = "Hızlı Ürün Ekleme";
            this.Load += new System.EventHandler(this.HizliUrunEkleme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.CheckBox chTümü;
        private System.Windows.Forms.Label lÜrünAra;
        private System.Windows.Forms.TextBox tUrunAra;
        private System.Windows.Forms.Label lButonNumarasi;
        public System.Windows.Forms.Label lButonId;
    }
}