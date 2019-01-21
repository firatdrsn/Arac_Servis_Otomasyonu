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
    public partial class Personelİslemleri : Form
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=patron; password=patron;");
        public SqlConnection baglanti4 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
        public SqlConnection baglanti6 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
        public string menu;


        public Personelİslemleri()
        {
            InitializeComponent();
        }


        private void Personelİslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Iller ORDER BY Il_kodu ASC ", baglanti);
                adtr.Fill(dt);
                cmbİlKodu.ValueMember = "Il_kodu";
                cmbİlKodu.DisplayMember = "Il_adi";
                cmbİlKodu.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
             
            }
            
        }
        public void bilgidoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel ORDER BY P_id DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        bool kayıtvarmi(string sorgu)
        {
            SqlConnection baglanti3 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            baglanti3.Open();
            bool kayıt = false;
            SqlCommand varmi = new SqlCommand(sorgu, baglanti3);
            int sonc = Convert.ToInt32(varmi.ExecuteScalar());
            if (sonc > 1)
            {
                kayıt = true;
            }
            else
            {
                kayıt = false;
            }
            baglanti3.Close();

            return kayıt;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbİlceKodu.SelectedValue.ToString());
            SqlConnection baglanti1 = new SqlConnection("Data Source=.; Initial Catalog=BMW; Integrated Security=true");


            if (kayıtvarmi("select count(*) from Personel where P_TCno='" + txtTcNO.Text + "'") == true)
            {
                MessageBox.Show("PERSONEL numarası sistemde kayıtlı");
            }
            else
            {

                if (dateİstenAyrılmaTarihi.Checked == true)
                {
                    try
                    {
                        baglanti1.Open();
                        SqlCommand komut = new SqlCommand("INSERT INTO Personel(P_kodu,P_TCno,P_adi,P_soyadi,P_dog_tar,Il_kodu,Ilce_kodu,P_adres,P_maas,P_is_giristarih,P_is_cikistarih,Bol_kodu)VALUES(@P_kodu,@P_TCno,@P_adi,@P_soyadi,@P_dog_tar,@il_kodu,@ilce_kodu,@P_adres,@P_maas,@P_ise_giristarih,@P_is_cikistarih,@Bol_kodu)", baglanti1);
                        komut.Parameters.AddWithValue("@P_kodu", txtPkodu.Text);
                        komut.Parameters.AddWithValue("@P_TCno", txtTcNO.Text);
                        komut.Parameters.AddWithValue("@P_adi", txtAdi.Text);
                        komut.Parameters.AddWithValue("@P_soyadi", txtSoyadi.Text);
                        komut.Parameters.AddWithValue("@P_dog_tar", dateDoğumTarih.Value.ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@il_kodu", cmbİlKodu.SelectedValue.ToString());
                        komut.Parameters.AddWithValue("@ilce_kodu", cmbİlceKodu.SelectedValue.ToString());
                        komut.Parameters.AddWithValue("@P_adres", txtAdres.Text);
                        komut.Parameters.AddWithValue("@P_maas", Convert.ToDouble(txtmaas.Text));
                        komut.Parameters.AddWithValue("@P_ise_giristarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                        komut.Parameters.AddWithValue("@P_is_cikistarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                        komut.Parameters.AddWithValue("@Bol_kodu", txtBölümKodu.Text);
                        komut.ExecuteNonQuery();
                        bilgidoldur();
                        baglanti1.Close();
                        MessageBox.Show("Kişi BMW veritabanın Persoel tablosuna eklenmiştir");

                    }
                    catch (System.Data.SqlClient.SqlException SqlException)
                    {

                        System.Windows.Forms.MessageBox.Show(SqlException.Message);

                    }
                }
                else
                {
                    try
                    {
                        baglanti1.Open();
                        SqlCommand komut = new SqlCommand("INSERT INTO Personel(P_kodu,P_TCno,P_adi,P_soyadi,P_dog_tar,Il_kodu,Ilce_kodu,P_adres,P_maas,P_is_giristarih,P_is_cikistarih,Bol_kodu)VALUES(@P_kodu,@P_TCno,@P_adi,@P_soyadi,@P_dog_tar,@il_kodu,@ilce_kodu,@P_adres,@P_maas,@P_ise_giristarih,'Null',@Bol_kodu)", baglanti1);
                        komut.Parameters.AddWithValue("@P_kodu", txtPkodu.Text);
                        komut.Parameters.AddWithValue("@P_TCno", txtTcNO.Text);
                        komut.Parameters.AddWithValue("@P_adi", txtAdi.Text);
                        komut.Parameters.AddWithValue("@P_soyadi", txtSoyadi.Text);
                        komut.Parameters.AddWithValue("@P_dog_tar", dateDoğumTarih.Value.ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@il_kodu", cmbİlKodu.SelectedValue.ToString());
                        komut.Parameters.AddWithValue("@ilce_kodu", cmbİlceKodu.SelectedValue.ToString());
                        komut.Parameters.AddWithValue("@P_adres", txtAdres.Text);
                        komut.Parameters.AddWithValue("@P_maas", Convert.ToDouble(txtmaas.Text));
                        komut.Parameters.AddWithValue("@P_ise_giristarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                        komut.Parameters.AddWithValue("@P_is_cikistarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                        komut.Parameters.AddWithValue("@Bol_kodu", txtBölümKodu.Text);
                        komut.ExecuteNonQuery();
                        bilgidoldur();
                        baglanti1.Close();
                        MessageBox.Show("Kişi BMW veritabanın Persoel tablosuna eklenmiştir");
                    }
                    catch (System.Data.SqlClient.SqlException SqlException)
                    {

                        System.Windows.Forms.MessageBox.Show(SqlException.Message);

                    }
                }
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            bilgidoldur();
        }

        private void btnPguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti7 = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=patron; password=patron;");

            try
            {
                baglanti7.Open();
                SqlCommand komutum = new SqlCommand("UPDATE Personel SET P_kodu=@P_kodu,P_TCno=@P_TCno,P_adi=@P_adi,P_soyadi=@P_soyadi,P_dog_tar=@P_dog_tar,Il_kodu=@Il_kodu,Ilce_kodu=@Ilce_kodu,P_adres=@P_adres,P_maas=@P_maas,P_is_giristarih=@P_is_giristarih,P_is_cikistarih=@P_is_cikistarih,Bol_kodu=@Bol_kodu WHERE P_id=@id", baglanti7);
                komutum.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                komutum.Parameters.AddWithValue("@P_kodu", txtPkodu.Text);
                komutum.Parameters.AddWithValue("@P_TCno", txtTcNO.Text);
                komutum.Parameters.AddWithValue("@P_adi", txtAdi.Text);
                komutum.Parameters.AddWithValue("@P_soyadi", txtSoyadi.Text);
                komutum.Parameters.AddWithValue("@P_dog_tar", dateDoğumTarih.Value.ToString("yyyy-MM-dd"));
                komutum.Parameters.AddWithValue("@il_kodu", cmbİlKodu.SelectedValue.ToString());
                komutum.Parameters.AddWithValue("@ilce_kodu", cmbİlceKodu.SelectedValue.ToString());
                komutum.Parameters.AddWithValue("@P_adres", txtAdres.Text);
                komutum.Parameters.AddWithValue("@P_maas", Convert.ToDouble(txtmaas.Text));
                komutum.Parameters.AddWithValue("@P_ise_giristarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                komutum.Parameters.AddWithValue("@P_is_cikistarih", Convert.ToDateTime(txtiseBaslama.Text.ToString()));
                komutum.Parameters.AddWithValue("@Bol_kodu", txtBölümKodu.Text);
                komutum.ExecuteNonQuery();
                baglanti7.Close();
                bilgidoldur();
                MessageBox.Show("Güncellendi.");
            }
            catch (SqlException)
            {
                MessageBox.Show("Hata olustu!");
            }
        }

        private void btnPsil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti2 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("DELETE FROM Personel WHERE P_kodu=@pkod", baglanti2);
            komut2.Parameters.AddWithValue("@pkod", txtSil.Text);
            komut2.ExecuteNonQuery();
            bilgidoldur();
            MessageBox.Show("PERSONEL KAYDI SİLİNMİSTİR");
            txtSil.Clear();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaMenü_Click(object sender, EventArgs e)
        {
            AnaMenü m = new AnaMenü();
            this.Close();

            m.Show();

        }

        private void btnbolumekle_Click(object sender, EventArgs e)
        {
            BölümEkle blm = new BölümEkle();
            blm.Show();
            this.Hide();
        }

        private void btnara1_Click(object sender, EventArgs e)
        {

            baglanti4.Open();
            SqlCommand komut = new SqlCommand("SELECT P_kodu,P_TCno,P_adi,P_soyadi FROM Personel WHERE P_kodu  like '%" + txtPkoduara.Text + "%'", baglanti4);
            SqlDataAdapter dan = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            dan.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlDataReader cikti1 = komut.ExecuteReader();
            if (cikti1.Read())
            {
                txtGöster.Text = cikti1["P_kodu"].ToString() + cikti1["P_TCno"].ToString() + cikti1["P_adi"].ToString() + cikti1["P_soyadi"].ToString();

            }
            else
            {
                MessageBox.Show("kayıt bulunamadı...");
            }

            radiobtnPtcara.Enabled = true;
            txtAramatcno.Enabled = true;
            txtPkoduara.Clear();
            baglanti4.Close();
        }

        private void btnara2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti5 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            baglanti5.Open();
            SqlCommand komut3 = new SqlCommand("SELECT P_kodu,P_TCno,P_adi,P_soyadi FROM Personel WHERE  P_TCno  like '%" + txtAramatcno.Text + "%'", baglanti5);
            SqlDataAdapter adtr1 = new SqlDataAdapter(komut3);
            DataSet ds = new DataSet();
            adtr1.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlDataReader cikti2 = komut3.ExecuteReader();
            if (cikti2.Read())
            {
                txtGöster.Text = cikti2["P_kodu"].ToString() + cikti2["P_TCno"].ToString() + cikti2["P_adi"].ToString() + cikti2["P_soyadi"].ToString();

            }
            else
            {
                MessageBox.Show("kayıt bulunamadı...");
            }

            cikti2.Close();
            radiobtnPkoduara.Enabled = true;
            txtPkoduara.Enabled = true;
            txtAramatcno.Clear();

            baglanti5.Close();
        }

        private void dateİseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dateİseBaslamaTarihi.Checked == true)
                txtiseBaslama.Text = dateİseBaslamaTarihi.Value.ToString("yyyy-MM-dd");
        }

        private void dateİstenAyrılmaTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dateİstenAyrılmaTarihi.Checked == true)
            {
                if (txtİstenAyrilma.Text == null)
                {
                    txtİstenAyrilma.Text = dateİstenAyrılmaTarihi.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    txtİstenAyrilma.Text = "null";
                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string Pkodu = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Ptcno = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Padi = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Psoyadi = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string Pdogtar = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string ılkod = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string ılcekod = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string Padres = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string Pmaas = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
            string Pisgiris = dataGridView1.Rows[secilialan].Cells[10].Value.ToString();
            string Piscikis = dataGridView1.Rows[secilialan].Cells[11].Value.ToString();
            string Pbolkod = dataGridView1.Rows[secilialan].Cells[12].Value.ToString();

            txtPkodu.Text = Pkodu;
            txtTcNO.Text = Ptcno;
            txtAdi.Text = Padi;
            txtSoyadi.Text = Psoyadi;
            dateDoğumTarih.Text = Pdogtar;
            cmbİlKodu.Text = ılkod;
            cmbİlceKodu.Text = ılcekod;
            txtAdres.Text = Padres;
            txtmaas.Text = Pmaas;
            dateİseBaslamaTarihi.Text = Pisgiris;
            dateİstenAyrılmaTarihi.Text = Piscikis;
            txtBölümKodu.Text = Pbolkod;
        }

        private void cmbİlKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbİlKodu.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Ilceler where Il_kodu = " + cmbİlKodu.SelectedValue, baglanti);
                da.Fill(dt);
                cmbİlceKodu.ValueMember = "Ilce_kodu";
                cmbİlceKodu.DisplayMember = "Ilce_adi";
                cmbİlceKodu.DataSource = dt;
            }
        }

        private void cmbİlceKodu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
