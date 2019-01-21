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
    public partial class AracSatis_rapor : Form
    {
        AracSatisRaporu rapor = new AracSatisRaporu();
        public AracSatis_rapor()
        {
            InitializeComponent();
        }

        private void btnAracStokrap1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Arac_Satis WHERE Satis_tarih='" + txtSatisTarih.Text + "'", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Arac_Satis");
           
            rapor.SetDataSource(ds1.Tables["Arac_Satis"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btnAracSatis_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Arac_Satis WHERE Satis_kodu='" + ttAracSatis.Text + "'", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Arac_Satis");
         
            rapor.SetDataSource(ds1.Tables["Arac_Satis"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void AracSatis_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Arac_Satis", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Arac_Satis");
         
            rapor.SetDataSource(ds1.Tables["Arac_Satis"]);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
