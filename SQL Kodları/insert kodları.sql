USE  BMW
--Denemelik bir araç modeli kaydý giriliyor
INSERT INTO Arac_Motor Values('D10M2','BENZÝN',1.6,3000,0.50)

Insert Into Arac_Sanziman Values('BMW121-ZF6','OTOMATÝK','Deneme Arac Þanzýmaný')

Insert Into Arac_Serisi Values('BMW2','Deneme','10-01-2015')

Insert Into Donanim_Paket Values('DP11','Deneme',2500)

Insert Into Arac_Model Values('SE06','Deneme','BMW1','D10M2','DP00','BMW121-ZF6','2015',322000)

--Araç Modeli girildi

--Servis çalýþaný ekleniyor
INSERT INTO Bolumler(Bol_kodu,Bol_adi)VALUES('1','Servis')

INSERT INTO Iller(Il_kodu,Il_adi)VALUES('81','DUZCE')

INSERT INTO Ilceler(Ilce_kodu,Ilce_adi,Il_kodu)VALUES('81-01','Akçakoca','81')

INSERT INTO Personel(P_kodu,P_TCno,P_adi,P_soyadi,P_dog_tar,Il_kodu,Ilce_kodu,P_adres,P_maas,P_is_cikistarih,P_is_giristarih,Bol_kodu)VALUES('PK002','11111111112','king','size','1995-10-02','34','34-01','Esenyurt/ÝSTANBUL',2500,Null,'2012-04-01','1')

INSERT INTO Kullanici_Yetki(Yetki_kodu,Yetki_adi)VALUES('YK1','SERVÝS')

INSERT INTO Kullanici(Yetki_kodu,Kullanici_adi,Kullanici_sifre)VALUES('YK1','11111111111','servis123')

--Çalýþan Eklendi

--Araç Stok tablosuna veri ekleme
Insert Into Arac_Stok Values('SE01',8,322500,7500,10000,10000,350000)

--Parça stok ekleme
Insert Into Parca_Stok Values('PAK001','Direksiyon',50,250,'Ý serisi direksiyon')

Insert Into Parca_Stok Values('PAK002','Fren',20,800,'Fren sistemi')

select * from Parca_Stok

select * from Arac_Stok

select * from servis

select * from Personel

SELECT * FROM Musteri

Insert into Musteri values('MK0002','20348287598','Fýrat','Dursun','553-436-22-31','firat@gmail.com','34','34-00','Güngören','MT2')

exec Musteri_sorgu_mtcno 20348287598

select * from Arac_Model

Select * From Arac_Model Where Model_kodu = 'SE02'

Select CC From Arac_Motor Where AracM_kodu=(Select AracM_kodu From Arac_Model Where Model_kodu='SE00')

Select Model_adi From Arac_Model Where Seri_kodu='BMW1'

select * from Arac_Serisi

Select * From Donanim_Paket

Select * From Arac_Motor

select * from Arac_Stok

select Il_kodu from Iller Where Il_adi='ÝSTANBUL'

select Ilce_adi from Ilceler where Il_kodu=(select Il_kodu from Iller Where Il_adi='ÝSTANBUL')

Insert into Servis values('SK0007','MK0001','SE01','PK000',1000,1000,'2016.10.12','2017.10.12','34AFD90','500','1')

SELECT * FROM Arac_Satis

Execute Arac_Satis_kayitekle 'SK0002','SE01','PK000','MK0001','2015-12-01',1000,'34FD123'

SELECT * FROM Islem

select * from Parca_Stok

select * from Servis

insert into Islem Values('IK0001','sada','PAK000',2,'SK0002',600)

Select Model_kodu From Arac_Model Where Seri_kodu='BMW2' And Model_adi='Deneme2'  And Dp_kodu=(Select Dp_kodu From Donanim_Paket Where Dp_adi='X-Drive')