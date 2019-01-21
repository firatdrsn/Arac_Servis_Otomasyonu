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
    public partial class Musteriislem_kayitbul : Form
    {
        SQL cumle = new SQL();
        private int bul = 0;
        public string tcno;

        public Musteriislem_kayitbul()
        {
            InitializeComponent();
        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
                this.Close();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }


        }

        private void Musteriislem_kayitbul_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select_musterihzmt("Select * from Musteri", "Musterikayitbul");
                Musteribulgrid.DataSource = cumle.ds.Tables["Musterikayitbul"];
                // MessageBox.Show(cumle.ds.Tables["Musterikayitsil"].Columns["M_kodı"].ToString());

                sutunsecara.Items.Add(cumle.ds.Tables["Musterikayitbul"].Columns["M_kodu"].ToString());
                sutunsecara.Items.Add(cumle.ds.Tables["Musterikayitbul"].Columns["M_TCno"].ToString());
                sutunsecara.Items.Add(cumle.ds.Tables["Musterikayitbul"].Columns["M_adi"].ToString());
                sutunsecara.Items.Add(cumle.ds.Tables["Musterikayitbul"].Columns["M_soyadi"].ToString());
                sutunsecara.Items.Add(cumle.ds.Tables["Musterikayitbul"].Columns["M_adi"].ToString() + " " + cumle.ds.Tables["Musterikayitbul"].Columns["M_soyadi"].ToString());
                sutunsecara.SelectedIndex = 0;
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
                if (sutunsecara.SelectedItem.ToString() == "M_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["kayitbul"].Clear();
                        

                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Musteri WHERE M_kodu='" + Aranacakdeger.Text.ToString() + "'", "kayitbul");
                    Musteribulgrid.DataSource = cumle.ds.Tables["kayitbul"];
                    if (cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString()=="MT0")
                    {
                        musterituru.Text = "Araç Satış Müşterimiz.";
                        musterituru.Visible = true;
                    }
                    else if(cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString()=="MT1")
                    {
                        musterituru.Text = "Servis Müşterimiz.";
                        musterituru.Visible = true;
                    }
                    else if (cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString()=="MT2")
                    {
                        musterituru.Text = "Araç Satış ve Servis Müşterimiz";
                        musterituru.Visible = true;
                    }

                }
                else if (sutunsecara.SelectedItem.ToString() == "M_TCno")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["kayitbul"].Clear();
                        

                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Musteri WHERE M_TCno='" + Aranacakdeger.Text.ToString() + "'", "kayitbul");
                    Musteribulgrid.DataSource = cumle.ds.Tables["kayitbul"];
                    if (cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString() == "MT0")
                    {
                        musterituru.Text = "Araç Satış Müşterimiz.";
                        musterituru.Visible = true;
                    }
                    else if (cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString() == "MT1")
                    {
                        musterituru.Text = "Servis Müşterimiz.";
                        musterituru.Visible = true;
                    }
                    else if (cumle.ds.Tables["kayitbul"].Rows[0]["Musteri_turu_kodu"].ToString() == "MT2")
                    {
                        musterituru.Text = "Araç Satış ve Servis Müşterimiz";
                        musterituru.Visible = true;
                    }


                }
                else if (sutunsecara.SelectedItem.ToString() == "M_adi")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["kayitbul"].Clear();
                        

                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Musteri WHERE M_adi='" + Aranacakdeger.Text.ToString() + "'", "kayitbul");
                    Musteribulgrid.DataSource = cumle.ds.Tables["kayitbul"];
                    


                }
                else if (sutunsecara.SelectedItem.ToString() == "M_soyadi")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["kayitbul"].Clear();
                        

                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Musteri WHERE M_soyadi='" + Aranacakdeger.Text.ToString() + "'", "kayitbul");
                    Musteribulgrid.DataSource = cumle.ds.Tables["kayitbul"];
                    


                }
                else if (sutunsecara.SelectedItem.ToString() == "M_adi M_soyadi")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["kayitbul"].Clear();
                        

                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Musteri WHERE M_adi='" + mad.Text.ToString() + "' AND M_soyadi='" + msoyad.Text.ToString() + "'", "kayitbul");
                    Musteribulgrid.DataSource = cumle.ds.Tables["kayitbul"];
                   

                }

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
                cumle.ds.Tables["Musterikayitbul"].Clear();
                try
                {
                    cumle.ds.Tables["kayitbul"].Clear();
                }
                catch (Exception)
                {

                }

                cumle.Select_musterihzmt("Select * from Musteri", "Musterikayitbul");
                Musteribulgrid.DataSource = cumle.ds.Tables["Musterikayitbul"];
                bul = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }


        }

        private void sutunsecara_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sutunsecara.SelectedItem.ToString() == "M_kodu")
            {
                if ((ad.Visible == true)  || (soyad.Visible == true )|| (mad.Visible == true) || (msoyad.Visible == true))
                { 
                    ad.Visible = false;
                    soyad.Visible = false;
                    mad.Visible = false;
                    msoyad.Visible = false;
                }
                if ((Aranacakdeger.Visible==false) || deger.Visible==false)
                {
                    Aranacakdeger.Visible = true;
                    deger.Visible = true;


                }
            
            }
            else if (sutunsecara.SelectedItem.ToString() == "M_TCno")
            {
                if ((ad.Visible == true) || (soyad.Visible == true) || (mad.Visible == true) || (msoyad.Visible == true))
                {
                    ad.Visible = false;
                    soyad.Visible = false;
                    mad.Visible = false;
                    msoyad.Visible = false;
                }
                if ((Aranacakdeger.Visible == false) || deger.Visible == false)
                {
                    Aranacakdeger.Visible = true;
                    deger.Visible = true;


                }

            }
            else if (sutunsecara.SelectedItem.ToString() == "M_adi")
            {
                if ((ad.Visible == true) || (soyad.Visible == true) || (mad.Visible == true) || (msoyad.Visible == true))
                {
                    ad.Visible = false;
                    soyad.Visible = false;
                    mad.Visible = false;
                    msoyad.Visible = false;
                }
                if ((Aranacakdeger.Visible == false) || deger.Visible == false)
                {
                    Aranacakdeger.Visible = true;
                    deger.Visible = true;


                }

            }
            else if (sutunsecara.SelectedItem.ToString() == "M_soyadi")
            {
                if ((ad.Visible == true) || (soyad.Visible == true) || (mad.Visible == true) || (msoyad.Visible == true))
                {
                    ad.Visible = false;
                    soyad.Visible = false;
                    mad.Visible = false;
                    msoyad.Visible = false;
                }
                if ((Aranacakdeger.Visible == false) || deger.Visible == false)
                {
                    Aranacakdeger.Visible = true;
                    deger.Visible = true;


                }

            }
            else
            {
                if ((ad.Visible == false) || (soyad.Visible == false) || (mad.Visible == false) || (msoyad.Visible == false))
                {
                    ad.Visible = true;
                    soyad.Visible = true;
                    mad.Visible = true;
                    msoyad.Visible = true;
                }
                if ((Aranacakdeger.Visible == true) || deger.Visible == true)
                {
                    Aranacakdeger.Visible = false;
                    deger.Visible = false;


                }
            }
        
            }
            catch (Exception)
            {

               
            }



        }
    }
}
