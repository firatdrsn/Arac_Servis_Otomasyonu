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
    public partial class RAPORLAR : Form
    {
        public RAPORLAR()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AHMET; Initial Catalog=BMW; Integrated Security=true");
        DataTable tablo = new DataTable();
        private void RAPORLAR_Load(object sender, EventArgs e)
        {

        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            Personel_rapor personel = new Personel_rapor();
            personel.Show();
            this.Hide();
        }

        private void btnMüsteri_Click(object sender, EventArgs e)
        {

            Müsteri_rapor müsteri = new Müsteri_rapor();
            müsteri.Show();
            this.Hide();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Aracstok_rapor stok = new Aracstok_rapor();
            stok.Show();
            this.Hide();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            AracSatis_rapor satis = new AracSatis_rapor();
            satis.Show();
            this.Hide();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            Servis_rapor servis = new Servis_rapor();
            servis.Show();
            this.Hide();
        }

        private void btnPstok_Click(object sender, EventArgs e)
        {

            ParcaStok_rapor pstok = new ParcaStok_rapor();
            pstok.Show();
            this.Hide();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            AracModell_rapor model = new AracModell_rapor();
            model.Show();
            this.Hide();

        }

        private void btnSilinen_Click(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnaMenü ana = new AnaMenü();
            ana.Show();
            this.Hide();
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
