using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KK_DependentsApp.UI_Library.UI_Frames;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_rapports : UserControl
    {
        public uc_rapports()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var fr = new frm_liste_structures();
            fr.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_liste_dependants();
            fr.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var fr = new frm_liste_agents_dependants();
            fr.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_liste_agents();
            fr.ShowDialog();
        }
    }
}
