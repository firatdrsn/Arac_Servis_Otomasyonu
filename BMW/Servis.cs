using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMW
{
    public partial class Servis : Form
    {
        SqlConnection sv_baglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=servis; password=servis;");
        public string perkod, peradi, muskod, peradi1, persoyadi1, peradsoy,admin_tcno="";
        private string personeladsoy, girtarih, ciktarih, mustc;
        private int giriskm, cikiskm;
        string[] personel;
        SQL cumle = new SQL();
    
        public Servis()
        {
           
            InitializeComponent();
        }
        private void musteri_tckontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mtcno1 " + textSVmus.Text, sv_baglanti);
                sv_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                sv_DR.Read();
                muskod = (sv_DR["Müşteri Kodu"]).ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }
        private void musteri_kodkontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mkodu " + muskod, sv_baglanti);
                sv_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                sv_DR.Read();
                mustc = (sv_DR["TC Numarası"]).ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }
        public void servis_goster()
        {
            try
            {
                SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Servis", sv_baglanti);
                DataSet sv_DS = new DataSet();
                sv_baglanti.Open();
                sv_DA.Fill(sv_DS, "Servis");
                dataGridView1.DataSource = sv_DS.Tables["Servis"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }
        private void personel_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select P_adi,P_soyadi From Personel", sv_baglanti);
                sv_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                while (sv_DR.Read())
                {
                    peradi1 = sv_DR["P_adi"].ToString();
                    persoyadi1 = sv_DR["P_soyadi"].ToString();
                    peradsoy = peradi1 + " " + persoyadi1;
                    comboSVprc.Items.Add(peradsoy);
                }
                sv_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }
        private void Servis_Load(object sender, EventArgs e)
        {
            if (Giris.yetki_kodu == "YK0")
            {

                btn_GeriDon.Visible = true;
            }
            lbl_GirisBilgi.Text= cumle.Giris_Bilgisi(Giris.tc_no);
            servis_goster();
            personel_goster();
            dateTimeSVcik.Visible = false;
            label8.Visible = false;
        }
      
     

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            giriskm = Convert.ToInt32(textSVgkm.Text);
            cikiskm = Convert.ToInt32(textSVckm.Text);
            if (giriskm <= cikiskm)
            {
            try
            {
                musteri_tckontrol();
                
            
                girtarih = dateTimeSVgir.Value.Date.Year + "-" + dateTimeSVgir.Value.Date.Month + "-" + dateTimeSVgir.Value.Date.Day;
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO Servis Values(" + "'" + textSVkod.Text + "'," + "'" + muskod + "','" + textSVmod.Text + "','" + perkod.ToString() + "'," + textSVgkm.Text + "," + textSVckm.Text + ",'" + girtarih + "',Null,'" + textSVplk.Text + "'," + Convert.ToInt32(textSVfyt.Text) + ",'" + Convert.ToInt32(checkSVtm.Checked) + "')";
                sv_baglanti.Open();
                komut.Connection = sv_baglanti;
                komut.ExecuteNonQuery();
                sv_baglanti.Close();
                servis_goster();
            }
            catch (Exception eklehata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(eklehata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
            }
            else{
                MessageBox.Show("Çıkış kilometresi Giriş kilometresinden küçük olamaz!");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            giriskm = Convert.ToInt32(textSVgkm.Text);
            cikiskm = Convert.ToInt32(textSVckm.Text);
            if (giriskm <= cikiskm)
            {
                try
                {
                    musteri_tckontrol();
                    girtarih = dateTimeSVgir.Value.Date.Year + "-" + dateTimeSVgir.Value.Date.Month + "-" + dateTimeSVgir.Value.Date.Day;
                    ciktarih = dateTimeSVcik.Value.Date.Year + "-" + dateTimeSVcik.Value.Date.Month + "-" + dateTimeSVcik.Value.Date.Day;
                    SqlCommand komut = new SqlCommand();
                    komut.CommandText = "Update Servis Set S_kodu=" + "'" + textSVkod.Text + "',M_kodu=" + "'" + muskod + "',Model_kodu='" + textSVmod.Text + "',P_kodu='" + perkod.ToString() + "',Arac_giriskm=" + textSVgkm.Text + ",Arac_cikiskm=" + textSVckm.Text + ",S_giris_tarih='" + dateTimeSVgir.Value.ToString("yyyy-MM-dd") + "',S_cikis_tarih='" + dateTimeSVcik.Value.ToString("yyyy-MM-dd") + "',Plaka='" + textSVplk.Text + "',Servis_ucret=" + Convert.ToInt32(textSVfyt.Text) + ",Durum='" + Convert.ToInt32(checkSVtm.Checked) + "' Where S_id='" + textSVid.Text + "'";
                    sv_baglanti.Open();
                    komut.Connection = sv_baglanti;
                    komut.ExecuteNonQuery();
                    sv_baglanti.Close();
                    servis_goster();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                    MessageBox.Show(hata.ToString());
                }
                finally
                {
                    sv_baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Çıkış kilometresi Giriş kilometresiden küçük olamaz!");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                textSVid.Clear();
                textSVkod.Clear();
                textSVckm.Clear();
                textSVfyt.Clear();
                textSVgkm.Clear();
                textSVmod.Clear();
                textSVmus.Clear();
                textSVplk.Clear();
                comboSVprc.Text = "";
                personel_goster();
                dateTimeSVcik.Text = System.DateTime.Today.ToShortDateString();
                dateTimeSVgir.Text = System.DateTime.Today.ToShortDateString();
                checkSVtm.Checked = false;
                dateTimeSVcik.Visible = false;
                label8.Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "Delete From Servis Where S_id='" + textSVid.Text + "'";
                sv_baglanti.Open();
                komut.Connection = sv_baglanti;
                komut.ExecuteNonQuery();
                sv_baglanti.Close();
                servis_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Servis_Islem svisform = new Servis_Islem();
            svisform.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SV_musform sermus = new SV_musform();
            sermus.mustc = this.mustc;
            sermus.Show();
        }

        private void checkSVtm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboSVprc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                personeladsoy = Convert.ToString(comboSVprc.SelectedItem);
                personel = personeladsoy.Split(' ');
                SqlCommand komut = new SqlCommand("Exec Personel_sorgu_padsoyad'" + personel[0] + "','" + personel[1] + "'", sv_baglanti);
                sv_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                while (sv_DR.Read())
                {
                    perkod = (sv_DR["Personel Kodu"]).ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select P_adi,P_soyadi From Personel Where P_kodu='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'", sv_baglanti);
                sv_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                sv_DR.Read();
                peradi = (sv_DR["P_adi"]) + " " + (sv_DR["P_soyadi"]).ToString();
                sv_baglanti.Close();
                textSVid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textSVkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                muskod = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                musteri_kodkontrol();
                textSVmus.Text = mustc;
                textSVmod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboSVprc.Text = peradi;
                textSVgkm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textSVckm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimeSVgir.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dateTimeSVcik.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textSVplk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textSVfyt.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[10].Value).ToString();
                checkSVtm.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[11].Value);
                dateTimeSVcik.Visible = true;
                label8.Visible = true;
            }

            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_baglanti.Close();
            }
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
