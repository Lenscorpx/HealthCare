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
using System.IO;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_dependants : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_dependants()
        {
            InitializeComponent();
            cbx_sexe.Items.Add(Sexes.Female);
            cbx_sexe.Items.Add(Sexes.Male);
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_dependents(bunifuCustomDataGrid1);
            rps.recuperer_listbox_agent(listBox1);
            rps.recuperer_combobox_lien(cbx_lien);
            txt_adresse.Clear();
            txt_code_agent.Clear();
            txt_noms_dependant.Clear();
            cbx_lien.Text = "";
            cbx_sexe.Text = "";
            pictureBox2.Image = KK_DependentsApp.Properties.Resources.img_335918;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            rps.recherche_listbox_agent(listBox1, txt_search.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rps.rechercher_code_agent(txt_code_agent, listBox1.SelectedItem.ToString());
        }

        private void txt_code_agent_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_dependents(bunifuCustomDataGrid1, txt_code_agent.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "fichiers d'images|*.jpg;png;bmp";
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.Cancel)
                return;
            pictureBox2.Image = Image.FromFile(ofd.FileName);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] tof = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(tof, 0, tof.Length);

            if (txt_code_dependant.Text==""|| txt_code_agent.Text == "" || cbx_sexe.Text == "" || txt_noms_dependant.Text == ""|| cbx_lien.Text=="")
            {
                MessageBox.Show("Rassurez vous d'avoir copmlété toutes les informations nécessaires!");
            }
            else
            {
                rps.verifier_dependant(txt_code_dependant.Text, existance);
                string answer = Convert.ToString(existance);
                if(existance.Text=="1")
                {
                    var rs = new DialogResult();
                    rs = MessageBox.Show("Ce dependant existe deja! \nVoulez vous mettre a jour ses informations?", "Code Existant ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        rps.enregistrer_dependent(txt_code_dependant.Text, txt_noms_dependant.Text, bunifuDatepicker1.Value, cbx_sexe.Text, txt_adresse.Text, cbx_lien.Text, tof, txt_code_agent.Text);
                        refreshData();
                        MessageBox.Show("Les informations du dependant ont ete mis a jour!");
                    }
                }
                else
                {
                    rps.enregistrer_dependent(txt_code_dependant.Text, txt_noms_dependant.Text, bunifuDatepicker1.Value, cbx_sexe.Text, txt_adresse.Text, cbx_lien.Text, tof, txt_code_agent.Text);
                    refreshData();
                }                
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_code_dependant.Text == "")
            {
                MessageBox.Show("Veuillez completer l'ID du dependant!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Veuillez confirmer pour la suppression", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_dependents(txt_code_dependant.Text);
                    refreshData();
                    MessageBox.Show(this, "Suppression Reussie!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_noms_dependant_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_nom_dependents(bunifuCustomDataGrid1, txt_noms_dependant.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_dependant.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_noms_dependant.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                bunifuDatepicker1.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                bunifuDatepicker1.Value = DateTime.Today;
            }
            
            cbx_sexe.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_adresse.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            cbx_lien.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();

            try
            {
                byte[] tof2 = (byte[])bunifuCustomDataGrid1.SelectedRows[0].Cells[6].Value;
                var ms = new MemoryStream();
                ms = new MemoryStream(tof2);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox2.Image = Image.FromStream(ms);
            }
            catch
            {
                //MessageBox.Show("Cet agent n'a pas de photo convertible!");
                pictureBox2.Image = Properties.Resources.img_335918;
            }

            txt_code_agent.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void txt_code_dependant_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_code_dependents(bunifuCustomDataGrid1, txt_code_dependant.Text);
        }
    }
}
