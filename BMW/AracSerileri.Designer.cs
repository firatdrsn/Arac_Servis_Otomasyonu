namespace BMW
{
    partial class AracSerileri
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
            this.grp_Guncelle = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dt_g_CikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_SeriAd = new System.Windows.Forms.TextBox();
            this.txt_SeriKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_Ekle = new System.Windows.Forms.RadioButton();
            this.rd_Guncelle = new System.Windows.Forms.RadioButton();
            this.grp_Ekle = new System.Windows.Forms.GroupBox();
            this.chk_Constraint = new System.Windows.Forms.CheckBox();
            this.dt_e_CikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_arac_serisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.grp_Guncelle.SuspendLayout();
            this.grp_Ekle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Guncelle
            // 
            this.grp_Guncelle.Controls.Add(this.btn_Guncelle);
            this.grp_Guncelle.Controls.Add(this.dt_g_CikisTarihi);
            this.grp_Guncelle.Controls.Add(this.txt_SeriAd);
            this.grp_Guncelle.Controls.Add(this.txt_SeriKod);
            this.grp_Guncelle.Controls.Add(this.label4);
            this.grp_Guncelle.Controls.Add(this.label3);
            this.grp_Guncelle.Controls.Add(this.label2);
            this.grp_Guncelle.Location = new System.Drawing.Point(8, 179);
            this.grp_Guncelle.Name = "grp_Guncelle";
            this.grp_Guncelle.Size = new System.Drawing.Size(320, 116);
            this.grp_Guncelle.TabIndex = 30;
            this.grp_Guncelle.TabStop = false;
            this.grp_Guncelle.Text = "Güncelle";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Guncelle.Location = new System.Drawing.Point(124, 82);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 26;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            // 
            // dt_g_CikisTarihi
            // 
            this.dt_g_CikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_g_CikisTarihi.Location = new System.Drawing.Point(218, 46);
            this.dt_g_CikisTarihi.Name = "dt_g_CikisTarihi";
            this.dt_g_CikisTarihi.Size = new System.Drawing.Size(89, 20);
            this.dt_g_CikisTarihi.TabIndex = 25;
            // 
            // txt_SeriAd
            // 
            this.txt_SeriAd.Location = new System.Drawing.Point(115, 46);
            this.txt_SeriAd.Name = "txt_SeriAd";
            this.txt_SeriAd.Size = new System.Drawing.Size(100, 20);
            this.txt_SeriAd.TabIndex = 24;
            // 
            // txt_SeriKod
            // 
            this.txt_SeriKod.Location = new System.Drawing.Point(9, 46);
            this.txt_SeriKod.MaxLength = 8;
            this.txt_SeriKod.Name = "txt_SeriKod";
            this.txt_SeriKod.Size = new System.Drawing.Size(100, 20);
            this.txt_SeriKod.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(221, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seri Kodu";
            // 
            // rd_Ekle
            // 
            this.rd_Ekle.AutoSize = true;
            this.rd_Ekle.Location = new System.Drawing.Point(258, 109);
            this.rd_Ekle.Name = "rd_Ekle";
            this.rd_Ekle.Size = new System.Drawing.Size(46, 17);
            this.rd_Ekle.TabIndex = 29;
            this.rd_Ekle.TabStop = true;
            this.rd_Ekle.Text = "Ekle";
            this.rd_Ekle.UseVisualStyleBackColor = true;
            this.rd_Ekle.CheckedChanged += new System.EventHandler(this.rd_Ekle_CheckedChanged_1);
            // 
            // rd_Guncelle
            // 
            this.rd_Guncelle.AutoSize = true;
            this.rd_Guncelle.Location = new System.Drawing.Point(165, 108);
            this.rd_Guncelle.Name = "rd_Guncelle";
            this.rd_Guncelle.Size = new System.Drawing.Size(67, 17);
            this.rd_Guncelle.TabIndex = 28;
            this.rd_Guncelle.TabStop = true;
            this.rd_Guncelle.Text = "Güncelle";
            this.rd_Guncelle.UseVisualStyleBackColor = true;
            this.rd_Guncelle.CheckedChanged += new System.EventHandler(this.rd_Guncelle_CheckedChanged_1);
            // 
            // grp_Ekle
            // 
            this.grp_Ekle.Controls.Add(this.chk_Constraint);
            this.grp_Ekle.Controls.Add(this.dt_e_CikisTarihi);
            this.grp_Ekle.Controls.Add(this.label7);
            this.grp_Ekle.Controls.Add(this.txt_Ad);
            this.grp_Ekle.Controls.Add(this.label6);
            this.grp_Ekle.Controls.Add(this.btn_Kaydet);
            this.grp_Ekle.Controls.Add(this.txt_Kod);
            this.grp_Ekle.Controls.Add(this.label5);
            this.grp_Ekle.Location = new System.Drawing.Point(8, 301);
            this.grp_Ekle.Name = "grp_Ekle";
            this.grp_Ekle.Size = new System.Drawing.Size(320, 110);
            this.grp_Ekle.TabIndex = 27;
            this.grp_Ekle.TabStop = false;
            this.grp_Ekle.Text = "Yeni Seri Ekle";
            // 
            // chk_Constraint
            // 
            this.chk_Constraint.AutoSize = true;
            this.chk_Constraint.Location = new System.Drawing.Point(200, 28);
            this.chk_Constraint.Name = "chk_Constraint";
            this.chk_Constraint.Size = new System.Drawing.Size(73, 17);
            this.chk_Constraint.TabIndex = 24;
            this.chk_Constraint.Text = "Constraint";
            this.chk_Constraint.UseVisualStyleBackColor = true;
            this.chk_Constraint.CheckedChanged += new System.EventHandler(this.chk_Constraint_CheckedChanged_1);
            // 
            // dt_e_CikisTarihi
            // 
            this.dt_e_CikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_e_CikisTarihi.Location = new System.Drawing.Point(105, 76);
            this.dt_e_CikisTarihi.Name = "dt_e_CikisTarihi";
            this.dt_e_CikisTarihi.Size = new System.Drawing.Size(89, 20);
            this.dt_e_CikisTarihi.TabIndex = 23;
            this.dt_e_CikisTarihi.ValueChanged += new System.EventHandler(this.dt_e_CikisTarihi_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(94, 50);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ad.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seri Adı:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(214, 51);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 19;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(94, 24);
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.Size = new System.Drawing.Size(100, 20);
            this.txt_Kod.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Seri Kodu:";
            // 
            // cmb_arac_serisi
            // 
            this.cmb_arac_serisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_arac_serisi.FormattingEnabled = true;
            this.cmb_arac_serisi.Location = new System.Drawing.Point(18, 108);
            this.cmb_arac_serisi.Name = "cmb_arac_serisi";
            this.cmb_arac_serisi.Size = new System.Drawing.Size(121, 21);
            this.cmb_arac_serisi.TabIndex = 26;
            this.cmb_arac_serisi.SelectedIndexChanged += new System.EventHandler(this.cmb_arac_serisi_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kayıtlı Araç Serileri";
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GeriDon.Location = new System.Drawing.Point(15, 29);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(61, 43);
            this.btn_GeriDon.TabIndex = 24;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click_1);
            // 
            // AracSerileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 440);
            this.Controls.Add(this.grp_Guncelle);
            this.Controls.Add(this.rd_Ekle);
            this.Controls.Add(this.rd_Guncelle);
            this.Controls.Add(this.grp_Ekle);
            this.Controls.Add(this.cmb_arac_serisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GeriDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AracSerileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Serileri";
            this.Load += new System.EventHandler(this.AracSerileri_Load);
            this.grp_Guncelle.ResumeLayout(false);
            this.grp_Guncelle.PerformLayout();
            this.grp_Ekle.ResumeLayout(false);
            this.grp_Ekle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Guncelle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DateTimePicker dt_g_CikisTarihi;
        private System.Windows.Forms.TextBox txt_SeriAd;
        private System.Windows.Forms.TextBox txt_SeriKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_Ekle;
        private System.Windows.Forms.RadioButton rd_Guncelle;
        private System.Windows.Forms.GroupBox grp_Ekle;
        private System.Windows.Forms.CheckBox chk_Constraint;
        private System.Windows.Forms.DateTimePicker dt_e_CikisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_arac_serisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GeriDon;
    }
}