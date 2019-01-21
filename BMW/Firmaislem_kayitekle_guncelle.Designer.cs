namespace BMW
{
    partial class Firmaislem_kayitekle_guncelle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Firmagrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mkodu = new System.Windows.Forms.Label();
            this.fid = new System.Windows.Forms.Label();
            this.sonkayit = new System.Windows.Forms.Button();
            this.ılkkayit = new System.Windows.Forms.Button();
            this.oncekikayit = new System.Windows.Forms.Button();
            this.sonrakikayit = new System.Windows.Forms.Button();
            this.ilkodu = new System.Windows.Forms.Label();
            this.fadres = new System.Windows.Forms.Label();
            this.ilcekodu = new System.Windows.Forms.Label();
            this.fadi = new System.Windows.Forms.Label();
            this.fkodu = new System.Windows.Forms.Label();
            this.M_kodu = new System.Windows.Forms.TextBox();
            this.Firma_adres = new System.Windows.Forms.TextBox();
            this.Ilce_koduu = new System.Windows.Forms.TextBox();
            this.Il_koduu = new System.Windows.Forms.TextBox();
            this.Firma_adi = new System.Windows.Forms.TextBox();
            this.Firma_kodu = new System.Windows.Forms.TextBox();
            this.geridon = new System.Windows.Forms.Button();
            this.kayitguncelle = new System.Windows.Forms.Button();
            this.yenikayit = new System.Windows.Forms.Button();
            this.kayitekle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 699);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Firmagrid);
            this.tabPage1.Controls.Add(this.mkodu);
            this.tabPage1.Controls.Add(this.fid);
            this.tabPage1.Controls.Add(this.sonkayit);
            this.tabPage1.Controls.Add(this.ılkkayit);
            this.tabPage1.Controls.Add(this.oncekikayit);
            this.tabPage1.Controls.Add(this.sonrakikayit);
            this.tabPage1.Controls.Add(this.ilkodu);
            this.tabPage1.Controls.Add(this.fadres);
            this.tabPage1.Controls.Add(this.ilcekodu);
            this.tabPage1.Controls.Add(this.fadi);
            this.tabPage1.Controls.Add(this.fkodu);
            this.tabPage1.Controls.Add(this.M_kodu);
            this.tabPage1.Controls.Add(this.Firma_adres);
            this.tabPage1.Controls.Add(this.Ilce_koduu);
            this.tabPage1.Controls.Add(this.Il_koduu);
            this.tabPage1.Controls.Add(this.Firma_adi);
            this.tabPage1.Controls.Add(this.Firma_kodu);
            this.tabPage1.Controls.Add(this.geridon);
            this.tabPage1.Controls.Add(this.kayitguncelle);
            this.tabPage1.Controls.Add(this.yenikayit);
            this.tabPage1.Controls.Add(this.kayitekle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Firma Müşterileri";
            // 
            // Firmagrid
            // 
            this.Firmagrid.Location = new System.Drawing.Point(3, 6);
            this.Firmagrid.MainView = this.gridView1;
            this.Firmagrid.Name = "Firmagrid";
            this.Firmagrid.Size = new System.Drawing.Size(1246, 400);
            this.Firmagrid.TabIndex = 38;
            this.Firmagrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Firmagrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // mkodu
            // 
            this.mkodu.AutoSize = true;
            this.mkodu.Location = new System.Drawing.Point(451, 537);
            this.mkodu.Name = "mkodu";
            this.mkodu.Size = new System.Drawing.Size(46, 17);
            this.mkodu.TabIndex = 36;
            this.mkodu.Text = "label6";
            // 
            // fid
            // 
            this.fid.AutoSize = true;
            this.fid.Location = new System.Drawing.Point(149, 413);
            this.fid.Name = "fid";
            this.fid.Size = new System.Drawing.Size(46, 17);
            this.fid.TabIndex = 35;
            this.fid.Text = "label1";
            // 
            // sonkayit
            // 
            this.sonkayit.Location = new System.Drawing.Point(612, 412);
            this.sonkayit.Name = "sonkayit";
            this.sonkayit.Size = new System.Drawing.Size(103, 32);
            this.sonkayit.TabIndex = 34;
            this.sonkayit.Text = "Son Kayıt";
            this.sonkayit.UseVisualStyleBackColor = true;
            this.sonkayit.Click += new System.EventHandler(this.sonkayit_Click);
            // 
            // ılkkayit
            // 
            this.ılkkayit.Location = new System.Drawing.Point(285, 412);
            this.ılkkayit.Name = "ılkkayit";
            this.ılkkayit.Size = new System.Drawing.Size(103, 32);
            this.ılkkayit.TabIndex = 33;
            this.ılkkayit.Text = "İlk Kayıt";
            this.ılkkayit.UseVisualStyleBackColor = true;
            this.ılkkayit.Click += new System.EventHandler(this.ılkkayit_Click);
            // 
            // oncekikayit
            // 
            this.oncekikayit.Location = new System.Drawing.Point(394, 412);
            this.oncekikayit.Name = "oncekikayit";
            this.oncekikayit.Size = new System.Drawing.Size(103, 32);
            this.oncekikayit.TabIndex = 32;
            this.oncekikayit.Text = "Önceki Kayıt";
            this.oncekikayit.UseVisualStyleBackColor = true;
            this.oncekikayit.Click += new System.EventHandler(this.oncekikayit_Click);
            // 
            // sonrakikayit
            // 
            this.sonrakikayit.Location = new System.Drawing.Point(503, 412);
            this.sonrakikayit.Name = "sonrakikayit";
            this.sonrakikayit.Size = new System.Drawing.Size(103, 32);
            this.sonrakikayit.TabIndex = 31;
            this.sonrakikayit.Text = "Sonraki Kayıt";
            this.sonrakikayit.UseVisualStyleBackColor = true;
            this.sonrakikayit.Click += new System.EventHandler(this.sonrakikayit_Click);
            // 
            // ilkodu
            // 
            this.ilkodu.AutoSize = true;
            this.ilkodu.Location = new System.Drawing.Point(7, 536);
            this.ilkodu.Name = "ilkodu";
            this.ilkodu.Size = new System.Drawing.Size(46, 17);
            this.ilkodu.TabIndex = 27;
            this.ilkodu.Text = "label7";
            // 
            // fadres
            // 
            this.fadres.AutoSize = true;
            this.fadres.Location = new System.Drawing.Point(451, 509);
            this.fadres.Name = "fadres";
            this.fadres.Size = new System.Drawing.Size(46, 17);
            this.fadres.TabIndex = 26;
            this.fadres.Text = "label6";
            // 
            // ilcekodu
            // 
            this.ilcekodu.AutoSize = true;
            this.ilcekodu.Location = new System.Drawing.Point(451, 478);
            this.ilcekodu.Name = "ilcekodu";
            this.ilcekodu.Size = new System.Drawing.Size(46, 17);
            this.ilcekodu.TabIndex = 25;
            this.ilcekodu.Text = "label5";
            // 
            // fadi
            // 
            this.fadi.AutoSize = true;
            this.fadi.Location = new System.Drawing.Point(7, 507);
            this.fadi.Name = "fadi";
            this.fadi.Size = new System.Drawing.Size(46, 17);
            this.fadi.TabIndex = 22;
            this.fadi.Text = "label2";
            // 
            // fkodu
            // 
            this.fkodu.AutoSize = true;
            this.fkodu.Location = new System.Drawing.Point(7, 478);
            this.fkodu.Name = "fkodu";
            this.fkodu.Size = new System.Drawing.Size(46, 17);
            this.fkodu.TabIndex = 21;
            this.fkodu.Text = "label1";
            // 
            // M_kodu
            // 
            this.M_kodu.Location = new System.Drawing.Point(593, 532);
            this.M_kodu.Name = "M_kodu";
            this.M_kodu.Size = new System.Drawing.Size(263, 22);
            this.M_kodu.TabIndex = 16;
            // 
            // Firma_adres
            // 
            this.Firma_adres.Location = new System.Drawing.Point(593, 504);
            this.Firma_adres.Name = "Firma_adres";
            this.Firma_adres.Size = new System.Drawing.Size(263, 22);
            this.Firma_adres.TabIndex = 15;
            // 
            // Ilce_koduu
            // 
            this.Ilce_koduu.Location = new System.Drawing.Point(593, 473);
            this.Ilce_koduu.Name = "Ilce_koduu";
            this.Ilce_koduu.Size = new System.Drawing.Size(263, 22);
            this.Ilce_koduu.TabIndex = 14;
            // 
            // Il_koduu
            // 
            this.Il_koduu.Location = new System.Drawing.Point(149, 530);
            this.Il_koduu.Name = "Il_koduu";
            this.Il_koduu.Size = new System.Drawing.Size(263, 22);
            this.Il_koduu.TabIndex = 13;
            // 
            // Firma_adi
            // 
            this.Firma_adi.Location = new System.Drawing.Point(149, 502);
            this.Firma_adi.Name = "Firma_adi";
            this.Firma_adi.Size = new System.Drawing.Size(263, 22);
            this.Firma_adi.TabIndex = 12;
            // 
            // Firma_kodu
            // 
            this.Firma_kodu.Location = new System.Drawing.Point(149, 474);
            this.Firma_kodu.Name = "Firma_kodu";
            this.Firma_kodu.Size = new System.Drawing.Size(263, 22);
            this.Firma_kodu.TabIndex = 11;
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(1154, 586);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(93, 78);
            this.geridon.TabIndex = 10;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // kayitguncelle
            // 
            this.kayitguncelle.Location = new System.Drawing.Point(1154, 412);
            this.kayitguncelle.Name = "kayitguncelle";
            this.kayitguncelle.Size = new System.Drawing.Size(93, 78);
            this.kayitguncelle.TabIndex = 8;
            this.kayitguncelle.Text = "Kayit Güncelle";
            this.kayitguncelle.UseVisualStyleBackColor = true;
            this.kayitguncelle.Click += new System.EventHandler(this.kayitguncelle_Click);
            // 
            // yenikayit
            // 
            this.yenikayit.Location = new System.Drawing.Point(956, 412);
            this.yenikayit.Name = "yenikayit";
            this.yenikayit.Size = new System.Drawing.Size(93, 78);
            this.yenikayit.TabIndex = 7;
            this.yenikayit.Text = "Yeni Kayıt";
            this.yenikayit.UseVisualStyleBackColor = true;
            this.yenikayit.Click += new System.EventHandler(this.yenikayit_Click);
            // 
            // kayitekle
            // 
            this.kayitekle.Location = new System.Drawing.Point(1055, 412);
            this.kayitekle.Name = "kayitekle";
            this.kayitekle.Size = new System.Drawing.Size(93, 78);
            this.kayitekle.TabIndex = 6;
            this.kayitekle.Text = "Kayıt Ekle";
            this.kayitekle.UseVisualStyleBackColor = true;
            this.kayitekle.Click += new System.EventHandler(this.kayitekle_Click);
            // 
            // Firmaislem_kayitekle_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Firmaislem_kayitekle_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmaislem_kayitekle_guncelle";
            this.Load += new System.EventHandler(this.Firmaislem_kayitekle_guncelle_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label fid;
        private System.Windows.Forms.Button sonkayit;
        private System.Windows.Forms.Button ılkkayit;
        private System.Windows.Forms.Button oncekikayit;
        private System.Windows.Forms.Button sonrakikayit;
        private System.Windows.Forms.Label ilkodu;
        private System.Windows.Forms.Label fadres;
        private System.Windows.Forms.Label ilcekodu;
        private System.Windows.Forms.Label fadi;
        private System.Windows.Forms.Label fkodu;
        private System.Windows.Forms.TextBox M_kodu;
        private System.Windows.Forms.TextBox Firma_adres;
        private System.Windows.Forms.TextBox Ilce_koduu;
        private System.Windows.Forms.TextBox Il_koduu;
        private System.Windows.Forms.TextBox Firma_adi;
        private System.Windows.Forms.TextBox Firma_kodu;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button kayitguncelle;
        private System.Windows.Forms.Button yenikayit;
        private System.Windows.Forms.Button kayitekle;
        private System.Windows.Forms.Label mkodu;
        private DevExpress.XtraGrid.GridControl Firmagrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}