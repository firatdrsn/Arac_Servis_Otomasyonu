namespace BMW
{
    partial class Personel_rapor
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
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.personel_repor1 = new BMW.personel_repor();
            this.btnpersonel = new System.Windows.Forms.Button();
            this.txrPersonel = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.aracstokrapor1 = new BMW.aracstokrapor();
            this.AracModelrapor1 = new BMW.AracModelrapor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Personel Bölüm Kodunu Giriniz:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(9, 49);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.personel_repor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1294, 690);
            this.crystalReportViewer1.TabIndex = 10;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // btnpersonel
            // 
            this.btnpersonel.Location = new System.Drawing.Point(117, 13);
            this.btnpersonel.Margin = new System.Windows.Forms.Padding(4);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(100, 28);
            this.btnpersonel.TabIndex = 9;
            this.btnpersonel.Text = "Raporla";
            this.btnpersonel.UseVisualStyleBackColor = true;
            this.btnpersonel.Click += new System.EventHandler(this.btnpersonel_Click);
            // 
            // txrPersonel
            // 
            this.txrPersonel.Location = new System.Drawing.Point(438, 16);
            this.txrPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.txrPersonel.Name = "txrPersonel";
            this.txrPersonel.Size = new System.Drawing.Size(157, 22);
            this.txrPersonel.TabIndex = 8;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(9, 13);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Personel_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnpersonel);
            this.Controls.Add(this.txrPersonel);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.Name = "Personel_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_rapor";
            this.Load += new System.EventHandler(this.Personel_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnpersonel;
        private System.Windows.Forms.TextBox txrPersonel;
        private System.Windows.Forms.Button btnGeri;
        private AracModelrapor AracModelrapor1;
        private aracstokrapor aracstokrapor1;
        private personel_repor personel_repor1;
    }
}