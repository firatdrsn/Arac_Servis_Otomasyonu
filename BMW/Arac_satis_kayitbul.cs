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
    public partial class Arac_satis_kayitbul : Form
    {
        SQL cumle = new SQL();
        private int bul=0;
        public string tcno;


        public Arac_satis_kayitbul()
        {
            InitializeComponent();
        }

        private void Arac_satis_kayitbul_Load(object sender, EventArgs e)
        {
            try
            {
            cumle.Select_musterihzmt("Select * from Arac_Satis", "Aracsatiskayit");
            Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayit"];
            sutunsecara.Items.Add(cumle.ds.Tables["Aracsatiskayit"].Columns["Satis_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["Aracsatiskayit"].Columns["Model_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["Aracsatiskayit"].Columns["P_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["Aracsatiskayit"].Columns["M_kodu"].ToString());
            sutunsecara.Items.Add(cumle.ds.Tables["Aracsatiskayit"].Columns["Plaka"].ToString());
            sutunsecara.SelectedIndex = 0;
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

        private void kayitara_Click(object sender, EventArgs e)
        {
            try
            {
                if (sutunsecara.SelectedItem.ToString() == "Satis_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["Aracsatiskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Arac_Satis WHERE Satis_kodu='" + Aranacakdeger.Text.ToString() + "'", "Aracsatiskayitbul");
                    Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayitbul"];
                    cumle.Select_musterihzmt("SELECT Model_adi FROM Arac_Model WHERE Model_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Model_kodu"].ToString() + "'", "Aracmodeladi");
                    cumle.Select_musterihzmt("SELECT P_adi,P_soyadi FROM Personel WHERE P_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + "'", "Aracsatispersonel");
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + "'", "Aracsatismusteri");
                    sonuclist.Items.Clear();
                    sonuclist.Items.Add(cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Satis_kodu"].ToString() + " Satış Kodlu Kayıtta BMW 'nin " + cumle.ds.Tables["Aracmodeladi"].Rows[0]["Model_adi"].ToString() + " Modelinin Satışı Yapılmıştır.");
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Satışı Yapan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + " Personel Kodlu Personelin Adı Soyadı " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_adi"].ToString() + " " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_soyadi"].ToString());
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Aracı Satın Alan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri Kodlu Müşterinin Adı Soyadı " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_soyadi"].ToString());


                }
                else if (sutunsecara.SelectedItem.ToString() == "Model_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["Aracsatiskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Arac_Satis WHERE Model_kodu='" + Aranacakdeger.Text.ToString() + "'", "Aracsatiskayitbul");
                    Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayitbul"];
                    cumle.Select_musterihzmt("SELECT Model_adi FROM Arac_Model WHERE Model_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Model_kodu"].ToString() + "'", "Aracmodeladi");
                    cumle.Select_musterihzmt("SELECT P_adi,P_soyadi FROM Personel WHERE P_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + "'", "Aracsatispersonel");
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + "'", "Aracsatismusteri");
                    sonuclist.Items.Clear();
                    sonuclist.Items.Add(cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Satis_kodu"].ToString() + " Satış Kodlu Kayıtta BMW 'nin " + cumle.ds.Tables["Aracmodeladi"].Rows[0]["Model_adi"].ToString() + " Modelinin Satışı Yapılmıştır.");
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Satışı Yapan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + " Personel Kodlu Personelin Adı Soyadı " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_adi"].ToString() + " " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_soyadi"].ToString());
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Aracı Satın Alan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri Kodlu Müşterinin Adı Soyadı " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_soyadi"].ToString());



                }
                else if (sutunsecara.SelectedItem.ToString() == "P_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["Aracsatiskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Arac_Satis WHERE P_kodu='" + Aranacakdeger.Text.ToString() + "'", "Aracsatiskayitbul");
                    Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayitbul"];
                    cumle.Select_musterihzmt("SELECT Model_adi FROM Arac_Model WHERE Model_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Model_kodu"].ToString() + "'", "Aracmodeladi");
                    cumle.Select_musterihzmt("SELECT P_adi,P_soyadi FROM Personel WHERE P_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + "'", "Aracsatispersonel");
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + "'", "Aracsatismusteri");
                    sonuclist.Items.Clear();
                    sonuclist.Items.Add(cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Satis_kodu"].ToString() + " Satış Kodlu Kayıtta BMW 'nin " + cumle.ds.Tables["Aracmodeladi"].Rows[0]["Model_adi"].ToString() + " Modelinin Satışı Yapılmıştır.");
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Satışı Yapan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + " Personel Kodlu Personelin Adı Soyadı " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_adi"].ToString() + " " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_soyadi"].ToString());
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Aracı Satın Alan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri Kodlu Müşterinin Adı Soyadı " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_soyadi"].ToString());



                }
                else if (sutunsecara.SelectedItem.ToString() == "M_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["Aracsatiskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Arac_Satis WHERE M_kodu='" + Aranacakdeger.Text.ToString() + "'", "Aracsatiskayitbul");
                    Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayitbul"];
                    cumle.Select_musterihzmt("SELECT Model_adi FROM Arac_Model WHERE Model_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Model_kodu"].ToString() + "'", "Aracmodeladi");
                    cumle.Select_musterihzmt("SELECT P_adi,P_soyadi FROM Personel WHERE P_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + "'", "Aracsatispersonel");
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + "'", "Aracsatismusteri");
                    sonuclist.Items.Clear();
                    sonuclist.Items.Add(cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Satis_kodu"].ToString() + " Satış Kodlu Kayıtta BMW 'nin " + cumle.ds.Tables["Aracmodeladi"].Rows[0]["Model_adi"].ToString() + " Modelinin Satışı Yapılmıştır.");
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Satışı Yapan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + " Personel Kodlu Personelin Adı Soyadı " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_adi"].ToString() + " " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_soyadi"].ToString());
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Aracı Satın Alan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri Kodlu Müşterinin Adı Soyadı " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_soyadi"].ToString());



                }
                else if (sutunsecara.SelectedItem.ToString() == "Plaka")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["Aracsatiskayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Arac_Satis WHERE Plaka='" + Aranacakdeger.Text.ToString() + "'", "Aracsatiskayitbul");
                    Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayitbul"];
                    cumle.Select_musterihzmt("SELECT Model_adi FROM Arac_Model WHERE Model_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Model_kodu"].ToString() + "'", "Aracmodeladi");
                    cumle.Select_musterihzmt("SELECT P_adi,P_soyadi FROM Personel WHERE P_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + "'", "Aracsatispersonel");
                    cumle.Select_musterihzmt("SELECT M_adi,M_soyadi FROM Musteri WHERE M_kodu='" + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + "'", "Aracsatismusteri");
                    sonuclist.Items.Clear();
                    sonuclist.Items.Add(cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["Satis_kodu"].ToString() + " Satış Kodlu Kayıtta BMW 'nin " + cumle.ds.Tables["Aracmodeladi"].Rows[0]["Model_adi"].ToString() + " Modelinin Satışı Yapılmıştır.");
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Satışı Yapan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["P_kodu"].ToString() + " Personel Kodlu Personelin Adı Soyadı " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_adi"].ToString() + " " + cumle.ds.Tables["Aracsatispersonel"].Rows[0]["P_soyadi"].ToString());
                    // sonuclist.Items.Add("");
                    sonuclist.Items.Add("Aracı Satın Alan " + cumle.ds.Tables["Aracsatiskayitbul"].Rows[0]["M_kodu"].ToString() + " Müşteri Kodlu Müşterinin Adı Soyadı " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_adi"].ToString() + " " + cumle.ds.Tables["Aracsatismusteri"].Rows[0]["M_soyadi"].ToString());



                }
                
            }
            catch(Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
            
            

        }

        private void Tümtablogoster_Click(object sender, EventArgs e)
        {
            try
            {
                cumle.ds.Tables["Aracsatiskayit"].Clear();
                try
                {
                    cumle.ds.Tables["Aracsatiskayitbul"].Clear();
                }
                catch (Exception )
                {
                    
                }

                cumle.Select_musterihzmt("Select * from Arac_Satis", "Aracsatiskayit");
                Aracsatisbulgrid.DataSource = cumle.ds.Tables["Aracsatiskayit"];
                bul = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
            
        }
    }
}
