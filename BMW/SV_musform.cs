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
    public partial class SV_musform : Form
    {
        SqlConnection sv_musbaglanti = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=servis; password=servis;");
        Servis srvs;
        public string mustc;

        public SV_musform()
        {
            InitializeComponent();
        }

        private void SV_musform_Load(object sender, EventArgs e)
        {
            srvs = new Servis();
            try
            {
                //string mustc = ((Servis)Application.OpenForms.OfType<Servis>().SingleOrDefault()).mustc;
                SqlDataAdapter svmus_DA = new SqlDataAdapter("Execute Musteri_sorgu_mtcno1 " + mustc, sv_musbaglanti);
                DataSet svmus_DS = new DataSet();
                sv_musbaglanti.Open();
                svmus_DA.Fill(svmus_DS, "Servis Musteri");
                dataGridView1.DataSource = svmus_DS.Tables["Servis Musteri"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                sv_musbaglanti.Close();
            }

        }
    }
}
