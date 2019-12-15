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
using KK_DependentsApp.UI_Library.UI_UserControls;

namespace KK_DependentsApp.UI_Library.UI_Frames
{
    public partial class frm_menu : MetroForm
    {
        public frm_menu()
        {
            InitializeComponent();
            afficher_accueil();
        }
        private void afficher_accueil()
        {
            var fr = new uc_accueil()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            var fr = new frm_params();
            fr.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_apropos();
            fr.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var fr = new uc_agent()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            var fr = new uc_dependants()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new uc_affectation_structure()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new uc_rapports()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var fr = new uc_stats()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            var fr = new uc_dashboard()
            {
                Size = panel1.Size
            };
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }

        private void frm_menu_Click(object sender, EventArgs e)
        {
            afficher_accueil();
        }
    }
}
