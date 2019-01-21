namespace BMW
{
    partial class Backup
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
            this.components = new System.ComponentModel.Container();
            this.progres_bekle = new DevExpress.XtraWaitForm.ProgressPanel();
            this.Backup_al = new System.Windows.Forms.FolderBrowserDialog();
            this.bekle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progres_bekle
            // 
            this.progres_bekle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progres_bekle.Appearance.Options.UseBackColor = true;
            this.progres_bekle.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progres_bekle.AppearanceCaption.Options.UseFont = true;
            this.progres_bekle.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progres_bekle.AppearanceDescription.Options.UseFont = true;
            this.progres_bekle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progres_bekle.Caption = "Lütfen Bekleyin";
            this.progres_bekle.Description = "Backup Alınıyor...";
            this.progres_bekle.Location = new System.Drawing.Point(12, 1);
            this.progres_bekle.Name = "progres_bekle";
            this.progres_bekle.Size = new System.Drawing.Size(199, 90);
            this.progres_bekle.TabIndex = 0;
            this.progres_bekle.Text = "progres_bekle";
            this.progres_bekle.UseWaitCursor = true;
            // 
            // bekle
            // 
            this.bekle.Tick += new System.EventHandler(this.bekle_Tick);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 103);
            this.ControlBox = false;
            this.Controls.Add(this.progres_bekle);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progres_bekle;
        private System.Windows.Forms.FolderBrowserDialog Backup_al;
        public System.Windows.Forms.Timer bekle;

    }
}