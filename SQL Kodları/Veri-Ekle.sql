--Veri Ekleme
use BMW

Insert into Arac_Serisi values('BMW1','BMW-1','10-9-2005')
Insert into Donanim_Paket values('DP00','X-Drive','2000')
Insert into Arac_Motor values('D10M0','BENZÝN',2000,300,2)
Insert into Arac_Sanziman values('BMW000-ZF5','OTOMATÝK','5 ileri 1 geri')
Insert into Arac_Model values('SE00','BMW Toureng','BMW1','D10M0','DP00','BMW000-ZF5','10-09-2006','100000')
Insert into Arac_Model values('SE03','BMW Toureng','BMW1','D10M0','DP00','BMW000-ZF5','10-09-2006','100000')

INSERT INTO Bolumler(Bol_kodu,Bol_adi)VALUES('0','Bilgi Ýþlem')
INSERT INTO Iller(Il_kodu,Il_adi)VALUES('34','Ýstanbul')
INSERT INTO Ilceler(Ilce_kodu,Ilce_adi,Il_kodu)VALUES('34-00','Güngören','34')
INSERT INTO Personel(P_kodu,P_TCno,P_adi,P_soyadi,P_dog_tar,Il_kodu,Ilce_kodu,P_adres,P_maas,P_is_cikistarih,P_is_giristarih,Bol_kodu)VALUES('PK000','12345678901','Mert','ÖZEN','1995-10-02','34','34-00','Güngören/Ýstanbul','0',Null,'2016-12-07','0')
INSERT INTO Kullanici_Yetki(Yetki_kodu,Yetki_adi)VALUES('YK0','Admin')
INSERT INTO Kullanici(Yetki_kodu,Kullanici_adi,Kullanici_sifre)VALUES('YK0','12345678901','Admin0')

Insert into Musteri_Turu values('MT0','Sýfýr Araç')
Insert into Musteri_Turu values('MT2','Sýfýr ve Servis')
Insert into Musteri values('MK0000','12365498701','Mert','OZEN','551-553-52-30','mert@gmail.com','34','34-00','Güngören','MT0')
Insert into Musteri values('MK0001','12365498702','Mehmet','OZEN','551-553-52-32','mehmet@gmail.com','34','34-00','Güngören','MT2')
Insert into Firma_Musteri Values('FK000','Mert Otomotiv','34','34-00','Mustafa Kemal Caddesi','MK0000')

Insert into Arac_Satis values('SK0000','SE00','PK000','MK0000','10-12-2015','120000','34ABC94')
Insert into Arac_Satis values('SK0001','SE01','PK000','MK0001','11-12-2015','110000','34ABC95')

Insert into Parca_Stok values('PAK000','Tampon',2,'500','BMW1 Tamponu')

Insert into Servis values('SK0001','MK0001','SE01','PK000',1000,1000,'2016-12-12','2016-12-14','34ABC95','500','1')
Insert into Islem values('IK0000','Tampon Takýldý','PAK000',1,'SK0001','200')

Insert into Arac_Stok values('SE00',1,'100000','80000','30000','10000','220000')
Insert into Arac_Stok values('SE02',5,'1000','100','100','100','5000')
Insert into Arac_Stok values('SE04',5,'1000','100','100','100','5000')
