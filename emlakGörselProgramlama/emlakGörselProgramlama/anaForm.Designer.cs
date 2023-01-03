
namespace emlakGörselProgramlama
{
    partial class anaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satılıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satılıkToolStripMenuItem,
            this.kiralıkToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.aramaToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // satılıkToolStripMenuItem
            // 
            this.satılıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konutToolStripMenuItem,
            this.işYeriToolStripMenuItem});
            this.satılıkToolStripMenuItem.Name = "satılıkToolStripMenuItem";
            this.satılıkToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.satılıkToolStripMenuItem.Text = "Satılık";
            this.satılıkToolStripMenuItem.Click += new System.EventHandler(this.satılıkToolStripMenuItem_Click);
            // 
            // konutToolStripMenuItem
            // 
            this.konutToolStripMenuItem.Name = "konutToolStripMenuItem";
            this.konutToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.konutToolStripMenuItem.Text = "Konut";
            this.konutToolStripMenuItem.Click += new System.EventHandler(this.konutToolStripMenuItem_Click_1);
            // 
            // işYeriToolStripMenuItem
            // 
            this.işYeriToolStripMenuItem.Name = "işYeriToolStripMenuItem";
            this.işYeriToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.işYeriToolStripMenuItem.Text = "İşyeri";
            this.işYeriToolStripMenuItem.Click += new System.EventHandler(this.işYeriToolStripMenuItem_Click_1);
            // 
            // kiralıkToolStripMenuItem
            // 
            this.kiralıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konutToolStripMenuItem1,
            this.işyeriToolStripMenuItem1});
            this.kiralıkToolStripMenuItem.Name = "kiralıkToolStripMenuItem";
            this.kiralıkToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.kiralıkToolStripMenuItem.Text = "Kiralık";
            // 
            // konutToolStripMenuItem1
            // 
            this.konutToolStripMenuItem1.Name = "konutToolStripMenuItem1";
            this.konutToolStripMenuItem1.Size = new System.Drawing.Size(145, 28);
            this.konutToolStripMenuItem1.Text = "Konut";
            this.konutToolStripMenuItem1.Click += new System.EventHandler(this.konutToolStripMenuItem1_Click_1);
            // 
            // işyeriToolStripMenuItem1
            // 
            this.işyeriToolStripMenuItem1.Name = "işyeriToolStripMenuItem1";
            this.işyeriToolStripMenuItem1.Size = new System.Drawing.Size(145, 28);
            this.işyeriToolStripMenuItem1.Text = "İşyeri";
            this.işyeriToolStripMenuItem1.Click += new System.EventHandler(this.işyeriToolStripMenuItem1_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satıcıToolStripMenuItem,
            this.alıcıToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(109, 27);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // satıcıToolStripMenuItem
            // 
            this.satıcıToolStripMenuItem.Name = "satıcıToolStripMenuItem";
            this.satıcıToolStripMenuItem.Size = new System.Drawing.Size(140, 28);
            this.satıcıToolStripMenuItem.Text = "Satıcı";
            this.satıcıToolStripMenuItem.Click += new System.EventHandler(this.satıcıToolStripMenuItem_Click_1);
            // 
            // alıcıToolStripMenuItem
            // 
            this.alıcıToolStripMenuItem.Name = "alıcıToolStripMenuItem";
            this.alıcıToolStripMenuItem.Size = new System.Drawing.Size(140, 28);
            this.alıcıToolStripMenuItem.Text = "Alıcı";
            this.alıcıToolStripMenuItem.Click += new System.EventHandler(this.alıcıToolStripMenuItem_Click);
            // 
            // aramaToolStripMenuItem
            // 
            this.aramaToolStripMenuItem.Name = "aramaToolStripMenuItem";
            this.aramaToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.aramaToolStripMenuItem.Text = "Arama";
            this.aramaToolStripMenuItem.Click += new System.EventHandler(this.aramaToolStripMenuItem_Click_1);
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click_1);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click_1);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click_1);
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarihSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.Location = new System.Drawing.Point(12, 510);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(116, 24);
            this.lblTarihSaat.TabIndex = 2;
            this.lblTarihSaat.Text = "Tarih/Saat :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(825, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(661, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hava Durumu :";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarihSaat);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anaForm";
            this.Text = "anaForm";
            this.Load += new System.EventHandler(this.anaForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satılıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işyeriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}