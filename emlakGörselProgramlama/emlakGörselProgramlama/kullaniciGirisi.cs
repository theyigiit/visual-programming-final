using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace emlakGörselProgramlama
{
    
    public partial class kullaniciGirisi : Form
    {
        
        public kullaniciGirisi()
        {
            InitializeComponent();
        }
        Sinif _sinif = new Sinif();
        
        private void kullaniciGirisi_Load(object sender, EventArgs e)
        {
            try
            {
               
                if (_sinif.dataTableDoldur("kullanici").Rows.Count == 0)
                {
                    kullaniciKayit KullaniciKayit = new kullaniciKayit();
                    KullaniciKayit.ShowDialog();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                string sorgu = "select kullaniciAdi, sifre from kullanici where kullaniciAdi = '" + txtKullaniciAdi.Text + "' and sifre = '" + txtSifre.Text + "'";
                _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = _sinif.komut.ExecuteReader();
                if (dr.Read())
                {
                    anaForm anaform = new anaForm();
                    anaform.Show();
                    this.Hide();
                    
                }
                else
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }

        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum SifremiUnuttum = new sifremiUnuttum();
            SifremiUnuttum.ShowDialog();
            this.Hide();
        }
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciKayit kyt = new kullaniciKayit();
            kyt.Show();
            this.Hide();
        }

        private void kullaniciGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
