
namespace emlakGörselProgramlama
{
    partial class musterilerAlici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musterilerAlici));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbEmlakDurumu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEmlakTipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.cbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(12, 355);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 42);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(173, 355);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 42);
            this.btnGuncelle.TabIndex = 36;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbEmlakDurumu
            // 
            this.cbEmlakDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakDurumu.FormattingEnabled = true;
            this.cbEmlakDurumu.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cbEmlakDurumu.Location = new System.Drawing.Point(161, 140);
            this.cbEmlakDurumu.Name = "cbEmlakDurumu";
            this.cbEmlakDurumu.Size = new System.Drawing.Size(150, 24);
            this.cbEmlakDurumu.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Emlak Durumu:";
            // 
            // cbEmlakTipi
            // 
            this.cbEmlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakTipi.FormattingEnabled = true;
            this.cbEmlakTipi.Items.AddRange(new object[] {
            "Konut",
            "İşyeri",
            "Arsa"});
            this.cbEmlakTipi.Location = new System.Drawing.Point(161, 110);
            this.cbEmlakTipi.Name = "cbEmlakTipi";
            this.cbEmlakTipi.Size = new System.Drawing.Size(150, 24);
            this.cbEmlakTipi.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Emlak Tipi:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(12, 307);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(154, 42);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(173, 307);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 42);
            this.btnEkle.TabIndex = 33;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(161, 199);
            this.txtAciklama.MaxLength = 255;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(150, 77);
            this.txtAciklama.TabIndex = 32;
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Location = new System.Drawing.Point(240, 170);
            this.txtMaxFiyat.MaxLength = 10;
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(71, 22);
            this.txtMaxFiyat.TabIndex = 31;
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Location = new System.Drawing.Point(161, 170);
            this.txtMinFiyat.MaxLength = 10;
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(71, 22);
            this.txtMinFiyat.TabIndex = 30;
            this.txtMinFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinFiyat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // mtxtTelefon2
            // 
            this.mtxtTelefon2.Location = new System.Drawing.Point(161, 81);
            this.mtxtTelefon2.Mask = "(999) 000 00 00";
            this.mtxtTelefon2.Name = "mtxtTelefon2";
            this.mtxtTelefon2.Size = new System.Drawing.Size(150, 22);
            this.mtxtTelefon2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefon 2:";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(161, 52);
            this.mtxtTelefon.Mask = "(999) 000 00 00";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(150, 22);
            this.mtxtTelefon.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Telefon:";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(286, 23);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(25, 24);
            this.btnYeni.TabIndex = 39;
            this.btnYeni.Text = "+";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // cbAdSoyad
            // 
            this.cbAdSoyad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdSoyad.FormattingEnabled = true;
            this.cbAdSoyad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAdSoyad.IntegralHeight = false;
            this.cbAdSoyad.ItemHeight = 16;
            this.cbAdSoyad.Location = new System.Drawing.Point(161, 22);
            this.cbAdSoyad.Name = "cbAdSoyad";
            this.cbAdSoyad.Size = new System.Drawing.Size(119, 24);
            this.cbAdSoyad.TabIndex = 25;
            this.cbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cbAdSoyad_SelectedIndexChanged);
            this.cbAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAdSoyad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ad Soyad:";
            // 
            // musterilerAlici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(355, 430);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbEmlakDurumu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEmlakTipi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtTelefon2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.cbAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "musterilerAlici";
            this.Text = "musterilerAlici";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.musterilerAlici_FormClosed);
            this.Load += new System.EventHandler(this.musterilerAlici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbEmlakDurumu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEmlakTipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeni;
        public System.Windows.Forms.ComboBox cbAdSoyad;
        private System.Windows.Forms.Label label1;
    }
}