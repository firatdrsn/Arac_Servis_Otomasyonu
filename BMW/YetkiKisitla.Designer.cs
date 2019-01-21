namespace BMW
{
    partial class YetkiKisitla
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
            this.chk_select = new System.Windows.Forms.CheckBox();
            this.chk_insert = new System.Windows.Forms.CheckBox();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.btn_yetkiver = new System.Windows.Forms.Button();
            this.cmb_tabloadlari = new System.Windows.Forms.ComboBox();
            this.lbl_yetkikodu = new System.Windows.Forms.Label();
            this.cmb_Kullanici = new System.Windows.Forms.ComboBox();
            this.dtg_Goster = new System.Windows.Forms.DataGridView();
            this.rd_YetkiTanimla = new System.Windows.Forms.RadioButton();
            this.rd_YetkileriGoster = new System.Windows.Forms.RadioButton();
            this.pnl_Yetkiler = new System.Windows.Forms.Panel();
            this.pnl_kullanicilar = new System.Windows.Forms.Panel();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Goster)).BeginInit();
            this.pnl_Yetkiler.SuspendLayout();
            this.pnl_kullanicilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_select
            // 
            this.chk_select.AutoSize = true;
            this.chk_select.Location = new System.Drawing.Point(5, 22);
            this.chk_select.Name = "chk_select";
            this.chk_select.Size = new System.Drawing.Size(56, 17);
            this.chk_select.TabIndex = 1;
            this.chk_select.Text = "Select";
            this.chk_select.UseVisualStyleBackColor = true;
            // 
            // chk_insert
            // 
            this.chk_insert.AutoSize = true;
            this.chk_insert.Location = new System.Drawing.Point(67, 22);
            this.chk_insert.Name = "chk_insert";
            this.chk_insert.Size = new System.Drawing.Size(52, 17);
            this.chk_insert.TabIndex = 2;
            this.chk_insert.Text = "Insert";
            this.chk_insert.UseVisualStyleBackColor = true;
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Location = new System.Drawing.Point(125, 22);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(61, 17);
            this.chk_update.TabIndex = 3;
            this.chk_update.Text = "Update";
            this.chk_update.UseVisualStyleBackColor = true;
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Location = new System.Drawing.Point(192, 22);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(57, 17);
            this.chk_delete.TabIndex = 4;
            this.chk_delete.Text = "Delete";
            this.chk_delete.UseVisualStyleBackColor = true;
            // 
            // btn_yetkiver
            // 
            this.btn_yetkiver.Location = new System.Drawing.Point(281, 265);
            this.btn_yetkiver.Name = "btn_yetkiver";
            this.btn_yetkiver.Size = new System.Drawing.Size(119, 23);
            this.btn_yetkiver.TabIndex = 5;
            this.btn_yetkiver.Text = "Yetkileri Ver";
            this.btn_yetkiver.UseVisualStyleBackColor = true;
            this.btn_yetkiver.Click += new System.EventHandler(this.yetkiver_Click);
            // 
            // cmb_tabloadlari
            // 
            this.cmb_tabloadlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tabloadlari.FormattingEnabled = true;
            this.cmb_tabloadlari.Location = new System.Drawing.Point(279, 20);
            this.cmb_tabloadlari.Name = "cmb_tabloadlari";
            this.cmb_tabloadlari.Size = new System.Drawing.Size(147, 21);
            this.cmb_tabloadlari.TabIndex = 7;
            // 
            // lbl_yetkikodu
            // 
            this.lbl_yetkikodu.AutoSize = true;
            this.lbl_yetkikodu.Location = new System.Drawing.Point(457, 20);
            this.lbl_yetkikodu.Name = "lbl_yetkikodu";
            this.lbl_yetkikodu.Size = new System.Drawing.Size(35, 13);
            this.lbl_yetkikodu.TabIndex = 6;
            this.lbl_yetkikodu.Text = "label1";
            this.lbl_yetkikodu.Visible = false;
            // 
            // cmb_Kullanici
            // 
            this.cmb_Kullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kullanici.FormattingEnabled = true;
            this.cmb_Kullanici.Location = new System.Drawing.Point(13, 20);
            this.cmb_Kullanici.Name = "cmb_Kullanici";
            this.cmb_Kullanici.Size = new System.Drawing.Size(121, 21);
            this.cmb_Kullanici.TabIndex = 8;
            this.cmb_Kullanici.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtg_Goster
            // 
            this.dtg_Goster.AllowUserToAddRows = false;
            this.dtg_Goster.AllowUserToDeleteRows = false;
            this.dtg_Goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Goster.Location = new System.Drawing.Point(35, 12);
            this.dtg_Goster.Name = "dtg_Goster";
            this.dtg_Goster.ReadOnly = true;
            this.dtg_Goster.Size = new System.Drawing.Size(652, 114);
            this.dtg_Goster.TabIndex = 9;
            // 
            // rd_YetkiTanimla
            // 
            this.rd_YetkiTanimla.AutoSize = true;
            this.rd_YetkiTanimla.Location = new System.Drawing.Point(205, 221);
            this.rd_YetkiTanimla.Name = "rd_YetkiTanimla";
            this.rd_YetkiTanimla.Size = new System.Drawing.Size(102, 17);
            this.rd_YetkiTanimla.TabIndex = 10;
            this.rd_YetkiTanimla.TabStop = true;
            this.rd_YetkiTanimla.Text = "Yetkileri Tanımla";
            this.rd_YetkiTanimla.UseVisualStyleBackColor = true;
            this.rd_YetkiTanimla.CheckedChanged += new System.EventHandler(this.rd_YetkiTanimla_CheckedChanged);
            // 
            // rd_YetkileriGoster
            // 
            this.rd_YetkileriGoster.AutoSize = true;
            this.rd_YetkileriGoster.Location = new System.Drawing.Point(380, 221);
            this.rd_YetkileriGoster.Name = "rd_YetkileriGoster";
            this.rd_YetkileriGoster.Size = new System.Drawing.Size(96, 17);
            this.rd_YetkileriGoster.TabIndex = 11;
            this.rd_YetkileriGoster.TabStop = true;
            this.rd_YetkileriGoster.Text = "Yetkileri Göster";
            this.rd_YetkileriGoster.UseVisualStyleBackColor = true;
            this.rd_YetkileriGoster.CheckedChanged += new System.EventHandler(this.rd_YetkileriGoster_CheckedChanged);
            // 
            // pnl_Yetkiler
            // 
            this.pnl_Yetkiler.Controls.Add(this.label2);
            this.pnl_Yetkiler.Controls.Add(this.cmb_tabloadlari);
            this.pnl_Yetkiler.Controls.Add(this.chk_select);
            this.pnl_Yetkiler.Controls.Add(this.chk_insert);
            this.pnl_Yetkiler.Controls.Add(this.chk_update);
            this.pnl_Yetkiler.Controls.Add(this.chk_delete);
            this.pnl_Yetkiler.Controls.Add(this.lbl_yetkikodu);
            this.pnl_Yetkiler.Location = new System.Drawing.Point(188, 143);
            this.pnl_Yetkiler.Name = "pnl_Yetkiler";
            this.pnl_Yetkiler.Size = new System.Drawing.Size(499, 49);
            this.pnl_Yetkiler.TabIndex = 12;
            // 
            // pnl_kullanicilar
            // 
            this.pnl_kullanicilar.Controls.Add(this.label1);
            this.pnl_kullanicilar.Controls.Add(this.cmb_Kullanici);
            this.pnl_kullanicilar.Location = new System.Drawing.Point(35, 143);
            this.pnl_kullanicilar.Name = "pnl_kullanicilar";
            this.pnl_kullanicilar.Size = new System.Drawing.Size(147, 49);
            this.pnl_kullanicilar.TabIndex = 13;
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(629, 265);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(65, 47);
            this.btn_GeriDon.TabIndex = 14;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tablolar";
            // 
            // YetkiKisitla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(706, 320);
            this.Controls.Add(this.btn_GeriDon);
            this.Controls.Add(this.pnl_kullanicilar);
            this.Controls.Add(this.pnl_Yetkiler);
            this.Controls.Add(this.rd_YetkileriGoster);
            this.Controls.Add(this.rd_YetkiTanimla);
            this.Controls.Add(this.dtg_Goster);
            this.Controls.Add(this.btn_yetkiver);
            this.MaximizeBox = false;
            this.Name = "YetkiKisitla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Tanımla";
            this.Load += new System.EventHandler(this.YetkiKisitla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Goster)).EndInit();
            this.pnl_Yetkiler.ResumeLayout(false);
            this.pnl_Yetkiler.PerformLayout();
            this.pnl_kullanicilar.ResumeLayout(false);
            this.pnl_kullanicilar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_select;
        private System.Windows.Forms.CheckBox chk_insert;
        private System.Windows.Forms.CheckBox chk_update;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.Button btn_yetkiver;
        private System.Windows.Forms.ComboBox cmb_tabloadlari;
        private System.Windows.Forms.Label lbl_yetkikodu;
        private System.Windows.Forms.ComboBox cmb_Kullanici;
        private System.Windows.Forms.DataGridView dtg_Goster;
        private System.Windows.Forms.RadioButton rd_YetkiTanimla;
        private System.Windows.Forms.RadioButton rd_YetkileriGoster;
        private System.Windows.Forms.Panel pnl_Yetkiler;
        private System.Windows.Forms.Panel pnl_kullanicilar;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}