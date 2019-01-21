namespace BMW
{
    partial class A_Kullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rd_KulSil = new System.Windows.Forms.RadioButton();
            this.rd_Kayitli = new System.Windows.Forms.RadioButton();
            this.rd_Yeni = new System.Windows.Forms.RadioButton();
            this.grp_Kullanici = new System.Windows.Forms.GroupBox();
            this.btn_SifreKural = new System.Windows.Forms.Button();
            this.dtg_KulGoster = new System.Windows.Forms.DataGridView();
            this.btn_YeniKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_TcNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Yetki = new System.Windows.Forms.ComboBox();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.grp_Kullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KulGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_KulSil
            // 
            this.rd_KulSil.AutoSize = true;
            this.rd_KulSil.Location = new System.Drawing.Point(354, 84);
            this.rd_KulSil.Name = "rd_KulSil";
            this.rd_KulSil.Size = new System.Drawing.Size(78, 17);
            this.rd_KulSil.TabIndex = 10;
            this.rd_KulSil.TabStop = true;
            this.rd_KulSil.Text = "Kullanıcı Sil";
            this.rd_KulSil.UseVisualStyleBackColor = true;
            this.rd_KulSil.CheckedChanged += new System.EventHandler(this.rd_KulSil_CheckedChanged_1);
            // 
            // rd_Kayitli
            // 
            this.rd_Kayitli.AutoSize = true;
            this.rd_Kayitli.Location = new System.Drawing.Point(130, 84);
            this.rd_Kayitli.Name = "rd_Kayitli";
            this.rd_Kayitli.Size = new System.Drawing.Size(94, 17);
            this.rd_Kayitli.TabIndex = 9;
            this.rd_Kayitli.TabStop = true;
            this.rd_Kayitli.Text = "Kayıtlı Kullanıcı";
            this.rd_Kayitli.UseVisualStyleBackColor = true;
            this.rd_Kayitli.CheckedChanged += new System.EventHandler(this.rd_Kayitli_CheckedChanged_1);
            // 
            // rd_Yeni
            // 
            this.rd_Yeni.AutoSize = true;
            this.rd_Yeni.Location = new System.Drawing.Point(244, 84);
            this.rd_Yeni.Name = "rd_Yeni";
            this.rd_Yeni.Size = new System.Drawing.Size(88, 17);
            this.rd_Yeni.TabIndex = 8;
            this.rd_Yeni.TabStop = true;
            this.rd_Yeni.Text = "Yeni Kullanıcı";
            this.rd_Yeni.UseVisualStyleBackColor = true;
            this.rd_Yeni.CheckedChanged += new System.EventHandler(this.rd_Yeni_CheckedChanged_1);
            // 
            // grp_Kullanici
            // 
            this.grp_Kullanici.Controls.Add(this.btn_SifreKural);
            this.grp_Kullanici.Controls.Add(this.dtg_KulGoster);
            this.grp_Kullanici.Controls.Add(this.btn_YeniKaydet);
            this.grp_Kullanici.Controls.Add(this.label3);
            this.grp_Kullanici.Controls.Add(this.txt_Sifre);
            this.grp_Kullanici.Controls.Add(this.btn_Ara);
            this.grp_Kullanici.Controls.Add(this.txt_TcNO);
            this.grp_Kullanici.Controls.Add(this.label2);
            this.grp_Kullanici.Controls.Add(this.label1);
            this.grp_Kullanici.Controls.Add(this.cmb_Yetki);
            this.grp_Kullanici.Location = new System.Drawing.Point(18, 124);
            this.grp_Kullanici.Name = "grp_Kullanici";
            this.grp_Kullanici.Size = new System.Drawing.Size(509, 204);
            this.grp_Kullanici.TabIndex = 7;
            this.grp_Kullanici.TabStop = false;
            this.grp_Kullanici.Text = "Kullanıcı Tanımla";
            // 
            // btn_SifreKural
            // 
            this.btn_SifreKural.Location = new System.Drawing.Point(332, 138);
            this.btn_SifreKural.Name = "btn_SifreKural";
            this.btn_SifreKural.Size = new System.Drawing.Size(24, 24);
            this.btn_SifreKural.TabIndex = 10;
            this.btn_SifreKural.Text = "?";
            this.btn_SifreKural.UseVisualStyleBackColor = true;
            this.btn_SifreKural.Click += new System.EventHandler(this.btn_SifreKural_Click_1);
            // 
            // dtg_KulGoster
            // 
            this.dtg_KulGoster.AllowUserToAddRows = false;
            this.dtg_KulGoster.AllowUserToDeleteRows = false;
            this.dtg_KulGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_KulGoster.Location = new System.Drawing.Point(165, 19);
            this.dtg_KulGoster.Name = "dtg_KulGoster";
            this.dtg_KulGoster.ReadOnly = true;
            this.dtg_KulGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_KulGoster.Size = new System.Drawing.Size(335, 113);
            this.dtg_KulGoster.TabIndex = 9;
            // 
            // btn_YeniKaydet
            // 
            this.btn_YeniKaydet.Location = new System.Drawing.Point(366, 138);
            this.btn_YeniKaydet.Name = "btn_YeniKaydet";
            this.btn_YeniKaydet.Size = new System.Drawing.Size(134, 23);
            this.btn_YeniKaydet.TabIndex = 8;
            this.btn_YeniKaydet.Text = "Kaydet";
            this.btn_YeniKaydet.UseVisualStyleBackColor = true;
            this.btn_YeniKaydet.Click += new System.EventHandler(this.btn_YeniKaydet_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(199, 141);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(127, 20);
            this.txt_Sifre.TabIndex = 6;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(18, 72);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(75, 23);
            this.btn_Ara.TabIndex = 4;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click_1);
            // 
            // txt_TcNO
            // 
            this.txt_TcNO.Location = new System.Drawing.Point(6, 46);
            this.txt_TcNO.Name = "txt_TcNO";
            this.txt_TcNO.Size = new System.Drawing.Size(121, 20);
            this.txt_TcNO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel TC NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yetki";
            // 
            // cmb_Yetki
            // 
            this.cmb_Yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Yetki.FormattingEnabled = true;
            this.cmb_Yetki.Location = new System.Drawing.Point(6, 140);
            this.cmb_Yetki.Name = "cmb_Yetki";
            this.cmb_Yetki.Size = new System.Drawing.Size(121, 21);
            this.cmb_Yetki.TabIndex = 0;
            this.cmb_Yetki.SelectedIndexChanged += new System.EventHandler(this.cmb_Yetki_SelectedIndexChanged_1);
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(13, 21);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(61, 43);
            this.btn_GeriDon.TabIndex = 6;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // A_Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(540, 350);
            this.Controls.Add(this.rd_KulSil);
            this.Controls.Add(this.rd_Kayitli);
            this.Controls.Add(this.rd_Yeni);
            this.Controls.Add(this.grp_Kullanici);
            this.Controls.Add(this.btn_GeriDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "A_Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Tanımlama";
            this.Load += new System.EventHandler(this.A_Kullanici_Load);
            this.grp_Kullanici.ResumeLayout(false);
            this.grp_Kullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KulGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_KulSil;
        private System.Windows.Forms.RadioButton rd_Kayitli;
        private System.Windows.Forms.RadioButton rd_Yeni;
        private System.Windows.Forms.GroupBox grp_Kullanici;
        private System.Windows.Forms.Button btn_SifreKural;
        private System.Windows.Forms.DataGridView dtg_KulGoster;
        private System.Windows.Forms.Button btn_YeniKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_TcNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Yetki;
        private System.Windows.Forms.Button btn_GeriDon;
    }
}