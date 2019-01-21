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
    public partial class Giris : Form
    {
        public static string tc_no,yetki_kodu;

        SQL cumle = new SQL();
        AdminPanel admin = new AdminPanel();
        MusteriHizmetleriPanel Musterihzmt = new MusteriHizmetleriPanel();
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {

                cumle.Select("Select yetki_kontrol from Yetki_Kontrol", "yetki_kontrol");
                if (cumle.ds.Tables["yetki_kontrol"].Rows[0]["yetki_kontrol"].ToString() == "0")
                {
                 
                    cumle.Yetkileri_Ver();


                    cumle.IDU("Update Yetki_Kontrol set yetki_kontrol=1");
                }
                cumle.Select("Select Yetki_kodu from Kullanici where Kullanici_adi='" + txt_Kulad.Text.ToString() + "' AND Kullanici_sifre='" + txt_Sifre.Text.ToString() + "'", "giris");


                yetki_kodu = cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString();


                if (yetki_kodu == "YK0")
                {
                    tc_no = txt_Kulad.Text;
                    admin.Show();
                    this.Hide();
                }
                else if( yetki_kodu == "YK1")
                {
                    tc_no = txt_Kulad.Text;
                    AnaMenü m = new AnaMenü();
                    m.Show();
                    this.Hide();
                   

                }
                else if (yetki_kodu == "YK2")
                {
                    tc_no=txt_Kulad.Text;
                    Servis s = new Servis();
                    s.Show();
                    this.Hide();
                }
                else if (yetki_kodu == "YK3")
                {
                    tc_no = txt_Kulad.Text;
                    Arac_Satis asts = new Arac_Satis();
                    asts.Show();
                    this.Hide();
                }
                else if (yetki_kodu == "YK4")
                {
                    tc_no = txt_Kulad.Text;
                    Musterihzmt.tcno = txt_Kulad.Text.ToString();
                    Musterihzmt.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş"); 
            }


        }

        private void Giris_Load(object sender, EventArgs e)
        {
            SqlConnection kontrol = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=true;");
            SqlConnection kontrol1 = new SqlConnection("Data Source=.; Initial Catalog=master;Integrated Security=true;");
            try
            {

                kontrol.Open();
                kontrol.Close();
            }
            catch (Exception)
            {
                vtyukle.Filter = "Backup Dosyası |*.bak";

                DialogResult secenek = MessageBox.Show("Malesef BMW Veri Tabanı Sunucunuzda Bulunmadı. Veri Tabanınını Backup'tan Geri Yüklemek İster misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    vtyukle.ShowDialog();
                    string vt_yolu = vtyukle.FileName.ToString();
                    MessageBox.Show(vt_yolu);

                    kontrol1.Open();
                    SqlCommand komut = new SqlCommand(@"RESTORE DATABASE BMW FROM DISK = '" + vt_yolu.ToString() + "' WITH REPLACE;", kontrol1);
                    try
                    {
                        komut.ExecuteNonQuery();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Geri yüklerken Bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show(hata.Message);

                    }
                    finally { kontrol1.Close(); }


                    try
                    {


                        cumle.Kullanicilari_Tanimla();
                       
                        kontrol.Open();
                        kontrol.Close();
                        MessageBox.Show("Yükleme Başarı ile Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Programın Düzgün Çalışabilmesi için Bilgisayar Yeniden Başlatılacaktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        System.Diagnostics.Process.Start("ShutDown", "/r -f -t 2");
                        


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Yükleme Sırasında Bir Hata Meydana Geldi Lütfen Sistem Yöneticinize Başvurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { kontrol.Close(); }

                }
                else if (secenek == DialogResult.No)
                {
                    Application.Exit();
                }
            }

        }
        
    }
}
