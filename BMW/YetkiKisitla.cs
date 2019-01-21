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
    public partial class YetkiKisitla : Form
    {
        SQL cumle = new SQL();
        public YetkiKisitla()
        {
            InitializeComponent();
        }

            string verilen_yetkiler,kisitlanan_yetkiler;

        private void YetkiKisitla_Load(object sender, EventArgs e)
        {
            pnl_kullanicilar.Enabled = false;
            pnl_Yetkiler.Enabled = false;
            cumle.Select("select*from Kullanici_Yetki", "kullaniciyetkiadi");
            int satir1 = cumle.ds.Tables["kullaniciyetkiadi"].Rows.Count;
            while (satir1 > 0)
            {
                satir1--;
                cmb_Kullanici.Items.Add(cumle.ds.Tables["kullaniciyetkiadi"].Rows[satir1]["Yetki_adi"].ToString());
            }
         
            cumle.Select_yonetici("Select * From Tablo_Adlari","Tablo_Adlari");
            int satir = cumle.ds.Tables["Tablo_Adlari"].Rows.Count;
            while (satir > 0)
            {
                satir--;
                cmb_tabloadlari.Items.Add(cumle.ds.Tables["Tablo_Adlari"].Rows[satir]["Tablo_adi"].ToString());
            }
        }

  

        private void yetkiver_Click(object sender, EventArgs e)
        {
            try
            {
                if (cumle.ds.Tables["Verilen_Yetkiler"] != null)
                {
                    cumle.ds.Tables["Verilen_Yetkiler"].Clear();
                }
               
                if (rd_YetkileriGoster.Checked == true)
                {
                    if (cmb_Kullanici.SelectedIndex != -1)
                    {
                        cumle.Select("Select * from Verilen_Yetkiler where Kullanici_adi='" + cmb_Kullanici.Text.ToString() + "'", "Verilen_Yetkiler");
                        dtg_Goster.DataSource = cumle.ds.Tables["Verilen_Yetkiler"];
                    }
                    else { MessageBox.Show("Lütfen tanımlı kullanıcıyı seçiniz"); }
                }
                else if (rd_YetkiTanimla.Checked == true)
                {
                    if (cmb_tabloadlari.SelectedIndex != -1 && cmb_Kullanici.SelectedIndex!=-1)
                    {
                        verilen_yetkiler = "";
                        kisitlanan_yetkiler = "";


                        cumle.Select("select * from Kullanici_Yetki  where Yetki_kodu='" + lbl_yetkikodu.Text.ToString() + "'", "yetkiadi");
                        //  MessageBox.Show(cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                        if (chk_select.Checked)
                        {
                            cumle.IDU("REVOKE select FROM " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            cumle.IDU("GRANT select ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            verilen_yetkiler = verilen_yetkiler + " SELECT ";

                        }
                        else
                        {
                            cumle.IDU("DENY select ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            kisitlanan_yetkiler = kisitlanan_yetkiler + " SELECT ";

                        }

                        if (chk_insert.Checked)
                        {
                            cumle.IDU("REVOKE insert FROM " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            cumle.IDU("GRANT insert ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            verilen_yetkiler = verilen_yetkiler + " INSERT ";

                        }
                        else
                        {
                            cumle.IDU("DENY insert ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            kisitlanan_yetkiler = kisitlanan_yetkiler + " INSERT ";

                        }

                        if (chk_update.Checked)
                        {
                            cumle.IDU("REVOKE update FROM " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            cumle.IDU("GRANT update ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            verilen_yetkiler = verilen_yetkiler + " UPDATE ";

                        }
                        else
                        {
                            cumle.IDU("DENY update ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            kisitlanan_yetkiler = kisitlanan_yetkiler + " UPDATE ";

                        }
                        if (chk_delete.Checked)
                        {
                            cumle.IDU("REVOKE delete FROM " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            cumle.IDU("GRANT delete ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            verilen_yetkiler = verilen_yetkiler + " DELETE ";
                        }
                        else
                        {
                            cumle.IDU("DENY delete ON " + cmb_tabloadlari.Text + " TO " + cumle.ds.Tables["yetkiadi"].Rows[0]["Yetki_adi"].ToString());
                            kisitlanan_yetkiler = kisitlanan_yetkiler + " DELETE ";
                        }
                        cumle.Select("Select*from Verilen_Yetkiler where Kullanici_adi='" + cmb_Kullanici.Text.ToString() + "' AND Tablo_adi='" + cmb_tabloadlari.Text.ToString() + "'", "Kontrol");

                        if (cumle.ds.Tables["Kontrol"].Rows.Count > 0)
                        {
                            //güncelleme
                            cumle.IDU("UPDATE Verilen_Yetkiler SET Verilen_yetki='" + verilen_yetkiler + "',Kisitlanan_yetki='" + kisitlanan_yetkiler + "' where Kullanici_adi='" + cmb_Kullanici.Text.ToString() + "' AND Tablo_adi='" + cmb_tabloadlari.Text.ToString() + "'");
                        }
                        else
                        {
                            cumle.IDU("INSERT INTO Verilen_Yetkiler VALUES('" + verilen_yetkiler.ToString() + "','" + kisitlanan_yetkiler.ToString() + "','" + cmb_Kullanici.Text.ToString() + "','" + cmb_tabloadlari.Text.ToString() + "')");
                        }

                    }
                    else
                    { MessageBox.Show("Lütfen tablo adını ve tanımlı kullanıcıyı seçiniz"); }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata meydana geldi "+hata,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if (cumle.ds.Tables["yetkikodu"] != null)
                {
                    cumle.ds.Tables["yetkikodu"].Clear();
                }
    
            cumle.Select("select * from Kullanici_yetki where Yetki_adi='"+cmb_Kullanici.Text+"'","yetkikodu");
            lbl_yetkikodu.Text = cumle.ds.Tables["yetkikodu"].Rows[0]["Yetki_kodu"].ToString();
        }

        private void rd_YetkiTanimla_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YetkiTanimla.Checked == true)
            {
                btn_yetkiver.Text = "Yetki Tanımla";
                pnl_Yetkiler.Enabled = true;
                pnl_kullanicilar.Enabled = true;
            }
        }

        private void rd_YetkileriGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YetkileriGoster.Checked == true)
            {
                btn_yetkiver.Text = "Yetkileri Göster";
                pnl_Yetkiler.Enabled = false;
                pnl_kullanicilar.Enabled = true;
            }
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

    }
}
