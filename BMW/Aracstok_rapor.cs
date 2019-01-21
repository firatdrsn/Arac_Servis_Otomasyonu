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
    public partial class Aracstok_rapor : Form
    {
        aracstokrapor rapor = new aracstokrapor();
        public Aracstok_rapor()
        {
            InitializeComponent();
        }

        private void Aracstok_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Arac_Stok", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Arac_Stok");
            
            rapor.SetDataSource(ds1.Tables["Arac_Stok"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btnAracstok_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("execute Arac_Stok_sorgu_modelkodu '" + txtAracStok.Text + "'", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Arac_Stok");
            MessageBox.Show(komut1.CommandText);
            rapor.SetDataSource(ds1.Tables["Arac_Stok"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void aracstokrapor1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
