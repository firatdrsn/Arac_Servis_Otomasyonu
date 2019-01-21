namespace BMW
{
    partial class BölümEkle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bTNgeri = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbolumadı = new System.Windows.Forms.TextBox();
            this.txtbolumkodu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 185);
            this.dataGridView1.TabIndex = 24;
            // 
            // bTNgeri
            // 
            this.bTNgeri.Location = new System.Drawing.Point(12, 100);
            this.bTNgeri.Margin = new System.Windows.Forms.Padding(4);
            this.bTNgeri.Name = "bTNgeri";
            this.bTNgeri.Size = new System.Drawing.Size(100, 28);
            this.bTNgeri.TabIndex = 23;
            this.bTNgeri.Text = "Geri DÖN";
            this.bTNgeri.UseVisualStyleBackColor = true;
            this.bTNgeri.Click += new System.EventHandler(this.bTNgeri_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(223, 100);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 28);
            this.btnsil.TabIndex = 22;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(115, 100);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 28);
            this.btnekle.TabIndex = 21;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bölüm ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bölüm KODU:";
            // 
            // txtbolumadı
            // 
            this.txtbolumadı.Location = new System.Drawing.Point(115, 54);
            this.txtbolumadı.Margin = new System.Windows.Forms.Padding(4);
            this.txtbolumadı.Name = "txtbolumadı";
            this.txtbolumadı.Size = new System.Drawing.Size(132, 22);
            this.txtbolumadı.TabIndex = 18;
            // 
            // txtbolumkodu
            // 
            this.txtbolumkodu.Location = new System.Drawing.Point(115, 13);
            this.txtbolumkodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtbolumkodu.Name = "txtbolumkodu";
            this.txtbolumkodu.Size = new System.Drawing.Size(132, 22);
            this.txtbolumkodu.TabIndex = 17;
            // 
            // BölümEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bTNgeri);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbolumadı);
            this.Controls.Add(this.txtbolumkodu);
            this.MaximizeBox = false;
            this.Name = "BölümEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BölümEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bTNgeri;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolumadı;
        private System.Windows.Forms.TextBox txtbolumkodu;
    }
}