namespace BMW
{
    partial class Musteriislem_kayitbul
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.musterituru = new System.Windows.Forms.Label();
            this.geridonara = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.soyad = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.msoyad = new System.Windows.Forms.TextBox();
            this.mad = new System.Windows.Forms.TextBox();
            this.Tümtablogoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sutunsecara = new System.Windows.Forms.ComboBox();
            this.kayitara = new System.Windows.Forms.Button();
            this.deger = new System.Windows.Forms.Label();
            this.Aranacakdeger = new System.Windows.Forms.TextBox();
            this.Musteribulgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Musteribulgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 699);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.musterituru);
            this.tabPage2.Controls.Add(this.geridonara);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Musteribulgrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Bul";
            // 
            // musterituru
            // 
            this.musterituru.AutoSize = true;
            this.musterituru.Location = new System.Drawing.Point(968, 459);
            this.musterituru.Name = "musterituru";
            this.musterituru.Size = new System.Drawing.Size(46, 17);
            this.musterituru.TabIndex = 25;
            this.musterituru.Text = "label1";
            this.musterituru.Visible = false;
            // 
            // geridonara
            // 
            this.geridonara.Location = new System.Drawing.Point(1154, 586);
            this.geridonara.Name = "geridonara";
            this.geridonara.Size = new System.Drawing.Size(93, 78);
            this.geridonara.TabIndex = 24;
            this.geridonara.Text = "Geri Dön";
            this.geridonara.UseVisualStyleBackColor = true;
            this.geridonara.Click += new System.EventHandler(this.geridonara_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.soyad);
            this.groupBox2.Controls.Add(this.ad);
            this.groupBox2.Controls.Add(this.msoyad);
            this.groupBox2.Controls.Add(this.mad);
            this.groupBox2.Controls.Add(this.Tümtablogoster);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sutunsecara);
            this.groupBox2.Controls.Add(this.kayitara);
            this.groupBox2.Controls.Add(this.deger);
            this.groupBox2.Controls.Add(this.Aranacakdeger);
            this.groupBox2.Location = new System.Drawing.Point(27, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 212);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müsteri Kayıt Bul";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(66, 125);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(109, 17);
            this.soyad.TabIndex = 29;
            this.soyad.Text = "Müşteri Soyadı: ";
            this.soyad.Visible = false;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(66, 97);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(86, 17);
            this.ad.TabIndex = 28;
            this.ad.Text = "Müşteri Adı: ";
            this.ad.Visible = false;
            // 
            // msoyad
            // 
            this.msoyad.Location = new System.Drawing.Point(326, 120);
            this.msoyad.Name = "msoyad";
            this.msoyad.Size = new System.Drawing.Size(263, 22);
            this.msoyad.TabIndex = 27;
            this.msoyad.Visible = false;
            // 
            // mad
            // 
            this.mad.Location = new System.Drawing.Point(326, 92);
            this.mad.Name = "mad";
            this.mad.Size = new System.Drawing.Size(263, 22);
            this.mad.TabIndex = 26;
            this.mad.Visible = false;
            // 
            // Tümtablogoster
            // 
            this.Tümtablogoster.Location = new System.Drawing.Point(691, 55);
            this.Tümtablogoster.Name = "Tümtablogoster";
            this.Tümtablogoster.Size = new System.Drawing.Size(152, 50);
            this.Tümtablogoster.TabIndex = 25;
            this.Tümtablogoster.Text = "Bütün Tabloyu Göster";
            this.Tümtablogoster.UseVisualStyleBackColor = true;
            this.Tümtablogoster.Click += new System.EventHandler(this.Tümtablogoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hangi Parametreye Göre Arayacaksın: ";
            // 
            // sutunsecara
            // 
            this.sutunsecara.FormattingEnabled = true;
            this.sutunsecara.Items.AddRange(new object[] {
            "Sütun Seçin.."});
            this.sutunsecara.Location = new System.Drawing.Point(326, 50);
            this.sutunsecara.Name = "sutunsecara";
            this.sutunsecara.Size = new System.Drawing.Size(263, 24);
            this.sutunsecara.TabIndex = 22;
            this.sutunsecara.SelectedIndexChanged += new System.EventHandler(this.sutunsecara_SelectedIndexChanged);
            // 
            // kayitara
            // 
            this.kayitara.Location = new System.Drawing.Point(691, 134);
            this.kayitara.Name = "kayitara";
            this.kayitara.Size = new System.Drawing.Size(152, 50);
            this.kayitara.TabIndex = 7;
            this.kayitara.Text = "Kayıt Ara";
            this.kayitara.UseVisualStyleBackColor = true;
            this.kayitara.Click += new System.EventHandler(this.kayitara_Click);
            // 
            // deger
            // 
            this.deger.AutoSize = true;
            this.deger.Location = new System.Drawing.Point(67, 151);
            this.deger.Name = "deger";
            this.deger.Size = new System.Drawing.Size(85, 17);
            this.deger.TabIndex = 21;
            this.deger.Text = "Değer Girin:";
            // 
            // Aranacakdeger
            // 
            this.Aranacakdeger.Location = new System.Drawing.Point(326, 148);
            this.Aranacakdeger.Name = "Aranacakdeger";
            this.Aranacakdeger.Size = new System.Drawing.Size(263, 22);
            this.Aranacakdeger.TabIndex = 11;
            // 
            // Musteribulgrid
            // 
            this.Musteribulgrid.Location = new System.Drawing.Point(3, 6);
            this.Musteribulgrid.MainView = this.gridView2;
            this.Musteribulgrid.Name = "Musteribulgrid";
            this.Musteribulgrid.Size = new System.Drawing.Size(1246, 400);
            this.Musteribulgrid.TabIndex = 1;
            this.Musteribulgrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Musteribulgrid;
            this.gridView2.Name = "gridView2";
            // 
            // Musteriislem_kayitbul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Musteriislem_kayitbul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriislem_kayitbul";
            this.Load += new System.EventHandler(this.Musteriislem_kayitbul_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Musteribulgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button geridonara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox sutunsecara;
        private System.Windows.Forms.Button kayitara;
        private System.Windows.Forms.Label deger;
        private System.Windows.Forms.TextBox Aranacakdeger;
        private DevExpress.XtraGrid.GridControl Musteribulgrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button Tümtablogoster;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox msoyad;
        private System.Windows.Forms.TextBox mad;
        private System.Windows.Forms.Label musterituru;

    }
}