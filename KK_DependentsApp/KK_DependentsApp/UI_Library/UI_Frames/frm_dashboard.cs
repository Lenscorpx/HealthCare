using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KK_DependentsApp.Code_Library;
using MetroFramework.Forms;
using KK_DependentsApp.UI_Library.UI_UserControls;

namespace KK_DependentsApp.UI_Library.UI_Frames
{
    public partial class frm_dashboard : MetroForm
    {
        public frm_dashboard()
        {
            InitializeComponent();
            afficher_accueil();
        }
        private void afficher_accueil()
        {
            var fr = new uc_accueil()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            //bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var fr = new uc_recherche_agent()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new uc_recherche_structure_dependant()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            var fr = new uc_recherche_dependants()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //var rs = new DialogResult();
            //rs = MessageBox.Show("Voulez vous passez en mode administrateur?", "Administrator rights ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rs == DialogResult.Yes)
            //{                
                var fr = new frm_pwd();
                fr.Show();
                this.Hide();
            //}            
        }

        private void frm_dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}