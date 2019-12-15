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
using System.Windows.Forms.DataVisualization.Charting;

namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    public partial class uc_stats : UserControl
    {
        Data_Repository rps = new Data_Repository();
        decimal nbre_agent, nbre_dependant, nbre_famille, enfant, conjoint, dep_femin, dep_masc, sans_dependant;
        public uc_stats()
        {
            InitializeComponent();
            //actualiser();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        private void actualiser()
        {
            charger_nombre_agent();            
            charger_nombre_dependants();
            charts_nombre_familles();
            charger_nombre_enfants();            
            charger_nombre_conjoint();
            charts_nombre_filles();
            charts_nombre_garcons();
            charts_dependants_paragent();
            charts_sans_dependants();
        }
        private void charger_nombre_agent()
        {
            rps.charts_nombre_agent(lbl_nombre_agents);
            try
            {
                if (lbl_nombre_agents.Text == "")
                {
                    lbl_nombre_agents.Text = "0";
                    nbre_agent = 0;
                }
                else
                {
                    nbre_agent = Convert.ToDecimal(lbl_nombre_agents.Text);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Agent!");
            }
        }
        private void charger_nombre_conjoint()
        {
            rps.charts_nombre_conjoint(lbl_conjoints);
            try
            {
                if (lbl_conjoints.Text == "")
                {
                    lbl_conjoints.Text = "0";
                    conjoint = 0;
                }
                else
                {
                    conjoint = Convert.ToDecimal(lbl_conjoints.Text);
                    gauge_conjoint.Value = Convert.ToInt32((conjoint / nbre_dependant) * 100);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement conjoint!");
            }
        }
        private void charger_nombre_dependants()
        {
            rps.charts_nombre_dependants(lbl_dependants);
            try
            {
                if (lbl_dependants.Text == "")
                {
                    lbl_dependants.Text = "0";
                    nbre_dependant = 0;
                }
                else
                {
                    nbre_dependant = Convert.ToDecimal(lbl_dependants.Text);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Dependants!");
            }
        }
        private void charger_nombre_enfants()
        {
            rps.charts_nombre_enfants(lbl_nombre_enfant);
            try
            {
                if (lbl_nombre_enfant.Text == "")
                {
                    lbl_nombre_enfant.Text = "0";
                    enfant = 0;
                }
                else
                {
                    enfant = Convert.ToDecimal(lbl_nombre_enfant.Text);
                    gauge_enfant.Value = Convert.ToInt32((enfant/nbre_dependant)*100);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Enfants!");
            }
        }
        private void charts_nombre_familles()
        {
            rps.charts_nombre_familles(lbl_familles);
            try
            {
                if (lbl_familles.Text == "")
                {
                    lbl_familles.Text = "0";
                    nbre_famille = 0;
                }
                else
                {
                    nbre_famille = Convert.ToDecimal(lbl_familles.Text);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Familles!");
            }


        }
        private void charts_nombre_garcons()
        {
            rps.charts_nombre_garcons(lbl_dep_masculins);
            try
            {
                if (lbl_dep_masculins.Text == "")
                {
                    lbl_dep_masculins.Text = "0";
                    dep_masc = 0;
                }
                else
                {
                    dep_masc = Convert.ToDecimal(lbl_dep_masculins.Text);
                    gauge_dep_masc.Value = Convert.ToInt32((dep_masc / nbre_dependant) * 100);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Garcons!");
            }
        }        
        private void charts_dependants_paragent()
        {
            rps.charts_dependants_paragent(chart1);         
        }
        private void charts_nombre_filles()
        {
            rps.charts_nombre_filles(lbl_dep_feminins);
            try
            {
                if (lbl_dep_feminins.Text == "")
                {
                    lbl_dep_feminins.Text = "0";
                    dep_femin = 0;
                }
                else
                {
                    dep_femin = Convert.ToDecimal(lbl_dep_feminins.Text);
                    gauge_dep_fem.Value = Convert.ToInt32((dep_femin / nbre_dependant) * 100);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Filles!");
            }


        }
        private void charts_sans_dependants()
        {
            rps.charts_sans_dependants(lbl_sans_dependant);
            try
            {
                if (lbl_sans_dependant.Text == "")
                {
                    lbl_sans_dependant.Text = "0";
                    sans_dependant = 0;
                }
                else
                {
                    sans_dependant = Convert.ToDecimal(lbl_sans_dependant.Text);
                    gauge_sans_dependant.Value = Convert.ToInt32((sans_dependant / nbre_agent) * 100);
                }

            }
            catch (Exception ext)
            {
                MessageBox.Show("Echec de chargement Filles!");
            }


        }
    }
}
