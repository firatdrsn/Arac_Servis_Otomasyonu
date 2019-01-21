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
    public partial class Personel_rapor : Form
    {
        public Personel_rapor()
        {
            InitializeComponent();
        }
        personel_repor rapor = new personel_repor();


        private void Personel_rapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Personel", baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Personel");
            
            rapor.SetDataSource(ds1.Tables["Personel"]);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
            DataSet ds1 = new DataSet();
            baglan1.Open();
            string sorgu = "execute Personel_sorgu_bolkod '" + txrPersonel.Text + "' ";
            SqlCommand komut1 = new SqlCommand(sorgu, baglan1);
            komut1.ExecuteNonQuery();
            SqlDataAdapter adtr = new SqlDataAdapter(komut1);
            adtr.Fill(ds1, "Personel");
            MessageBox.Show(komut1.CommandText);
            rapor.SetDataSource(ds1.Tables["Personel"]);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
