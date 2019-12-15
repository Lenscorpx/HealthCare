using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KK_DependentsApp.Code_Library;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_recherche_structure_dependant : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_recherche_structure_dependant()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.liste_dependants_structure(bunifuCustomDataGrid1);
            rps.recuperer_listbox_agent(listBox1);
            rps.recuperer_combobox_ville(cbx_ville);
            cbx_ville.SelectedIndex = 0;
            rps.recuperer_combo_structure(cbx_structure, cbx_ville.Text);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            rps.recherche_listbox_agent(listBox1, txt_search.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_noms_complet.Text = listBox1.SelectedItem.ToString();
        }

        private void cbx_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.recuperer_combo_structure(cbx_structure, cbx_ville.Text);
        }

        private void cbx_structure_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.rechercher_dependants_structure_parstructure(bunifuCustomDataGrid1, cbx_structure.Text);
        }

        private void txt_noms_complet_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_dependants_structure_paragent(bunifuCustomDataGrid1, txt_noms_complet.Text);
        }
    }
}
