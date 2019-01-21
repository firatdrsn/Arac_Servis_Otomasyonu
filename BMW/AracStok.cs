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
    public partial class AracStok : Form
    {
        string modelkodu;
        double model_fiyat, toplam_fiyat, asotv, askdv, askar;
        string asmodelkod;
        int ascc;
        SqlConnection astok_baglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=satis; password=satis;");
        public AracStok()
        {
            InitializeComponent();
        }
        private void model_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Distinct(Model_adi) From Arac_Model", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    comboASmod.Items.Add(as_DR["Model_adi"]);
                }
                astok_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void asfiyathesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Arac_Model Where Model_kodu='" + textASmod.Text + "'", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    model_fiyat = Convert.ToDouble((as_DR["Fiyat"]));
                    textASalf.Text = model_fiyat.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void asotvhesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select CC From Arac_Motor Where AracM_kodu=(Select AracM_kodu From Arac_Model Where Model_kodu='" + asmodelkod.ToString() + "')", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    ascc = Convert.ToInt32((as_DR["CC"]));
                }
                if (ascc <= 1600)
                {
                    textASotv.Text = "60";
                }
                else if (ascc <= 2000)
                {
                    textASotv.Text = "110";
                }
                else
                {
                    textASotv.Text = "160";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void asbirimtoplamfiyathesapla()
        {
            asotv = ((model_fiyat * (Convert.ToInt32(textASotv.Text))) / 100);
            askdv = ((model_fiyat * (Convert.ToInt32(textASkdv.Text))) / 100);
            askar = ((model_fiyat * (Convert.ToInt32(textASkar.Text))) / 100);
            toplam_fiyat = (model_fiyat + asotv + askdv + askar);
            textASbtf.Text = toplam_fiyat.ToString();
        }
        private void aracstok_goster()
        {
            try
            {
                SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Arac_Stok", astok_baglanti);
                DataSet sv_DS = new DataSet();
                astok_baglanti.Open();
                sv_DA.Fill(sv_DS, "Arac_Stok");
                dataGridView1.DataSource = sv_DS.Tables["Arac_Stok"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void asseri_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Seri_kodu From Arac_Serisi", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    comboASsri.Items.Add(ast_DR["Seri_kodu"]);
                }
                astok_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void asmodel_kontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Arac_Model Where Seri_kodu='" + comboASsri.SelectedItem.ToString() + "' And Model_adi='" + comboASmod.SelectedItem.ToString() + "'", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                ast_DR.Read();
                asmodelkod = (ast_DR["Model_kodu"]).ToString();
                textASmod.Text = asmodelkod;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }


        private void AracStok_Load(object sender, EventArgs e)
        {
            aracstok_goster();
            model_goster();
            asseri_goster();
        }


     
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO Arac_Stok Values('" + textASmod.Text + "'," + textASadt.Text + ",'" + Convert.ToDouble(model_fiyat) + "','" + Convert.ToDouble(asotv) + "','" + Convert.ToDouble(askdv) + "','" + Convert.ToDouble(askar) + "','" + Convert.ToDouble(toplam_fiyat) + "')";
                astok_baglanti.Open();
                komut.Connection = astok_baglanti;
                komut.ExecuteNonQuery();
                astok_baglanti.Close();
                aracstok_goster();
            }
            catch (Exception eklehata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(eklehata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textASadt.Text) < 0)
            {
                MessageBox.Show("Adet değeri negatif olamaz");
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    komut.CommandText = ("Update Arac_Stok Set Adet='" + textASadt.Text + "' Where Model_kodu='" + modelkodu + "'");
                    komut.Connection = astok_baglanti;
                    astok_baglanti.Open();
                    komut.Connection = astok_baglanti;
                    komut.ExecuteNonQuery();
                    astok_baglanti.Close();
                    aracstok_goster();
                }
                catch (Exception eklehata)
                {
                    MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                    MessageBox.Show(eklehata.ToString());
                }
                finally
                {
                    astok_baglanti.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ASmodel aracstokmodelform = new ASmodel();
            aracstokmodelform.asmkodu = this.modelkodu;

            aracstokmodelform.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textASadt.Clear();
            textASalf.Clear();
            textASbtf.Clear();
            textASid.Clear();
            textASmod.Clear();
            textASotv.Clear();
            comboASmod.Text = "";
            comboASsri.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Arac_Satis satis = new Arac_Satis();
            satis.Show();
            this.Hide();
        }

        private void comboASsri_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                comboASmod.Items.Clear();
                comboASmod.Text = "";
                SqlCommand komut = new SqlCommand("Select Model_adi From Arac_Model Where Seri_kodu='" + comboASsri.SelectedItem.ToString() + "'");
                komut.Connection = astok_baglanti;
                astok_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    comboASmod.Items.Add(ast_DR["Model_adi"]);
                }
                astok_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void comboASmod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            asmodel_kontrol();
            asfiyathesapla();
            asotvhesapla();
            asbirimtoplamfiyathesapla();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                modelkodu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

    }
}
