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

        public void majCbx() //Mise à jour des deux combobox
        {
            cbxPays.DisplayMember = "libelle";
            cbxPays.ValueMember = "id";
            cbxPays.DataSource = PaysManager.GetInstance().GetLesPays(); // Récupération des Pays
        }

        private void btnAjouter_Click(object sender, EventArgs e) //Appui sur le bouton enregistrer
        {
            int nbAjouts;
            string msgErr = "";  //Liste des erreurs
            if (cbxPays.SelectedIndex == 0)
            {
                msgErr += ("Veuillez sélectionner un pays \n");
            }
            if (cbxAnnee.SelectedIndex == -1)
            {
                msgErr += ("Veuillez sélectionner un annee \n");
            }
            if (txtSommeMaximum.Text.Trim() == "," || txtSommeMaximum.Text.Trim() == "0") //Si il n'y a pas de somme maximum
            {
                msgErr += ("Veuillez saisir une somme maximum \n");
            }

            if (msgErr != "")
            {
                MessageBox.Show(msgErr);
            }
            else
            {
                //On récupère la valeur de la SommeMaximum
                decimal SommeMaximum = decimal.Parse(txtSommeMaximum.Text);

                //Appel de la méthode AjoutLimiteMecenat
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
