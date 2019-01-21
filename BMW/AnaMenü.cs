using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW
{
    public partial class AnaMenü : Form
    {
        SQL cumle = new SQL();
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void btnPersonelİslemleri_Click(object sender, EventArgs e)
        {
            Form personelislemleri = new Personelİslemleri();
            personelislemleri.Show();
            this.Hide();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {

            Form raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

    

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {
            if (Giris.yetki_kodu == "YK0")
            {

                btn_GeriDon.Visible = true;
            }
           label1.Text= cumle.Giris_Bilgisi(Giris.tc_no);
        
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

    }
}
