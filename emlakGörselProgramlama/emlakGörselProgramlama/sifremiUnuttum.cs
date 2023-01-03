using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace emlakGörselProgramlama
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }
        Sinif _sinif = new Sinif();
        Sinif baglanti = new Sinif();
        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                Sinif.baglan.Open();
                if (_sinif.emailRegex.IsMatch(txtEPosta.Text) && txtEPosta.Text != "")
                {
                    string sorgu = "select * from kullanici where ePosta = '" + txtEPosta.Text + "'";
                    _sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                    MySqlDataReader dr = _sinif.komut.ExecuteReader();
                    if (dr.Read())
                    {
                        SmtpClient kaynak = new SmtpClient();
                        kaynak.Credentials = new System.Net.NetworkCredential("jncheimdall@gmail.com", "1310111");
                        kaynak.Host = "localhost";
                        kaynak.Port = 587;
                        kaynak.EnableSsl = true;
                        MailAddress gonderen = new MailAddress("jncheimdall@gmail.com", "Emlak Otomasyon");
                        MailAddress giden = new MailAddress(dr["ePosta"].ToString(), dr["adSoyad"].ToString());
                        MailMessage mesaj = new MailMessage(gonderen, giden);
                        mesaj.IsBodyHtml = true;
                        mesaj.Subject = "Emlak Şifre Hatırlatması";
                        mesaj.Body = "Kullanıcı Adınız: " + dr["kullaniciAdi"] + " <br /> Şifreniz: " + dr["sifre"];
                        kaynak.Send(mesaj);
                        MessageBox.Show("Şifreniz e-posta adresinize gönderilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Girmiş olduğunuz e-posta adresine ait kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Lütfen e-posta adresinizi doğru girdiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            catch (Exception)
            {
                MessageBox.Show("E-Posta gönderilemedi. İnternet bağlantınızı kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            finally { Sinif.baglan.Close(); }
            
            
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void frmSifremiUnuttum_FormClosing(object sender, FormClosingEventArgs e)
        {
            kullaniciGirisi klncgrs = new kullaniciGirisi();
            klncgrs.Show();
            this.Hide();
        }

    }
}
