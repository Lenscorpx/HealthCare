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
    public partial class frm_params : MetroForm
    {
        public frm_params()
        {
            InitializeComponent();
            afficher_accueil();
        }
        private void afficher_accueil()
        {
            var fr = new uc_accueil_params()
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

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            var fr = new uc_liens()
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
            var fr = new uc_villes()
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
            var fr = new uc_structure()
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
    }
}
