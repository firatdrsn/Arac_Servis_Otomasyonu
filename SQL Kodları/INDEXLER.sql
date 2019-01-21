-- nonclustered ýndex --
use BMW
--
CREATE NONCLUSTERED INDEX IN_Arac_Model_modelkodu ON Arac_Model(Model_adi)
--
CREATE NONCLUSTERED INDEX IN_Arac_Motor ON Arac_Motor(Yakit_tipi)
--
CREATE NONCLUSTERED INDEX IN_Arac_Satis ON Arac_Satis(Model_kodu,plaka)
--
CREATE NONCLUSTERED INDEX IN_Arac_Serisi ON Arac_Serisi(Seri_adi)
--
CREATE NONCLUSTERED INDEX IN_Arac_Stok ON Arac_Stok(AStok_id)
--
CREATE NONCLUSTERED INDEX IN_Bolumler ON Bolumler(Bol_adi)
--
CREATE NONCLUSTERED INDEX IN_Donanim_paket ON Donanim_Paket(Dp_id,Dp_adi)
--
CREATE NONCLUSTERED INDEX IN_Firma_Musteri ON Firma_Musteri(Firma_adi,M_kodu)
--
CREATE NONCLUSTERED INDEX IN_Ilceler ON Ilceler(Ilce_adi)
--
CREATE NONCLUSTERED INDEX IN_Iller ON Iller(Il_adi)
--
CREATE NONCLUSTERED INDEX IN_Islem ON Islem(Parca_kodu,S_kodu)
--
CREATE NONCLUSTERED INDEX IN_Kullanici ON Kullanici(Yetki_kodu)
--
CREATE NONCLUSTERED INDEX IN_Kullanici_Yetki ON Kullanici_Yetki(Yetki_adi)
--
CREATE NONCLUSTERED INDEX IN_Musteri ON Musteri(M_TCno,M_adi,M_soyadi,Musteri_turu_kodu)
--
CREATE NONCLUSTERED INDEX IN_Musteri_Turu ON Musteri_Turu(M_tur_adi)
--
CREATE NONCLUSTERED INDEX IN_Parca_Stok ON Parca_Stok(Parca_adi)
--
CREATE NONCLUSTERED INDEX IN_Personel ON Personel(P_tcno,P_adi,P_soyadi,Bol_kodu)
--
CREATE NONCLUSTERED INDEX IN_Servis ON Servis(M_kodu,Model_kodu,P_kodu,Plaka,Durum)