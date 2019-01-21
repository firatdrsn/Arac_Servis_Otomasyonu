-- TRIGGERS --
use BMW

drop TRIGGER Servis_fiyat_hesapla
ON Islem
FOR INSERT
AS
Declare @parcafiyat money,@servisucret money,@serviskodu varchar(6)

select @serviskodu=S_kodu From Inserted 

select @servisucret=Servis_ucret From Servis Where S_kodu=@serviskodu

Select @parcafiyat=Birim_fiyat From Parca_Stok ps INNER JOIN Islem ýs ON ps.Parca_kodu=ýs.Parca_kodu Where ps.Parca_kodu=@serviskodu

Update Servis
Set Servis_ucret=@parcafiyat
Where S_kodu=@serviskodu
GO


CREATE TRIGGER TG_S_Arac_Model
ON Arac_Model
FOR DELETE
AS

DECLARE @modelid int,@modelkodu varchar(4),@modeladi varchar(25),@serikodu varchar(8),
@aracmkodu varchar(5),@dpkodu varchar(4),@sanzimankodu varchar(10),@modelyili date,@fiyat money

Select @modelid=Model_id,@modelkodu=Model_kodu,@modeladi=Model_adi,@serikodu=Seri_kodu,
@aracmkodu=AracM_kodu,@dpkodu=Dp_kodu,@sanzimankodu=Sanziman_kodu,@modelyili=Model_yili,@fiyat=Fiyat from deleted

INSERT INTO S_Arac_Model VALUES (@modelid,@modelkodu,@modeladi,@serikodu,@aracmkodu,@dpkodu,@sanzimankodu,@modelyili,@fiyat)

GO

CREATE TRIGGER TG_S_Arac_Motor
ON Arac_Motor
FOR DELETE
AS

DECLARE @aracmid int,@aracmkodu varchar(5),@yakittipi varchar(8),@cc int,
@bg int,@yakittuketim float

Select @aracmid=AracM_id,@aracmkodu=AracM_kodu,@yakittipi=Yakit_tipi,@cc=CC,@bg=BG,@yakittuketim=Yakit_tuketim from deleted

INSERT INTO S_Arac_Motor VALUES (@aracmid,@aracmkodu,@yakittipi,@cc,@bg,@yakittuketim)

GO


CREATE TRIGGER TG_S_Arac_Sanziman
ON Arac_Sanziman
FOR DELETE
AS

DECLARE @sanzimanid int,@sanzimankodu varchar(10),@sanzimanadi varchar(8),@ozellik varchar(80)

Select @sanzimanid=Sanziman_id,@sanzimankodu=Sanziman_kodu,@sanzimanadi=Sanziman_adi,@ozellik=Ozellik from deleted

INSERT INTO S_Arac_Sanziman VALUES (@sanzimanid,@sanzimankodu,@sanzimanadi,@ozellik)

GO


CREATE TRIGGER TG_S_Arac_Satis
ON Arac_Satis
FOR DELETE
AS

DECLARE @satisid int,@satiskodu varchar(6),@modelkodu varchar(4),@pkodu varchar(5),@mkodu varchar(6),@satistarih date,@satisfiyat money,@adet int,@plaka varchar(9)

Select @satisid=Satis_id,@satiskodu=Satis_kodu,@modelkodu=Model_kodu,@pkodu=P_kodu,@mkodu=M_kodu,@satistarih=Satis_tarih,@satisfiyat=Satis_Fiyat,
@plaka=Plaka from deleted

INSERT INTO S_Arac_Satis VALUES (@satisid,@satiskodu,@modelkodu,@pkodu,@mkodu,@satistarih,@satisfiyat,@plaka)

GO


CREATE TRIGGER TG_S_Arac_Serisi
ON Arac_Serisi
FOR DELETE
AS

DECLARE @seriid int,@serikodu varchar(8),@seriadi varchar(20),@cikisyili date

Select @seriid=Seri_id,@serikodu=Seri_kodu,@seriadi=Seri_adi,@cikisyili=Cikis_yili from deleted

INSERT INTO S_Arac_Serisi VALUES (@seriid,@serikodu,@seriadi,@cikisyili)

GO


CREATE TRIGGER TG_S_Arac_Stok
ON Arac_Stok
FOR DELETE
AS

DECLARE @astokid int,@modelkodu varchar(4),@adet int,@birimalisfiyat money,@otv money,@kdv money,@kar money,@birimtoplamfiyat money

Select @astokid=AStok_id,@modelkodu=Model_kodu,@adet=Adet,@birimalisfiyat=Birim_alis_fiyat,@otv=OTV,@kdv=KDV,@kar=Kar,
@birimtoplamfiyat=@birimtoplamfiyat from deleted

INSERT INTO S_Arac_Stok VALUES (@astokid,@modelkodu,@adet,@birimalisfiyat,@otv,@kdv,@kar,@birimtoplamfiyat)

GO


CREATE TRIGGER TG_S_Bolumler
ON Bolumler
FOR DELETE
AS

DECLARE @bolid int,@bolkodu varchar(2),@boladi varchar(15)

Select @bolid=Bol_id,@bolkodu=Bol_kodu,@boladi=Bol_adi from deleted

INSERT INTO S_Bolumler VALUES (@bolid,@bolkodu,@boladi)

GO



CREATE TRIGGER TG_S_Donanim_Paket
ON Donanim_Paket
FOR DELETE
AS

DECLARE @dpid int,@dpkodu varchar(4),@dpadi varchar(10),@dpfiyat money

Select @dpid=Dp_id,@dpkodu=Dp_kodu,@dpadi=Dp_adi,@dpfiyat=Dp_fiyat from deleted

INSERT INTO S_Donanim_Paket VALUES (@dpid,@dpkodu,@dpadi,@dpfiyat)

GO


CREATE TRIGGER TG_S_Firma_Musteri
ON Firma_Musteri
FOR DELETE
AS

DECLARE @firmaid int,@firmakodu varchar(5),@firmaadi varchar(20),@ilkodu varchar(2),@ilcekodu varchar(5),@firmaadres varchar(100),@mkodu varchar(6)

Select @firmaid=Firma_id,@firmakodu=Firma_kodu,@firmaadi=Firma_adi,@ilkodu=Il_kodu,@ilcekodu=Ilce_kodu,@firmaadres=Firma_adres,@mkodu=M_kodu from deleted

INSERT INTO S_Firma_Musteri VALUES (@firmaid,@firmakodu,@firmaadi,@ilkodu,@ilcekodu,@firmaadres,@mkodu)

GO


CREATE TRIGGER TG_S_Ilceler
ON Ilceler
FOR DELETE
AS

DECLARE @ilceid int,@ilcekodu varchar(5),@ilceadi varchar(20),@ilkodu varchar(2)

Select @ilceid=Ilce_id,@ilcekodu=Ilce_kodu,@ilceadi=Ilce_adi,@ilkodu=Il_kodu from deleted

INSERT INTO S_Ilceler VALUES (@ilceid,@ilcekodu,@ilceadi,@ilkodu)

GO



CREATE TRIGGER TG_S_Iller
ON Iller
FOR DELETE
AS

DECLARE @ilid int,@ilkodu varchar(5),@iladi varchar(20)

Select @ilid=Il_id,@ilkodu=Il_kodu,@iladi=Il_adi from deleted

INSERT INTO S_Iller VALUES (@ilid,@ilkodu,@iladi)

GO



CREATE TRIGGER TG_S_Islem
ON Islem
FOR DELETE
AS

DECLARE @islemid int,@islemkodu varchar(6),@islem varchar(200),@parcakodu varchar(6),@parcaadet int,@skodu varchar(6),@ucret money

Select @islemid=Islem_id,@islemkodu=Islem_kodu,@islem=Islem,@parcakodu=Parca_kodu,@parcaadet=Parca_adet,@skodu=S_kodu,@ucret=Ucret from deleted


GO



CREATE TRIGGER TG_S_Kullanici
ON Kullanici
FOR DELETE
AS

DECLARE @kulid int,@yetkikodu varchar(3),@kullaniciadi varchar(11),@sifre varchar(12)

Select @kulid=Kul_id,@yetkikodu=Yetki_kodu,@kullaniciadi=Kullanici_adi,@sifre=Kullanici_sifre from deleted

INSERT INTO S_Kullanici VALUES (@kulid,@yetkikodu,@kullaniciadi,@sifre)

GO



CREATE TRIGGER TG_S_Kullanici_Yetki
ON Kullanici_Yetki
FOR DELETE
AS

DECLARE @yetkiid int,@yetkikodu varchar(3),@yetkiadi varchar(30)

Select @yetkiid=Yetki_id,@yetkikodu=Yetki_kodu,@yetkiadi=Yetki_adi from deleted

INSERT INTO S_Kullanici_Yetki VALUES (@yetkiid,@yetkikodu,@yetkiadi)

GO


CREATE TRIGGER TG_S_Musteri
ON Musteri
FOR DELETE
AS

DECLARE @mid int,@mkodu varchar(6),@mtcno int,@madi varchar(15),@msoyadi varchar(20),@mtel varchar(13),
@memail varchar(35),@ilkodu varchar(2),@ilcekodu varchar(5),@adres varchar(100),@mturukodu varchar(3)

Select @mid=M_id,@mkodu=M_kodu,@mtcno=M_TCno,@madi=M_adi,@msoyadi=M_soyadi,@mtel=M_tel,
@memail=M_email,@ilkodu=Il_kodu,@ilcekodu=Ilce_kodu,@adres=Adres,@mturukodu=Musteri_turu_kodu from deleted

INSERT INTO S_Musteri VALUES (@mid,@mkodu,@mtcno,@madi,@msoyadi,@mtel,@memail,@ilkodu,@ilcekodu,@adres,@mturukodu)

GO




CREATE TRIGGER TG_S_Musteri_Turu
ON Musteri_Turu
FOR DELETE
AS

DECLARE @musteriid int,@mturkodu varchar(3),@mturadi varchar(15)

Select @musteriid=Musteri_id,@mturkodu=Musteri_turu_kodu,@mturadi=M_tur_adi from deleted

INSERT INTO S_Musteri_Turu VALUES (@musteriid,@mturkodu,@mturadi)

GO


CREATE TRIGGER TG_S_Parca_Stok
ON Parca_Stok
FOR DELETE
AS

DECLARE @pstokid int,@parcakodu varchar(6),@parcaadi varchar(25),@stokadet int,@fiyat money,@aciklama varchar(100)

Select @pstokid=PStok_id,@parcakodu=Parca_kodu,@parcaadi=Parca_adi,@stokadet=Stok_adet,@fiyat=Birim_fiyat,@aciklama=Aciklama from deleted

INSERT INTO S_Parca_Stok VALUES (@pstokid,@parcakodu,@parcaadi,@stokadet,@fiyat,@aciklama)

GO



CREATE TRIGGER TG_S_Personel
ON Personel
FOR DELETE
AS

DECLARE @pid int,@pkodu varchar(5),@ptcno varchar(11),@padi varchar(10),@psoyadi varchar(25),@pdogtar date,@ilkodu varchar(2),@ilcekodu varchar(5),
@padres varchar(100),@pmaas money,@pisgiristarih date,@piscikistarih date,@bolkodu varchar(2)

Select @pid=P_id,@pkodu=P_kodu,@ptcno=P_TCno,@padi=P_adi,@psoyadi=P_soyadi,@pdogtar=P_dog_tar,@ilkodu=Il_kodu,@ilcekodu=Ilce_kodu,
@padres=P_adres,@pmaas=P_maas,@pisgiristarih=P_is_giristarih,@piscikistarih=P_is_cikistarih,@bolkodu=Bol_kodu from deleted

INSERT INTO S_Personel VALUES (@pid,@pkodu,@ptcno,@padi,@psoyadi,@pdogtar,@ilkodu,@ilcekodu,@padres,@pmaas,@pisgiristarih,@piscikistarih,@bolkodu)

GO



CREATE TRIGGER TG_S_Servis
ON Servis
FOR DELETE
AS

DECLARE @sid int,@skodu varchar(6),@mkodu varchar(6),@modelkodu varchar(4),@pkodu varchar(5),@aracgiriskm int,@araccikiskm int,@sgiristarih date,
@scikistarih date,@plaka varchar(9),@servisucret money,@durum varchar(1)

Select @sid=S_id,@skodu=S_kodu,@mkodu=M_kodu,@modelkodu=Model_kodu,@pkodu=P_kodu,@aracgiriskm=Arac_giriskm,@araccikiskm=Arac_cikiskm,
@sgiristarih=S_giris_tarih,@scikistarih=S_cikis_tarih,@plaka=Plaka,@servisucret=Servis_ucret,@durum=Durum from deleted

INSERT INTO S_Servis VALUES (@sid,@skodu,@mkodu,@modelkodu,@pkodu,@aracgiriskm,@araccikiskm,@sgiristarih,@scikistarih,@plaka,@servisucret,@durum)

GO

--Araç satýldýðýnda stoktan bir azaltan trigger
CREATE TRIGGER TG_Stok_Azaltma
ON Arac_Satis
FOR INSERT
AS
Update Arac_Stok Set Adet=Adet-1 Where Model_kodu=(Select Model_kodu From Inserted)
GO

--Silinmiþ kayýtlarýn olduðu tablolarda veriler silinemez.

CREATE TRIGGER TG_Silme_S_Arac_Model
ON S_Arac_Model
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Arac_Motor
ON S_Arac_Motor
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Arac_Sanziman
ON S_Arac_Sanziman
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Arac_Satis
ON S_Arac_Satis
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Arac_Serisi
ON S_Arac_Serisi
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Arac_Stok
ON S_Arac_Stok
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Bolumler
ON S_Bolumler
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Donanim_Paket
ON S_Donanim_Paket
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Firma_Musteri
ON S_Firma_Musteri
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Ilceler
ON S_Ilceler
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Iller
ON S_Iller
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Islem
ON S_Islem
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Kullanici
ON S_Kullanici
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Kullanici_Yetki
ON S_Kullanici_Yetki
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Musteri
ON S_Musteri
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Musteri_Turu
ON S_Musteri_Turu
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Parca_Stok
ON S_Parca_Stok
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Personel
ON S_Personel
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO

CREATE TRIGGER TG_Silme_S_Servis
ON S_Servis
INSTEAD OF DELETE
AS
Print 'Bu veri silinemez..'
GO
