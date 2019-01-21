namespace BMW
{
    partial class Aracstok_rapor
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
            this.btnAracstok = new System.Windows.Forms.Button();
            this.txtAracStok = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btngeri = new System.Windows.Forms.Button();
            this.aracstokrapor1 = new BMW.aracstokrapor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model Kodunu Giriniz:";
            // 
            // btnAracstok
            // 
            this.btnAracstok.Location = new System.Drawing.Point(125, 11);
            this.btnAracstok.Margin = new System.Windows.Forms.Padding(4);
            this.btnAracstok.Name = "btnAracstok";
            this.btnAracstok.Size = new System.Drawing.Size(100, 28);
            this.btnAracstok.TabIndex = 8;
            this.btnAracstok.Text = "RAPORLA";
            this.btnAracstok.UseVisualStyleBackColor = true;
            this.btnAracstok.Click += new System.EventHandler(this.btnAracstok_Click);
            // 
            // txtAracStok
            // 
            this.txtAracStok.Location = new System.Drawing.Point(389, 10);
            this.txtAracStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtAracStok.Name = "txtAracStok";
            this.txtAracStok.Size = new System.Drawing.Size(145, 22);
            this.txtAracStok.TabIndex = 7;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(5, 46);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.aracstokrapor1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1303, 697);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(17, 11);
            this.btngeri.Margin = new System.Windows.Forms.Padding(4);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(100, 28);
            this.btngeri.TabIndex = 5;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Aracstok_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAracstok);
            this.Controls.Add(this.txtAracStok);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btngeri);
            this.MaximizeBox = false;
            this.Name = "Aracstok_rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aracstok_rapor";
            this.Load += new System.EventHandler(this.Aracstok_rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracstok;
        private System.Windows.Forms.TextBox txtAracStok;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btngeri;
        private aracstokrapor aracstokrapor1;
    }
}