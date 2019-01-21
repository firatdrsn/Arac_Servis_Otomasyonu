namespace BMW
{
    partial class AracSatis_rapor
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
            this.txtSatisTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAracStokrap1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAracSatis = new System.Windows.Forms.Button();
            this.ttAracSatis = new System.Windows.Forms.TextBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AracSatisRaporu1 = new BMW.AracSatisRaporu();
            this.SuspendLayout();
            // 
            // txtSatisTarih
            // 
            this.txtSatisTarih.Location = new System.Drawing.Point(884, 6);
            this.txtSatisTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatisTarih.Name = "txtSatisTarih";
            this.txtSatisTarih.Size = new System.Drawing.Size(132, 22);
            this.txtSatisTarih.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1025, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Satış Tarihini GİRİNİZ";
            // 
            // btnAracStokrap1
            // 
            this.btnAracStokrap1.Location = new System.Drawing.Point(1180, 2);
            this.btnAracStokrap1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracStokrap1.Name = "btnAracStokrap1";
            this.btnAracStokrap1.Size = new System.Drawing.Size(100, 28);
            this.btnAracStokrap1.TabIndex = 13;
            this.btnAracStokrap1.Text = "RAPORLA";
            this.btnAracStokrap1.UseVisualStyleBackColor = true;
            this.btnAracStokrap1.Click += new System.EventHandler(this.btnAracStokrap1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Satış Kodunu GİRİNİZ";
            // 
            // btnAracSatis
            // 
            this.btnAracSatis.Location = new System.Drawing.Point(110, 2);
            this.btnAracSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracSatis.Name = "btnAracSatis";
            this.btnAracSatis.Size = new System.Drawing.Size(100, 28);
            this.btnAracSatis.TabIndex = 11;
            this.btnAracSatis.Text = "RAPORLA";
            this.btnAracSatis.UseVisualStyleBackColor = true;
            this.btnAracSatis.Click += new System.EventHandler(this.btnAracSatis_Click);
            // 
            // ttAracSatis
            // 
            this.ttAracSatis.Location = new System.Drawing.Point(377, 7);
            this.ttAracSatis.Margin = new System.Windows.Forms.Padding(4);
            this.ttAracSatis.Name = "ttAracSatis";
            this.ttAracSatis.Size = new System.Drawing.Size(132, 22);
            this.ttAracSatis.TabIndex = 10;
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(2, 2);
            this.btngeri.Margin = new System.Windows.Forms.Padding(4);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(100, 28);
            this.btngeri.TabIndex = 8;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 37);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.AracSatisRaporu1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1298, 714);
            this.crystalReportViewer1.TabIndex = 16;
            // 
            // AracSatis_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 763);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSatisTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAracStokrap1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAracSatis);
            this.Controls.Add(this.ttAracSatis);
            this.Controls.Add(this.btngeri);
            this.MaximizeBox = false;
            this.Name = "AracSatis_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracSatis_rapor";
            this.Load += new System.EventHandler(this.AracSatis_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatisTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAracStokrap1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracSatis;
        private System.Windows.Forms.TextBox ttAracSatis;
        private System.Windows.Forms.Button btngeri;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private AracSatisRaporu AracSatisRaporu1;
    }
}