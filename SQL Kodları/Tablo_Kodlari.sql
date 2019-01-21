
Create Database BMW
use BMW
use master
DROP Database BMW
----------------------------------------------- ARAÇ OLUÞTURMA BOLUMU-------------------------------------------------------


-- Araç Serisi tablosu

Create table Arac_Serisi (
Seri_id int IDENTITY,
Seri_kodu varchar(8) constraint ck_serikodu check(Seri_kodu in('BMW1','BMW2','BMW3','BMW4','BMW5','BMW6','BMW7','BMWI','BMWM','BMWZ')),
Seri_adi varchar(20) NOT NULL,
Cikis_yili date NOT NULL,
constraint pk_key primary key (Seri_kodu)
)

-- Araç Þanzýman tablosu

Create Table Arac_Sanziman(
Sanziman_id int identity,
Sanziman_kodu varchar(10) constraint ck_sanzimankod check(Sanziman_kodu like ('BMW[0-9][0-9][0-9]-ZF[0-9]')), -- örnek þanzýman kodu :  BMW740-ZF8
Sanziman_adi varchar(8) constraint ck_sanzimanadi check(Sanziman_adi in('OTOMATÝK','MANUEL')) NOT NULL,
Ozellik varchar(80),
constraint pk_key_sanziman PRIMARY KEY(Sanziman_kodu)
)

-- Donaným Paketleri tablosu

Create Table Donanim_Paket(
Dp_id int identity,
Dp_kodu varchar(4) constraint ck_dpkodu check(Dp_kodu like('DP[0-9][0-9]')),
Dp_adi varchar(10) NOT NULL,
Dp_fiyat money NOT NULL,
constraint pk_key_paket PRIMARY KEY (Dp_kodu)
)


-- Araç motor tablosu

Create table Arac_Motor(
AracM_id int identity,
AracM_kodu varchar(5) constraint ck_motorkodu check(AracM_kodu like('[DBE][1-7][0-9]M[0-9]')),
Yakit_tipi varchar(8) constraint ck_yakittipi check(Yakit_tipi in ('BENZÝN','DÝZEL','ELEKTRÝK')) NOT NULL,
CC int NOT NULL,
BG int NOT NULL,
Yakit_tuketim float NOT NULL,
constraint pk_key_motor PRIMARY KEY (AracM_kodu)
)

-- Arac model tablosu

Create table Arac_Model(
Model_id int identity,
Model_kodu varchar(4) constraint ck_modelkodu check(Model_kodu like('[STCGRHB][EOARPM][0-9][0-9]')),
Model_adi varchar(25) NOT NULL,
Seri_kodu varchar(8) FOREIGN KEY REFERENCES Arac_Serisi(Seri_kodu),
AracM_kodu varchar(5) FOREIGN KEY REFERENCES Arac_Motor(AracM_kodu),
Dp_kodu varchar(4) FOREIGN KEY REFERENCES Donanim_Paket(Dp_kodu),
Sanziman_kodu varchar(10) FOREIGN KEY REFERENCES Arac_Sanziman(Sanziman_kodu),
Model_yili date NOT NULL,
Fiyat money NOT NULL,
constraint pk_key_model PRIMARY KEY (Model_kodu)
)
----------------------------------------------- ARAÇ OLUÞTURMA BOLUMU BÝTTÝ--------------------------------------------------



----------------------------------------------- ÇALIÞAN PERSONEL BOLUMU -----------------------------------------------------

-- iller tablosu

Create table Iller(
Il_id int identity,
Il_kodu varchar(2),
Il_adi varchar(15) NOT NULL,
constraint pk_key_iller PRIMARY KEY (Il_kodu)

)

--ilçeler tablosu 

Create table Ilceler(
Ilce_id int identity,
Ilce_kodu varchar(5) constraint ck_ilcekodu check(Ilce_kodu like ('__-[0-9][0-9]')),
Ilce_adi varchar(15) NOT NULL,
Il_kodu varchar(2) FOREIGN KEY REFERENCES Iller(Il_kodu),
constraint pk_key_ilceler PRIMARY KEY (Ilce_kodu)
)

-- Bölümler tablosu

Create table Bolumler(
Bol_id int identity,
Bol_kodu varchar(2),
Bol_adi varchar(15) NOT NULL,
constraint pk_key_bolumler PRIMARY KEY (Bol_kodu)
)

-- personel tablosu 
Create table Personel(
P_id int identity,
P_kodu varchar(5) constraint ck_pkodu check(P_kodu like ('PK[0-9][0-9][0-9]')),
P_TCno varchar(11) constraint ck_tcno check(Len(P_TCno)=11),
P_adi varchar(10) NOT NULL,
P_soyadi varchar(25) NOT NULL,
P_dog_tar date constraint ck_doguntar check(DATEDIFF(YEAR,P_dog_tar,GETDATE())>16) NOT NULL,
Il_kodu varchar(2) FOREIGN KEY REFERENCES Iller(Il_kodu),
Ilce_kodu varchar(5) FOREIGN KEY REFERENCES Ilceler(Ilce_kodu),
P_adres varchar(100) NOT NULL,
P_maas money,
P_is_giristarih date constraint ck_giristarih check(P_is_giristarih<=GETDATE()) NOT NULL,
P_is_cikistarih date constraint ck_cikistarih check(P_is_cikistarih<=GETDATE()),
Bol_kodu varchar(2) FOREIGN KEY REFERENCES Bolumler(Bol_kodu),
constraint pk_key_personel PRIMARY KEY (P_kodu),
Constraint uk_personel UNIQUE(P_TCno)

)

----------------------------------------------- ÇALIÞAN PERSONEL BOLUMU BÝTTÝ------------------------------------------------




----------------------------------------------- PROGRAM GÝRÝÞÝ BOLUMU -------------------------------------------------------

-- Kullanýcý yetki tablosu 

Create table Kullanici_Yetki(
Yetki_id int identity,
Yetki_kodu varchar(3) constraint ck_yetkikodu check(Yetki_kodu like('YK[0-9]')),
Yetki_adi varchar(30) NOT NULL,
constraint pk_key_yetki PRIMARY KEY (Yetki_kodu)
)

--Kullanýcý Tablosu

Create table Kullanici(
Kul_id int identity,
Yetki_kodu varchar(3) FOREIGN KEY REFERENCES Kullanici_yetki(Yetki_kodu) ON UPDATE CASCADE ON DELETE CASCADE,
Kullanici_adi varchar(11) FOREIGN KEY REFERENCES Personel(P_TCno),
Kullanici_sifre varchar(12),
constraint ck_sifre check(Kullanici_sifre like('%[A-Z][a-z][0-9]%') and Len(Kullanici_sifre)>=6),
constraint pk_key_kullanici PRIMARY KEY (Kullanici_adi)
)


----------------------------------------------- PROGRAM GÝRÝÞÝ BOLUMU BÝTTÝ -------------------------------------------------------


----------------------------------------------- Araç satýþ bölümü -------------------------------------------------------

Create table Musteri_Turu(
Musteri_id int identity,
Musteri_turu_kodu varchar(3) constraint ck_musteriturukodu check(Musteri_turu_kodu like('MT[0-2]')),
M_tur_adi varchar(15),
constraint pk_key_musturu PRIMARY KEY (Musteri_turu_kodu)
)

Create table Musteri(
M_id int identity,
M_kodu varchar(6) constraint ck_musterikodu check(M_kodu like('MK[0-9][0-9][0-9][0-9]')),
M_TCno varchar(11) constraint ck_tcno_musteri check(Len(M_TCno)=11),
M_adi varchar(15) NOT NULL,
M_soyadi varchar(20) NOT NULL,
M_tel varchar(13) constraint ck_tel check(M_tel like ('[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]')) NOT NULL,
M_email varchar(35) constraint ck_mail check(M_email like('[a-z-0-9]%@%[a-z-0-9]%.com')) NOT NULL,
Il_kodu varchar(2) FOREIGN KEY REFERENCES Iller(Il_kodu),
Ilce_kodu varchar(5) FOREIGN KEY REFERENCES Ilceler(Ilce_kodu),
Adres varchar(100),
Musteri_turu_kodu varchar(3) FOREIGN KEY REFERENCES Musteri_turu(Musteri_turu_kodu),
constraint pk_key_musteri PRIMARY KEY (M_kodu),
constraint uk_musteri UNIQUE (M_TCno)
)

Create table Firma_Musteri(
Firma_id int identity,
Firma_kodu varchar(5) constraint ck_firmakodu check(Firma_kodu like('FK[0-9][0-9][0-9]')),
Firma_adi varchar(20) NOT NULL,
Il_kodu varchar(2) FOREIGN KEY REFERENCES Iller(Il_kodu),
Ilce_kodu varchar(5) FOREIGN KEY REFERENCES Ilceler(Ilce_kodu),
Firma_adres varchar(100) NOT NULL,
M_kodu varchar(6) FOREIGN KEY REFERENCES Musteri(M_kodu),
constraint pk_key_firmamus PRIMARY KEY (Firma_kodu)
)

Create table Arac_Satis(
Satis_id int identity,
Satis_kodu varchar(6) constraint ck_satiskodu check(Satis_kodu like('SK[0-9][0-9][0-9][0-9]')),
Model_kodu varchar(4) FOREIGN KEY REFERENCES Arac_Model(Model_kodu),
P_kodu varchar(5) FOREIGN KEY REFERENCES Personel(P_kodu),
M_kodu varchar(6) FOREIGN KEY REFERENCES Musteri(M_kodu),
Satis_tarih date constraint ck_satistarih check(Satis_tarih<= GETDATE()) NOT NULL,
Satis_Fiyat Money NOT NULL,
Plaka varchar(9) constraint ck_plaka check(Plaka like('[0-8][0-9]%[A-Z]%[0-9]')) NOT NULL,
constraint pk_key_aracsatis PRIMARY KEY (Satis_kodu),
constraint uk_aracsatis UNIQUE (Plaka)
)

----------------------------------------------- Araç satýþ bölümü bitti-------------------------------------------------------


----------------------------------------------- Servis bölümü -------------------------------------------------------

Create table Parca_Stok(
PStok_id int identity,
Parca_kodu varchar(6) constraint ck_parcakodu check(Parca_kodu like ('PAK[0-9][0-9][0-9]')),
Parca_adi varchar(25),
Stok_adet int,
Birim_fiyat money,
Aciklama varchar(100),
constraint pk_key_parcastok PRIMARY KEY (Parca_kodu)
)

select * from ýslem
Create table Servis(
S_id int identity,
S_kodu varchar(6) constraint ck_skodu check(S_kodu like ('SK[0-9][0-9][0-9][0-9]')),
M_kodu varchar(6) FOREIGN KEY REFERENCES Musteri(M_kodu),
Model_kodu varchar(4) FOREIGN KEY REFERENCES Arac_Model(Model_kodu),
P_kodu varchar(5) FOREIGN KEY REFERENCES Personel(P_kodu),
Arac_giriskm int NOT NULL,
Arac_cikiskm int constraint ck_arac_cikiskm check(Arac_cikiskm>=Arac_giriskm),
S_giris_tarih date NOT NULL,
S_cikis_tarih date constraint ck_svcikistarih check(S_cikis_tarih<=GETDATE()),
Plaka varchar(9) constraint ck_plaka_servis check(Plaka like('[0-8][0-9]%[A-Z]%[0-9]')) NOT NULL,
Servis_ucret money,
Durum bit default(0),
constraint pk_key_servis PRIMARY KEY (S_kodu),
constraint uk_servis UNIQUE (Plaka)
)

Create table Islem(
Islem_id int identity,
Islem_kodu varchar(6) constraint ck_islemkodu check(Islem_kodu like ('IK[0-9][0-9][0-9][0-9]')),
Islem varchar(200),
Parca_kodu varchar(6) FOREIGN KEY REFERENCES Parca_Stok(Parca_kodu),
Parca_adet int NOT NULL,
S_kodu varchar(6) FOREIGN KEY REFERENCES Servis(S_kodu),
Ucret money,
constraint pk_key_islem PRIMARY KEY (Islem_kodu)
)

Create table Arac_Stok(
AStok_id int identity,
Model_kodu varchar(4) FOREIGN KEY REFERENCES Arac_Model(Model_kodu),
Adet int NOT NULL,
Birim_alis_fiyat money NOT NULL,
OTV money NOT NULL,
KDV money NOT NULL,
Kar money NOT NULL,
Birim_toplam_Fiyat money NOT NULL,
constraint pk_key_aracstok PRIMARY KEY (Model_kodu),
)

																-------- SÝLÝNEN KAYITLARIN TABLOLARI --------------

-- Araç Serisi tablosu

Create table S_Arac_Serisi (
Seri_id int ,
Seri_kodu varchar(8) ,
Seri_adi varchar(20) ,
Cikis_yili date
)

-- Araç Þanzýman tablosu

Create Table S_Arac_Sanziman(
Sanziman_id int ,
Sanziman_kodu varchar(10) ,
Sanziman_adi varchar(8) ,
Ozellik varchar(80)
)

-- Donaným Paketleri tablosu

Create Table S_Donanim_Paket(
Dp_id int,
Dp_kodu varchar(4),
Dp_adi varchar(10),
Dp_fiyat money
)


-- Araç motor tablosu

Create table S_Arac_Motor(
AracM_id int,
AracM_kodu varchar(5),
Yakit_tipi varchar(8),
CC int ,
BG int ,
Yakit_tuketim float
)

-- Arac model tablosu

Create table S_Arac_Model(
Model_id int,
Model_kodu varchar(4),
Model_adi varchar(25),
Seri_kodu varchar(8),
AracM_kodu varchar(5),
Dp_kodu varchar(4),
Sanziman_kodu varchar(10),
Model_yili date,
Fiyat money
)
----------------------------------------------- ARAÇ OLUÞTURMA BOLUMU BÝTTÝ--------------------------------------------------



----------------------------------------------- ÇALIÞAN PERSONEL BOLUMU -----------------------------------------------------

-- iller tablosu

Create table S_Iller(
Il_id int,
Il_kodu varchar(2),
Il_adi varchar(15)

)

--ilçeler tablosu 

Create table S_Ilceler(
Ilce_id int,
Ilce_kodu varchar(5),
Ilce_adi varchar(15),
Il_kodu varchar(2)
)

-- Bölümler tablosu

Create table S_Bolumler(
Bol_id int,
Bol_kodu varchar(2),
Bol_adi varchar(15)
)

-- personel tablosu 
Create table S_Personel(
P_id int,
P_kodu varchar(5),
P_TCno varchar(11),
P_adi varchar(10),
P_soyadi varchar(25),
P_dog_tar date,
Il_kodu varchar(2),
Ilce_kodu varchar(5),
P_adres varchar(100),
P_maas money,
P_is_giristarih date,
P_is_cikistarih date,
Bol_kodu varchar(2)
)

----------------------------------------------- ÇALIÞAN PERSONEL BOLUMU BÝTTÝ------------------------------------------------




----------------------------------------------- PROGRAM GÝRÝÞÝ BOLUMU -------------------------------------------------------

-- Kullanýcý yetki tablosu 

Create table S_Kullanici_Yetki(
Yetki_id int,
Yetki_kodu varchar(3),
Yetki_adi varchar(30)
)

--Kullanýcý Tablosu

Create table S_Kullanici(
Kul_id int,
Yetki_kodu varchar(3),
Kullanici_adi varchar(11),
Kullanici_sifre varchar(12)
)


----------------------------------------------- PROGRAM GÝRÝÞÝ BOLUMU BÝTTÝ -------------------------------------------------------


----------------------------------------------- Araç satýþ bölümü -------------------------------------------------------

Create table S_Musteri_Turu(
Musteri_id int,
Musteri_turu_kodu varchar(3),
M_tur_adi varchar(15)
)

Create table S_Musteri(
M_id int,
M_kodu varchar(6),
M_TCno varchar(11),
M_adi varchar(15),
M_soyadi varchar(20),
M_tel varchar(13),
M_email varchar(35),
Il_kodu varchar(2),
Ilce_kodu varchar(5),
Adres varchar(100),
Musteri_turu_kodu varchar(3)
)

Create table S_Firma_Musteri(
Firma_id int,
Firma_kodu varchar(5),
Firma_adi varchar(20),
Il_kodu varchar(2),
Ilce_kodu varchar(5),
Firma_adres varchar(100),
M_kodu varchar(6)
)

Create table S_Arac_Satis(
Satis_id int,
Satis_kodu varchar(6),
Model_kodu varchar(4),
P_kodu varchar(5),
M_kodu varchar(6),
Satis_tarih date,
Satis_Fiyat Money,
Plaka varchar(9)
)

----------------------------------------------- Araç satýþ bölümü bitti-------------------------------------------------------


----------------------------------------------- Servis bölümü -------------------------------------------------------

Create table S_Parca_Stok(
PStok_id int,
Parca_kodu varchar(6),
Parca_adi varchar(25),
Stok_adet int,
Birim_fiyat money,
Aciklama varchar(100)
)

Create table S_Servis(
S_id int,
S_kodu varchar(6),
M_kodu varchar(6),
Model_kodu varchar(4),
P_kodu varchar(5),
Arac_giriskm int,
Arac_cikiskm int,
S_giris_tarih date,
S_cikis_tarih date,
Plaka varchar(9),
Servis_ucret money,
Durum bit

)

Create table S_Islem(
Islem_id int,
Islem_kodu varchar(6),
Islem varchar(200),
Parca_kodu varchar(6),
Parca_adet int,
S_kodu varchar(6),
Ucret money
)

Create table S_Arac_Stok(
AStok_id int,
Model_kodu varchar(4),
Adet int,
Birim_alis_fiyat money,
OTV money,
KDV money,
Kar money,
Birim_toplam_Fiyat money
)

