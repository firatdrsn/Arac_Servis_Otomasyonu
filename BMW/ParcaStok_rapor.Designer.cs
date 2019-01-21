namespace BMW
{
    partial class ParcaStok_rapor
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
            this.ParcaStokRapor1 = new BMW.ParcaStokRapor();
            this.btnParcaStok = new System.Windows.Forms.Button();
            this.txtParcaStok = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parça Adını Giriniz:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-4, 40);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ParcaStokRapor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1333, 681);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // btnParcaStok
            // 
            this.btnParcaStok.Location = new System.Drawing.Point(104, 5);
            this.btnParcaStok.Margin = new System.Windows.Forms.Padding(4);
            this.btnParcaStok.Name = "btnParcaStok";
            this.btnParcaStok.Size = new System.Drawing.Size(100, 28);
            this.btnParcaStok.TabIndex = 7;
            this.btnParcaStok.Text = "RAPORLA";
            this.btnParcaStok.UseVisualStyleBackColor = true;
            this.btnParcaStok.Click += new System.EventHandler(this.btnParcaStok_Click);
            // 
            // txtParcaStok
            // 
            this.txtParcaStok.Location = new System.Drawing.Point(348, 8);
            this.txtParcaStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtParcaStok.Name = "txtParcaStok";
            this.txtParcaStok.Size = new System.Drawing.Size(192, 22);
            this.txtParcaStok.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(-4, 5);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ParcaStok_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnParcaStok);
            this.Controls.Add(this.txtParcaStok);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.Name = "ParcaStok_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParcaStok_rapor";
            this.Load += new System.EventHandler(this.ParcaStok_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnParcaStok;
        private System.Windows.Forms.TextBox txtParcaStok;
        private System.Windows.Forms.Button btnGeri;
        private ParcaStokRapor ParcaStokRapor1;
    }
}