using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KK_DependentsApp.Code_Library;
using System.Windows.Forms;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_dashboard : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_dashboard()
        {
            InitializeComponent();
            //bunifuImageButton1_Click(sender, e);
            rps.remplir_treeview(treeView1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            rps.remplir_treeview(treeView1);
        }
    }
}
