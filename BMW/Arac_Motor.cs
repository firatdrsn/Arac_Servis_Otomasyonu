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
    public partial class Arac_Motor : Form
    {
        
        SQL cumle = new SQL();
        int satir_sayisi = 0;
        string secilen_motorkod, kaydet_tuketim, guncelle_tuketim;
        public Arac_Motor()
        {
            InitializeComponent();
        }

        private void Arac_Motor_Load(object sender, EventArgs e)
        {
            Motor_Getir();
            grp_Ekle.Enabled = false;
            grp_Guncelle.Enabled = false;
            cmb_AracMotor.Enabled = false;
        }
        public void Motor_Getir()
        {
            cmb_AracMotor.Items.Clear();
            if (cumle.ds.Tables["Arac_Motor"] != null)
            {
                cumle.ds.Tables["Arac_Motor"].Clear();
            }
            cumle.Select_yonetici("Select AracM_kodu from Arac_Motor", "Arac_Motor");
            satir_sayisi = cumle.ds.Tables["Arac_Motor"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_AracMotor.Items.Add(cumle.ds.Tables["Arac_Motor"].Rows[satir_sayisi]["AracM_kodu"]);
            }
        }
       

        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }

        private void cmb_AracMotor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rd_Guncelle.Checked == true)
            {
                if (cumle.ds.Tables["Arac_Motor"] != null)
                {
                    cumle.ds.Tables["Arac_Motor"].Clear();
                }
                if (cmb_AracMotor.SelectedIndex != -1)
                {
                    string yakit_tip;
                    cumle.Select_yonetici("Select*from Arac_Motor where AracM_kodu='" + cmb_AracMotor.SelectedItem.ToString() + "'", "Arac_Motor");
                    txt_MotorKod.Text = cumle.ds.Tables["Arac_Motor"].Rows[0]["AracM_kodu"].ToString();
                    yakit_tip = cumle.ds.Tables["Arac_Motor"].Rows[0]["Yakit_tipi"].ToString();
                    if (yakit_tip == "BENZİN")
                    {
                        cmb_YakitTip.SelectedIndex = 0;
                    }
                    else if (yakit_tip == "DİZEL")
                    {
                        cmb_YakitTip.SelectedIndex = 1;
                    }
                    else
                    {
                        cmb_YakitTip.SelectedIndex = 2;
                    }
                    txt_CC.Text = cumle.ds.Tables["Arac_Motor"].Rows[0]["CC"].ToString();
                    txt_BG.Text = cumle.ds.Tables["Arac_Motor"].Rows[0]["BG"].ToString();
                    txt_Tuketim.Text = cumle.ds.Tables["Arac_Motor"].Rows[0]["Yakit_tuketim"].ToString();
                    secilen_motorkod = txt_MotorKod.Text.ToString();

                }
            }
        }

        private void rd_Guncelle_CheckedChanged_1(object sender, EventArgs e)
        {
            grp_Ekle.Enabled = false;
            grp_Guncelle.Enabled = true;
            Motor_Getir();
            cmb_AracMotor.Enabled = true;
            txt_MotorHacmi.Text = "";
            txt_MotorKodu.Text = "";
            cmb_YakitTipi.SelectedIndex = -1;
            txt_BeygirGucu.Text = "";
            txt_Tuketimi.Text = "";

            
           
        }

        private void rd_Ekle_CheckedChanged_1(object sender, EventArgs e)
        {
            grp_Ekle.Enabled = true;
            grp_Guncelle.Enabled = false;
            cmb_AracMotor.SelectedIndex = -1;
            cmb_AracMotor.Enabled = false;
            txt_MotorKod.Text = "";
            cmb_YakitTip.SelectedIndex = -1;
            txt_BG.Text = "";
            txt_CC.Text = "";
            txt_Tuketim.Text = "";
        }

        private void btn_Bilgi_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi:[DBE][1-7][0-9]M[0-9]");
        }

        private void cmb_YakitTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (cmb_AracMotor.SelectedIndex != -1)
            {
                if (txt_BG.Text != "" && txt_CC.Text != "" && txt_MotorKod.Text != "" && txt_Tuketim.Text != "" && cmb_YakitTip.SelectedIndex != -1)
                {
                    string motor_kod, yakit_tip;
                    int cc, bg;
                    motor_kod = txt_MotorKod.Text.ToString();
                    yakit_tip = cmb_YakitTip.Text.ToString();
                    cc = Convert.ToInt32(txt_CC.Text);
                    bg = Convert.ToInt32(txt_BG.Text);
                    if (cmb_YakitTip.SelectedIndex == 0 || cmb_YakitTip.SelectedIndex == 1)
                    {
                        guncelle_tuketim = (txt_Tuketim.Text + " lt").ToString();
                    }
                    else if (cmb_YakitTip.SelectedIndex == 2)
                    {
                        guncelle_tuketim = (txt_Tuketim.Text + " kw").ToString();
                    }
                    cumle.IDU_yonetici("Update Arac_Motor set AracM_kodu='" + motor_kod + "',Yakit_tipi='" + yakit_tip + "',CC=" + cc + ",BG=" + bg + ",Yakit_tuketim='" + guncelle_tuketim + "' where AracM_kodu='" + secilen_motorkod + "'");
                    MessageBox.Show("İşlem Başarılı");
                    txt_BG.Text = "";
                    txt_CC.Text = "";
                    txt_MotorKod.Text = "";
                    txt_Tuketim.Text = "";
                    cmb_YakitTip.SelectedIndex = -1;
                    cmb_AracMotor.SelectedIndex = -1;
                    Motor_Getir();
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek Motor'u Seçiniz");
            }
        }

        private void btn_KodBilgi_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi:[DBE][1-7][0-9]M[0-9]");
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Motor"] != null)
            {
                cumle.ds.Tables["Arac_Motor"].Clear();
            }
            if (txt_MotorKodu.Text != "" && cmb_YakitTipi.SelectedIndex != -1 && txt_Tuketimi.Text != "" && txt_MotorHacmi.Text != "" && txt_Tuketimi.Text != "")
            {
                string motor_kod, yakit_tip;
                int cc, bg;
                motor_kod = txt_MotorKodu.Text.ToString();
                yakit_tip = cmb_YakitTipi.Text.ToString();
                cc = Convert.ToInt32(txt_MotorHacmi.Text);
                bg = Convert.ToInt32(txt_BeygirGucu.Text);
                if (cmb_YakitTipi.SelectedIndex == 0 || cmb_YakitTipi.SelectedIndex == 1)
                {
                    kaydet_tuketim = (txt_Tuketimi.Text + " lt").ToString();
                }
                else if (cmb_YakitTipi.SelectedIndex == 2)
                {
                    kaydet_tuketim = (txt_Tuketimi.Text + " kw").ToString();
                }
                //Eklenecek motor kodunun var olup olmadığını veri tabanınından kontrol etmemiz gerekiyor
                if (cumle.ds.Tables["Arac_Motor"] != null)
                {
                    cumle.ds.Tables["Arac_Motor"].Clear();
                }
                cumle.Select_yonetici("Select*from Arac_Motor where AracM_kodu='"+txt_MotorKodu+"'","Arac_Motor");

                if (cumle.ds.Tables["Arac_Motor"] != null)
                {
                    MessageBox.Show("Girmiş olduğunuz motor kodu veritabanında kayıtlıdır başka bir motor kodu giriniz");
                }
                else
                {
                    cumle.IDU_yonetici("Insert into Arac_Motor values('" + motor_kod + "','" + yakit_tip + "'," + cc + "," + bg + ",'" + kaydet_tuketim + "')");
                    MessageBox.Show("İşlem Başarılı");
                    txt_MotorKodu.Text = "";
                    txt_Tuketimi.Text = "";
                    cmb_YakitTipi.SelectedIndex = -1;
                    txt_MotorHacmi.Text = "";
                    txt_BeygirGucu.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun.");
            }
        }

    }
}
