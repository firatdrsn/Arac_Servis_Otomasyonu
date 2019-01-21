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

    public partial class Parca : Form
    {
        SqlConnection prc_baglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=servis; password=servis;");

        public void parca_stok_goster()
        {
            try
            {
                SqlDataAdapter prc_DA = new SqlDataAdapter("Select * From Parca_Stok", prc_baglanti);
                DataSet prc_DS = new DataSet();
                prc_baglanti.Open();
                prc_DA.Fill(prc_DS, "Parca_Stok");
                dataGridView1.DataSource = prc_DS.Tables["Parca_Stok"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                prc_baglanti.Close();
            }
        }
        public Parca()
        {
            InitializeComponent();
        }

    

 


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                prc_baglanti.Open();
                komut.Connection = prc_baglanti;
                komut.CommandText = "INSERT INTO Parca_Stok Values(" + "'" + textPAK.Text + "'," + "'" + textPAad.Text + "'," + textPAstok.Text + "," + Convert.ToDouble(textPAfiyat.Text) + ",'" + textPAaciklama.Text + "')";
                komut.ExecuteNonQuery();
                prc_baglanti.Close();
                parca_stok_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                prc_baglanti.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sv_sorgu = "UPDATE Parca_Stok Set Parca_kodu='" + textPAK.Text + "'," + "Parca_adi='" + textPAad.Text + "'," + "Stok_adet=" + Convert.ToInt32(textPAstok.Text) + "," + "Birim_Fiyat=" + Convert.ToDouble(textPAfiyat.Text) + "," + "Aciklama='" + textPAaciklama.Text + "' Where PStok_id=" + Convert.ToInt32(textPAid.Text);
                SqlCommand komut = new SqlCommand(sv_sorgu, prc_baglanti);
                prc_baglanti.Open();
                komut.ExecuteNonQuery();
                prc_baglanti.Close();
                parca_stok_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                prc_baglanti.Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sv_sorgu = "Delete From Parca_Stok Where PStok_id=" + Convert.ToInt32(textPAid.Text);
                SqlCommand komut = new SqlCommand(sv_sorgu, prc_baglanti);
                prc_baglanti.Open();
                komut.ExecuteNonQuery();
                prc_baglanti.Close();
                parca_stok_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                prc_baglanti.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Servis_Islem servis_islemform = new Servis_Islem();
            servis_islemform.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                textPAid.Clear();
                textPAK.Clear();
                textPAad.Clear();
                textPAstok.Clear();
                textPAfiyat.Clear();
                textPAaciklama.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
        }

        private void Parca_Load(object sender, EventArgs e)
        {
            parca_stok_goster();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textPAid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textPAK.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textPAad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textPAstok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textPAfiyat.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value).ToString();
                textPAaciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
        }
    }
}