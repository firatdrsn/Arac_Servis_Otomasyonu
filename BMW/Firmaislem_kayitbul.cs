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
    public partial class Firmaislem_kayitbul : Form
    {
        SQL cumle = new SQL();
        private int bul=0;
        public string tcno;


        public Firmaislem_kayitbul()
        {
            InitializeComponent();
        }

        private void geridonara_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
                m.tcno = tcno;
                m.Show();
                this.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
           
        }

        private void Firmaislem_kayitbul_Load(object sender, EventArgs e)
        {
         try
         {
             cumle.Select_musterihzmt("Select * from Firma_Musteri", "firmabul");
             Firmabulgrid.DataSource = cumle.ds.Tables["firmabul"];
             sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["Firma_kodu"].ToString());
             sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["Firma_adi"].ToString());
             sutunsecara.Items.Add(cumle.ds.Tables["firmabul"].Columns["M_kodu"].ToString());
             sutunsecara.SelectedIndex = 0;

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
                cumle.ds.Tables["firmabul"].Clear();
                try
                {
                    cumle.ds.Tables["firmakayitbul"].Clear();
                }
                catch (Exception )
                {
                   
                }

                cumle.Select_musterihzmt("Select * from Firma_Musteri", "firmabul");
                Firmabulgrid.DataSource = cumle.ds.Tables["firmabul"];
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
                if (sutunsecara.SelectedItem.ToString() == "Firma_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["firmakayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Firma_Musteri WHERE Firma_kodu='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


                }
                else if (sutunsecara.SelectedItem.ToString() == "Firma_adi")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["firmakayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Firma_Musteri WHERE Firma_adi='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


                }
                else if (sutunsecara.SelectedItem.ToString() == "M_kodu")
                {
                    if (bul == 0)
                    { }
                    else if (bul > 0)
                    {
                        cumle.ds.Tables["firmakayitbul"].Clear();


                    }
                    bul++;
                    cumle.Select_musterihzmt("SELECT * FROM Firma_Musteri WHERE M_kodu='" + Aranacakdeger.Text.ToString() + "'", "firmakayitbul");
                    Firmabulgrid.DataSource = cumle.ds.Tables["firmakayitbul"];


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
           
            
        }
    }
}
