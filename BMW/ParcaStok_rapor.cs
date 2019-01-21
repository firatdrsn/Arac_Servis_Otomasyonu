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
    public partial class ParcaStok_rapor : Form
    {
        public ParcaStok_rapor()
        {
            InitializeComponent();
        }
        ParcaStokRapor rapor = new ParcaStokRapor();
        private void btnGeri_Click(object sender, EventArgs e)
        {

            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide(); 
        }

        private void btnParcaStok_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Parca_Stok WHERE Parca_adi='" + txtParcaStok.Text + "' ", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Parca_Stok");
            MessageBox.Show(komut1.CommandText);
            rapor.SetDataSource(ds1.Tables["Parca_Stok"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void ParcaStok_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("select * from Parca_Stok", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Parca_Stok");
            
            rapor.SetDataSource(ds1.Tables["Parca_Stok"]);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
