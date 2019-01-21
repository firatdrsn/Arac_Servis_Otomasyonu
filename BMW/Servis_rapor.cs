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
    public partial class Servis_rapor : Form
    {
        public Servis_rapor()
        {
            InitializeComponent();
        }
        ServisRapor rapor = new ServisRapor();
        private void Servis_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Servis", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Servis");
            MessageBox.Show(komut1.CommandText);
            rapor.SetDataSource(ds1.Tables["Servis"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Servis where Durum ='" + txtServis.Text + "'", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Servis");
            MessageBox.Show(komut1.CommandText);
            rapor.SetDataSource(ds1.Tables["Servis"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }
    }
}
