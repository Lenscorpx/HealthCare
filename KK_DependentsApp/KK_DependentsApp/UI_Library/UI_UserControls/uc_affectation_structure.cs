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
    public partial class uc_affectation_structure : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_affectation_structure()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_affectation(bunifuCustomDataGrid1);
            rps.recuperer_listbox_agent(listBox1);
            rps.recuperer_combobox_ville(cbx_ville);
            cbx_ville.SelectedIndex = 0;
            rps.recuperer_combo_structure(cbx_structure, cbx_ville.Text);            
        }

        private void cbx_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.recuperer_combo_structure(cbx_structure, cbx_ville.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.rechercher_code_agent(txt_code_agent, listBox1.SelectedItem.ToString());
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            rps.recherche_listbox_agent(listBox1, txt_search.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_num_affectation.Text=="")
            {
                if (txt_code_agent.Text == "" || cbx_ville.Text == "" || cbx_structure.Text == "")
                {
                    MessageBox.Show("Rassurez vous d'avoir complété toutes les informations nécessaires!");
                }
                else
                {
                    rps.inserer_affectation(txt_code_agent.Text, cbx_structure.Text, DateTime.Now);
                    refreshData();
                }
            }
            else
            {
                if (txt_code_agent.Text == "" || cbx_ville.Text == "" || cbx_structure.Text == "")
                {
                    MessageBox.Show("Rassurez vous d'avoir complété toutes les informations nécessaires!");
                }
                else
                {
                    rps.modifier_affectation(Convert.ToInt32(txt_num_affectation.Text),txt_code_agent.Text, cbx_structure.Text, DateTime.Now);
                    refreshData();
                }
            }
            
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_num_affectation.Text == "")
            {
                MessageBox.Show("Veuillez completer l'ID de l'affectation a supprimer!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Veuillez confirmer pour la suppression", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_affectation(Convert.ToInt32(txt_num_affectation.Text));
                    refreshData();
                    MessageBox.Show(this, "Suppression Reussie!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_code_agent_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_affectation_paragent(bunifuCustomDataGrid1, txt_code_agent.Text);
        }

        private void cbx_structure_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.rechercher_affectation_parstructure(bunifuCustomDataGrid1, cbx_structure.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num_affectation.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_code_agent.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            cbx_structure.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
