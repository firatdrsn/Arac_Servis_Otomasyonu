-- STORED PROCEDURE --


use BMW
CREATE PROCEDURE Arac_model_sorgu_modelkodu 
@modelkodu varchar(4)
AS
SELECT Model_kodu AS 'Arac�n Model Kodu',Model_adi AS 'Modelin Ad�',Seri_kodu AS 'Modelin Seri Numaras�'
,AracM_kodu AS 'Arac�n Motor Kodu',Dp_kodu AS 'Ara�taki Donan�m Paketi Kodu',Sanziman_kodu AS 'Ara�taki �anziman Kodu',
Model_yili AS 'Modelin �retim Y�l�',Fiyat AS 'Arac�n Fiyat�' FROM Arac_Model where Model_kodu=@modelkodu
GO



CREATE PROCEDURE Arac_model_sorgu_modelyili 
@modelyili date
AS
SELECT Model_kodu AS 'Arac�n Model Kodu',Model_adi AS 'Modelin Ad�',Seri_kodu AS 'Modelin Seri Numaras�'
,AracM_kodu AS 'Arac�n Motor Kodu',Dp_kodu AS 'Ara�taki Donan�m Paketi Kodu',Sanziman_kodu AS 'Ara�taki �anziman Kodu',
Model_yili AS 'Modelin �retim Y�l�',Fiyat AS 'Arac�n Fiyat�' FROM Arac_Model where Model_yili=@modelyili
GO

CREATE PROCEDURE Arac_model_sorgu_modeladi 
@modeladi varchar(25)
AS
SELECT Model_kodu AS 'Arac�n Model Kodu',Model_adi AS 'Modelin Ad�',Seri_kodu AS 'Modelin Seri Numaras�'
,AracM_kodu AS 'Arac�n Motor Kodu',Dp_kodu AS 'Ara�taki Donan�m Paketi Kodu',Sanziman_kodu AS 'Ara�taki �anziman Kodu',
Model_yili AS 'Modelin �retim Y�l�',Fiyat AS 'Arac�n Fiyat�' FROM Arac_Model where Model_adi=@modeladi
GO

CREATE PROCEDURE Personel_sorgu_pkodu
@personelkodu varchar(5)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE P_kodu=@personelkodu
GO

CREATE PROCEDURE Personel_sorgu_tcno
@personeltcnumarsi varchar(11)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE P_TCno=@personeltcnumarsi
GO

CREATE PROCEDURE Personel_sorgu_padi
@personeladi varchar(10)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE P_adi=@personeladi
GO

CREATE PROCEDURE Personel_sorgu_psoyadi
@personelsoyadi varchar(25)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE P_soyadi=@personelsoyadi
GO

CREATE PROCEDURE Personel_sorgu_padsoyad
@personeladi varchar(10),@personelsoyadi varchar(25)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE P_adi=@personeladi AND P_soyadi=@personelsoyadi
GO

CREATE PROCEDURE Personel_sorgu_bolkod
@bolumkodu varchar(2)
AS
SELECT P_kodu AS 'Personel Kodu',P_TCno AS 'TC Numaras�',P_adi AS 'Ad�',P_soyadi AS 'Soyad�',P_dog_tar AS 'Do�um Tarihi',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Kodu',P_adres AS 'Adres',P_is_giristarih AS '��e giri� Tarihi',P_is_cikistarih AS '��ten ��k�� Tarihi',P_maas AS 'Personelin Maa��',
Bol_kodu AS '�al��t��� B�l�m Kodu' FROM Personel WHERE Bol_kodu=@bolumkodu
GO


CREATE PROCEDURE Musteri_sorgu_mkodu
@musterikodu varchar(6)
AS
SELECT M_kodu AS 'M��teri Kodu',M_TCno AS 'TC Numaras�',M_adi AS 'Ad�',M_soyadi AS 'Soyad�',M_tel AS 'Telefon',M_email AS 'E-MA�L',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Koldu',Adres AS 'Adres',Musteri_turu_kodu AS 'M��teri T�r� Kodu' FROM Musteri WHERE M_kodu=@musterikodu
GO

CREATE PROCEDURE Musteri_sorgu_mtcno
@musteritcno varchar(11)
AS
SELECT M_kodu AS 'M��teri Kodu',M_TCno AS 'TC Numaras�',M_adi AS 'Ad�',M_soyadi AS 'Soyad�',M_tel AS 'Telefon',M_email AS 'E-MA�L',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Koldu',Adres AS 'Adres',Musteri_turu_kodu AS 'M��teri T�r� Kodu' FROM Musteri WHERE M_TCno=@musteritcno
GO

CREATE PROCEDURE Musteri_sorgu_madi
@musteriadi varchar(15)
AS
SELECT M_kodu AS 'M��teri Kodu',M_TCno AS 'TC Numaras�',M_adi AS 'Ad�',M_soyadi AS 'Soyad�',M_tel AS 'Telefon',M_email AS 'E-MA�L',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Koldu',Adres AS 'Adres',Musteri_turu_kodu AS 'M��teri T�r� Kodu' FROM Musteri WHERE M_adi=@musteriadi
GO

CREATE PROCEDURE Musteri_sorgu_msoyadi
@musterisoyadi varchar(20)
AS
SELECT M_kodu AS 'M��teri Kodu',M_TCno AS 'TC Numaras�',M_adi AS 'Ad�',M_soyadi AS 'Soyad�',M_tel AS 'Telefon',M_email AS 'E-MA�L',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Koldu',Adres AS 'Adres',Musteri_turu_kodu AS 'M��teri T�r� Kodu' FROM Musteri WHERE M_soyadi=@musterisoyadi
GO

CREATE PROCEDURE Musteri_sorgu_mturukodu
@musteriturukodu varchar(3)
AS
SELECT M_kodu AS 'M��teri Kodu',M_TCno AS 'TC Numaras�',M_adi AS 'Ad�',M_soyadi AS 'Soyad�',M_tel AS 'Telefon',M_email AS 'E-MA�L',Il_kodu AS '�l Kodu',
Ilce_kodu AS '�l�e Koldu',Adres AS 'Adres',Musteri_turu_kodu AS 'M��teri T�r� Kodu' FROM Musteri WHERE Musteri_turu_kodu=@musteriturukodu
GO

CREATE PROCEDURE Arac_Stok_sorgu_modelkodu
@modelkodu varchar(4)
AS
SELECT Model_kodu AS 'Model Kodu',Adet AS 'Adet',Birim_alis_fiyat AS 'Al�� Fiyat�',OTV AS 'OTV',KDV AS 'KDV',Kar AS 'Kar',
Birim_toplam_Fiyat AS 'Anahtar Teslim Fiyat�' FROM Arac_Stok WHERE Model_kodu=@modelkodu
GO


CREATE PROCEDURE Arac_Stok_kayitekle 
@modelkodu varchar(4),@adet int,@birimalisfiyat money,@otv money,@kdv money,@kar money,@birimtoplamfiyat money
AS
INSERT INTO Arac_Stok VALUES(@modelkodu,@adet,@birimalisfiyat,@otv,@kdv,@kar,@birimtoplamfiyat)	
GO

CREATE PROCEDURE Musteri_kayitekle 
@mkodu varchar(6),@mtcno varchar(11),@madi varchar(15),@msoyadi varchar(20),@mtel varchar(13),
@memail varchar(35),@ilkodu varchar(2),@ilcekodu varchar(5),@adres varchar(100),@musteriturukodu varchar(3)
AS
INSERT INTO Musteri VALUES(@mkodu,@mtcno,@madi,@msoyadi,@mtel,@memail,@ilkodu,@ilcekodu,@adres,@musteriturukodu)
GO

Create PROCEDURE Arac_Satis_kayitekle 
@satiskodu varchar(6),@modelkodu varchar(4),@personelkodu varchar(5),@musterikodu varchar(6),@satistarihi date,
@satisfiyati money,@plaka varchar(9)
AS
INSERT INTO Arac_Satis VALUES(@satiskodu,@modelkodu,@personelkodu,@musterikodu,@satistarihi,@satisfiyati,@plaka)
GO

CREATE PROCEDURE Arac_Satis_kayitsil_satiskodu 
@satiskodu varchar(6)
AS
DELETE FROM Arac_Satis WHERE Satis_kodu=@satiskodu
GO

CREATE PROCEDURE Arac_Satis_kayitsil_plaka
@plaka varchar(9)
AS
DELETE FROM Arac_Satis WHERE Plaka=@plaka
GO

CREATE PROCEDURE Islem_kayitsil_islemkodu
@islemkodu varchar(6)
AS
DELETE FROM Islem WHERE Islem_kodu=@islemkodu
GO

CREATE PROCEDURE Islem_kayitsil_skodu
@skodu varchar(6)
AS
DELETE FROM Islem WHERE S_kodu=@skodu
GOs

CREATE PROCEDURE Arac_Stok_model_kodu_bul2
@skodu varchar(8),@model_adi varchar(25),@dp_adi varchar(10)
AS
Select Model_kodu From Arac_Model Where Seri_kodu=@skodu And Model_adi=@model_adi  And Dp_kodu=(Select Dp_kodu From Donanim_Paket Where Dp_adi=@dp_adi)
GO
-- STORED PROCEDURE --

Exec Arac_Stok_model_kodu_bul2 'BMW2','Deneme2','X-Drive'