namespace BMW
{
    partial class AracModell_rapor
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
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.btnraporla = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGeri = new System.Windows.Forms.Button();
            this.AracModelrapor2 = new BMW.AracModelrapor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model Adını Giriniz:";
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(373, 8);
            this.txtAracModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(191, 22);
            this.txtAracModel.TabIndex = 8;
            // 
            // btnraporla
            // 
            this.btnraporla.Location = new System.Drawing.Point(128, 8);
            this.btnraporla.Margin = new System.Windows.Forms.Padding(4);
            this.btnraporla.Name = "btnraporla";
            this.btnraporla.Size = new System.Drawing.Size(100, 28);
            this.btnraporla.TabIndex = 7;
            this.btnraporla.Text = "RAPORLA";
            this.btnraporla.UseVisualStyleBackColor = true;
            this.btnraporla.Click += new System.EventHandler(this.btnraporla_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 44);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.AracModelrapor2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1307, 701);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(20, 8);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // AracModell_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAracModel);
            this.Controls.Add(this.btnraporla);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.Name = "AracModell_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracModell_rapor";
            this.Load += new System.EventHandler(this.AracModell_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Button btnraporla;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnGeri;
        private AracModelrapor AracModelrapor2;
    }
}