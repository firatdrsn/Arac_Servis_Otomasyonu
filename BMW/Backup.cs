using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BMW
{
    public partial class Backup : Form
    {
        int say = 0;
        SQL cumle = new SQL();
        
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
          
          
            try
            {
               
                
                Backup_al.ShowDialog();
                string vt_yolu = Backup_al.SelectedPath.ToString();
                vt_yolu=vt_yolu+"\\BMW.bak";
                
                cumle.IDU(@"BACKUP DATABASE BMW TO DISK = '" + vt_yolu.ToString() +"'  WITH FORMAT,     MEDIANAME = 'BMW_VT_BACKUP',   NAME = 'Full Backup BMW';");
                this.bekle.Enabled = true;

            }
            catch (Exception)
            {
                
              
            }
        }
        

        private void bekle_Tick(object sender, EventArgs e)
        {
            try
            {
                say++;
                
                if (say == 15)
                {
                     MessageBox.Show("Beckup Başarı Alınmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     AdminPanel m = new AdminPanel();
                     m.Show();
                     this.Close();
                     

                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
