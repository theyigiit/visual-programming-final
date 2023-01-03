using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace emlakGörselProgramlama
{
    public partial class satilikIsYeri : Form
    {
        public satilikIsYeri()
        {
            InitializeComponent();
        }
        musterilerSatici MusterilerSatici = new musterilerSatici();
        Sinif sinif = new Sinif();
        List<PictureBox> pb = new List<PictureBox>();
      
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                foreach (Control item in this.tabControl1.TabPages[i].Controls)
                    if (!(item is CheckBox) && !(item is Label) && !(item is GroupBox) && !(item is Button))
                        item.Text = null;
                    else if (item is CheckBox)
                        (item as CheckBox).Checked = false;
            }
            foreach (Control item in this.groupBox1.Controls)
                (item as CheckBox).Checked = false;
            txtFiyat.Text = "0";
            
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void satilikIsYeri_Load(object sender, EventArgs e)
        {

            try
            {
                cbDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbDoldur()
        {
            cbEmlakSahibi.ValueMember = "id";
            cbEmlakSahibi.DisplayMember = "adSoyad";
            cbEmlakSahibi.DataSource = sinif.dataTableDoldur("musterilerSatici");
            cbIl.ValueMember = "id";
            cbIl.DisplayMember = "sehir";
            cbIl.DataSource = sinif.dataTableDoldur("iller");
            cbIlanBasligi.ValueMember = "id";
            cbIlanBasligi.DisplayMember = "ilanBasligi";
            cbIlanBasligi.DataSource = sinif.dataTableDoldur("satilikIsYeri");
        }

        private void btnEmlakSahibiGit_Click(object sender, EventArgs e)
        {
            if (MusterilerSatici.Created)
            {
                MusterilerSatici.Activate();
                MusterilerSatici.WindowState = FormWindowState.Normal;
            }
            else
            {
                MusterilerSatici = new musterilerSatici();
                MusterilerSatici.MdiParent = this.MdiParent;
                MusterilerSatici.Show();
            }
            MusterilerSatici.cbAdSoyad.Text = cbEmlakSahibi.Text;
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbIlanBasligi.Text != "")
                {

                    ekle();
                    temizle();
                    cbDoldur();


                }
                else
                    MessageBox.Show("İlan başlığını boş geçemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ekle()
        {
            Sinif.baglan.Open();
            string sorgu = "INSERT INTO satilikisyeri(ilanBasligi, fiyat, krediUygun, emlakTipi, metreKare, iskan, il, ilce, adres, eklenmeTarihi, emlakSahibi, binadakiKatSayisi, bulunduguKat, emlaginDurumu,  takas, tapuDurumu, isitma, aciklama, alarm, aritmaTesisi, asansor, barbeku, beyazEsya, depremYonetmeligi, goruntuluDiyafon, esyali, gunesEnerjisi, guvenlik, hidrofor, jenerator, kabloTvUydu, kapaliGaraj, kapici, klima, otopark, ozelDekorasyon, panjur, somine, terasVeranda, yanginMerdiveni,devren) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40 ,@41)";
            sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
            sinif.komut.Parameters.AddWithValue("@1", cbIlanBasligi.Text);
            sinif.komut.Parameters.AddWithValue("@2", txtFiyat.Text);
            sinif.komut.Parameters.AddWithValue("@3", chbKrediUygun.Checked);
            sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
            sinif.komut.Parameters.AddWithValue("@5", txtMetrekare.Text);
            sinif.komut.Parameters.AddWithValue("@6", cbIskan.Text);
            sinif.komut.Parameters.AddWithValue("@7", cbIl.Text);
            sinif.komut.Parameters.AddWithValue("@8", cbIlce.Text);
            sinif.komut.Parameters.AddWithValue("@9", txtAdres.Text);
            sinif.komut.Parameters.AddWithValue("@10", Convert.ToDateTime(dtpEklenmeTarihi.Value.ToShortDateString()));
            sinif.komut.Parameters.AddWithValue("@11", cbEmlakSahibi.SelectedValue);
            sinif.komut.Parameters.AddWithValue("@12", cbBinadakiKatSayisi.Text);
            sinif.komut.Parameters.AddWithValue("@13", cbBulunduguKat.Text);
            sinif.komut.Parameters.AddWithValue("@14", cbEmlaginDurumu.Text);
            sinif.komut.Parameters.AddWithValue("@15", chbTakas.Checked);
            sinif.komut.Parameters.AddWithValue("@16", cbTapuDurumu.Text);
            sinif.komut.Parameters.AddWithValue("@17", cbIsitma.Text);
            sinif.komut.Parameters.AddWithValue("@18", txtAciklama.Text);
            sinif.komut.Parameters.AddWithValue("@19", chbAlarm.Checked);
            sinif.komut.Parameters.AddWithValue("@20", chbAritmaTesisi.Checked);
            sinif.komut.Parameters.AddWithValue("@21", chbAsansor.Checked);
            sinif.komut.Parameters.AddWithValue("@22", chbBarbeku.Checked);
            sinif.komut.Parameters.AddWithValue("@23", chbBeyazEsya.Checked);
            sinif.komut.Parameters.AddWithValue("@24", chbDepremYonetmeligi.Checked);
            sinif.komut.Parameters.AddWithValue("@25", chbGoruntuluDiyafon.Checked);
            sinif.komut.Parameters.AddWithValue("@26", chbEsyali.Checked);
            sinif.komut.Parameters.AddWithValue("@27", chbGunesEnerjisi.Checked);
            sinif.komut.Parameters.AddWithValue("@28", chbGuvenlik.Checked);
            sinif.komut.Parameters.AddWithValue("@29", chbHidrofor.Checked);
            sinif.komut.Parameters.AddWithValue("@30", chbJenerator.Checked);
            sinif.komut.Parameters.AddWithValue("@31", chbKabloTVUydu.Checked);
            sinif.komut.Parameters.AddWithValue("@32", chbKapaliGaraj.Checked);
            sinif.komut.Parameters.AddWithValue("@33", chbKapici.Checked);
            sinif.komut.Parameters.AddWithValue("@34", chbKlima.Checked);
            sinif.komut.Parameters.AddWithValue("@35", chbOtopark.Checked);
            sinif.komut.Parameters.AddWithValue("@36", chbOzelDekorasyon.Checked);
            sinif.komut.Parameters.AddWithValue("@37", chbPanjur.Checked);
            sinif.komut.Parameters.AddWithValue("@38", chbSomine.Checked);
            sinif.komut.Parameters.AddWithValue("@39", chbTerasVeranda.Checked);
            sinif.komut.Parameters.AddWithValue("@40", chbYanginMerdiveni.Checked); 
            sinif.komut.Parameters.AddWithValue("@41", chbDevren.Checked);
            sinif.komut.ExecuteNonQuery();
            temizle();
            Sinif.baglan.Close();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (cbIl.SelectedIndex != -1)
                {

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from ilceler where sehir = " + cbIl.SelectedValue, Sinif.baglan);
                    da.Fill(dt);
                    cbIlce.ValueMember = "id";
                    cbIlce.DisplayMember = "ilce";
                    cbIlce.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { Sinif.baglan.Close(); }

        }

        private void cbIlanBasligi_SelectedIndexChanged(object sender, EventArgs e)
        {
            sinif.yardimciDegisken = Convert.ToInt16(cbIlanBasligi.SelectedValue);
            try
            {
                Sinif.baglan.Open();
                string sorgu = "select * from satilikisyeri where id = " + Convert.ToInt16(cbIlanBasligi.SelectedValue);
                sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = sinif.komut.ExecuteReader();
                while (dr.Read())
                {
                    txtFiyat.Text = dr["fiyat"].ToString();
                    chbKrediUygun.Checked = Convert.ToBoolean(dr["krediUygun"]);
                    cbEmlakTipi.Text = dr["emlakTipi"].ToString();
                    txtMetrekare.Text = dr["metrekare"].ToString();
                    cbIskan.Text = dr["iskan"].ToString();
                    cbIl.Text = dr["il"].ToString();
                    cbIlce.Text = dr["ilce"].ToString();
                    txtAdres.Text = dr["adres"].ToString();
                    dtpEklenmeTarihi.Value = Convert.ToDateTime(dr["eklenmeTarihi"]);
                    cbEmlakSahibi.SelectedValue = dr["emlakSahibi"];
                    cbBinadakiKatSayisi.Text = dr["binadakiKatSayisi"].ToString();
                    cbBulunduguKat.Text = dr["bulunduguKat"].ToString();
                    cbEmlaginDurumu.Text = dr["emlaginDurumu"].ToString();
                    chbTakas.Checked = Convert.ToBoolean(dr["takas"]);
                    cbTapuDurumu.Text = dr["tapuDurumu"].ToString();
                    cbIsitma.Text = dr["isitma"].ToString();
                    txtAciklama.Text = dr["aciklama"].ToString();
                    chbDevren.Checked = Convert.ToBoolean(dr["devren"]);  
                }

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
                if (cbIlanBasligi.Text != "")
                {
                    DialogResult silmeSorusu = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Kayıt Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (silmeSorusu == DialogResult.Yes)
                    {
                        string sorgu = "Delete from satilikisyeri where id = " + Convert.ToInt16(cbIlanBasligi.SelectedValue) + "";
                        sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                        sinif.komut.ExecuteNonQuery();
                        cbDoldur();
                        temizle();
                        MessageBox.Show("Kayıt silinmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
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
                string sorgu = "Update satilikisyeri SET ilanBasligi = @1, fiyat = @2, krediUygun = @3, emlakTipi = @4, metrekare = @5, iskan = @6, il = @7, ilce = @8, adres = @9, emlakSahibi = @10, binadakiKatSayisi = @11, bulunduguKat = @12, emlaginDurumu = @13,  takas = @14, tapuDurumu = @15, isitma = @16, aciklama = @17, devren = @18 where id = " + sinif.yardimciDegisken + "";
                sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                sinif.komut.Parameters.AddWithValue("@1", cbIlanBasligi.Text);
                sinif.komut.Parameters.AddWithValue("@2", txtFiyat.Text);
                sinif.komut.Parameters.AddWithValue("@3", chbKrediUygun.Checked);
                sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
                sinif.komut.Parameters.AddWithValue("@5", txtMetrekare.Text);
                sinif.komut.Parameters.AddWithValue("@6", cbIskan.Text);
                sinif.komut.Parameters.AddWithValue("@7", cbIl.Text);
                sinif.komut.Parameters.AddWithValue("@8", cbIlce.Text);
                sinif.komut.Parameters.AddWithValue("@9", txtAdres.Text);
                sinif.komut.Parameters.AddWithValue("@10", cbEmlakSahibi.SelectedValue);
                sinif.komut.Parameters.AddWithValue("@11", cbBinadakiKatSayisi.Text);
                sinif.komut.Parameters.AddWithValue("@12", cbBulunduguKat.Text);
                sinif.komut.Parameters.AddWithValue("@13", cbEmlaginDurumu.Text);
                sinif.komut.Parameters.AddWithValue("@14", chbTakas.Checked);
                sinif.komut.Parameters.AddWithValue("@15", cbTapuDurumu.Text);
                sinif.komut.Parameters.AddWithValue("@16", cbIsitma.Text);
                sinif.komut.Parameters.AddWithValue("@17", txtAciklama.Text);
                sinif.komut.Parameters.AddWithValue("@18", chbDevren.Checked);
                sinif.komut.ExecuteNonQuery();
                cbDoldur();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { Sinif.baglan.Close(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
    
}
