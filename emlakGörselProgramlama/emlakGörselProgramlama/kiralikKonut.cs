using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace emlakGörselProgramlama
{
    public partial class kiralikKonut : Form
    {
        public kiralikKonut()
        {
            InitializeComponent();
        }
        musterilerAlici MusterilerAlici = new musterilerAlici();
        Sinif sinif = new Sinif();
        List<PictureBox> pb = new List<PictureBox>();
       
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
            foreach (Control item in this.gbDosemeOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbDuvarOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbTavanOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbKapiOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbLokasyonOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbDogramaOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbDisCepheOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbMutfakOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbBanyoOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbZeminOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbBinaninYapiTarzi.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbCevreOzellikleri.Controls)
                (item as CheckBox).Checked = false;
            foreach (Control item in this.gbDiger.Controls)
                (item as CheckBox).Checked = false;
            txtFiyat.Text = "0";
            txtAidatTutari.Text = "0";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void kiralikKonut_Load(object sender, EventArgs e)
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
            cbEmlakSahibi.DataSource = sinif.dataTableDoldur("musterilerAlici");
            cbIl.ValueMember = "id";
            cbIl.DisplayMember = "sehir";
            cbIl.DataSource = sinif.dataTableDoldur("iller");
            cbIlanBasligi.ValueMember = "id";
            cbIlanBasligi.DisplayMember = "ilanBasligi";
            cbIlanBasligi.DataSource = sinif.dataTableDoldur("kiralikKonut");
        }

        private void btnEmlakSahibiGit_Click(object sender, EventArgs e)
        {

            if (MusterilerAlici.Created)
            {
                MusterilerAlici.Activate();
                MusterilerAlici.WindowState = FormWindowState.Normal;
            }
            else
            {
                MusterilerAlici = new musterilerAlici();
                MusterilerAlici.MdiParent = this.MdiParent;
                MusterilerAlici.Show();
            }
            MusterilerAlici.cbAdSoyad.Text = cbEmlakSahibi.Text;
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
            string sorgu = "INSERT INTO kiralikkonut(ilanBasligi, fiyat, krediUygun, emlakTipi, metrekare, odaSalon, iskanDurumu, il, ilce, adres, eklenmeTarihi, emlakSahibi, aidatTutari, banyoSayisi, binadakiKatSayisi, binaninYasi, bulunduguKat, emlaginDurumu, kullanimDurumu, takas, tapuDurumu, balkonSayisi, isitma, aciklama, ahsapParke, laminantParke, lamineParke, haliDoseme, pvcKaplamali, marley, satenDuvar, plastikBoyaliDuvar, yagliboyaDuvar, duvarKagidi, kirecBoyaliDuvar, ithalBoyaliDuvar, kirecTavan, kartonpiyerliTavan, asmaTavan, plastikTavan, plastikBoyaliTavan, ahsapKapi, yagliboyaKapi, laminantKapi, celikKapi, lakeBoyaliKapi, amerikanPanelKapi, caddeUzerinde, caddeyeYakin, e5Cepheli, e5Yakin, havaalaninaYakin, otogaraYakin, topluTasimayaYakin, sahileYakin, ahsapDograma, aluminyumDograma, isicamliDograma, pvcDograma, sidingKaplama, btbKaplama, boyali, sivali, granitKaplama, mermerKaplama, tasKaplama, ahsapKaplama, mantolama, laminantMutfak, ahsapMutfak, lakeMutfak, formikaMutfak, ozelTasarimMutfak, ankastreBeyazEsyaliMutfak, ebeveynBanyo, wc, jakuzi, dusakabin, hiltonLavabo, saunaHamam, mozaikZemin, travertenZemin, granitZemin, dogaltasZemin, seramikZemin, mermerZemin, kutuk, celikSistem, prefabrik, tarihiEser, betonarmeKargas, tamKagir, yarimKagir, ahsap, acikYuzmeHavuzu, bahce, bogazManzarasi, denizManzarasi, dagManzarasi, dogaIcinde, golManzarasi, hastane, kapaliYuzmeHavuzu, kres, market, okul, sinema, siteIcinde, sporTesisi, sehirManzarasi, tenisKortu, vadiManzarasi, alarm, aritmaTesisi, asansor, barbeku, beyazEsya, depremYonetmeligi, goruntuluDiyafon, esyali, gunesEnerjisi, guvenlik, hidrofor, jenerator, kabloTvUydu, kapaliGaraj, kapici, klima, otopark, ozelDekorasyon, panjur, somine, terasVeranda, yanginMerdiveni) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62, @63, @64, @65, @66, @67, @68, @69, @70, @71, @72, @73, @74, @75, @76, @77, @78, @79, @80, @81, @82, @83, @84, @85, @86, @87, @88, @89, @90, @91, @92, @93, @94, @95, @96, @97, @98, @99, @100, @101, @102, @103, @104, @105, @106, @107, @108, @109, @110, @111, @112, @113, @114, @115, @116, @117, @118, @119, @120, @121, @122, @123, @124, @125, @126, @127, @128, @129, @130, @131, @132, @133, @134)";
            sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
            sinif.komut.Parameters.AddWithValue("@1", cbIlanBasligi.Text);
            sinif.komut.Parameters.AddWithValue("@2", txtFiyat.Text);
            sinif.komut.Parameters.AddWithValue("@3", chbKrediUygun.Checked);
            sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
            sinif.komut.Parameters.AddWithValue("@5", txtMetrekare.Text);
            sinif.komut.Parameters.AddWithValue("@6", cbOdaSalon.Text);
            sinif.komut.Parameters.AddWithValue("@7", cbIskan.Text);
            sinif.komut.Parameters.AddWithValue("@8", cbIl.Text);
            sinif.komut.Parameters.AddWithValue("@9", cbIlce.Text);
            sinif.komut.Parameters.AddWithValue("@10", txtAdres.Text);
            sinif.komut.Parameters.AddWithValue("@11", Convert.ToDateTime(dtpEklenmeTarihi.Value.ToShortDateString()));
            sinif.komut.Parameters.AddWithValue("@12", cbEmlakSahibi.SelectedValue);
            sinif.komut.Parameters.AddWithValue("@13", txtAidatTutari.Text);
            sinif.komut.Parameters.AddWithValue("@14", cbBanyoSayisi.Text);
            sinif.komut.Parameters.AddWithValue("@15", cbBinadakiKatSayisi.Text);
            sinif.komut.Parameters.AddWithValue("@16", cbBinaninYasi.Text);
            sinif.komut.Parameters.AddWithValue("@17", cbBulunduguKat.Text);
            sinif.komut.Parameters.AddWithValue("@18", cbEmlaginDurumu.Text);
            sinif.komut.Parameters.AddWithValue("@19", cbKullanimDurumu.Text);
            sinif.komut.Parameters.AddWithValue("@20", chbTakas.Checked);
            sinif.komut.Parameters.AddWithValue("@21", cbTapuDurumu.Text);
            sinif.komut.Parameters.AddWithValue("@22", cbBalkonSayisi.Text);
            sinif.komut.Parameters.AddWithValue("@23", cbIsitma.Text);
            sinif.komut.Parameters.AddWithValue("@24", txtAciklama.Text);
            sinif.komut.Parameters.AddWithValue("@25", chbAhsapParke.Checked);
            sinif.komut.Parameters.AddWithValue("@26", chbLaminantParke.Checked);
            sinif.komut.Parameters.AddWithValue("@27", chbLamineParke.Checked);
            sinif.komut.Parameters.AddWithValue("@28", chbHaliDoseme.Checked);
            sinif.komut.Parameters.AddWithValue("@29", chbPvcKaplamali.Checked);
            sinif.komut.Parameters.AddWithValue("@30", chbMarley.Checked);
            sinif.komut.Parameters.AddWithValue("@31", chbSatenDuvar.Checked);
            sinif.komut.Parameters.AddWithValue("@32", chbPlastikBoyaliDuvar.Checked);
            sinif.komut.Parameters.AddWithValue("@33", chbYagliboyaDuvar.Checked);
            sinif.komut.Parameters.AddWithValue("@34", chbDuvarKagidi.Checked);
            sinif.komut.Parameters.AddWithValue("@35", chbKirecBoyaliDuvar.Checked);
            sinif.komut.Parameters.AddWithValue("@36", chbIthalBoyaliDuvar.Checked);
            sinif.komut.Parameters.AddWithValue("@37", chbKirecTavan.Checked);
            sinif.komut.Parameters.AddWithValue("@38", chbKartonpiyerliTavan.Checked);
            sinif.komut.Parameters.AddWithValue("@39", chbAsmaTavan.Checked);
            sinif.komut.Parameters.AddWithValue("@40", chbPlastikTavan.Checked);
            sinif.komut.Parameters.AddWithValue("@41", chbPlastikBoyaliTavan.Checked);
            sinif.komut.Parameters.AddWithValue("@42", chbAhsapKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@43", chbYagliboyaKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@44", chbLaminantKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@45", chbCelikKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@46", chbLakeBoyaliKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@47", chbAmerikanPanelKapi.Checked);
            sinif.komut.Parameters.AddWithValue("@48", chbCaddeUzerinde.Checked);
            sinif.komut.Parameters.AddWithValue("@49", chbCaddeyeYakin.Checked);
            sinif.komut.Parameters.AddWithValue("@50", chbE5Cepheli.Checked);
            sinif.komut.Parameters.AddWithValue("@51", chbE5Yakin.Checked);
            sinif.komut.Parameters.AddWithValue("@52", chbHavaalaninaYakin.Checked);
            sinif.komut.Parameters.AddWithValue("@53", chbOtogaraYakin.Checked);
            sinif.komut.Parameters.AddWithValue("@54", chbTopluTasimayaYakin.Checked);
            sinif.komut.Parameters.AddWithValue("@55", chbSahileYakin.Checked);
            sinif.komut.Parameters.AddWithValue("@56", chbAhsapDograma.Checked);
            sinif.komut.Parameters.AddWithValue("@57", chbAluminyumDograma.Checked);
            sinif.komut.Parameters.AddWithValue("@58", chbIsicamliDograma.Checked);
            sinif.komut.Parameters.AddWithValue("@59", chbPvcDograma.Checked);
            sinif.komut.Parameters.AddWithValue("@60", chbSidingKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@61", chbBTBKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@62", chbBoyali.Checked);
            sinif.komut.Parameters.AddWithValue("@63", chbSivali.Checked);
            sinif.komut.Parameters.AddWithValue("@64", chbGranitKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@65", chbMermerKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@66", chbTasKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@67", chbAhsapKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@68", chbMantolama.Checked);
            sinif.komut.Parameters.AddWithValue("@69", chbLaminantMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@70", chbAhsapMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@71", chbLakeMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@72", chbFormikaMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@73", chbOzelTasarimMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@74", chbAnkastreBeyazEsyaliMutfak.Checked);
            sinif.komut.Parameters.AddWithValue("@75", chbEbeveynBanyo.Checked);
            sinif.komut.Parameters.AddWithValue("@76", chbWC.Checked);
            sinif.komut.Parameters.AddWithValue("@77", chbJakuzi.Checked);
            sinif.komut.Parameters.AddWithValue("@78", chbDusakabin.Checked);
            sinif.komut.Parameters.AddWithValue("@79", chbHiltonLavabo.Checked);
            sinif.komut.Parameters.AddWithValue("@80", chbSaunaHamam.Checked);
            sinif.komut.Parameters.AddWithValue("@81", chbMozaikZemin.Checked);
            sinif.komut.Parameters.AddWithValue("@82", chbTravertenZemin.Checked);
            sinif.komut.Parameters.AddWithValue("@83", chbGranitZemin.Checked);
            sinif.komut.Parameters.AddWithValue("@84", chbDogaltasZemin.Checked);
            sinif.komut.Parameters.AddWithValue("@85", chbSeramikZemin.Checked);
            sinif.komut.Parameters.AddWithValue("@86", chbMermerKaplama.Checked);
            sinif.komut.Parameters.AddWithValue("@87", chbKutuk.Checked);
            sinif.komut.Parameters.AddWithValue("@88", chbCelikSistem.Checked);
            sinif.komut.Parameters.AddWithValue("@89", chbPrefabrik.Checked);
            sinif.komut.Parameters.AddWithValue("@90", chbTarihiEser.Checked);
            sinif.komut.Parameters.AddWithValue("@91", chbBetonarmeKargas.Checked);
            sinif.komut.Parameters.AddWithValue("@92", chbTamKagir.Checked);
            sinif.komut.Parameters.AddWithValue("@93", chbYarimKagir.Checked);
            sinif.komut.Parameters.AddWithValue("@94", chbAhsap.Checked);
            sinif.komut.Parameters.AddWithValue("@95", chbAcikYuzmeHavuzu.Checked);
            sinif.komut.Parameters.AddWithValue("@96", chbBahce.Checked);
            sinif.komut.Parameters.AddWithValue("@97", chbBogazManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@98", chbDenizManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@99", chbDagManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@100", chbDogaIcinde.Checked);
            sinif.komut.Parameters.AddWithValue("@101", chbGolManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@102", chbHastane.Checked);
            sinif.komut.Parameters.AddWithValue("@103", chbKapaliYuzmeHavuzu.Checked);
            sinif.komut.Parameters.AddWithValue("@104", chbKres.Checked);
            sinif.komut.Parameters.AddWithValue("@105", chbMarket.Checked);
            sinif.komut.Parameters.AddWithValue("@106", chbOkul.Checked);
            sinif.komut.Parameters.AddWithValue("@107", chbSinema.Checked);
            sinif.komut.Parameters.AddWithValue("@108", chbSiteIcinde.Checked);
            sinif.komut.Parameters.AddWithValue("@109", chbSporTesisi.Checked);
            sinif.komut.Parameters.AddWithValue("@110", chbSehirManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@111", chbTenisKortu.Checked);
            sinif.komut.Parameters.AddWithValue("@112", chbVadiManzarasi.Checked);
            sinif.komut.Parameters.AddWithValue("@113", chbAlarm.Checked);
            sinif.komut.Parameters.AddWithValue("@114", chbAritmaTesisi.Checked);
            sinif.komut.Parameters.AddWithValue("@115", chbAsansor.Checked);
            sinif.komut.Parameters.AddWithValue("@116", chbBarbeku.Checked);
            sinif.komut.Parameters.AddWithValue("@117", chbBeyazEsya.Checked);
            sinif.komut.Parameters.AddWithValue("@118", chbDepremYonetmeligi.Checked);
            sinif.komut.Parameters.AddWithValue("@119", chbGoruntuluDiyafon.Checked);
            sinif.komut.Parameters.AddWithValue("@120", chbEsyali.Checked);
            sinif.komut.Parameters.AddWithValue("@121", chbGunesEnerjisi.Checked);
            sinif.komut.Parameters.AddWithValue("@122", chbGuvenlik.Checked);
            sinif.komut.Parameters.AddWithValue("@123", chbHidrofor.Checked);
            sinif.komut.Parameters.AddWithValue("@124", chbJenerator.Checked);
            sinif.komut.Parameters.AddWithValue("@125", chbKabloTVUydu.Checked);
            sinif.komut.Parameters.AddWithValue("@126", chbKapaliGaraj.Checked);
            sinif.komut.Parameters.AddWithValue("@127", chbKapici.Checked);
            sinif.komut.Parameters.AddWithValue("@128", chbKlima.Checked);
            sinif.komut.Parameters.AddWithValue("@129", chbOtopark.Checked);
            sinif.komut.Parameters.AddWithValue("@130", chbOzelDekorasyon.Checked);
            sinif.komut.Parameters.AddWithValue("@131", chbPanjur.Checked);
            sinif.komut.Parameters.AddWithValue("@132", chbSomine.Checked);
            sinif.komut.Parameters.AddWithValue("@133", chbTerasVeranda.Checked);
            sinif.komut.Parameters.AddWithValue("@134", chbYanginMerdiveni.Checked);
            sinif.komut.ExecuteNonQuery();
            temizle();
            Sinif.baglan.Close();
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.tabControl1.TabPages[6].Controls)
            {
                if (item is PictureBox)
                    pb.Add(item as PictureBox);
            }
            ofd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = ((PictureBox)sender).Image;
            pictureBox11.Tag = ((PictureBox)sender).Tag;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = pictureBox11.Tag.ToString();
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                if (ofd.FileNames.Length > 10)
                {
                    MessageBox.Show("En fazla 10 adet resim seçebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image = Image.FromFile(ofd.FileNames[i]);
                        pb[i + 1].Tag = ofd.FileNames[i];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string sorgu = "select * from kiralikkonut where id = " + Convert.ToInt16(cbIlanBasligi.SelectedValue);
                sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                MySqlDataReader dr = sinif.komut.ExecuteReader();
                while (dr.Read())
                {
                    txtFiyat.Text = dr["fiyat"].ToString();
                    chbKrediUygun.Checked = Convert.ToBoolean(dr["krediUygun"]);
                    cbEmlakTipi.Text = dr["emlakTipi"].ToString();
                    txtMetrekare.Text = dr["metrekare"].ToString();
                    cbOdaSalon.Text = dr["odaSalon"].ToString();
                    cbIskan.Text = dr["iskanDurumu"].ToString();
                    cbIl.Text = dr["il"].ToString();
                    cbIlce.Text = dr["ilce"].ToString();
                    txtAdres.Text = dr["adres"].ToString();
                    dtpEklenmeTarihi.Value = Convert.ToDateTime(dr["eklenmeTarihi"]);
                    cbEmlakSahibi.SelectedValue = dr["emlakSahibi"];
                    txtAidatTutari.Text = dr["aidatTutari"].ToString();
                    cbBanyoSayisi.Text = dr["banyoSayisi"].ToString();
                    cbBinadakiKatSayisi.Text = dr["binadakiKatSayisi"].ToString();
                    cbBinaninYasi.Text = dr["binaninYasi"].ToString();
                    cbBulunduguKat.Text = dr["bulunduguKat"].ToString();
                    cbEmlaginDurumu.Text = dr["emlaginDurumu"].ToString();
                    cbKullanimDurumu.Text = dr["kullanimDurumu"].ToString();
                    chbTakas.Checked = Convert.ToBoolean(dr["takas"]);
                    cbTapuDurumu.Text = dr["tapuDurumu"].ToString();
                    cbBalkonSayisi.Text = dr["balkonSayisi"].ToString();
                    cbIsitma.Text = dr["isitma"].ToString();
                    txtAciklama.Text = dr["aciklama"].ToString();
                    chbAhsapParke.Checked = Convert.ToBoolean(dr["ahsapParke"].ToString());
                    chbLaminantParke.Checked = Convert.ToBoolean(dr["laminantParke"].ToString());
                    chbLamineParke.Checked = Convert.ToBoolean(dr["lamineParke"].ToString());
                    chbHaliDoseme.Checked = Convert.ToBoolean(dr["haliDoseme"].ToString());
                    chbPvcKaplamali.Checked = Convert.ToBoolean(dr["pvcKaplamali"].ToString());
                    chbMarley.Checked = Convert.ToBoolean(dr["marley"].ToString());
                    chbSatenDuvar.Checked = Convert.ToBoolean(dr["satenDuvar"].ToString());
                    chbPlastikBoyaliDuvar.Checked = Convert.ToBoolean(dr["plastikBoyaliDuvar"].ToString());
                    chbYagliboyaDuvar.Checked = Convert.ToBoolean(dr["yagliboyaDuvar"].ToString());
                    chbDuvarKagidi.Checked = Convert.ToBoolean(dr["duvarKagidi"].ToString());
                    chbKirecBoyaliDuvar.Checked = Convert.ToBoolean(dr["kirecBoyaliDuvar"].ToString());
                    chbIthalBoyaliDuvar.Checked = Convert.ToBoolean(dr["ithalBoyaliDuvar"].ToString());
                    chbKirecTavan.Checked = Convert.ToBoolean(dr["kirecTavan"].ToString());
                    chbKartonpiyerliTavan.Checked = Convert.ToBoolean(dr["kartonPiyerliTavan"].ToString());
                    chbAsmaTavan.Checked = Convert.ToBoolean(dr["asmaTavan"].ToString());
                    chbPlastikTavan.Checked = Convert.ToBoolean(dr["plastikTavan"].ToString());
                    chbPlastikBoyaliTavan.Checked = Convert.ToBoolean(dr["plastikBoyaliTavan"].ToString());
                    
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
                        string sorgu = "Delete from kiralikkonut where id = " + Convert.ToInt16(cbIlanBasligi.SelectedValue) + "";
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
                string sorgu = "Update kiralikkonut SET ilanBasligi = @1, fiyat = @2, krediUygun = @3, emlakTipi = @4, metrekare = @5, odaSalon = @6, iskanDurumu = @7, il = @8, ilce = @9, adres = @10, emlakSahibi = @12, aidatTutari = @13, banyoSayisi = @14, binadakiKatSayisi = @15, binaninYasi = @16, bulunduguKat = @17, emlaginDurumu = @18, kullanimDurumu = @19, takas = @20, tapuDurumu = @21, balkonSayisi = @22, isitma = @23, aciklama = @24 where id = " + sinif.yardimciDegisken + "";
                sinif.komut = new MySqlCommand(sorgu, Sinif.baglan);
                sinif.komut.Parameters.AddWithValue("@1", cbIlanBasligi.Text);
                sinif.komut.Parameters.AddWithValue("@2", txtFiyat.Text);
                sinif.komut.Parameters.AddWithValue("@3", chbKrediUygun.Checked);
                sinif.komut.Parameters.AddWithValue("@4", cbEmlakTipi.Text);
                sinif.komut.Parameters.AddWithValue("@5", txtMetrekare.Text);
                sinif.komut.Parameters.AddWithValue("@6", cbOdaSalon.Text);
                sinif.komut.Parameters.AddWithValue("@7", cbIskan.Text);
                sinif.komut.Parameters.AddWithValue("@8", cbIl.Text);
                sinif.komut.Parameters.AddWithValue("@9", cbIlce.Text);
                sinif.komut.Parameters.AddWithValue("@10", txtAdres.Text);
                sinif.komut.Parameters.AddWithValue("@12", cbEmlakSahibi.SelectedValue);
                sinif.komut.Parameters.AddWithValue("@13", txtAidatTutari.Text);
                sinif.komut.Parameters.AddWithValue("@14", cbBanyoSayisi.Text);
                sinif.komut.Parameters.AddWithValue("@15", cbBinadakiKatSayisi.Text);
                sinif.komut.Parameters.AddWithValue("@16", cbBinaninYasi.Text);
                sinif.komut.Parameters.AddWithValue("@17", cbBulunduguKat.Text);
                sinif.komut.Parameters.AddWithValue("@18", cbEmlaginDurumu.Text);
                sinif.komut.Parameters.AddWithValue("@19", cbKullanimDurumu.Text);
                sinif.komut.Parameters.AddWithValue("@20", chbTakas.Checked);
                sinif.komut.Parameters.AddWithValue("@21", cbTapuDurumu.Text);
                sinif.komut.Parameters.AddWithValue("@22", cbBalkonSayisi.Text);
                sinif.komut.Parameters.AddWithValue("@23", cbIsitma.Text);
                sinif.komut.Parameters.AddWithValue("@24", txtAciklama.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            anaForm frm = new anaForm();
            frm.Show();
            this.Hide();
        }
    }
}
