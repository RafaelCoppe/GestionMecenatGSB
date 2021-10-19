using GestionMecenatBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMecenatGSB
{
    public partial class FormAjoutLimiteMecenat : Form
    {
        public FormAjoutLimiteMecenat()
        {
            InitializeComponent();
            majCbx();
        }

        public void majCbx()
        {
            cbxPays.DisplayMember = "libelle";
            cbxPays.ValueMember = "id";
            cbxPays.DataSource = PaysManager.GetInstance().GetLesPays(); // Récupération des Pays
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int nbAjouts;
            string msgErr = "";
            if (cbxPays.SelectedIndex == 0)
            {
                msgErr += ("Veuillez sélectionner un pays \n");
            }
            if (cbxAnnee.SelectedIndex == -1)
            {
                msgErr += ("Veuillez sélectionner un annee \n");
            }
            if (txtSommeMaximum.Text.Trim() == "" || txtSommeMaximum.Text.Trim() == "0") //Si il n'y a pas de somme maximum
            {
                msgErr += ("Veuillez saisir une somme maximum \n");
            }

            if (msgErr != "")
            {
                MessageBox.Show(msgErr);
            }
            else
            {
                float SommeMaximum = float.Parse(txtSommeMaximum.Text);
                try
                {
                    nbAjouts = AvoirPourLimiteDeMecenatManager.GetInstance().AjoutLimiteMecenat(SommeMaximum, (int)cbxPays.SelectedValue, cbxPays.Text, (int)cbxAnnee.SelectedValue);
                    MessageBox.Show("L'ajout de la limite de mecenat a été réalisé");
                    majCbx();
                    txtSommeMaximum.Text = "";
                }
                catch (Exception execption)
                {
                    MessageBox.Show("Error : " + execption.Message);
                }
            }
        }

        private void cbxPays_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbxAnnee.DisplayMember = "numAnnee";
            cbxAnnee.ValueMember = "numAnnee";
            cbxAnnee.DataSource = AnneeManager.GetInstance().GetLesAnneesDisponiblePourUnPays((int)cbxPays.SelectedValue); //Récupération des Annees
            cbxAnnee.SelectedItem = null;
        }
    }
}
