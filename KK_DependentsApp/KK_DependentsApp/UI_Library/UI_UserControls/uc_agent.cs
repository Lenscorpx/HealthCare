using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KK_DependentsApp.Code_Library;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_agent : UserControl
    {
        Data_Repository rps = new Data_Repository();
        public uc_agent()
        {
            InitializeComponent();
            cbx_sexe.Items.Add(Sexes.Female);
            cbx_sexe.Items.Add(Sexes.Male);
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_agent(bunifuCustomDataGrid1);
            txt_adresse.Clear();
            txt_code_agent.Clear();
            txt_noms_complet.Clear();
            txt_telephone.Clear();
            pictureBox2.Image = KK_DependentsApp.Properties.Resources.img_335918;
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

            if(txt_code_agent.Text==""||cbx_sexe.Text==""||txt_noms_complet.Text=="")
            {
                MessageBox.Show("Rassurez vous d'avoir copmlété toutes les informations nécessaires!");
            }
            else
            {
                rps.enregistrer_agent(txt_code_agent.Text, txt_noms_complet.Text, bunifuDatepicker1.Value, txt_telephone.Text, txt_adresse.Text, cbx_sexe.Text, tof);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_code_agent.Text == "")
            {
                MessageBox.Show("Veuillez completer l'ID de l'agent!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Veuillez confirmer pour la suppression", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_agent(txt_code_agent.Text);
                    refreshData();
                    MessageBox.Show(this, "Suppression Reussie!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_noms_complet_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_agent_parnom(bunifuCustomDataGrid1, txt_noms_complet.Text);
        }

        private void txt_code_agent_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_agent_parcode(bunifuCustomDataGrid1, txt_code_agent.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_agent.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_noms_complet.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                bunifuDatepicker1.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                bunifuDatepicker1.Value = DateTime.Today;
            }            
            txt_telephone.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_adresse.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            cbx_sexe.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
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
                pictureBox2.Image = KK_DependentsApp.Properties.Resources.img_335918;
            }
        }
    }
}
