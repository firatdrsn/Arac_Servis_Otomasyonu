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
    public partial class Servis_detayli_arama : Form
    {
        SQL    cumle = new SQL();
        Islem_goster islem = new Islem_goster();
        private int bul = 0;
        public string tcno;

        public Servis_detayli_arama()
        {
            InitializeComponent();
        }

        private void Servis_detayli_arama_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select_musterihzmt("Select * from Servis", "servisdetaylikayit");
                Firmabulgrid.DataSource = cumle.ds.Tables["servisdetaylikayit"];
                sutunsecara.Items.Add(cumle.ds.Tables["servisdetaylikayit"].Columns["S_kodu"].ToString());
                sutunsecara.Items.Add(cumle.ds.Tables["servisdetaylikayit"].Columns["Plaka"].ToString());
                sutunsecara.SelectedIndex = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void Tümtablogoster_Click(object sender, EventArgs e)
        {
            try
            {
                cumle.ds.Tables["servisdetaylikayit"].Clear();
                try
                {
                    cumle.ds.Tables["servisdetaylikayitbul"].Clear();
                }
                catch (Exception)
                {

                }

                cumle.Select_musterihzmt("Select * from Servis", "servisdetaylikayit");
                Firmabulgrid.DataSource = cumle.ds.Tables["servisdetaylikayit"];
                bul = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void kayitara_Click(object sender, EventArgs e)
        {
            try
            {
                if (sutunsecara.SelectedItem.ToString() == "S_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["servisdetaylikayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Servis WHERE S_kodu='" + Aranacakdeger.Text.ToString() + "'", "servisdetaylikayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["servisdetaylikayitbul"];
                    islemleri_goster(Aranacakdeger.Text.ToString());
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + "'", "servismusteri");
                    cumle.Select_musterihzmt("SELECT M_kodu,Count(*) AS 'adet' FROM Servis Group by M_kodu ", "serviskayitadeti");

                   

                    sonuc1.Text = Aranacakdeger.Text.ToString() + " Servis Kodlu Kayıt " + cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri koduna Sahip " + cumle.ds.Tables["servismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["servismusteri"].Rows[0]["M_soyadi"].ToString() + " Müşterimize Aittir.";
                    sonuc2.Text = cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri koduna Sahip " + cumle.ds.Tables["servismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["servismusteri"].Rows[0]["M_soyadi"].ToString() + " Müşterimizin Serviste "+cumle.ds.Tables["serviskayitadeti"].Rows[0]["adet"].ToString()+ " Adet Kaydı Bulunmaktadır.";
                    sonuc1.Visible = true;
                    sonuc2.Visible = true;
                    servisislem.Visible = true;


                    
                    

                }
                else if (sutunsecara.SelectedItem.ToString() == "Plaka")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["servisdetaylikayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Servis WHERE Plaka='" + Aranacakdeger.Text.ToString() + "'", "servisdetaylikayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["servisdetaylikayitbul"];
                    cumle.Select_musterihzmt("SELECT S_kodu FROM Servis WHERE Plaka='" + Aranacakdeger.Text.ToString() + "'", "serviskodu");
                    islemleri_goster(cumle.ds.Tables["serviskodu"].Rows[0]["S_kodu"].ToString());
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + "'", "servismusteri");
                    cumle.Select_musterihzmt("SELECT M_kodu,Count(*) AS 'adet' FROM Servis Group by M_kodu ", "serviskayitadeti");

                    sonuc1.Text = Aranacakdeger.Text.ToString() + " Plaka Kodlu Kayıt " + cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri koduna Sahip " + cumle.ds.Tables["servismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["servismusteri"].Rows[0]["M_soyadi"].ToString() + " Müşterimize Aittir.";
                    sonuc2.Text = cumle.ds.Tables["servisdetaylikayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri koduna Sahip " + cumle.ds.Tables["servismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["servismusteri"].Rows[0]["M_soyadi"].ToString() + " Müşterimizin Serviste " + cumle.ds.Tables["serviskayitadeti"].Rows[0]["adet"].ToString() + " Adet Kaydı Bulunmaktadır.";
                    sonuc1.Visible = true;
                    sonuc2.Visible = true;
                    servisislem.Visible = true;

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
                this.Close();
                m.tcno = tcno;
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
           

        }

        private void islemleri_goster(string deger)
        {
            try
            {
                try
                {
                    cumle.ds.Tables["islemgoster"].Clear();
                }
                catch (Exception)
                {
                    
                   
                }
                cumle.Select_musterihzmt("SELECT * FROM Islem Where S_kodu='" + deger.ToString() + "'", "islemgoster");
                islem.lb_arac.Text = deger + " Servis Kodlu Araç İçin Yapılan İşlemler";
                islem.Islemgrid.DataSource = cumle.ds.Tables["islemgoster"];
            }
            catch (Exception)
            {
                
            }
            


        }

        private void servisislem_Click(object sender, EventArgs e)
        {
            try
            {

                islem.Show();
            }
            catch (Exception)
            {
                
               
            }
        }
    }
}
