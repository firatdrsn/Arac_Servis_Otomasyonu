namespace BMW
{
    partial class Arac_Motor
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
            this.grp_Ekle = new System.Windows.Forms.GroupBox();
            this.cmb_YakitTipi = new System.Windows.Forms.ComboBox();
            this.txt_Tuketimi = new System.Windows.Forms.TextBox();
            this.txt_BeygirGucu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_KodBilgi = new System.Windows.Forms.Button();
            this.txt_MotorHacmi = new System.Windows.Forms.TextBox();
            this.txt_MotorKodu = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.Label();
            this.Yakit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_Ekle = new System.Windows.Forms.RadioButton();
            this.rd_Guncelle = new System.Windows.Forms.RadioButton();
            this.cmb_AracMotor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Guncelle = new System.Windows.Forms.GroupBox();
            this.cmb_YakitTip = new System.Windows.Forms.ComboBox();
            this.txt_Tuketim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_BG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Bilgi = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txt_CC = new System.Windows.Forms.TextBox();
            this.txt_MotorKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.grp_Ekle.SuspendLayout();
            this.grp_Guncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Ekle
            // 
            this.grp_Ekle.Controls.Add(this.cmb_YakitTipi);
            this.grp_Ekle.Controls.Add(this.txt_Tuketimi);
            this.grp_Ekle.Controls.Add(this.txt_BeygirGucu);
            this.grp_Ekle.Controls.Add(this.label7);
            this.grp_Ekle.Controls.Add(this.label10);
            this.grp_Ekle.Controls.Add(this.btn_Kaydet);
            this.grp_Ekle.Controls.Add(this.btn_KodBilgi);
            this.grp_Ekle.Controls.Add(this.txt_MotorHacmi);
            this.grp_Ekle.Controls.Add(this.txt_MotorKodu);
            this.grp_Ekle.Controls.Add(this.cc);
            this.grp_Ekle.Controls.Add(this.Yakit);
            this.grp_Ekle.Controls.Add(this.label5);
            this.grp_Ekle.Location = new System.Drawing.Point(20, 289);
            this.grp_Ekle.Name = "grp_Ekle";
            this.grp_Ekle.Size = new System.Drawing.Size(640, 130);
            this.grp_Ekle.TabIndex = 46;
            this.grp_Ekle.TabStop = false;
            this.grp_Ekle.Text = "Yeni Motor Ekle";
            // 
            // cmb_YakitTipi
            // 
            this.cmb_YakitTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_YakitTipi.FormattingEnabled = true;
            this.cmb_YakitTipi.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "ELEKTRİK"});
            this.cmb_YakitTipi.Location = new System.Drawing.Point(137, 60);
            this.cmb_YakitTipi.Name = "cmb_YakitTipi";
            this.cmb_YakitTipi.Size = new System.Drawing.Size(108, 21);
            this.cmb_YakitTipi.TabIndex = 15;
            // 
            // txt_Tuketimi
            // 
            this.txt_Tuketimi.Location = new System.Drawing.Point(430, 58);
            this.txt_Tuketimi.MaxLength = 10;
            this.txt_Tuketimi.Name = "txt_Tuketimi";
            this.txt_Tuketimi.Size = new System.Drawing.Size(107, 20);
            this.txt_Tuketimi.TabIndex = 14;
            // 
            // txt_BeygirGucu
            // 
            this.txt_BeygirGucu.Location = new System.Drawing.Point(430, 32);
            this.txt_BeygirGucu.MaxLength = 4;
            this.txt_BeygirGucu.Name = "txt_BeygirGucu";
            this.txt_BeygirGucu.Size = new System.Drawing.Size(107, 20);
            this.txt_BeygirGucu.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(293, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tüketim(100 km de)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(293, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Beygir Gücü:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(447, 90);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click_1);
            // 
            // btn_KodBilgi
            // 
            this.btn_KodBilgi.Location = new System.Drawing.Point(250, 32);
            this.btn_KodBilgi.Name = "btn_KodBilgi";
            this.btn_KodBilgi.Size = new System.Drawing.Size(27, 19);
            this.btn_KodBilgi.TabIndex = 8;
            this.btn_KodBilgi.Text = "?";
            this.btn_KodBilgi.UseVisualStyleBackColor = true;
            this.btn_KodBilgi.Click += new System.EventHandler(this.btn_KodBilgi_Click_1);
            // 
            // txt_MotorHacmi
            // 
            this.txt_MotorHacmi.Location = new System.Drawing.Point(138, 89);
            this.txt_MotorHacmi.Name = "txt_MotorHacmi";
            this.txt_MotorHacmi.Size = new System.Drawing.Size(107, 20);
            this.txt_MotorHacmi.TabIndex = 5;
            // 
            // txt_MotorKodu
            // 
            this.txt_MotorKodu.Location = new System.Drawing.Point(137, 32);
            this.txt_MotorKodu.MaxLength = 5;
            this.txt_MotorKodu.Name = "txt_MotorKodu";
            this.txt_MotorKodu.Size = new System.Drawing.Size(107, 20);
            this.txt_MotorKodu.TabIndex = 3;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cc.Location = new System.Drawing.Point(15, 90);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(121, 15);
            this.cc.TabIndex = 2;
            this.cc.Text = "Motor Hacmi(CC):";
            // 
            // Yakit
            // 
            this.Yakit.AutoSize = true;
            this.Yakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakit.Location = new System.Drawing.Point(15, 61);
            this.Yakit.Name = "Yakit";
            this.Yakit.Size = new System.Drawing.Size(70, 15);
            this.Yakit.TabIndex = 1;
            this.Yakit.Text = "Yakıt Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Motor Kodu:";
            // 
            // rd_Ekle
            // 
            this.rd_Ekle.AutoSize = true;
            this.rd_Ekle.Location = new System.Drawing.Point(270, 106);
            this.rd_Ekle.Name = "rd_Ekle";
            this.rd_Ekle.Size = new System.Drawing.Size(46, 17);
            this.rd_Ekle.TabIndex = 45;
            this.rd_Ekle.TabStop = true;
            this.rd_Ekle.Text = "Ekle";
            this.rd_Ekle.UseVisualStyleBackColor = true;
            this.rd_Ekle.CheckedChanged += new System.EventHandler(this.rd_Ekle_CheckedChanged_1);
            // 
            // rd_Guncelle
            // 
            this.rd_Guncelle.AutoSize = true;
            this.rd_Guncelle.Location = new System.Drawing.Point(170, 106);
            this.rd_Guncelle.Name = "rd_Guncelle";
            this.rd_Guncelle.Size = new System.Drawing.Size(67, 17);
            this.rd_Guncelle.TabIndex = 44;
            this.rd_Guncelle.TabStop = true;
            this.rd_Guncelle.Text = "Güncelle";
            this.rd_Guncelle.UseVisualStyleBackColor = true;
            this.rd_Guncelle.CheckedChanged += new System.EventHandler(this.rd_Guncelle_CheckedChanged_1);
            // 
            // cmb_AracMotor
            // 
            this.cmb_AracMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AracMotor.FormattingEnabled = true;
            this.cmb_AracMotor.Location = new System.Drawing.Point(26, 106);
            this.cmb_AracMotor.Name = "cmb_AracMotor";
            this.cmb_AracMotor.Size = new System.Drawing.Size(121, 21);
            this.cmb_AracMotor.TabIndex = 43;
            this.cmb_AracMotor.SelectedIndexChanged += new System.EventHandler(this.cmb_AracMotor_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kayıtlı Araç Motorları";
            // 
            // grp_Guncelle
            // 
            this.grp_Guncelle.Controls.Add(this.cmb_YakitTip);
            this.grp_Guncelle.Controls.Add(this.txt_Tuketim);
            this.grp_Guncelle.Controls.Add(this.label9);
            this.grp_Guncelle.Controls.Add(this.txt_BG);
            this.grp_Guncelle.Controls.Add(this.label8);
            this.grp_Guncelle.Controls.Add(this.btn_Bilgi);
            this.grp_Guncelle.Controls.Add(this.btn_Guncelle);
            this.grp_Guncelle.Controls.Add(this.txt_CC);
            this.grp_Guncelle.Controls.Add(this.txt_MotorKod);
            this.grp_Guncelle.Controls.Add(this.label4);
            this.grp_Guncelle.Controls.Add(this.label3);
            this.grp_Guncelle.Controls.Add(this.label2);
            this.grp_Guncelle.Location = new System.Drawing.Point(20, 154);
            this.grp_Guncelle.Name = "grp_Guncelle";
            this.grp_Guncelle.Size = new System.Drawing.Size(640, 118);
            this.grp_Guncelle.TabIndex = 41;
            this.grp_Guncelle.TabStop = false;
            this.grp_Guncelle.Text = "Güncelle";
            // 
            // cmb_YakitTip
            // 
            this.cmb_YakitTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_YakitTip.FormattingEnabled = true;
            this.cmb_YakitTip.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "ELEKTRİK"});
            this.cmb_YakitTip.Location = new System.Drawing.Point(121, 45);
            this.cmb_YakitTip.Name = "cmb_YakitTip";
            this.cmb_YakitTip.Size = new System.Drawing.Size(108, 21);
            this.cmb_YakitTip.TabIndex = 16;
            this.cmb_YakitTip.SelectedIndexChanged += new System.EventHandler(this.cmb_YakitTip_SelectedIndexChanged);
            // 
            // txt_Tuketim
            // 
            this.txt_Tuketim.Location = new System.Drawing.Point(492, 45);
            this.txt_Tuketim.Name = "txt_Tuketim";
            this.txt_Tuketim.Size = new System.Drawing.Size(100, 20);
            this.txt_Tuketim.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(476, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tüketim(100 km de)";
            // 
            // txt_BG
            // 
            this.txt_BG.Location = new System.Drawing.Point(358, 45);
            this.txt_BG.Name = "txt_BG";
            this.txt_BG.Size = new System.Drawing.Size(100, 20);
            this.txt_BG.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(367, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Beygir Gücü";
            // 
            // btn_Bilgi
            // 
            this.btn_Bilgi.Location = new System.Drawing.Point(43, 71);
            this.btn_Bilgi.Name = "btn_Bilgi";
            this.btn_Bilgi.Size = new System.Drawing.Size(27, 19);
            this.btn_Bilgi.TabIndex = 7;
            this.btn_Bilgi.Text = "?";
            this.btn_Bilgi.UseVisualStyleBackColor = true;
            this.btn_Bilgi.Click += new System.EventHandler(this.btn_Bilgi_Click_1);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(293, 89);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 6;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            // 
            // txt_CC
            // 
            this.txt_CC.Location = new System.Drawing.Point(235, 45);
            this.txt_CC.Name = "txt_CC";
            this.txt_CC.Size = new System.Drawing.Size(100, 20);
            this.txt_CC.TabIndex = 5;
            // 
            // txt_MotorKod
            // 
            this.txt_MotorKod.Location = new System.Drawing.Point(6, 45);
            this.txt_MotorKod.MaxLength = 5;
            this.txt_MotorKod.Name = "txt_MotorKod";
            this.txt_MotorKod.Size = new System.Drawing.Size(100, 20);
            this.txt_MotorKod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(232, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CC(Motor Hacmi)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(142, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yakıt Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Motor Kodu";
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(20, 12);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(61, 43);
            this.btn_GeriDon.TabIndex = 40;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click_1);
            // 
            // Arac_Motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 431);
            this.Controls.Add(this.grp_Ekle);
            this.Controls.Add(this.rd_Ekle);
            this.Controls.Add(this.rd_Guncelle);
            this.Controls.Add(this.cmb_AracMotor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_Guncelle);
            this.Controls.Add(this.btn_GeriDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Arac_Motor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Motor";
            this.Load += new System.EventHandler(this.Arac_Motor_Load);
            this.grp_Ekle.ResumeLayout(false);
            this.grp_Ekle.PerformLayout();
            this.grp_Guncelle.ResumeLayout(false);
            this.grp_Guncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Ekle;
        private System.Windows.Forms.ComboBox cmb_YakitTipi;
        private System.Windows.Forms.TextBox txt_Tuketimi;
        private System.Windows.Forms.TextBox txt_BeygirGucu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_KodBilgi;
        private System.Windows.Forms.TextBox txt_MotorHacmi;
        private System.Windows.Forms.TextBox txt_MotorKodu;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label Yakit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_Ekle;
        private System.Windows.Forms.RadioButton rd_Guncelle;
        private System.Windows.Forms.ComboBox cmb_AracMotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Guncelle;
        private System.Windows.Forms.ComboBox cmb_YakitTip;
        private System.Windows.Forms.TextBox txt_Tuketim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_BG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Bilgi;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox txt_CC;
        private System.Windows.Forms.TextBox txt_MotorKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GeriDon;
    }
}