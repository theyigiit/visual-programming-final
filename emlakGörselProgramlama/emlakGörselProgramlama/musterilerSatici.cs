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

namespace emlakGörselProgramlama
{
    public partial class musterilerSatici : Form
    {
        public musterilerSatici()
        {
            InitializeComponent();
        }
        Sinif _sinif = new Sinif();
        private void temizle()
        {
            foreach (Control item in this.Controls)
                if (!(item is Label) && !(item is Button))
                    item.Text = null;
            cbAdSoyad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAdSoyad.Size = new System.Drawing.Size(119, 24);
            btnYeni.Visible = true;
        }

        private void cbAdSoyadDoldur()
        {
            cbAdSoyad.ValueMember = "id";
            cbAdSoyad.DisplayMember = "adSoyad";
            cbAdSoyad.DataSource = _sinif.dataTableDoldur("musterilerSatici");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            cbAdSoyad.DropDownStyle = ComboBoxStyle.DropDown;
            cbAdSoyad.Size = new System.Drawing.Size(150, 24);
            btnYeni.Visible = false;
            _sinif.yardimciDegisken = Convert.ToInt16(cbAdSoyad.SelectedValue);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbAdSoyad.Text != "")
                {
                    string sorgu = "INSERT INTO musterilersatici(adSoyad, telefon, telefon2, aciklama) VALUES (@1, @2, @3, @4)";
                    _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                    _sinif.komut.Parameters.AddWithValue("@1", cbAdSoyad.Text);
                    _sinif.komut.Parameters.AddWithValue("@2", mtxtTelefon.Text);
                    _sinif.komut.Parameters.AddWithValue("@3", mtxtTelefon2.Text);
                    _sinif.komut.Parameters.AddWithValue("@4", txtAciklama.Text);
                    _sinif.komut.ExecuteNonQuery();
                    cbAdSoyadDoldur();
                    temizle();  
                }
                else
                    MessageBox.Show("Lütfen ad soyad girişi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }

        private void frmMusterilerSatici_Load(object sender, EventArgs e)
        {
            try
            {
                
                cbAdSoyadDoldur();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void frmMusterilerSatici_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sinif.yardimciDegisken = Convert.ToInt16(cbAdSoyad.SelectedValue);
            try
            {
                Sinif.baglan.Open();
                string sorgu = "select * from musterilersatici where id = " + Convert.ToInt16(cbAdSoyad.SelectedValue);
                _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = _sinif.komut.ExecuteReader();
                while (dr.Read())
                {
                    mtxtTelefon.Text = dr["telefon"].ToString();
                    mtxtTelefon2.Text = dr["telefon2"].ToString();
                    txtAciklama.Text = dr["aciklama"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { Sinif.baglan.Close(); }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbAdSoyad.Text != "")
                {
                    string sorgu = "Update musterilersatici SET adSoyad = @1, telefon = @2, telefon2 = @3, aciklama = @4 where id = " + _sinif.yardimciDegisken + "";
                    _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                    _sinif.komut.Parameters.AddWithValue("@1", cbAdSoyad.Text);
                    _sinif.komut.Parameters.AddWithValue("@2", mtxtTelefon.Text);
                    _sinif.komut.Parameters.AddWithValue("@3", mtxtTelefon2.Text);
                    _sinif.komut.Parameters.AddWithValue("@4", txtAciklama.Text);
                    _sinif.komut.ExecuteNonQuery();
                    cbAdSoyadDoldur();
                    temizle();
                }
                else
                    MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbAdSoyad.Text != "")
                {
                    DialogResult silmeSorusu = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Kayıt Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (silmeSorusu == DialogResult.Yes)
                    {
                        string sorgu = "Delete from musterilersatici where id = " + Convert.ToInt16(cbAdSoyad.SelectedValue) + "";
                        _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        _sinif.komut.ExecuteNonQuery();
                        cbAdSoyadDoldur();
                        temizle();
                        MessageBox.Show("Kayıt silinmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }

        private void cbAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void musterilerSatici_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
}
