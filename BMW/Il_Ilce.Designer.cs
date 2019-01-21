namespace BMW
{
    partial class Il_Ilce
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
            this.grp_secim = new System.Windows.Forms.GroupBox();
            this.rd_dis = new System.Windows.Forms.RadioButton();
            this.rd_ic = new System.Windows.Forms.RadioButton();
            this.btn_d_aktar = new System.Windows.Forms.Button();
            this.btn_i_aktar = new System.Windows.Forms.Button();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.dtg_il_ilce = new System.Windows.Forms.DataGridView();
            this.rd_Ilce = new System.Windows.Forms.RadioButton();
            this.rd_Il = new System.Windows.Forms.RadioButton();
            this.btn_DosyaSec = new System.Windows.Forms.Button();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.DosyaSec = new System.Windows.Forms.OpenFileDialog();
            this.grp_secim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_il_ilce)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_secim
            // 
            this.grp_secim.Controls.Add(this.rd_dis);
            this.grp_secim.Controls.Add(this.rd_ic);
            this.grp_secim.Location = new System.Drawing.Point(122, 21);
            this.grp_secim.Name = "grp_secim";
            this.grp_secim.Size = new System.Drawing.Size(195, 100);
            this.grp_secim.TabIndex = 20;
            this.grp_secim.TabStop = false;
            this.grp_secim.Text = "Seçim";
            // 
            // rd_dis
            // 
            this.rd_dis.AutoSize = true;
            this.rd_dis.Location = new System.Drawing.Point(23, 57);
            this.rd_dis.Name = "rd_dis";
            this.rd_dis.Size = new System.Drawing.Size(95, 17);
            this.rd_dis.TabIndex = 10;
            this.rd_dis.TabStop = true;
            this.rd_dis.Text = "Dışa Veri Aktar";
            this.rd_dis.UseVisualStyleBackColor = true;
            this.rd_dis.CheckedChanged += new System.EventHandler(this.rd_dis_CheckedChanged_1);
            // 
            // rd_ic
            // 
            this.rd_ic.AutoSize = true;
            this.rd_ic.Location = new System.Drawing.Point(23, 31);
            this.rd_ic.Name = "rd_ic";
            this.rd_ic.Size = new System.Drawing.Size(89, 17);
            this.rd_ic.TabIndex = 9;
            this.rd_ic.TabStop = true;
            this.rd_ic.Text = "İçe Veri Aktar";
            this.rd_ic.UseVisualStyleBackColor = true;
            this.rd_ic.CheckedChanged += new System.EventHandler(this.rd_ic_CheckedChanged_1);
            // 
            // btn_d_aktar
            // 
            this.btn_d_aktar.Location = new System.Drawing.Point(175, 336);
            this.btn_d_aktar.Name = "btn_d_aktar";
            this.btn_d_aktar.Size = new System.Drawing.Size(143, 23);
            this.btn_d_aktar.TabIndex = 19;
            this.btn_d_aktar.Text = "Dışa Aktar";
            this.btn_d_aktar.UseVisualStyleBackColor = true;
            this.btn_d_aktar.Click += new System.EventHandler(this.btn_d_aktar_Click_1);
            // 
            // btn_i_aktar
            // 
            this.btn_i_aktar.Location = new System.Drawing.Point(16, 336);
            this.btn_i_aktar.Name = "btn_i_aktar";
            this.btn_i_aktar.Size = new System.Drawing.Size(130, 23);
            this.btn_i_aktar.TabIndex = 18;
            this.btn_i_aktar.Text = "İçe Aktar";
            this.btn_i_aktar.UseVisualStyleBackColor = true;
            this.btn_i_aktar.Click += new System.EventHandler(this.btn_i_aktar_Click);
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(232, 128);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(75, 23);
            this.btn_Goster.TabIndex = 17;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click_1);
            // 
            // dtg_il_ilce
            // 
            this.dtg_il_ilce.AllowUserToAddRows = false;
            this.dtg_il_ilce.AllowUserToDeleteRows = false;
            this.dtg_il_ilce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_il_ilce.Location = new System.Drawing.Point(16, 159);
            this.dtg_il_ilce.Name = "dtg_il_ilce";
            this.dtg_il_ilce.ReadOnly = true;
            this.dtg_il_ilce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_il_ilce.Size = new System.Drawing.Size(301, 155);
            this.dtg_il_ilce.TabIndex = 16;
            // 
            // rd_Ilce
            // 
            this.rd_Ilce.AutoSize = true;
            this.rd_Ilce.Location = new System.Drawing.Point(175, 130);
            this.rd_Ilce.Name = "rd_Ilce";
            this.rd_Ilce.Size = new System.Drawing.Size(42, 17);
            this.rd_Ilce.TabIndex = 15;
            this.rd_Ilce.TabStop = true;
            this.rd_Ilce.Text = "İlce";
            this.rd_Ilce.UseVisualStyleBackColor = true;
            // 
            // rd_Il
            // 
            this.rd_Il.AutoSize = true;
            this.rd_Il.Location = new System.Drawing.Point(122, 130);
            this.rd_Il.Name = "rd_Il";
            this.rd_Il.Size = new System.Drawing.Size(30, 17);
            this.rd_Il.TabIndex = 14;
            this.rd_Il.TabStop = true;
            this.rd_Il.Text = "İl";
            this.rd_Il.UseVisualStyleBackColor = true;
            // 
            // btn_DosyaSec
            // 
            this.btn_DosyaSec.Location = new System.Drawing.Point(22, 124);
            this.btn_DosyaSec.Name = "btn_DosyaSec";
            this.btn_DosyaSec.Size = new System.Drawing.Size(82, 29);
            this.btn_DosyaSec.TabIndex = 13;
            this.btn_DosyaSec.Text = "Dosya Seç";
            this.btn_DosyaSec.UseVisualStyleBackColor = true;
            this.btn_DosyaSec.Click += new System.EventHandler(this.btn_DosyaSec_Click_1);
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(16, 24);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(61, 43);
            this.btn_GeriDon.TabIndex = 12;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click_1);
            // 
            // DosyaSec
            // 
            this.DosyaSec.FileName = "il_ilce.xls";
            // 
            // Il_Ilce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(335, 379);
            this.Controls.Add(this.grp_secim);
            this.Controls.Add(this.btn_d_aktar);
            this.Controls.Add(this.btn_i_aktar);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.dtg_il_ilce);
            this.Controls.Add(this.rd_Ilce);
            this.Controls.Add(this.rd_Il);
            this.Controls.Add(this.btn_DosyaSec);
            this.Controls.Add(this.btn_GeriDon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Il_Ilce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İl ve İlçe Tanımlama";
            this.Load += new System.EventHandler(this.Il_Ilce_Load);
            this.grp_secim.ResumeLayout(false);
            this.grp_secim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_il_ilce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_secim;
        private System.Windows.Forms.RadioButton rd_dis;
        private System.Windows.Forms.RadioButton rd_ic;
        private System.Windows.Forms.Button btn_d_aktar;
        private System.Windows.Forms.Button btn_i_aktar;
        private System.Windows.Forms.Button btn_Goster;
        private System.Windows.Forms.DataGridView dtg_il_ilce;
        private System.Windows.Forms.RadioButton rd_Ilce;
        private System.Windows.Forms.RadioButton rd_Il;
        private System.Windows.Forms.Button btn_DosyaSec;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.OpenFileDialog DosyaSec;
    }
}