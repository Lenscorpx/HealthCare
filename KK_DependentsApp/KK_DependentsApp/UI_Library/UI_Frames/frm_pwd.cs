using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using KK_DependentsApp.Code_Library;

namespace KK_DependentsApp.UI_Library.UI_Frames
{
    public partial class frm_pwd : MetroForm
    {
        Data_Repository rps = new Data_Repository();
        int r;
        public frm_pwd()
        {
            InitializeComponent();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
                  
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (txt_mot_de_passe.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Informations non completes!");
            }
            else
            {
                this.Hide();
                rps.rechercher_login(txt_username.Text, txt_mot_de_passe.Text, r);            
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tst_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_mot_de_passe_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
