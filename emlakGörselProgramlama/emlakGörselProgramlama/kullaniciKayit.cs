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
    public partial class kullaniciKayit : Form
    {
        public kullaniciKayit()
        {
            InitializeComponent();
        }
        Sinif _sinif = new Sinif();
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
                if (item is TextBox)
                    item.Text = null;
        }

        private void kullaniciKayit_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Programı ilk kez çalıştırdığınız için kayıtlı kullanıcı bulunamamıştır. Lütfen kayıt olunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kullaniciKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifre.Text != "" && txtAdSoyad.Text != "")
                {
                    if (txtSifre.Text.Length >= 6)
                    {
                        if (txtSifre.Text == txtSifreTekrar.Text)
                        {
                            if (_sinif.emailRegex.IsMatch(txtEPosta.Text))
                            {
                                string sorgu = "INSERT INTO kullanici(kullaniciAdi, sifre, ePosta, adSoyad) VALUES (@1, @2, @3, @4)";
                                _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                                _sinif.komut.Parameters.AddWithValue("@1", txtKullaniciAdi.Text);
                                _sinif.komut.Parameters.AddWithValue("@2", txtSifre.Text);
                                _sinif.komut.Parameters.AddWithValue("@3", txtEPosta.Text);
                                _sinif.komut.Parameters.AddWithValue("@4", txtAdSoyad.Text);
                                _sinif.komut.ExecuteNonQuery();     
                                this.Hide();
                                kullaniciGirisi klncgrs = new kullaniciGirisi();
                                klncgrs.Show();
                            }
                            else
                                MessageBox.Show("E-posta adresiniz hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Şifreler birbiri ile uyuşmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Şifreniz en az 6 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }
        private void kullaniciKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            kullaniciGirisi klncgrs = new kullaniciGirisi();
            klncgrs.Show();
            this.Hide();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
