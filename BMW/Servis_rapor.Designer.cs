namespace BMW
{
    partial class Servis_rapor
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ServisRapor1 = new BMW.ServisRapor();
            this.txtServis = new System.Windows.Forms.TextBox();
            this.btnServis = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 40);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ServisRapor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1307, 708);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // txtServis
            // 
            this.txtServis.Location = new System.Drawing.Point(219, 7);
            this.txtServis.Margin = new System.Windows.Forms.Padding(4);
            this.txtServis.Name = "txtServis";
            this.txtServis.Size = new System.Drawing.Size(99, 22);
            this.txtServis.TabIndex = 6;
            // 
            // btnServis
            // 
            this.btnServis.Location = new System.Drawing.Point(111, 5);
            this.btnServis.Margin = new System.Windows.Forms.Padding(4);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(100, 28);
            this.btnServis.TabIndex = 5;
            this.btnServis.Text = "RAPORLA";
            this.btnServis.UseVisualStyleBackColor = true;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(3, 5);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Servis_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtServis);
            this.Controls.Add(this.btnServis);
            this.Controls.Add(this.btnGeri);
            this.MinimizeBox = false;
            this.Name = "Servis_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis_rapor";
            this.Load += new System.EventHandler(this.Servis_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtServis;
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btnGeri;
        private ServisRapor ServisRapor1;
    }
}