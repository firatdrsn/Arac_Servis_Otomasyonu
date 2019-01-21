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
    public partial class Musteriislem_kayitekle_guncelle : Form
    {
        SQL cumle = new SQL();
        public string tcno;
        private int i = 0;

        public Musteriislem_kayitekle_guncelle()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
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

        private void geridon_Click_1(object sender, EventArgs e)
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

        private void Musteriislem_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select_musterihzmt("Select * from Musteri", "Musteri");
                mkodu.Text = cumle.ds.Tables["Musteri"].Columns["M_kodu"].ToString();
                mtcno.Text = cumle.ds.Tables["Musteri"].Columns["M_TCno"].ToString();
                madi.Text = cumle.ds.Tables["Musteri"].Columns["M_adi"].ToString();
                msoyadi.Text = cumle.ds.Tables["Musteri"].Columns["M_soyadi"].ToString();
                mtel.Text = cumle.ds.Tables["Musteri"].Columns["M_tel"].ToString();
                memail.Text = cumle.ds.Tables["Musteri"].Columns["M_email"].ToString();
                ilkodu.Text = cumle.ds.Tables["Musteri"].Columns["Il_kodu"].ToString();
                ilcekodu.Text = cumle.ds.Tables["Musteri"].Columns["Ilce_kodu"].ToString();
                adres.Text = cumle.ds.Tables["Musteri"].Columns["Adres"].ToString();
                mturukodu.Text = cumle.ds.Tables["Musteri"].Columns["Musteri_turu_kodu"].ToString();
                Musterigrid.DataSource = cumle.ds.Tables["Musteri"];

                mid.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_id"].ToString();

                M_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_kodu"].ToString();
                M_tcno.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_TCno"].ToString();
                M_adi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_adi"].ToString();
                M_soyadi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_soyadi"].ToString();
                M_tel.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_tel"].ToString();

                M_email.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_email"].ToString();
                Il_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Il_kodu"].ToString();
                Ilce_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Ilce_kodu"].ToString();
                Adress.Text = cumle.ds.Tables["Musteri"].Rows[i]["Adres"].ToString();
                M_turu_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Musteri_turu_kodu"].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            


        }

        private void yenikayit_Click(object sender, EventArgs e)
        {
            try
            {
                mid.Text = "";
                M_kodu.Clear();
                M_tcno.Clear();
                M_adi.Clear();
                M_soyadi.Clear();
                M_tel.Clear();

                M_email.Clear();
                Il_kodu.Clear();
                Ilce_kodu.Clear();
                Adress.Clear();
                M_turu_kodu.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void ılkkayit_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                mid.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_id"].ToString();

                M_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_kodu"].ToString();
                M_tcno.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_TCno"].ToString();
                M_adi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_adi"].ToString();
                M_soyadi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_soyadi"].ToString();
                M_tel.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_tel"].ToString();

                M_email.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_email"].ToString();
                Il_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Il_kodu"].ToString();
                Ilce_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Ilce_kodu"].ToString();
                Adress.Text = cumle.ds.Tables["Musteri"].Rows[i]["Adres"].ToString();
                M_turu_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Musteri_turu_kodu"].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
           
        }

        private void sonkayit_Click(object sender, EventArgs e)
        {
            try
            {
                i = cumle.ds.Tables["Musteri"].Rows.Count - 1;
                mid.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_id"].ToString();

                M_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_kodu"].ToString();
                M_tcno.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_TCno"].ToString();
                M_adi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_adi"].ToString();
                M_soyadi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_soyadi"].ToString();
                M_tel.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_tel"].ToString();

                M_email.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_email"].ToString();
                Il_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Il_kodu"].ToString();
                Ilce_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Ilce_kodu"].ToString();
                Adress.Text = cumle.ds.Tables["Musteri"].Rows[i]["Adres"].ToString();
                M_turu_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Musteri_turu_kodu"].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void sonrakikayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < cumle.ds.Tables["Musteri"].Rows.Count - 1)
                {
                    i++;
                    mid.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_id"].ToString();

                    M_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_kodu"].ToString();
                    M_tcno.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_TCno"].ToString();
                    M_adi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_adi"].ToString();
                    M_soyadi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_soyadi"].ToString();
                    M_tel.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_tel"].ToString();

                    M_email.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_email"].ToString();
                    Il_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Il_kodu"].ToString();
                    Ilce_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Ilce_kodu"].ToString();
                    Adress.Text = cumle.ds.Tables["Musteri"].Rows[i]["Adres"].ToString();
                    M_turu_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Musteri_turu_kodu"].ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void oncekikayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == cumle.ds.Tables["Musteri"].Rows.Count - 1 || i != 0)
                {
                    i--;
                    mid.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_id"].ToString();

                    M_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_kodu"].ToString();
                    M_tcno.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_TCno"].ToString();
                    M_adi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_adi"].ToString();
                    M_soyadi.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_soyadi"].ToString();
                    M_tel.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_tel"].ToString();

                    M_email.Text = cumle.ds.Tables["Musteri"].Rows[i]["M_email"].ToString();
                    Il_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Il_kodu"].ToString();
                    Ilce_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Ilce_kodu"].ToString();
                    Adress.Text = cumle.ds.Tables["Musteri"].Rows[i]["Adres"].ToString();
                    M_turu_kodu.Text = cumle.ds.Tables["Musteri"].Rows[i]["Musteri_turu_kodu"].ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void kayitekle_Click(object sender, EventArgs e)
        {
            try
            {
                cumle.IDU_musterihzmt("EXECUTE Musteri_kayitekle '" + M_kodu.Text.ToString() + "', '" + Convert.ToString(M_tcno.Text) + "', '" + M_adi.Text.ToString() + "', '" + M_soyadi.Text.ToString() + "', '" + M_tel.Text.ToString() + "', '" + M_email.Text.ToString() + "', '" + Convert.ToInt16(Il_kodu.Text) + "', '" + Ilce_kodu.Text.ToString() + "', '" + Adress.Text.ToString() + "', '" + M_turu_kodu.Text.ToString() + "'");
                // cumle.IDU("INSERT INTO Musteri VALUES('" + M_kodu.Text.ToString() + "' '" + Convert.ToString(M_tcno.Text) + "' '" + M_adi.Text.ToString() + "' '" + M_soyadi.Text.ToString() + "' '" + M_tel.Text.ToString() + "' '" + M_email.Text.ToString() + "' '" + Convert.ToInt16(Il_kodu.Text) + "' '" + Ilce_kodu.Text.ToString() + "' '" + Adress.Text.ToString() + "' '" + M_turu_kodu.Text.ToString() + "')");
                cumle.ds.Tables["Musteri"].Clear();
                cumle.Select_musterihzmt("Select * From Musteri", "Musteri");
                Musterigrid.DataSource = cumle.ds.Tables["Musteri"];
                int deger = cumle.ds.Tables["Musteri"].Rows.Count-1;
                mid.Text = deger.ToString();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
          


        }

        private void kayitguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cumle.IDU_musterihzmt("UPDATE Musteri SET M_kodu='" + M_kodu.Text.ToString() + "', M_TCno='" + Convert.ToString(M_tcno.Text) + "', M_adi='" + M_adi.Text.ToString() + "', M_soyadi='" + M_soyadi.Text.ToString() + "', M_tel='" + M_tel.Text.ToString() + "', M_email='" + M_email.Text.ToString() + "', Il_kodu='" + Convert.ToInt16(Il_kodu.Text) + "', Ilce_kodu='" + Ilce_kodu.Text.ToString() + "', Adres='" + Adress.Text.ToString() + "', Musteri_turu_kodu='" + M_turu_kodu.Text.ToString() + "' WHERE M_id='" + mid.Text.ToString() + "'");
                cumle.ds.Tables["Musteri"].Clear();
                cumle.Select_musterihzmt("Select * From Musteri", "Musteri");
                Musterigrid.DataSource = cumle.ds.Tables["Musteri"];
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }
    }
}
