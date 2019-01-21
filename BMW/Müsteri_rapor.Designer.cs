namespace BMW
{
    partial class Müsteri_rapor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusterirap = new System.Windows.Forms.TextBox();
            this.btnMusteriRaporla1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.btnMüsteri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MusteriRapor1 = new BMW.MusteriRapor();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Müşteri Türünü Giriniz:";
            // 
            // txtMusterirap
            // 
            this.txtMusterirap.Location = new System.Drawing.Point(982, 10);
            this.txtMusterirap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusterirap.Name = "txtMusterirap";
            this.txtMusterirap.Size = new System.Drawing.Size(211, 22);
            this.txtMusterirap.TabIndex = 14;
            // 
            // btnMusteriRaporla1
            // 
            this.btnMusteriRaporla1.Location = new System.Drawing.Point(1202, 7);
            this.btnMusteriRaporla1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriRaporla1.Name = "btnMusteriRaporla1";
            this.btnMusteriRaporla1.Size = new System.Drawing.Size(100, 28);
            this.btnMusteriRaporla1.TabIndex = 13;
            this.btnMusteriRaporla1.Text = "RAPORLA";
            this.btnMusteriRaporla1.UseVisualStyleBackColor = true;
            this.btnMusteriRaporla1.Click += new System.EventHandler(this.btnMusteriRaporla1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = " Müşteri TCno\'yu Giriniz:";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(395, 12);
            this.txtMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(211, 22);
            this.txtMusteri.TabIndex = 10;
            // 
            // btnMüsteri
            // 
            this.btnMüsteri.Location = new System.Drawing.Point(118, 9);
            this.btnMüsteri.Margin = new System.Windows.Forms.Padding(4);
            this.btnMüsteri.Name = "btnMüsteri";
            this.btnMüsteri.Size = new System.Drawing.Size(100, 28);
            this.btnMüsteri.TabIndex = 9;
            this.btnMüsteri.Text = "RAPORLA";
            this.btnMüsteri.UseVisualStyleBackColor = true;
            this.btnMüsteri.Click += new System.EventHandler(this.btnMüsteri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(10, 10);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(10, 44);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.MusteriRapor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1290, 671);
            this.crystalReportViewer1.TabIndex = 16;
            // 
            // Müsteri_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusterirap);
            this.Controls.Add(this.btnMusteriRaporla1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.btnMüsteri);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.Name = "Müsteri_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müsteri_rapor";
            this.Load += new System.EventHandler(this.Müsteri_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusterirap;
        private System.Windows.Forms.Button btnMusteriRaporla1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Button btnMüsteri;
        private System.Windows.Forms.Button btnGeri;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MusteriRapor MusteriRapor1;
    }
}