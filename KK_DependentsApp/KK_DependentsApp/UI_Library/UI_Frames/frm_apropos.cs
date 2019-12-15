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

namespace KK_DependentsApp.UI_Library.UI_Frames
{
    public partial class frm_apropos : MetroForm
    {
        public frm_apropos()
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