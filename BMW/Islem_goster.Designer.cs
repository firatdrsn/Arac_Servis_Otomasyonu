namespace BMW
{
    partial class Islem_goster
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
            this.lb_arac = new System.Windows.Forms.Label();
            this.geridon = new System.Windows.Forms.Button();
            this.Islemgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Islemgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(43, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 529);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lb_arac);
            this.tabPage2.Controls.Add(this.geridon);
            this.tabPage2.Controls.Add(this.Islemgrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yapılan İşlemler";
            // 
            // lb_arac
            // 
            this.lb_arac.AutoSize = true;
            this.lb_arac.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arac.Location = new System.Drawing.Point(26, 37);
            this.lb_arac.Name = "lb_arac";
            this.lb_arac.Size = new System.Drawing.Size(69, 29);
            this.lb_arac.TabIndex = 25;
            this.lb_arac.Text = "label1";
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(1156, 6);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(93, 78);
            this.geridon.TabIndex = 24;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // Islemgrid
            // 
            this.Islemgrid.Location = new System.Drawing.Point(6, 90);
            this.Islemgrid.MainView = this.gridView2;
            this.Islemgrid.Name = "Islemgrid";
            this.Islemgrid.Size = new System.Drawing.Size(1246, 400);
            this.Islemgrid.TabIndex = 1;
            this.Islemgrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Islemgrid;
            this.gridView2.Name = "gridView2";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Islemgrid;
            this.gridView1.Name = "gridView1";
            // 
            // Islem_goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1352, 604);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Islem_goster";
            this.Text = "Islem_goster";
            this.Load += new System.EventHandler(this.Islem_goster_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Islemgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label lb_arac;
        private System.Windows.Forms.Button geridon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl Islemgrid;
    }
}