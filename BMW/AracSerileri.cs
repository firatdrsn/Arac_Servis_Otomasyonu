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
    public partial class AracSerileri : Form
    {
       
        SQL cumle = new SQL();
        int satir_sayisi;
        string secilen_seri_kod;
        string e_tarih, g_tarih;
        public AracSerileri()
        {
            InitializeComponent();
        }

        private void AracSerileri_Load(object sender, EventArgs e)
        {
            SerileriGetir();
            grp_Ekle.Enabled = false;
            grp_Guncelle.Enabled = false;
            cmb_arac_serisi.Enabled = false;
        }
        public void SerileriGetir()
        {
            cmb_arac_serisi.Items.Clear();
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            cumle.Select_yonetici("Select Seri_adi from Arac_Serisi", "Arac_Serisi");
            satir_sayisi = cumle.ds.Tables["Arac_Serisi"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_arac_serisi.Items.Add(cumle.ds.Tables["Arac_Serisi"].Rows[satir_sayisi]["Seri_adi"]);
            }
        }
       

        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            AdminPanel A_P = new AdminPanel();
            A_P.Show();
            this.Hide();
        }

        private void rd_Guncelle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rd_Guncelle.Checked == true)
            {
                grp_Guncelle.Enabled = true;
                grp_Ekle.Enabled = false;
                txt_Ad.Text = "";
                txt_Kod.Text = "";
                cmb_arac_serisi.Enabled = true;
            }
            else if (rd_Ekle.Checked == true)
            {
                grp_Ekle.Enabled = true;
                grp_Guncelle.Enabled = false;
                txt_SeriAd.Text = "";
                txt_SeriKod.Text = "";
                cmb_arac_serisi.Enabled = false;
            }
            cmb_arac_serisi.SelectedIndex = -1;
        }

        private void rd_Ekle_CheckedChanged_1(object sender, EventArgs e)
        {
            grp_Ekle.Enabled = true;
            txt_SeriAd.Text = "";
            txt_SeriKod.Text = "";
            cmb_arac_serisi.SelectedIndex = -1;
        }

        private void cmb_arac_serisi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            if (cmb_arac_serisi.SelectedIndex != -1)
            {
                cumle.Select_yonetici("Select*from Arac_Serisi where Seri_adi='" + cmb_arac_serisi.SelectedItem.ToString() + "'", "Arac_Serisi");
                txt_SeriKod.Text = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_kodu"].ToString();
                txt_SeriAd.Text = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_adi"].ToString();
                dt_g_CikisTarihi.Value = Convert.ToDateTime(cumle.ds.Tables["Arac_Serisi"].Rows[0]["Cikis_yili"]);
                secilen_seri_kod = txt_SeriKod.Text;
            }
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (cmb_arac_serisi.SelectedIndex != -1)
            {
                if (txt_SeriAd.Text != "" && txt_SeriKod.Text != "" && dt_g_CikisTarihi.Text != "")
                {
                    cumle.IDU_yonetici("Update Arac_Serisi set Seri_kodu='" + txt_SeriKod.Text.ToString() + "', Seri_adi='" + txt_SeriAd.Text.ToString() + "', Cikis_yili='" + g_tarih + "' where Seri_kodu='" + secilen_seri_kod + "'");
                    txt_SeriAd.Text = "";
                    txt_SeriKod.Text = "";
                    cmb_arac_serisi.SelectedIndex = -1;
                    SerileriGetir();
                    MessageBox.Show("İşlem Başarılı");
                }
                else
                { MessageBox.Show("Tüm alanları doldurunuz"); }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellenecek Seriyi Seçiniz.");
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            if (txt_Kod.Text != "")
            {

                cumle.Select_yonetici("Select Seri_kodu from Arac_Serisi", "Arac_Serisi");
                satir_sayisi = cumle.ds.Tables["Arac_Serisi"].Rows.Count;
                string kayitli_serikodlari = "";
                while (satir_sayisi > 0)
                {
                    satir_sayisi--;
                    kayitli_serikodlari = kayitli_serikodlari + "'" + cumle.ds.Tables["Arac_Serisi"].Rows[satir_sayisi]["Seri_kodu"] + "',";
                }
                //constraint silme ve yeniden tanımlama işlemleri yapılacak.
                cumle.IDU("Alter Table Arac_Serisi DROP Constraint ck_serikodu");
                cumle.IDU("Alter Table Arac_Serisi ADD Constraint ck_serikodu check(Seri_kodu in(" + kayitli_serikodlari + "'" + txt_Kod.Text.Trim().ToString() + "'))");
                if (chk_Constraint.Checked != true)//Sadece constraint eklenmeyecekse burasıda çalışacak
                {
                    if (txt_Ad.Text != "" && dt_e_CikisTarihi.Value.ToString() != "")
                    {
                        cumle.IDU("Insert into Arac_Serisi(Seri_kodu,Seri_adi,Cikis_yili) values('" + txt_Kod.Text.ToString().Trim() + "','" + txt_Ad.Text.ToString().Trim() + "','" + e_tarih + "')");
                    }
                    else { MessageBox.Show("Tüm Alanları doldurunuz"); }
                }
                MessageBox.Show("İşlem Başarılı");
                txt_Ad.Text = "";
                txt_Kod.Text = "";
                dt_e_CikisTarihi.Refresh();
                SerileriGetir();
            }
            else
            {
                MessageBox.Show("Seri kodunu doldurunuz");
            }
        }

        private void chk_Constraint_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chk_Constraint.Checked == true)
            {
                txt_Ad.Enabled = false;
                dt_e_CikisTarihi.Enabled = false;
            }
            else if (chk_Constraint.Checked == false)
            {
                txt_Ad.Enabled = true;
                dt_e_CikisTarihi.Enabled = true;
            }
        }

        private void dt_e_CikisTarihi_ValueChanged_1(object sender, EventArgs e)
        {
            g_tarih = (dt_g_CikisTarihi.Value.Date.Year.ToString()) + "-" + (dt_g_CikisTarihi.Value.Date.Month.ToString()) + "-" + (dt_g_CikisTarihi.Value.Date.Day.ToString());
      
        }

    }
}
