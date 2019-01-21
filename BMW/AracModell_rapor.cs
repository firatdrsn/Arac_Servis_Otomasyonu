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
    public partial class AracModell_rapor : Form
    {
        AracModelrapor rapor = new AracModelrapor();
        public AracModell_rapor()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void btnraporla_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
                DataSet ds1 = new DataSet();
                baglan1.Open();
                SqlCommand komut1 = new SqlCommand("select * from Arac_Model WHERE Model_adi ='" + txtAracModel.Text + "'", baglan1);
                komut1.ExecuteNonQuery();
                SqlDataAdapter adtr = new SqlDataAdapter(komut1);
                adtr.Fill(ds1, "Arac_Model");
                try
                {
                    ds1.Tables["Arac_Model"].Clear();
                }
                catch (Exception)
                {


                }
                rapor.SetDataSource(ds1.Tables["Arac_Model"]);
                crystalReportViewer1.ReportSource = rapor;


                baglan1.Close();
            }
            catch (Exception)
            {
                
            }
            
        }

        private void AracModell_rapor_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan1 = new SqlConnection("Data Source=.;Initial Catalog=BMW;Integrated Security=True");
                DataSet ds1 = new DataSet();
                baglan1.Open();
                SqlCommand komut1 = new SqlCommand("select * from Arac_Model", baglan1);
                komut1.ExecuteNonQuery();
                SqlDataAdapter adtr = new SqlDataAdapter(komut1);
                adtr.Fill(ds1, "Arac_Model");

                rapor.SetDataSource(ds1.Tables["Arac_Model"]);
                crystalReportViewer1.ReportSource = rapor;
            }
            catch (Exception)
            {
                
               
            }
            
        }

        private void AracModelrapor1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
