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
    public partial class ASmodel : Form
    {
        public ASmodel()
        {
            InitializeComponent();
        }
        public string asmkodu;
        SqlConnection asmodel_baglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=satis; password=satis;");
        private void ASmodel_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter as_DA = new SqlDataAdapter("Execute Arac_model_sorgu_modelkodu  " + asmkodu, asmodel_baglanti);
                DataSet as_DS = new DataSet();
                asmodel_baglanti.Open();
                as_DA.Fill(as_DS, "Arac Model");
                dataGridView1.DataSource = as_DS.Tables["Arac Model"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asmodel_baglanti.Close();
            }
        }
    }
}
