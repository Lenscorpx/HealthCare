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
    public partial class uc_liens : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_liens()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_liens(bunifuCustomDataGrid1);
            txt_description.Clear();
            txt_lien_id.Clear();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_lien_id.Text == "")
            {
                MessageBox.Show("Veuillez completer l'ID du lien!");
            }
            else
            {
                rps.enregistrer_lien(txt_lien_id.Text, txt_description.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_lien_id.Text == "")
            {
                MessageBox.Show("Veuillez completer l'ID du lien!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Veuillez confirmer pour la suppression", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_lien(txt_lien_id.Text);
                    refreshData();
                    MessageBox.Show(this, "Suppression Reussie!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_lien_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
