using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_apropos : UserControl
    {
        public uc_apropos()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.conebase-sas.com");
            }
            catch { }
        }
    }
}
