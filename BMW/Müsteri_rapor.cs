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
    public partial class Müsteri_rapor : Form
    {
        public Müsteri_rapor()
        {
            InitializeComponent();
        }
        MusteriRapor rapor = new MusteriRapor();
        private void btnGeri_Click(object sender, EventArgs e)
        {

            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void btnMüsteri_Click(object sender, EventArgs e)
        {
              SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
              DataSet ds1 = new DataSet();
              baglan1.Open();
              SqlCommand komut1 = new SqlCommand("execute Musteri_sorgu_mtcno '" + txtMusteri.Text + "'", baglan1);
              komut1.ExecuteNonQuery();
              SqlDataAdapter adtr = new SqlDataAdapter(komut1);
              adtr.Fill(ds1, "Musteri");
              MessageBox.Show(komut1.CommandText);
              rapor.SetDataSource(ds1.Tables["Musteri"]);
              crystalReportViewer1.ReportSource = rapor;
        }

        private void btnMusteriRaporla1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Musteri where Musteri_turu_kodu='" + txtMusterirap.Text + "' ", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Musteri");
    
            rapor.SetDataSource(ds1.Tables["Musteri"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void Müsteri_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Musteri", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Musteri");
            
            rapor.SetDataSource(ds1.Tables["Musteri"]);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
