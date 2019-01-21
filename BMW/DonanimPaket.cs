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
    public partial class DonanimPaket : Form
    {
        SQL cumle = new SQL();
        int satir_sayisi = 0;
        string secilen_paket_kod;
        public DonanimPaket()
        {
            InitializeComponent();
        }

        private void DonanimPaket_Load(object sender, EventArgs e)
        {
            Donanim_Paket_Getir();
            grp_Ekle.Enabled = false;
            grp_Guncelle.Enabled = false;
            cmb_DonanimPaket.Enabled = false;
        }
        public void Donanim_Paket_Getir()
        {
            cmb_DonanimPaket.Items.Clear();
            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            cumle.Select_yonetici("Select Dp_adi from Donanim_Paket", "Donanim_Paket");
            satir_sayisi = cumle.ds.Tables["Donanim_Paket"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_DonanimPaket.Items.Add(cumle.ds.Tables["Donanim_Paket"].Rows[satir_sayisi]["DP_adi"]);
            }
        }

        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            AdminPanel A_P = new AdminPanel();
            A_P.Show();
            this.Hide();
        }

        private void cmb_DonanimPaket_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rd_Guncelle.Checked == true)
            {
                if (cumle.ds.Tables["Donanim_Paket"] != null)
                {
                    cumle.ds.Tables["Donanim_Paket"].Clear();
                }
                if (cmb_DonanimPaket.SelectedIndex != -1)
                {
                    cumle.Select_yonetici("Select*from Donanim_Paket where Dp_adi='" + cmb_DonanimPaket.SelectedItem.ToString() + "'", "Donanim_Paket");
                    txt_PaketKodu.Text = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_kodu"].ToString();
                    txt_PaketAdi.Text = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_adi"].ToString();
                    txt_PaketFiyati.Text = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_fiyat"].ToString();
                    secilen_paket_kod = txt_PaketKodu.Text.ToString();
                }
            }
        }

        private void rd_Guncelle_CheckedChanged_1(object sender, EventArgs e)
        {
            cmb_DonanimPaket.Enabled = true;
            Donanim_Paket_Getir();
            grp_Guncelle.Enabled = true;
            grp_Ekle.Enabled = false;
            txt_PaketAd.Text = "";
            txt_PaketFiyat.Text = "";
            txt_PaketKod.Text = "";
        }

        private void rd_Ekle_CheckedChanged_1(object sender, EventArgs e)
        {
            grp_Ekle.Enabled = true;
            grp_Guncelle.Enabled = false;
            txt_PaketAdi.Text = "";
            txt_PaketFiyati.Text = "";
            txt_PaketKodu.Text = "";
            cmb_DonanimPaket.SelectedIndex = -1;
            cmb_DonanimPaket.Enabled = false;
        }

        private void btn_Bilgi_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("DP[0-9][0-9]");
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (cmb_DonanimPaket.SelectedIndex != -1)
            {
                if (txt_PaketAdi.Text != "" && txt_PaketFiyati.Text != "" && txt_PaketKodu.Text != "")
                {

                    cumle.IDU_yonetici("Update Donanim_Paket set DP_kodu='" + txt_PaketKodu.Text.ToString() + "', DP_adi='" + txt_PaketAdi.Text.ToString() + "', Dp_fiyat='" + Convert.ToDouble(txt_PaketFiyati.Text) + "' where DP_kodu='" + secilen_paket_kod + "'");
                    txt_PaketAdi.Text = "";
                    txt_PaketKodu.Text = "";
                    cmb_DonanimPaket.SelectedIndex = -1;
                    txt_PaketFiyati.Text = "";
                    Donanim_Paket_Getir();
                    MessageBox.Show("İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellenecek Paketi Seçiniz.");
            }
        }

        private void btn_KodBilgi_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi:DP[0-9][0-9]");
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {

            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            if (txt_PaketFiyat.Text != "" && txt_PaketAd.Text != "" && txt_PaketKod.Text != "")
            {
                cumle.Select_yonetici("Select*from Donanim_Paket where Dp_kodu='"+txt_PaketKod+"'","Donanim_Paket");
                if (cumle.ds.Tables["Donanim_Paket"] != null)
                {
                    MessageBox.Show("Girmiş olduğunuz paket kodu tanımlıdır başka bir kod deneyin.");
                }
                else
                {

                    cumle.IDU_yonetici("Insert into Donanim_Paket values('" + txt_PaketKod.Text.ToString() + "','" + txt_PaketAd.Text.ToString() + "'," + Convert.ToDouble(txt_PaketFiyat.Text) + ")");
                    MessageBox.Show("İşlem Başarılı");
                    txt_PaketAd.Text = "";
                    txt_PaketKod.Text = "";
                    txt_PaketFiyat.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun.");
            }
        }


    }
}
