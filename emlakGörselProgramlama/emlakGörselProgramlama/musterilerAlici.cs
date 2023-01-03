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
    public partial class musterilerAlici : Form
    {
        public musterilerAlici()
        {
            InitializeComponent();
        }
        Sinif sinif = new Sinif();
        private void cbAdSoyadDoldur()
        {
            cbAdSoyad.ValueMember = "id";
            cbAdSoyad.DisplayMember = "adSoyad";
            cbAdSoyad.DataSource = sinif.dataTableDoldur("musterilerAlici");
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            cbAdSoyad.DropDownStyle = ComboBoxStyle.DropDown;
            cbAdSoyad.Size = new System.Drawing.Size(150, 24);
            btnYeni.Visible = false;
            sinif.yardimciDegisken = Convert.ToInt16(cbAdSoyad.SelectedValue);
        }
       
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            foreach (Control item in this.Controls)
                if (!(item is Label) && !(item is Button))
                    item.Text = null;
            cbAdSoyad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAdSoyad.Size = new System.Drawing.Size(119, 24);
            btnYeni.Visible = true;
            txtMinFiyat.Text = "0";
            txtMaxFiyat.Text = "0";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                Sinif.baglan.Open();
                if (cbAdSoyad.Text != "")
                {
                    if (txtMinFiyat.Text != "" && txtMaxFiyat.Text != "")
                    {
                        string sorgu = "INSERT INTO musterileralici(adSoyad, telefon, telefon2, emlakTipi, emlakDurumu, minFiyat, maxFiyat, aciklama) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)";
                        sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        sinif.komut.Parameters.AddWithValue("@1", cbAdSoyad.Text);
                        sinif.komut.Parameters.AddWithValue("@2", mtxtTelefon.Text);
                        sinif.komut.Parameters.AddWithValue("@3", mtxtTelefon2.Text);
                        sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
                        sinif.komut.Parameters.AddWithValue("@5", cbEmlakDurumu.Text);
                        sinif.komut.Parameters.AddWithValue("@6", txtMinFiyat.Text);
                        sinif.komut.Parameters.AddWithValue("@7", txtMaxFiyat.Text);
                        sinif.komut.Parameters.AddWithValue("@8", txtAciklama.Text);
                        sinif.komut.ExecuteNonQuery();
                        cbAdSoyadDoldur();
                        temizle();
                    }
                    else
                        MessageBox.Show("Fiyat aralığı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void musterilerAlici_Load(object sender, EventArgs e)
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
                        string sorgu = "Delete from musterileralici where id = " + Convert.ToInt16(cbAdSoyad.SelectedValue) + "";
                        sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        sinif.komut.ExecuteNonQuery();
                        cbAdSoyadDoldur();
                        temizle();
                        MessageBox.Show("Kayıt silinmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            sinif.yardimciDegisken = Convert.ToInt16(cbAdSoyad.SelectedValue);
            try
            {
                Sinif.baglan.Open();
                string sorgu = "select * from musterileralici where id = " + Convert.ToInt16(cbAdSoyad.SelectedValue);
                sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = sinif.komut.ExecuteReader();
                while (dr.Read())
                {
                    mtxtTelefon.Text = dr["telefon"].ToString();
                    mtxtTelefon2.Text = dr["telefon2"].ToString();
                    cbEmlakTipi.Text = dr["emlakTipi"].ToString();
                    cbEmlakDurumu.Text = dr["emlakDurumu"].ToString();
                    txtMinFiyat.Text = dr["minFiyat"].ToString();
                    txtMaxFiyat.Text = dr["maxFiyat"].ToString();
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
                    if (txtMinFiyat.Text != "" && txtMaxFiyat.Text != "")
                    {
                        string sorgu = "Update musterileralici SET adSoyad = @1, telefon = @2, telefon2 = @3, emlakTipi = @4, emlakDurumu = @5, minFiyat = @6, maxFiyat = @7, aciklama = @8 where id = " + sinif.yardimciDegisken + "";
                        sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        sinif.komut.Parameters.AddWithValue("@1", cbAdSoyad.Text);
                        sinif.komut.Parameters.AddWithValue("@2", mtxtTelefon.Text);
                        sinif.komut.Parameters.AddWithValue("@3", mtxtTelefon2.Text);
                        sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
                        sinif.komut.Parameters.AddWithValue("@5", cbEmlakDurumu.Text);
                        sinif.komut.Parameters.AddWithValue("@6", txtMinFiyat.Text);
                        sinif.komut.Parameters.AddWithValue("@7", txtMaxFiyat.Text);
                        sinif.komut.Parameters.AddWithValue("@8", txtAciklama.Text);
                        sinif.komut.ExecuteNonQuery();
                        cbAdSoyadDoldur();
                        temizle();
                    }
                    else
                        MessageBox.Show("Fiyat aralığı boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtMinFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void cbAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void musterilerAlici_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
}
