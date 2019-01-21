using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMW
{
    public partial class Arac_Model : Form
    {
        
        SQL cumle = new SQL();
        string seri_kod, dp_kod, sanziman_kod, motor_kod, ekle_tarih;
        int satir_sayisi = 0;
        double dp_fiyati;
        string model_kod;
        SqlDataReader oku;
        SqlCommand komut;

        public Arac_Model()
        {
            InitializeComponent();
        }
        public void Seri_Getir()
        {
            cmb_Seri.Items.Clear();
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            cumle.Select_yonetici("Select Seri_adi from Arac_Serisi", "Arac_Serisi");
            satir_sayisi = cumle.ds.Tables["Arac_Serisi"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Seri.Items.Add(cumle.ds.Tables["Arac_Serisi"].Rows[satir_sayisi]["Seri_adi"]);
            }
        }
        public void DP_Getir()
        {
            cmb_DP.Items.Clear();
            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            cumle.Select_yonetici("Select DP_adi from Donanim_Paket", "Donanim_Paket");
            satir_sayisi = cumle.ds.Tables["Donanim_Paket"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_DP.Items.Add(cumle.ds.Tables["Donanim_Paket"].Rows[satir_sayisi]["DP_adi"]);
            }
        }
        public void Motor_Getir()
        {
            cmb_Motor.Items.Clear();
            if (cumle.ds.Tables["Arac_Motor"] != null)
            {
                cumle.ds.Tables["Arac_Motor"].Clear();
            }
            cumle.Select_yonetici("Select AracM_kodu from Arac_Motor", "Arac_Motor");
            satir_sayisi = cumle.ds.Tables["Arac_Motor"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Motor.Items.Add(cumle.ds.Tables["Arac_Motor"].Rows[satir_sayisi]["AracM_kodu"]);
            }
        }
        public void Sanziman_Getir()
        {
            cmb_Sanziman.Items.Clear();
            if (cumle.ds.Tables["Arac_Sanziman"] != null)
            {
                cumle.ds.Tables["Arac_Sanziman"].Clear();
            }
            cumle.Select_yonetici("Select Sanziman_adi from Arac_Sanziman", "Arac_Sanziman");
            satir_sayisi = cumle.ds.Tables["Arac_Sanziman"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Sanziman.Items.Add(cumle.ds.Tables["Arac_Sanziman"].Rows[satir_sayisi]["Sanziman_adi"]);
            }
        }
        private void Arac_Model_Load(object sender, EventArgs e)
        {
            grp_Ekle.Enabled = false;
            grp_Guncelle.Enabled = false;
            lbl_ModelFiyatGosterim.Visible = false;
            lbl_ModelFiyati.Visible = false;
            Seri_Getir();
            DP_Getir();
            Motor_Getir();
            Sanziman_Getir();
        }


        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }

        private void cmb_Seri_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            if (cmb_Seri.SelectedIndex != -1)
            {
                cumle.Select_yonetici("Select*from Arac_Serisi where Seri_adi='" + cmb_Seri.Text.ToString() + "'", "Arac_Serisi");
                seri_kod = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_kodu"].ToString();

            }
        }

        private void cmb_Motor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            motor_kod = cmb_Motor.Text.ToString();
        }

        private void btn_Bilgi2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi: [STCGRHB][EOARPM][0-9][0-9]");
        }

        private void dtp_ModelTarih_ValueChanged_1(object sender, EventArgs e)
        {
            ekle_tarih = dtp_ModelTarih.Value.Date.Year + "-" + dtp_ModelTarih.Value.Date.Month + "-" + dtp_ModelTarih.Value.Date.Day;
        }

        private void cmb_DP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            //----
            if (cmb_DP.SelectedIndex != -1)
            {
                lbl_DP_adi.Text = cmb_DP.Text.ToString();
                cumle.Select_yonetici("Select*from Donanim_Paket where Dp_adi='" + lbl_DP_adi.Text + "'", "Donanim_Paket");
                dp_fiyati = Convert.ToDouble(cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_fiyat"]);
                dp_kod = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_kodu"].ToString();
                if (txt_PaketsizFiyat.Text != "")
                {
                    lbl_ModelFiyati.Text = Convert.ToDouble(Convert.ToDouble(txt_PaketsizFiyat.Text) + dp_fiyati).ToString();
                }
            }
            else { lbl_DP_adi.Text = "Paket Adı"; }
        }

        private void cmb_Sanziman_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Sanziman"] != null)
            {
                cumle.ds.Tables["Arac_Sanziman"].Clear();
            }
            if (cmb_Sanziman.SelectedIndex != -1)
            {
                cumle.Select_yonetici("Select*from Arac_Sanziman where Sanziman_adi='" + cmb_Sanziman.Text.ToString() + "'", "Arac_Sanziman");
                sanziman_kod = cumle.ds.Tables["Arac_Sanziman"].Rows[0]["Sanziman_kodu"].ToString();
            }
        }

        private void btn_Bilgi_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi: Model adı-Donanım Paketi");
        }

        private void txt_PaketsizFiyat_TextChanged_1(object sender, EventArgs e)
        {
            if (cmb_DP.SelectedIndex != -1 && txt_PaketsizFiyat.Text != "")
            {
                lbl_ModelFiyati.Visible = true;
                lbl_ModelFiyatGosterim.Visible = true;
                lbl_ModelFiyati.Text = Convert.ToDouble(Convert.ToDouble(txt_PaketsizFiyat.Text) + dp_fiyati).ToString();
            }
            else
            {
                lbl_ModelFiyatGosterim.Visible = false;
                lbl_ModelFiyati.Visible = false;

            }
        }

        private void txt_PaketsizFiyat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            if (cmb_Seri.SelectedIndex != -1 && cmb_Sanziman.SelectedIndex != -1 && cmb_Motor.SelectedIndex != -1 && cmb_DP.SelectedIndex != -1 && txt_ModelAdi.Text != "" && txt_ModelKodu.Text != "" && txt_PaketsizFiyat.Text != "")
            {
                if (rd_Ekle.Checked == true)
                {
                    cumle.Select_yonetici("Select *from Arac_Model where Model_kodu='"+txt_ModelKodu.Text.ToString()+"'","Model_Karsilastir");
                    if (cumle.ds.Tables["Model_Karsilastir"].Rows.Count>0)
                    {
                        MessageBox.Show("Girmiş olduğunuz model kodu kullanılmış başka bir model kodu giriniz.");
                    }
                    else
                    {
                        cumle.IDU_yonetici("Insert into Arac_Model values('" + txt_ModelKodu.Text + "','" + txt_ModelAdi.Text.ToString() + "-" + lbl_DP_adi.Text.ToString() + "','" + seri_kod + "','" + motor_kod + "','" + dp_kod + "','" + sanziman_kod + "','" + ekle_tarih + "'," + Convert.ToDouble(lbl_ModelFiyati.Text) + ")");
                        MessageBox.Show("İşlem Başarılı");
                        cmb_DP.SelectedIndex = -1;
                        cmb_Motor.SelectedIndex = -1;
                        cmb_Sanziman.SelectedIndex = -1;
                        cmb_Seri.SelectedIndex = -1;
                        txt_ModelAdi.Text = "";
                        txt_ModelKodu.Text = "";
                        txt_PaketsizFiyat.Text = "";
                    }
                }
                else if (rd_Guncelle.Checked == true)
                {
                    cumle.IDU_yonetici("Update Arac_Model set Model_kodu='" + model_kod + "',Model_adi='" + txt_ModelAdi.Text.ToString() + "-" + lbl_DP_adi.Text.ToString() + "',Seri_kodu='" + seri_kod + "',AracM_kodu='" + motor_kod + "',Dp_kodu='" + dp_kod + "',Sanziman_kodu='" + sanziman_kod + "',Model_yili='" + ekle_tarih + "',Fiyat=" + Convert.ToDouble(lbl_ModelFiyati.Text) + " where Model_kodu='" + model_kod + "'");
                    MessageBox.Show("İşlem Başarılı");
                    cmb_DP.SelectedIndex = -1;
                    cmb_Motor.SelectedIndex = -1;
                    cmb_Sanziman.SelectedIndex = -1;
                    cmb_Seri.SelectedIndex = -1;
                    txt_ModelAdi.Text = "";
                    txt_ModelKodu.Text = "";
                    txt_PaketsizFiyat.Text = "";
                    cmb_AracModel.SelectedIndex = -1;
                    cmb_AracSeri.SelectedIndex = -1;
                    grp_Ekle.Enabled = false;
                }


            }
            else { MessageBox.Show("Lütfen tüm alanları doldurun."); }
        }

        private void cmb_AracSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            if (cmb_AracSeri.SelectedIndex != -1)
            {
                int satirsayisi = 0;
                cmb_AracModel.Items.Clear();
                if (cumle.ds.Tables["Arac_Model"] != null)
                {
                    cumle.ds.Tables["Arac_Model"].Clear();
                }
                cumle.Select_yonetici("Select*from Arac_Serisi where Seri_adi='" + cmb_AracSeri.Text.ToString() + "'", "Arac_Serisi");
                seri_kod = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_kodu"].ToString();
                cumle.Select_yonetici("Select Model_adi,Seri_kodu from Arac_Model where Seri_kodu='" + seri_kod + "'", "Arac_Model");
                satirsayisi = cumle.ds.Tables["Arac_Model"].Rows.Count;
                while (satirsayisi > 0)
                {
                    satirsayisi--;
                    cmb_AracModel.Items.Add(cumle.ds.Tables["Arac_Model"].Rows[satirsayisi]["Model_adi"].ToString());
                }
            }
        }

        private void cmb_AracModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cumle.ds.Tables["Arac_Model"] != null)
            {
                cumle.ds.Tables["Arac_Model"].Clear();
            }
            if (cmb_AracModel.SelectedIndex != -1)
            {
                string seri_kod = "", dp_kod = "", sanziman_kod = "";
                double dp_fiyat;
                grp_Ekle.Enabled = true;
                cumle.Select_yonetici("Select * from Arac_Model where Model_adi='" + cmb_AracModel.Text.ToString() + "'", "Arac_Model");
                //model kodunu yazdırdım
                txt_ModelKodu.Text = cumle.ds.Tables["Arac_Model"].Rows[0]["Model_kodu"].ToString();
                //Model kodunu model adı için en altta kullandım.
                model_kod = txt_ModelKodu.Text.ToString();

                //Seçilen modelin bağlı olduğu araç serisini yazdırmak için seri kodunu aldım.
                seri_kod = cumle.ds.Tables["Arac_Model"].Rows[0]["Seri_kodu"].ToString();
                //Araç serisini yazdırdım.
                if (cumle.ds.Tables["Arac_Serisi"] != null)
                {
                    cumle.ds.Tables["Arac_Serisi"].Clear();
                }
                cumle.Select_yonetici("Select Seri_adi from Arac_Serisi where Seri_kodu='" + seri_kod + "'", "Arac_Serisi");
                cmb_Seri.Text = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_adi"].ToString();

                //Seçilen modelin motor kodunu yazdırdım.
                cmb_Motor.Text = cumle.ds.Tables["Arac_Model"].Rows[0]["AracM_kodu"].ToString();

                //Seçilen modelin donanım paketi için DP_kodunu Arac_Model tablosundan aldım.
                dp_kod = cumle.ds.Tables["Arac_Model"].Rows[0]["Dp_kodu"].ToString();
                //Donanım paketini yazdırdım
                if (cumle.ds.Tables["Donanim_Paket"] != null)
                {
                    cumle.ds.Tables["Donanim_Paket"].Clear();
                }
                cumle.Select_yonetici("Select Dp_adi,Dp_fiyat from Donanim_Paket where Dp_kodu='" + dp_kod + "'", "Donanim_Paket");
                cmb_DP.Text = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_adi"].ToString();

                //Paketsiz fiyatı hesaplamak için donanım paketi fiyatını aldım.
                dp_fiyat = Convert.ToDouble(cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_fiyat"]);
                //Paketsiz Fiyatın hesaplanması
                txt_PaketsizFiyat.Text = (Convert.ToDouble(cumle.ds.Tables["Arac_Model"].Rows[0]["Fiyat"]) - dp_fiyat).ToString();

                //Seçilen modelin şanzımanı için Sanziman_kodu bilgisini Arac_Model tablosundan aldım.
                sanziman_kod = cumle.ds.Tables["Arac_Model"].Rows[0]["Sanziman_kodu"].ToString();
                //Şanzımanı yazdırdım
                if (cumle.ds.Tables["Arac_Sanziman"] != null)
                {
                    cumle.ds.Tables["Arac_Sanziman"].Clear();
                }
                cumle.Select_yonetici("Select Sanziman_adi from Arac_Sanziman where Sanziman_kodu='" + sanziman_kod + "'", "Arac_Sanziman");
                cmb_Sanziman.Text = cumle.ds.Tables["Arac_Sanziman"].Rows[0]["Sanziman_adi"].ToString();


                if (cumle.ds.Tables["Arac_Model"] != null)
                {
                    cumle.ds.Tables["Arac_Model"].Clear();
                }
                //Model adını yazdırdım. Not:Model adi donanım paketi ile birleştirildiği için ayırmak için substring kullanıldı
                cumle.Select_yonetici("SELECT SUBSTRING(Model_adi,1, CHARINDEX('-', Model_adi)-1) as Model_adi FROM Arac_Model where Model_kodu='" + model_kod + "'", "Arac_Model");
                txt_ModelAdi.Text = cumle.ds.Tables["Arac_Model"].Rows[0]["Model_adi"].ToString();



            }
        }

        private void rd_Ekle_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Ekle.Checked == true)
            {
                grp_Ekle.Enabled = true;
                grp_Guncelle.Enabled = false;
                cmb_AracSeri.SelectedIndex = -1;
                cmb_AracModel.SelectedIndex = -1;
                cmb_Seri.SelectedIndex = -1;
                cmb_Motor.SelectedIndex = -1;
                cmb_Sanziman.SelectedIndex = -1;
                cmb_DP.SelectedIndex = -1;
                txt_ModelAdi.Text = "";
                txt_ModelKodu.Text = "";
                lbl_DP_adi.Text = "Paket adı";
                txt_PaketsizFiyat.Text = "";
                btn_Kaydet.Text = "KAYDET";
            }
        }

        private void rd_Guncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Guncelle.Checked == true)
            {
                grp_Ekle.Text = "Model Güncelle";
                btn_Kaydet.Text = "GÜNCELLE";
                grp_Ekle.Enabled = false;
                grp_Guncelle.Enabled = true;
                cmb_Seri.SelectedIndex = -1;
                cmb_DP.SelectedIndex = -1;
                cmb_Sanziman.SelectedIndex = -1;
                cmb_Motor.SelectedIndex = -1;
                txt_ModelAdi.Text = "";
                txt_ModelKodu.Text = "";
                txt_PaketsizFiyat.Text = "";
                lbl_ModelFiyatGosterim.Visible = false;
                lbl_ModelFiyati.Visible = false;
                if (cumle.ds.Tables["Arac_Serisi"] != null)
                {
                    cumle.ds.Tables["Arac_Serisi"].Clear();
                }
                //Modeli bulunmayan serileri getirmeyecek.
                cmb_AracSeri.Items.Clear();
                cumle.baglan_yonetici(1);
                komut = new SqlCommand("Select DISTINCT Arac_Serisi.Seri_adi From Arac_Serisi INNER JOIN Arac_Model ON Arac_Serisi.Seri_kodu=Arac_Model.Seri_kodu", cumle.bag_cumle_yonetici);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmb_AracSeri.Items.Add(oku[0]);
                }
                cumle.baglan_yonetici(0);
            }
        }

    }
}
