namespace BMW
{
    partial class Arac_satis_kayitbul
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
            this.geridonara = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuclist = new DevExpress.XtraEditors.ListBoxControl();
            this.Tümtablogoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sutunsecara = new System.Windows.Forms.ComboBox();
            this.kayitara = new System.Windows.Forms.Button();
            this.deger = new System.Windows.Forms.Label();
            this.Aranacakdeger = new System.Windows.Forms.TextBox();
            this.Aracsatisbulgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonuclist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aracsatisbulgrid)).BeginInit();
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
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.geridonara);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Aracsatisbulgrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Araç Satış Kayıt Arama";
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
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sonuclist);
            this.groupBox2.Controls.Add(this.Tümtablogoster);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sutunsecara);
            this.groupBox2.Controls.Add(this.kayitara);
            this.groupBox2.Controls.Add(this.deger);
            this.groupBox2.Controls.Add(this.Aranacakdeger);
            this.groupBox2.Location = new System.Drawing.Point(27, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 226);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Satış Kayıt Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "AÇIKLAMA:";
            // 
            // sonuclist
            // 
            this.sonuclist.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sonuclist.Appearance.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclist.Appearance.Options.UseBackColor = true;
            this.sonuclist.Appearance.Options.UseFont = true;
            this.sonuclist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sonuclist.HorizontalScrollbar = true;
            this.sonuclist.HorzScrollStep = 1;
            this.sonuclist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sonuclist.Location = new System.Drawing.Point(162, 101);
            this.sonuclist.Name = "sonuclist";
            this.sonuclist.Size = new System.Drawing.Size(815, 119);
            this.sonuclist.TabIndex = 26;
            // 
            // Tümtablogoster
            // 
            this.Tümtablogoster.Location = new System.Drawing.Point(626, 38);
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
            this.label2.Location = new System.Drawing.Point(63, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hangi Parametreye Göre Arayacaksın:";
            // 
            // sutunsecara
            // 
            this.sutunsecara.FormattingEnabled = true;
            this.sutunsecara.Items.AddRange(new object[] {
            "Sütun Seçin.."});
            this.sutunsecara.Location = new System.Drawing.Point(326, 33);
            this.sutunsecara.Name = "sutunsecara";
            this.sutunsecara.Size = new System.Drawing.Size(263, 24);
            this.sutunsecara.TabIndex = 22;
            // 
            // kayitara
            // 
            this.kayitara.Location = new System.Drawing.Point(825, 38);
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
            this.deger.Location = new System.Drawing.Point(64, 71);
            this.deger.Name = "deger";
            this.deger.Size = new System.Drawing.Size(85, 17);
            this.deger.TabIndex = 21;
            this.deger.Text = "Değer Girin:";
            // 
            // Aranacakdeger
            // 
            this.Aranacakdeger.Location = new System.Drawing.Point(326, 68);
            this.Aranacakdeger.Name = "Aranacakdeger";
            this.Aranacakdeger.Size = new System.Drawing.Size(263, 22);
            this.Aranacakdeger.TabIndex = 11;
            // 
            // Aracsatisbulgrid
            // 
            this.Aracsatisbulgrid.Location = new System.Drawing.Point(3, 6);
            this.Aracsatisbulgrid.MainView = this.gridView2;
            this.Aracsatisbulgrid.Name = "Aracsatisbulgrid";
            this.Aracsatisbulgrid.Size = new System.Drawing.Size(1246, 400);
            this.Aracsatisbulgrid.TabIndex = 1;
            this.Aracsatisbulgrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Aracsatisbulgrid;
            this.gridView2.Name = "gridView2";
            // 
            // Arac_satis_kayitbul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Arac_satis_kayitbul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac_satis_kayitbul";
            this.Load += new System.EventHandler(this.Arac_satis_kayitbul_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonuclist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aracsatisbulgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button geridonara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Tümtablogoster;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox sutunsecara;
        private System.Windows.Forms.Button kayitara;
        private System.Windows.Forms.Label deger;
        private System.Windows.Forms.TextBox Aranacakdeger;
        private DevExpress.XtraGrid.GridControl Aracsatisbulgrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ListBoxControl sonuclist;
    }
}