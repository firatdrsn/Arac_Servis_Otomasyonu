using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BMW
{
    public partial class Il_Ilce : Form
    {

        public string dosya_yolu;
        SQL cumle = new SQL();
        SqlCommand komut;

        public Il_Ilce()
        {

            InitializeComponent();
        }

        private void Il_Ilce_Load(object sender, EventArgs e)
        {
            rd_ic.Checked = true;
            rd_Il.Checked = true;
            btn_d_aktar.Enabled = false;
            DosyaSec.Filter = "Excel Dosyası |*.xls";
        }

      

        private void btn_GeriDon_Click_1(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }

        private void rd_ic_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rd_ic.Checked == true)
            {
                btn_i_aktar.Enabled = true;
                btn_d_aktar.Enabled = false;
            }
        }

        private void rd_dis_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rd_dis.Checked == true)
            {
                btn_d_aktar.Enabled = true;
                btn_i_aktar.Enabled = false;
            }
        }

        private void btn_DosyaSec_Click_1(object sender, EventArgs e)
        {
            DosyaSec.ShowDialog();
            dosya_yolu = DosyaSec.FileName.ToString();
        }

        private void btn_Goster_Click_1(object sender, EventArgs e)
        {
            if (rd_ic.Checked == true)
            {
                if (dosya_yolu != null)
                {

                    OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_yolu + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                    baglanti.Open();
                    if (rd_Il.Checked == true)
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [iller$]", baglanti);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtg_il_ilce.DataSource = dt.DefaultView;
                    }
                    else if (rd_Ilce.Checked == true)
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [ilceler$]", baglanti);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtg_il_ilce.DataSource = dt.DefaultView;
                    }
                    baglanti.Close();
                }
                else
                { MessageBox.Show("Lütfen dosya seçiniz."); }
            }
            else if (rd_dis.Checked == true)
            {
                if (cumle.ds.Tables["Iller"] != null)
                {
                    cumle.ds.Tables["Iller"].Clear();
                }
                if (cumle.ds.Tables["Ilceler"] != null)
                {
                    cumle.ds.Tables["Ilceler"].Clear();
                }
                //----
                if (rd_Il.Checked == true)
                {
                    cumle.Select_yonetici("Select Il_kodu,Il_adi from Iller", "Iller");
                    dtg_il_ilce.DataSource = cumle.ds.Tables["Iller"];
                }
                else if (rd_Ilce.Checked == true)
                {
                    cumle.Select_yonetici("Select Ilce_kodu,Ilce_adi,Il_kodu from Ilceler", "Ilceler");
                    dtg_il_ilce.DataSource = cumle.ds.Tables["Ilceler"];
                }

            }
        }

        private void btn_i_aktar_Click(object sender, EventArgs e)
        {
            if (dtg_il_ilce.Rows.Count > 0)
            {
                if (rd_Il.Checked == true)
                {
                    int satir_sayisi = dtg_il_ilce.Rows.Count;
                    while (satir_sayisi > 0)
                    {
                        string il_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_kodu"].Value.ToString();
                        string il_adi = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_adi"].Value.ToString();
                        satir_sayisi--;
                        cumle.baglan_yonetici(1);
                        komut = new SqlCommand("Insert into Iller values('" + il_kodu + "','" + il_adi + "')", cumle.bag_cumle);
                        komut.ExecuteNonQuery();
                        cumle.baglan_yonetici(0);

                    }
                    MessageBox.Show("Aktarma İşlemi Başarılı");
                }
                else if (rd_Ilce.Checked == true)
                {
                    int satir_sayisi = dtg_il_ilce.Rows.Count;
                    while (satir_sayisi > 0)
                    {
                        string il_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_kodu"].Value.ToString();
                        string ilce_adi = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Ilce_adi"].Value.ToString();
                        string ilce_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Ilce_kodu"].Value.ToString();
                        satir_sayisi--;
                        cumle.baglan_yonetici(1);
                        komut = new SqlCommand("Insert into Ilceler values('" + ilce_kodu + "','" + ilce_adi + "','" + il_kodu + "')", cumle.bag_cumle);
                        komut.ExecuteNonQuery();
                        cumle.baglan_yonetici(0);

                    }
                    MessageBox.Show("Aktarma İşlemi Başarılı");

                }
            }
            else { MessageBox.Show("İçe aktarılacak veri yok."); }
        }

        private void btn_d_aktar_Click_1(object sender, EventArgs e)
        {
            if (DosyaSec.SafeFileName == "il_ilce_disariaktar.xls")
            {
                if (dtg_il_ilce.Rows.Count > 0)
                {
                    int satir_sayisi = dtg_il_ilce.Rows.Count;

                    OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_yolu + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    if (rd_Il.Checked == true)
                    {
                        while (satir_sayisi > 0)
                        {
                            string il_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_kodu"].Value.ToString();
                            string il_adi = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_adi"].Value.ToString();
                            satir_sayisi--;
                            komut.CommandText = "Insert into [iller$] (Il_kodu,Il_adi) values('" + il_kodu + "','" + il_adi + "')";
                            komut.ExecuteNonQuery();

                        }
                        MessageBox.Show("Aktarma İşlemi Tamamlandı");
                    }
                    else if (rd_Ilce.Checked == true)
                    {
                        while (satir_sayisi > 0)
                        {
                            string il_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Il_kodu"].Value.ToString();
                            string ilce_adi = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Ilce_adi"].Value.ToString();
                            string ilce_kodu = dtg_il_ilce.Rows[satir_sayisi - 1].Cells["Ilce_kodu"].Value.ToString();

                            satir_sayisi--;
                            komut.CommandText = "Insert into [ilceler$] (Ilce_kodu,Ilce_adi,Il_kodu) values('" + ilce_kodu + "','" + ilce_adi + "','" + il_kodu + "')";
                            komut.ExecuteNonQuery();

                        }
                        MessageBox.Show("Aktarma İşlemi Tamamlandı");
                    }

                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Dışa aktarılacak veri yok.");
                }
            }
            else
            {
                MessageBox.Show("Veri aktarılacak dosyayı seçiniz.");
            }
        }

        

    }
}
