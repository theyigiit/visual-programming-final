using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakGörselProgramlama
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        // FORM TANIMLAMALARI
        Hakkinda hakkinda = new Hakkinda();
        satilikKonut SatilikKonut = new satilikKonut();
        musterilerAlici MusterilerAlici = new musterilerAlici();
        musterilerSatici MusterilerSatici = new musterilerSatici();
        Kullanicilar kullanicilar = new Kullanicilar();
        satilikIsYeri SatilikIsyeri = new satilikIsYeri();
        kiralikKonut KiralikKonut = new kiralikKonut();
        kiralikIsYeri KiralikIsyeri = new kiralikIsYeri();
        arama Arama = new arama();
        // ! FORM TANIMLAMALARI
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anaForm_LocationChanged(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void hakkındaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hakkinda.Show();
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaForm_Load_1(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=kutahya&units=metric&lang=tr&appid=18b7da270bfc7233837e5cb92fd84f38");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
                    label2.Text = data["main"]["temp"].ToString();
                    
                }

            }
            catch { }
        }

        private void aramaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Arama.Show();
            this.Hide();
        }

        private void kullanıcılarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kullanicilar.Show();
            this.Hide();
        }

        private void konutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SatilikKonut.Show();
            this.Hide();
        }

        private void işYeriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SatilikIsyeri.Show();
            this.Hide();
        }

        private void konutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            KiralikKonut.Show();
            this.Hide();
        }

        private void işyeriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KiralikIsyeri.Show();
            this.Hide();
        }

        private void satıcıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MusterilerSatici.Show();
            this.Hide();
        }

        private void alıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusterilerAlici.Show();
            this.Hide();
        }

        private void satılıkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
