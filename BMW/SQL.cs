using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMW
{

    class SQL
    {

       public SqlConnection bag_cumle = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=true;");
       public SqlConnection bag_cumle_yonetici = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=yonetici; password=yonetici;");
       public SqlConnection bag_cumle_patron = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=patron; password=patron;");
       public SqlConnection bag_cumle_servis = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=servis; password=servis;");
       public SqlConnection bag_cumle_satis = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=satis; password=satis;");
       public SqlConnection bag_cumle_musterihzmt = new SqlConnection("Data Source=.; Initial Catalog=BMW;Integrated Security=false; User ID=musterihzmt; password=musterihzmt;");
        SqlDataAdapter adapter;
        SqlCommand komut, kul1, kul2, kul3, kul4, kul5, kul1_yetki, kul2_yetki, kul3_yetki, kul4_yetki, kul5_yetki;

        public DataSet ds = new DataSet();
        public DataTable tablo = new DataTable();
        public void baglan(int secim)
        {
            if (secim == 1)
            {
                if (bag_cumle.State == ConnectionState.Closed)
                {
                    bag_cumle.Open();
                    
                }
            }
            else if (secim == 0)
            {
                bag_cumle.Close();
            }
        }
        public void baglan_yonetici(int secim)
        {
            if (secim == 1)
            {
                if (bag_cumle_yonetici.State == ConnectionState.Closed)
                {
                    bag_cumle_yonetici.Open();

                }
            }
            else if (secim == 0)
            {
                bag_cumle_yonetici.Close();
            }
        }
        private void baglan_musterihzmt(int secim)
        {
            if (secim == 1)
            {
                if (bag_cumle_musterihzmt.State == ConnectionState.Closed)
                {
                    bag_cumle_musterihzmt.Open();

                }
            }
            else if (secim == 0)
            {
                bag_cumle_musterihzmt.Close();
            }
        }
        public void Select(string sorgu, string tablo_adi)
        {
            try
            {
                baglan(1);
                adapter = new SqlDataAdapter(sorgu, bag_cumle);
                adapter.Fill(ds, tablo_adi);
                baglan(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);

            }

        }
        public void Select_yonetici(string sorgu, string tablo_adi)
        {
            try
            {
                baglan_yonetici(1);
                adapter = new SqlDataAdapter(sorgu, bag_cumle_yonetici);
                adapter.Fill(ds, tablo_adi);
                baglan_yonetici(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);

            }

        }
        public void Select_musterihzmt(string sorgu, string tablo_adi)
        {
            try
            {
                baglan_musterihzmt(1);
                adapter = new SqlDataAdapter(sorgu, bag_cumle_musterihzmt);
                adapter.Fill(ds, tablo_adi);
                baglan_musterihzmt(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);

            }

        }
        public void IDU(string sorgu)
        {
        
            //Insert Delete Update işlemlerimin hepsinde aynı komut satırları bulunduğu
            //için bir fonksiyon yeterli olacaktır.
            try
            {
                baglan(1);
                komut = new SqlCommand(sorgu, bag_cumle);
                komut.ExecuteNonQuery();
                baglan(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
            }

        }
        public void IDU_yonetici(string sorgu)
        {
            //Insert Delete Update işlemlerimin hepsinde aynı komut satırları bulunduğu
            //için bir fonksiyon yeterli olacaktır.
            try
            {
                baglan_yonetici(1);
                komut = new SqlCommand(sorgu, bag_cumle_yonetici);
                komut.ExecuteNonQuery();
                baglan_yonetici(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
            }

        }
        public void IDU_musterihzmt(string sorgu)
        {
            //Insert Delete Update işlemlerimin hepsinde aynı komut satırları bulunduğu
            //için bir fonksiyon yeterli olacaktır.
            try
            {
                baglan_musterihzmt(1);
                komut = new SqlCommand(sorgu, bag_cumle_musterihzmt);
                komut.ExecuteNonQuery();
                baglan_musterihzmt(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
            }

        }
        public string Giris_Bilgisi(string TC_no)
        {
            string ad_soyad, yetki, yetki_kod;

            try
            {
                //Giriş sırasında Tc_no alınıp bu fonksiyonda ad ve soyad bilgisi çekiliyor.
                Select("Select P_TCno,P_adi,P_soyadi from Personel where P_TCno='" + TC_no + "'", "Personel");
                ad_soyad = "Hoşgeldiniz" + " " + ds.Tables["Personel"].Rows[0][1].ToString() + " " + ds.Tables["Personel"].Rows[0][2];
                //Tc np ile yetki kodu elde ediliyor
                Select("Select Yetki_kodu,Kullanici_adi from Kullanici where Kullanici_adi='" + TC_no + "'", "Kullanici");
                yetki_kod = ds.Tables["Kullanici"].Rows[0][0].ToString();
                //yetki kodu ile yetki adı elde ediliyor
                Select("Select Yetki_kodu,Yetki_adi from Kullanici_Yetki where Yetki_kodu='" + yetki_kod + "'", "Kullanici_Yetki");
                yetki = ds.Tables["Kullanici_Yetki"].Rows[0][1].ToString();
                //hepsi birleştirilip çağrıldığı yere gönderiliyor
                ds.Clear();
                return ad_soyad + "(" + yetki + ")";

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
                return "";
            }
        }
        public void  Kullanicilari_Tanimla()
        {
            try
            {
                bag_cumle.Open();
                kul1 = new SqlCommand("create login yonetici with password='yonetici';create user yonetici for login yonetici;", bag_cumle);
                kul2 = new SqlCommand("create login patron with password='patron';create user patron for login patron;", bag_cumle);
                kul3 = new SqlCommand("create login servis with password='servis';create user servis for login servis;", bag_cumle);
                kul4 = new SqlCommand("create login satis with password='satis';create user satis for login satis;", bag_cumle);
                kul5 = new SqlCommand("create login musterihzmt with password='musterihzmt';create user musterihzmt for login musterihzmt;", bag_cumle);
                kul1.ExecuteNonQuery();
                kul2.ExecuteNonQuery();
                kul3.ExecuteNonQuery();
                kul4.ExecuteNonQuery();
                kul5.ExecuteNonQuery();
                bag_cumle.Close();

            }
            catch (Exception)
            {
                
                
            }
            finally
            {
                bag_cumle.Close();
            }
            

        }
     
   
        public void Yetkileri_Ver()
        {
            try
            {
                bag_cumle.Open();

                kul1_yetki = new SqlCommand(@"
                                              GRANT select,insert,update,delete,CREATE TABLE TO yonetici;
                                              GRANT EXEC TO yonetici;
                                              GRANT EXECUTE TO yonetici;", bag_cumle);


                kul2_yetki = new SqlCommand(@"
                                              GRANT select,insert,update,delete ON Personel TO patron;
                                              GRANT select ON Arac_Stok TO patron;
                                              GRANT select ON Musteri TO patron;
                                              GRANT select ON Servis TO patron;
                                              GRANT select ON Parca_Stok TO patron;
                                              grant select on Iller to patron;
                                              GRANT select ON Arac_Model TO patron;
                                              GRANT select ON S_Personel TO patron;
                                              GRANT select ON S_Musteri TO patron;
                                              GRANT select ON S_Arac_Stok TO patron;
                                              GRANT select ON S_Arac_Satis TO patron;
                                              GRANT select ON S_Servis TO patron;
                                              GRANT select ON S_Parca_Stok TO patron;
                                              GRANT select ON S_Arac_Model TO patron;
                                              GRANT EXEC TO patron;
                                              GRANT EXECUTE TO patron;", bag_cumle);


                kul3_yetki = new SqlCommand(@"
                                              GRANT select,insert,update,delete ON Servis TO servis;
                                              GRANT select,insert,update,delete ON Islem TO servis;
                                              GRANT select,insert,update,delete ON Parca_Stok TO servis;
                                              GRANT select ON Musteri TO servis;
                                              GRANT select ON Personel TO servis;
                                              GRANT EXEC TO servis;
                                              GRANT EXECUTE TO servis;", bag_cumle);


                kul4_yetki = new SqlCommand(@"
                                              GRANT select,insert ON Arac_Satis TO satis;
                                              GRANT select,insert ON Arac_Stok TO satis;
                                              GRANT select ON Arac_Model TO satis;
                                              GRANT select ON Musteri TO satis;
                                              GRANT select ON Personel TO satis;
                                              GRANT select ON Arac_Motor TO satis;
                                              GRANT select ON Arac_Serisi TO satis;
                                              GRANT select ON Arac_Model TO satis;
                                              GRANT select ON Servis TO satis;
                                              GRANT EXEC TO satis;
                                              GRANT EXECUTE TO satis;", bag_cumle);


                kul5_yetki = new SqlCommand(@"
                                              GRANT select,insert,update,delete ON Musteri TO musterihzmt;
                                              GRANT select,insert,update,delete ON Firma_Musteri TO musterihzmt;
                                              GRANT select ON Servis TO musterihzmt;
                                              GRANT select ON Arac_Model TO musterihzmt;
                                              GRANT select ON Islem TO musterihzmt;
                                              GRANT select ON Personel TO musterihzmt;
                                              GRANT select ON Arac_Satis TO musterihzmt;
                                              GRANT select ON Kullanici TO musterihzmt;
                                              GRANT select ON Kullanici_Yetki TO musterihzmt;
                                              GRANT EXEC TO musterihzmt;
                                              GRANT EXECUTE TO musterihzmt;", bag_cumle);
                kul1_yetki.ExecuteNonQuery();
                kul2_yetki.ExecuteNonQuery();
                kul3_yetki.ExecuteNonQuery();
                kul4_yetki.ExecuteNonQuery();
                kul5_yetki.ExecuteNonQuery();
                bag_cumle.Close();

            }
            catch (Exception hata)
            {

                MessageBox.Show("Yetki Vermede Hata oluştu"+hata.ToString());
            }
            finally
            {
                bag_cumle.Close();
            }


        }
      

    }
}
