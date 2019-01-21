namespace BMW
{
    partial class AnaMenü
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
            this.btncikis = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnPersonelİslemleri = new System.Windows.Forms.Button();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(92, 158);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(269, 23);
            this.btncikis.TabIndex = 7;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(238, 69);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(123, 62);
            this.btnRaporlar.TabIndex = 6;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnPersonelİslemleri
            // 
            this.btnPersonelİslemleri.Location = new System.Drawing.Point(92, 69);
            this.btnPersonelİslemleri.Name = "btnPersonelİslemleri";
            this.btnPersonelİslemleri.Size = new System.Drawing.Size(123, 62);
            this.btnPersonelİslemleri.TabIndex = 5;
            this.btnPersonelİslemleri.Text = "Personel işlemleri";
            this.btnPersonelİslemleri.UseVisualStyleBackColor = true;
            this.btnPersonelİslemleri.Click += new System.EventHandler(this.btnPersonelİslemleri_Click);
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(12, 12);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(60, 44);
            this.btn_GeriDon.TabIndex = 8;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Visible = false;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GeriDon);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnPersonelİslemleri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patron Panel";
            this.Load += new System.EventHandler(this.AnaMenü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnPersonelİslemleri;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Label label1;
    }
}