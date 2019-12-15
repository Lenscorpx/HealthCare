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
    public partial class frm_liste_agents_dependants : MetroForm
    {
        Data_Repository rps = new Data_Repository();
        public frm_liste_agents_dependants()
        {
            InitializeComponent();
            rps.imprimer_agents_dependants(documentViewer1);
        }
    }
}
