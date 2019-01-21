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
    public partial class BölümEkle : Form
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=AHMET;Initial Catalog=BMW;Integrated Security=True");
        public BölümEkle()
        {
            InitializeComponent();
        }
        public void bilgidoldur1()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=AHMET;Initial Catalog=BMW;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("INSERT INTO Bolumler(Bol_kodu,Bol_adi) VALUES(@Bol_kodu,@Bol_adi)", baglanti);
            komutlar.Parameters.AddWithValue("@Bol_kodu", txtbolumkodu.Text);
            komutlar.Parameters.AddWithValue("@Bol_adi", txtbolumadı.Text);
            komutlar.ExecuteNonQuery();
            bilgidoldur1();
            baglanti.Close();
            MessageBox.Show("BMW VERİTABANINA BÖLÜMLER EKLENMİŞTİR...");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti2 = new SqlConnection("Data Source=AHMET;Initial Catalog=BMW;Integrated Security=True");
            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("DELETE FROM Bolumler WHERE Bol_kodu=@Bol_kodu", baglanti2);
            komut2.Parameters.AddWithValue("@Bol_kodu", txtbolumkodu.Text);
            komut2.ExecuteNonQuery();
            bilgidoldur1();
            MessageBox.Show("PERSONEL KAYDI SİLİNMİSTİR");
            txtbolumkodu.Clear();
        }

        private void bTNgeri_Click(object sender, EventArgs e)
        {

            Personelİslemleri frm1 = new Personelİslemleri();
            frm1.Show();
            this.Hide();
        }
    }
}
