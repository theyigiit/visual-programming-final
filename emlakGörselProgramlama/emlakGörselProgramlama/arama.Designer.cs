
namespace emlakGörselProgramlama
{
    partial class arama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arama));
            this.rbtnKiralikKonut = new System.Windows.Forms.RadioButton();
            this.rbtnSatilikKonut = new System.Windows.Forms.RadioButton();
            this.txtMaxMetrekare = new System.Windows.Forms.TextBox();
            this.txtMinMetrekare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cbIsitma = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEmlakTipi = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnKiralikKonut
            // 
            this.rbtnKiralikKonut.AutoSize = true;
            this.rbtnKiralikKonut.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnKiralikKonut.Location = new System.Drawing.Point(408, 125);
            this.rbtnKiralikKonut.Name = "rbtnKiralikKonut";
            this.rbtnKiralikKonut.Size = new System.Drawing.Size(136, 26);
            this.rbtnKiralikKonut.TabIndex = 42;
            this.rbtnKiralikKonut.Text = "Kiralık Konut";
            this.rbtnKiralikKonut.UseVisualStyleBackColor = true;
            // 
            // rbtnSatilikKonut
            // 
            this.rbtnSatilikKonut.AutoSize = true;
            this.rbtnSatilikKonut.Checked = true;
            this.rbtnSatilikKonut.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSatilikKonut.Location = new System.Drawing.Point(256, 125);
            this.rbtnSatilikKonut.Name = "rbtnSatilikKonut";
            this.rbtnSatilikKonut.Size = new System.Drawing.Size(135, 26);
            this.rbtnSatilikKonut.TabIndex = 41;
            this.rbtnSatilikKonut.TabStop = true;
            this.rbtnSatilikKonut.Text = "Satılık Konut";
            this.rbtnSatilikKonut.UseVisualStyleBackColor = true;
            // 
            // txtMaxMetrekare
            // 
            this.txtMaxMetrekare.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxMetrekare.Location = new System.Drawing.Point(240, 57);
            this.txtMaxMetrekare.MaxLength = 10;
            this.txtMaxMetrekare.Name = "txtMaxMetrekare";
            this.txtMaxMetrekare.Size = new System.Drawing.Size(71, 29);
            this.txtMaxMetrekare.TabIndex = 39;
            this.txtMaxMetrekare.Text = "0";
            // 
            // txtMinMetrekare
            // 
            this.txtMinMetrekare.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinMetrekare.Location = new System.Drawing.Point(161, 57);
            this.txtMinMetrekare.MaxLength = 10;
            this.txtMinMetrekare.Name = "txtMinMetrekare";
            this.txtMinMetrekare.Size = new System.Drawing.Size(71, 29);
            this.txtMinMetrekare.TabIndex = 38;
            this.txtMinMetrekare.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "-";
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxFiyat.Location = new System.Drawing.Point(240, 24);
            this.txtMaxFiyat.MaxLength = 10;
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(71, 29);
            this.txtMaxFiyat.TabIndex = 35;
            this.txtMaxFiyat.Text = "0";
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinFiyat.Location = new System.Drawing.Point(161, 24);
            this.txtMinFiyat.MaxLength = 10;
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(71, 29);
            this.txtMinFiyat.TabIndex = 34;
            this.txtMinFiyat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(568, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(81, 39);
            this.btnAra.TabIndex = 33;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cbIsitma
            // 
            this.cbIsitma.DropDownHeight = 165;
            this.cbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsitma.DropDownWidth = 185;
            this.cbIsitma.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsitma.FormattingEnabled = true;
            this.cbIsitma.IntegralHeight = false;
            this.cbIsitma.Items.AddRange(new object[] {
            "Klima",
            "Merkezi Sistem",
            "Güneş Enerjisi",
            "Kombi (Elektrikli)",
            "Isıtma Sistemi Yok",
            "Jeotermal",
            "Kalorifer (Akaryakıt)",
            "Kalorifer (Doğalgaz)",
            "Kalorifer (Kömür)",
            "Kat Kaloriferi (Akaryakıt)",
            "Kombi (Doğalgaz)",
            "Soba (Doğalgaz)",
            "Soba (Kömür)",
            "Yerden Isıtma"});
            this.cbIsitma.Location = new System.Drawing.Point(496, 60);
            this.cbIsitma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsitma.Name = "cbIsitma";
            this.cbIsitma.Size = new System.Drawing.Size(153, 30);
            this.cbIsitma.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(390, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 22);
            this.label15.TabIndex = 31;
            this.label15.Text = "Isıtma:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(317, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 22);
            this.label21.TabIndex = 29;
            this.label21.Text = "m²";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(51, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 22);
            this.label20.TabIndex = 30;
            this.label20.Text = "Metrekare:";
            // 
            // cbEmlakTipi
            // 
            this.cbEmlakTipi.DropDownHeight = 212;
            this.cbEmlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakTipi.DropDownWidth = 165;
            this.cbEmlakTipi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmlakTipi.FormattingEnabled = true;
            this.cbEmlakTipi.IntegralHeight = false;
            this.cbEmlakTipi.Items.AddRange(new object[] {
            "Ahşap Ev",
            "Apartman",
            "Apartman Dairesi",
            "Çiftlik Evi",
            "Dağ Evi",
            "Daire (Bahçe Dublex)",
            "Daire (Çatı Dublex)",
            "Dublex",
            "Fourlex",
            "İkiz Ev",
            "Köşk",
            "Köy Evi",
            "Malikane",
            "Müstakil Ev",
            "Residence",
            "Stüdyo",
            "Townhouse",
            "Triplex",
            "Villa",
            "Yalı",
            "Taş Ev",
            "Apart"});
            this.cbEmlakTipi.Location = new System.Drawing.Point(496, 25);
            this.cbEmlakTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmlakTipi.Name = "cbEmlakTipi";
            this.cbEmlakTipi.Size = new System.Drawing.Size(153, 30);
            this.cbEmlakTipi.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(390, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 22);
            this.label19.TabIndex = 27;
            this.label19.Text = "Emlak Tipi:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 178);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(677, 200);
            this.dgv.TabIndex = 43;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(677, 380);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.rbtnKiralikKonut);
            this.Controls.Add(this.rbtnSatilikKonut);
            this.Controls.Add(this.txtMaxMetrekare);
            this.Controls.Add(this.txtMinMetrekare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbIsitma);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbEmlakTipi);
            this.Controls.Add(this.label19);
            this.Name = "arama";
            this.Text = "arama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.arama_FormClosed);
            this.Load += new System.EventHandler(this.arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEmlakTipi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbIsitma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxMetrekare;
        private System.Windows.Forms.TextBox txtMinMetrekare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSatilikKonut;
        private System.Windows.Forms.RadioButton rbtnKiralikKonut;
        private System.Windows.Forms.DataGridView dgv;
    }
}