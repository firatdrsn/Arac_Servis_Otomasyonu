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
    public partial class Firmaislem_kayitekle_guncelle : Form
    {
        SQL cumle = new SQL();
        private int i = 0;
        public string tcno;



        public Firmaislem_kayitekle_guncelle()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
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

        private void Firmaislem_kayitekle_guncelle_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select_musterihzmt("SELECT*FROM Firma_Musteri", "firma");
                Firmagrid.DataSource = cumle.ds.Tables["firma"];

                fkodu.Text = cumle.ds.Tables["firma"].Columns["Firma_kodu"].ToString();
                fadi.Text = cumle.ds.Tables["firma"].Columns["Firma_adi"].ToString();
                ilkodu.Text = cumle.ds.Tables["firma"].Columns["Il_kodu"].ToString();
                ilcekodu.Text = cumle.ds.Tables["firma"].Columns["Ilce_kodu"].ToString();
                fadres.Text = cumle.ds.Tables["firma"].Columns["Firma_adres"].ToString();
                mkodu.Text = cumle.ds.Tables["firma"].Columns["M_kodu"].ToString();



                fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();


                Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();

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

                Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
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
                i = cumle.ds.Tables["firma"].Rows.Count - 1;

                Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
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
                if (i < cumle.ds.Tables["firma"].Rows.Count - 1)
                {
                    i++;
                    Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                    Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                    Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                    Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                    Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                    M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                    fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();

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
                if (i == cumle.ds.Tables["firma"].Rows.Count - 1 || i != 0)
                {
                    i--;
                    Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                    Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                    Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                    Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                    Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                    M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                    fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
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
                cumle.IDU_musterihzmt("INSERT INTO Firma_Musteri VALUES('" + Firma_kodu.Text.ToString() + "', '" + Convert.ToString(Firma_adi.Text) + "', '" + Il_koduu.Text.ToString() + "', '" + Ilce_koduu.Text.ToString() + "', '" + Firma_adres.Text.ToString() + "', '" + M_kodu.Text.ToString() + "')");
                // cumle.IDU("INSERT INTO Musteri VALUES('" + M_kodu.Text.ToString() + "' '" + Convert.ToString(M_tcno.Text) + "' '" + M_adi.Text.ToString() + "' '" + M_soyadi.Text.ToString() + "' '" + M_tel.Text.ToString() + "' '" + M_email.Text.ToString() + "' '" + Convert.ToInt16(Il_kodu.Text) + "' '" + Ilce_kodu.Text.ToString() + "' '" + Adress.Text.ToString() + "' '" + M_turu_kodu.Text.ToString() + "')");
                cumle.ds.Tables["firma"].Clear();
                cumle.Select_musterihzmt("Select * From Firma_Musteri", "firma");
                Firmagrid.DataSource = cumle.ds.Tables["firma"];
                int deger = cumle.ds.Tables["firma"].Rows.Count - 1;
                fid.Text = deger.ToString();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Firma_kodu.Clear();
                Firma_adi.Clear();
                Il_koduu.Clear();
                Ilce_koduu.Clear();
                Firma_adres.Clear();
                M_kodu.Clear();

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
                cumle.IDU_musterihzmt("UPDATE Firma_Musteri SET Firma_kodu='" + Firma_kodu.Text.ToString() + "', Firma_adi='" + Convert.ToString(Firma_adi.Text) + "', Il_kodu='" + Il_koduu.Text.ToString() + "', Ilce_kodu='" + Ilce_koduu.Text.ToString() + "', Firma_adres='" + Firma_adres.Text.ToString() + "', M_kodu='" + M_kodu.Text.ToString() + "' WHERE Firma_id='" + fid.Text.ToString() + "'");
                cumle.ds.Tables["firma"].Clear();
                cumle.Select_musterihzmt("Select * From Firma_Musteri", "firma");
                Firmagrid.DataSource = cumle.ds.Tables["firma"];
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }
    }
}
