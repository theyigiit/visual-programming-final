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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }
        Sinif _sinif = new Sinif();
      
        private void cbAdSoyadDoldur()
        {
            cbKullaniciAdi.ValueMember = "id";
            cbKullaniciAdi.DisplayMember = "kullaniciAdi";
            cbKullaniciAdi.DataSource = _sinif.dataTableDoldur("kullanici");
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
            cbKullaniciAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKullaniciAdi.Size = new System.Drawing.Size(119, 24);
            btnYeni.Visible = true;
        }
       
        private void Kullanicilar_Load(object sender, EventArgs e)
        {

            try
            {
               
                cbAdSoyadDoldur();
                cbKullaniciAdi.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
        private void frmKullanicilar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbKullaniciAdi.Text != "")
                {
                    DialogResult silmeSorusu = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Kayıt Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (silmeSorusu == DialogResult.Yes)
                    {
                        string sorgu = "Delete from kullanici where id = " + Convert.ToInt16(cbKullaniciAdi.SelectedValue) + "";
                        _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        _sinif.komut.ExecuteNonQuery();
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
        private void cbKullaniciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sinif.yardimciDegisken = Convert.ToInt16(cbKullaniciAdi.SelectedValue);
            try
            {
                Sinif.baglan.Open();
                string sorgu = "select * from kullanici where id = " + Convert.ToInt16(cbKullaniciAdi.SelectedValue);
                _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = _sinif.komut.ExecuteReader();
                while (dr.Read())
                {
                    txtSifre.Text = dr["sifre"].ToString();
                    txtEPosta.Text = dr["ePosta"].ToString();
                    txtAdSoyad.Text = dr["adSoyad"].ToString();
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
            string kontrolKullaniciAdi = cbKullaniciAdi.Text, kontrolEPosta = txtEPosta.Text;
            try
            {
                Sinif.baglan.Open();
                if (cbKullaniciAdi.Text != "" && txtEPosta.Text != "" && txtSifre.Text != "" && txtAdSoyad.Text != "")
                {
                    if (txtSifre.Text.Length >= 6)
                    {
                        if (_sinif.emailRegex.IsMatch(txtEPosta.Text))
                        {
                            string sorgu = "Update kullanici SET kullaniciAdi = @1, sifre = @2, ePosta = @3, adSoyad = @4 where id = " + _sinif.yardimciDegisken + "";
                            _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                            _sinif.komut.Parameters.AddWithValue("@1", cbKullaniciAdi.Text);
                            _sinif.komut.Parameters.AddWithValue("@2", txtSifre.Text);
                            _sinif.komut.Parameters.AddWithValue("@3", txtEPosta.Text);
                            _sinif.komut.Parameters.AddWithValue("@4", txtAdSoyad.Text);
                            _sinif.komut.ExecuteNonQuery();
                            cbAdSoyadDoldur();
                            temizle();            
                        }
                        else
                            MessageBox.Show("E-Posta adresiniz hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Şifreniz en az 6 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { Sinif.baglan.Close(); }


        }
        private void cbKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbKullaniciAdi.Text != "" && txtEPosta.Text != "" && txtSifre.Text != "" && txtAdSoyad.Text != "")
                {
                    if (txtSifre.Text.Length >= 6)
                    {
                        if (_sinif.emailRegex.IsMatch(txtEPosta.Text))
                        {
                            string sorguKontrolKullaniciAdi = "select kullaniciAdi from kullanici where kullaniciAdi = '" + cbKullaniciAdi.Text + "'";
                            _sinif.komut = new MySqlCommand(sorguKontrolKullaniciAdi, Sinif.baglan);
                            MySqlDataReader dr = _sinif.komut.ExecuteReader();
                            if (!dr.Read())
                            {
                                string sorguKontrolEPosta = "select ePosta from kullanici where ePosta = '" + txtEPosta.Text + "'";
                                _sinif.komut = new MySqlCommand(sorguKontrolEPosta, Sinif.baglan);
                                MySqlDataReader dr2 = _sinif.komut.ExecuteReader();
                                if (!dr2.Read())
                                {
                                    string sorgu = "INSERT INTO kullanici(kullaniciAdi, sifre, ePosta, adSoyad) VALUES (@1, @2, @3, @4)";
                                    _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                                    _sinif.komut.Parameters.AddWithValue("@1", cbKullaniciAdi.Text);
                                    _sinif.komut.Parameters.AddWithValue("@2", txtSifre.Text);
                                    _sinif.komut.Parameters.AddWithValue("@3", txtEPosta.Text);
                                    _sinif.komut.Parameters.AddWithValue("@4", txtAdSoyad.Text);
                                    _sinif.komut.ExecuteNonQuery();
                                    cbAdSoyadDoldur();
                                    temizle();   
                                }
                                else
                                    MessageBox.Show("Girmiş olduğunuz e-Postaya ait kayıt bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Girmiş olduğunuz kullanıcı adına ait kayıt bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("E-Posta adresiniz hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Şifreniz en az 6 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally { Sinif.baglan.Close(); }


        }

        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            cbKullaniciAdi.DropDownStyle = ComboBoxStyle.DropDown;
            cbKullaniciAdi.Size = new System.Drawing.Size(150, 24);
            btnYeni.Visible = false;
            _sinif.yardimciDegisken = Convert.ToInt16(cbKullaniciAdi.SelectedValue);
        }

        private void Kullanicilar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
}
