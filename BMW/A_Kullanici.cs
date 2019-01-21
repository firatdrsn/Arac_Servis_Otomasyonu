using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BMW
{
    public partial class A_Kullanici : Form
    {
        
        string yetki_kodu;
        SQL K_sorgu = new SQL();
        SqlCommand komut;
        SqlDataReader oku;
        public A_Kullanici()
        {
            InitializeComponent();
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {

            AdminPanel A_P = new AdminPanel();
            A_P.Show();
            this.Hide();

        }

        private void A_Kullanici_Load(object sender, EventArgs e)
        {
            cmb_Yetki.Enabled = false;
            txt_Sifre.Enabled = false;
            rd_Kayitli.Checked = true;
            K_sorgu.baglan_yonetici(1);
            komut = new SqlCommand("Select*from Kullanici_Yetki", K_sorgu.bag_cumle_yonetici);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmb_Yetki.Items.Add(oku["Yetki_adi"]);
            }
            oku.Close();
            K_sorgu.baglan_yonetici(0);
        }

        
        private void rd_Kayitli_CheckedChanged_1(object sender, EventArgs e)
        {
            cmb_Yetki.Enabled = false;
            txt_Sifre.Enabled = false;
            grp_Kullanici.Text = "Kullanıcı Düzenleme";
            btn_YeniKaydet.Text = "Güncelle";
            //Her radiobuton değişiminde tablonun temizlenmesi gerekiyor
            //Eğer tablolar oluşturulmuş ise yeni güncelleme silme veya kayıt işleminde temizlenmeli
            if (K_sorgu.ds.Tables["Kullanici"] != null)
            {
                K_sorgu.ds.Tables["Kullanici"].Clear();

            }
            if (K_sorgu.ds.Tables["Personel"] != null)
            {
                K_sorgu.ds.Tables["Personel"].Clear();
            }
        }

        private void rd_Yeni_CheckedChanged_1(object sender, EventArgs e)
        {
            cmb_Yetki.Enabled = false;
            txt_Sifre.Enabled = false;
            grp_Kullanici.Text = "Kullanıcı Tanımlama";
            btn_YeniKaydet.Text = "Kaydet";
            //Eğer tablolar oluşturulmuş ise yeni güncelleme silme veya kayıt işleminde temizlenmeli
            if (K_sorgu.ds.Tables["Kullanici"] != null)
            {
                K_sorgu.ds.Tables["Kullanici"].Clear();

            }
            if (K_sorgu.ds.Tables["Personel"] != null)
            {
                K_sorgu.ds.Tables["Personel"].Clear();
            }
        }

        private void rd_KulSil_CheckedChanged_1(object sender, EventArgs e)
        {
            cmb_Yetki.Enabled = false;
            txt_Sifre.Enabled = false;
            grp_Kullanici.Text = "Kullanıcı Silme";
            btn_YeniKaydet.Text = "Sil";
            //Her radiobuton değişiminde tablonun temizlenmesi gerekiyor
            //Eğer tablolar oluşturulmuş ise yeni güncelleme silme veya kayıt işleminde temizlenmeli
            if (K_sorgu.ds.Tables["Kullanici"] != null)
            {
                K_sorgu.ds.Tables["Kullanici"].Clear();

            }
            if (K_sorgu.ds.Tables["Personel"] != null)
            {
                K_sorgu.ds.Tables["Personel"].Clear();
            }
        }

        private void btn_Ara_Click_1(object sender, EventArgs e)
        {
            //Eğer tablolar oluşturulmuş ise yeni güncelleme silme veya kayıt işleminde temizlenmeli
            if (K_sorgu.ds.Tables["Kullanici"] != null)
            {
                K_sorgu.ds.Tables["Kullanici"].Clear();

            }
            if (K_sorgu.ds.Tables["Personel"] != null)
            {
                K_sorgu.ds.Tables["Personel"].Clear();
            }
            if (txt_TcNO.Text != "")
            {
                if (txt_TcNO.TextLength == 11)
                {

                    if (rd_Kayitli.Checked == true)
                    {
                        
                        K_sorgu.Select_yonetici("Select Yetki_kodu,Kullanici_adi,Kullanici_sifre from Kullanici where Kullanici_adi='" + txt_TcNO.Text.ToString() + "'", "Kullanici");
                        if (K_sorgu.ds.Tables["Kullanici"].Rows.Count == 1)
                        {
                            cmb_Yetki.Enabled = true;
                            txt_Sifre.Enabled = true;
                            dtg_KulGoster.DataSource = K_sorgu.ds.Tables["Kullanici"];
                        }
                        else { MessageBox.Show("Kullanıcı Bulunamadı."); }

                    }
                    else if (rd_Yeni.Checked == true)
                    {
                        //Kullanıcı tanımlaması yapılmış personelin gözükmemesi gerekiyor
                        K_sorgu.baglan(1);
                        K_sorgu.Select_yonetici("Select Kullanici_adi from Kullanici where Kullanici_adi='" + txt_TcNO.Text.ToString() + "'", "Kullanici");
                        if (K_sorgu.ds.Tables["Kullanici"].Rows.Count > 0)
                        {
                            //kayitli radiobutonundan kaynaklanan gridview doldurma işlemi temizlenmeli
                            K_sorgu.ds.Tables["Kullanici"].Clear();
                            MessageBox.Show("Aradığınız personele kullanıcı girişi tanımlanmış.");
                            cmb_Yetki.Enabled = false;
                            txt_Sifre.Enabled = false;
                        }
                        else
                        {
                            K_sorgu.Select_yonetici("Select P_TCno,P_adi,P_soyadi from Personel where P_TCno='" + txt_TcNO.Text.ToString() + "'", "Personel");
                            if (K_sorgu.ds.Tables["Personel"].Rows.Count == 1)
                            {
                                cmb_Yetki.Enabled = true;
                                txt_Sifre.Enabled = true;
                                dtg_KulGoster.DataSource = K_sorgu.ds.Tables["Personel"];
                            }
                            else { MessageBox.Show("Kullanıcı Bulunamadı."); }

                        }
                    }
                    else if (rd_KulSil.Checked == true)
                    {

                        K_sorgu.Select_yonetici("Select Yetki_kodu,Kullanici_adi,Kullanici_sifre from Kullanici where Kullanici_adi='" + txt_TcNO.Text.ToString() + "'", "Kullanici");
                        if (K_sorgu.ds.Tables["Kullanici"].Rows.Count == 1)
                        {
                            dtg_KulGoster.DataSource = K_sorgu.ds.Tables["Kullanici"];
                        }
                        else { MessageBox.Show("Kullanıcı Bulunamadı."); }

                    }
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                }
            }
            else { MessageBox.Show("TC Kimlik Numarasını Giriniz"); }
        }

        private void btn_SifreKural_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Şifreniz en az 6 karakter olmalıdır. Ayrıca büyük harfle başlamalı,küçük harf ve sayı içermelidir.");
        }

        private void btn_YeniKaydet_Click_1(object sender, EventArgs e)
        {
            if (txt_Sifre.Text.Length >= 6 && txt_TcNO.Text != "" && cmb_Yetki.SelectedIndex != -1)
            {

                //Güncelleme İşlemi
                if (rd_Kayitli.Checked == true)
                {
                    K_sorgu.IDU_yonetici("Update Kullanici Set Yetki_kodu='" + yetki_kodu + "',Kullanici_sifre='" + txt_Sifre.Text + "' where Kullanici_adi='"+txt_TcNO.Text.ToString()+"'");
                    txt_TcNO.Text = "";
                    cmb_Yetki.SelectedIndex = -1;
                    txt_Sifre.Text = "";
                    MessageBox.Show("İşlem Başarılı");

                }
                //Kayıt İşlemi
                else if (rd_Yeni.Checked == true)
                {
                    K_sorgu.IDU_yonetici("Insert into Kullanici(Yetki_kodu,Kullanici_adi,Kullanici_sifre) Values('" + yetki_kodu + "','" + txt_TcNO.Text.ToString() + "','" + txt_Sifre.Text.ToString() + "')");
                    txt_TcNO.Text = "";
                    cmb_Yetki.SelectedIndex = -1;
                    txt_Sifre.Text = "";
                    MessageBox.Show("İşlem Başarılı");
                }
            }
            else if (rd_KulSil.Checked != true) { MessageBox.Show("Tüm alanları doldurun."); }
            //Silme İşlemi
            if (rd_KulSil.Checked == true)
            {
                if (txt_TcNO.Text != "")
                {
                    if (txt_TcNO.Text.ToString() == Giris.tc_no)
                    {
                        MessageBox.Show("Kendinizi Silemezsiniz.");
                    }
                    else
                    {
                        K_sorgu.IDU_yonetici("Delete from Kullanici where Kullanici_adi='" + txt_TcNO.Text.ToString() + "'");
                        txt_TcNO.Text = "";
                        MessageBox.Show("İşlem Başarılı");
                    }
                }
                else { MessageBox.Show("Tc Kimlik Numarasını giriniz"); }
            }
            //Eğer tablolar oluşturulmuş ise yeni güncelleme silme veya kayıt işleminde temizlenmeli
            if (K_sorgu.ds.Tables["Kullanici"] != null)
            {
                K_sorgu.ds.Tables["Kullanici"].Clear();

            }
            if (K_sorgu.ds.Tables["Personel"] != null)
            {
                K_sorgu.ds.Tables["Personel"].Clear();
            }
        }

        private void cmb_Yetki_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_Yetki.SelectedIndex != -1)
            {
                
                K_sorgu.Select_yonetici("Select Yetki_kodu,Yetki_adi from Kullanici_Yetki where Yetki_adi='" + cmb_Yetki.SelectedItem.ToString() + "'", "Kullanici_Yetki");
                yetki_kodu = K_sorgu.ds.Tables["Kullanici_Yetki"].Rows[0][0].ToString();
                K_sorgu.ds.Tables["Kullanici_Yetki"].Clear();
               
            }
        }
    }
}
