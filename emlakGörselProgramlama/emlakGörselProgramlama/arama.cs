using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace emlakGörselProgramlama
{
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }

        Sinif _sinif = new Sinif();
        satilikKonut SatilikKonut = new satilikKonut();
        kiralikKonut KiralikKonut = new kiralikKonut();
       
        private void arama_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvDoldur(string tablo)
        {
            Sinif.baglan.Open();
            string sorgu = "select id, fiyat, emlakTipi, metreKare, odaSalon, ilce, binadakiKatSayisi, bulunduguKat, binaninYasi, isitma from " + tablo + " where (fiyat >= " + txtMinFiyat.Text + " and fiyat <=  " + txtMaxFiyat.Text + ") and (metrekare >= " + txtMinMetrekare.Text + " and metrekare <= " + txtMaxMetrekare.Text + ") and isitma = '" + cbIsitma.Text + "' and emlakTipi = '" + cbEmlakTipi.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sorgu, Sinif.baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            dgv.Columns["id"].Visible = false;
            dgv.Columns["fiyat"].HeaderText = "Fiyat";
            dgv.Columns["emlakTipi"].HeaderText = "Emlak Tipi";
            dgv.Columns["metreKare"].HeaderText = "Metrekare";
            dgv.Columns["odaSalon"].HeaderText = "Oda - Salon";
            dgv.Columns["ilce"].HeaderText = "İlçe";
            dgv.Columns["binadakiKatSayisi"].HeaderText = "Binadaki Kat Sayısı";
            dgv.Columns["bulunduguKat"].HeaderText = "Bulunduğu Kat";
            dgv.Columns["binaninYasi"].HeaderText = "Binanın Yaşı";
            dgv.Columns["isitma"].HeaderText = "Isıtma";
            dgv.Columns["fiyat"].DefaultCellStyle.Format = "###,###,### TL";
            dgv.Columns["emlakTipi"].Width = 130;
            dgv.Columns["metreKare"].Width = 50;
            dgv.Columns["binadakiKatSayisi"].Width = 70;
            dgv.Columns["bulunduguKat"].Width = 80;
            dgv.Columns["binaninYasi"].Width = 65;
            dgv.Columns["metreKare"].HeaderText = "m²";
            dgv.Columns["isitma"].Width = 140;
            
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            dgv.ClearSelection();
            Sinif.baglan.Close();

        }
        private void frmArama_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if(db.baglanti().State == ConnectionState.Open)
              //  db.baglanti().Close();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (rbtnSatilikKonut.Checked)
                    dgvDoldur("satilikKonut");
                else
                    dgvDoldur("kiralikKonut");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbtnSatilikKonut.Checked)
            {
                if (SatilikKonut.Created)
                {
                    SatilikKonut.Activate();
                    SatilikKonut.WindowState = FormWindowState.Normal;
                }
                else
                {
                    SatilikKonut = new satilikKonut();
                    SatilikKonut.MdiParent = this.MdiParent;
                    SatilikKonut.Show();
                }
                SatilikKonut.cbIlanBasligi.SelectedValue = dgv.CurrentRow.Cells["id"].Value;
            }
            else
            {
                if (KiralikKonut.Created)
                {
                    KiralikKonut.Activate();
                    KiralikKonut.WindowState = FormWindowState.Normal;
                }
                else
                {
                    KiralikKonut = new kiralikKonut();
                    KiralikKonut.MdiParent = this.MdiParent;
                    KiralikKonut.Show();
                }
                KiralikKonut.cbIlanBasligi.SelectedValue = dgv.CurrentRow.Cells["id"].Value;
            }
        }
        private void txtMinFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void arama_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
}

