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
    public partial class AdminPanel : Form
    {
        SQL AP_cumle = new SQL();
        A_Kullanici kullanici;
        Giris giris;
        Il_Ilce il_ilce;
        AracSerileri seriler;
        DonanimPaket donanim;
        Arac_Motor motor;
        Arac_Model model;
        public AdminPanel()
        {
            InitializeComponent();
        }



        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //Giris sırasında textboxda girilen tc no bilgisi public tanımlanan Tc_no değişkenine
            //gönderiliyor ve giriş bilgisini elde etmek için tc no değişkeni fonksiyona gönderiliyor.
            lbl_GirisBilgisi.Text = AP_cumle.Giris_Bilgisi(Giris.tc_no);
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            giris = new Giris();
            giris.Show();
            this.Hide();
        }


        private void btn_Kullanicilar_Click_1(object sender, EventArgs e)
        {
            kullanici = new A_Kullanici();
            kullanici.Show();
            this.Hide();
        }

        private void btn_Il_Ilce_Click_1(object sender, EventArgs e)
        {
            il_ilce = new Il_Ilce();
            il_ilce.Show();
            this.Hide();
        }

        private void btn_AracSerileri_Click_1(object sender, EventArgs e)
        {
            seriler = new AracSerileri();
            seriler.Show();
            this.Hide();
        }

        private void btn_DonanimPaket_Click_1(object sender, EventArgs e)
        {
            donanim = new DonanimPaket();
            donanim.Show();
            this.Hide();
        }

        private void btn_AracMotor_Click_1(object sender, EventArgs e)
        {
            motor = new Arac_Motor();
            motor.Show();
            this.Hide();
        }

        private void btn_Arac_Model_Click_1(object sender, EventArgs e)
        {
            model = new Arac_Model();
            model.Show();
            this.Hide();
        }

        private void btn_ACikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MusteriHizmet_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel musteri = new MusteriHizmetleriPanel();
            musteri.btn_Geridon.Visible = true;
            musteri.Show();
            this.Hide();
        }

        private void btn_Servis_Click(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            servis.btn_GeriDon.Visible = true;
            servis.Show();
            this.Hide();
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            Arac_Satis satis = new Arac_Satis();
            satis.btn_Geridon.Visible = true;
            satis.Show();
            this.Hide();
        }

        private void btn_Patron_Click(object sender, EventArgs e)
        {
            AnaMenü patron = new AnaMenü();
            patron.Show();
            this.Hide();
        }

        private void btn_YetkiTanimla_Click(object sender, EventArgs e)
        {
            YetkiKisitla yetki = new YetkiKisitla();
            yetki.Show();
            this.Hide();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            Backup b = new Backup();
            b.Show();
            this.Hide();
        }


    }
}
