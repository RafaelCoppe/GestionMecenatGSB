using GestionMecenatBLL;
using GestionMecenatBO;
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
    public partial class FormModifLimiteMecenat : Form
    {
        private int idPays = 0;
        private int idAnnee = 0;
        bool limiteMecenatChoisi = false;

        public FormModifLimiteMecenat()
        {
            InitializeComponent();
            majCbx();
        }
        private void majCbx() //Mise à jour des deux combobox
        {
            dtgConsultLimiteMecenat.DataSource = AvoirPourLimiteDeMecenatManager.GetInstance().GetLimiteDeMecenat();

            dtgConsultLimiteMecenat.Columns[1].Visible = false;
            dtgConsultLimiteMecenat.Columns[2].Visible = false;
            dtgConsultLimiteMecenat.Columns[5].Visible = false;

            dtgConsultLimiteMecenat.Columns[0].HeaderText = "Plafond de mécénat";
            dtgConsultLimiteMecenat.Columns[3].HeaderText = "Année";
            dtgConsultLimiteMecenat.Columns[4].HeaderText = "Pays";

            cbxPays.DisplayMember = "libelle";
            cbxPays.ValueMember = "id";
            cbxPays.DataSource = PaysManager.GetInstance().GetLesPays(); // Récupération des Pays

            cbxAnnee.DisplayMember = "numAnnee";
            cbxAnnee.ValueMember = "numAnnee";
            cbxAnnee.DataSource = AnneeManager.GetInstance().GetLesAnneesDisponiblePourUnPays((int)cbxPays.SelectedValue); //Récupération des Annees
            cbxAnnee.SelectedItem = null;
        }


        private void dtgConsultLimiteMecenat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSommeMax.Text = dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[0].Value.ToString();
            limiteMecenatChoisi = true;

            idPays = (int)dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[5].Value;
            idAnnee = (int)dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[3].Value;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (limiteMecenatChoisi == false)
            {
                MessageBox.Show("Choisissez une limite de mecenat en double-cliquant sur une cellule", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ErreursEntrees = ""; //Liste des erreurs
                if (txtSommeMax.Text.Trim() == "," || txtSommeMax.Text.Trim() == "0,") //Si il n'y a pas de somme
                {
                    ErreursEntrees += "Veuillez entrer une somme maximale !\n";
                    txtSommeMax.Focus(); //Curseur sur le champ qui pose problème
                }

                if (cbxAnnee.SelectedItem == null) //Si il n'y a pas d'annee
                {
                    ErreursEntrees += "Veuillez sélectionner une annee dans la liste déroulante !\n";
                    if (txtSommeMax.Focused == false) cbxAnnee.Focus();//Si aucun champ n'est focus, on met le curseur sur celui-ci
                }

                if (cbxPays.SelectedItem == null) //Si il n'y a pas de pays
                {
                    ErreursEntrees += "Veuillez sélectionner un pays dans la liste déroulante !";
                    if (txtSommeMax.Focused == false && cbxAnnee.Focused == false) cbxPays.Focus();//Si aucun champ n'est focus, on met le curseur sur celui-ci
                }

                if (ErreursEntrees != "") //Si erreurs, on affiche une messageBox
                {
                    MessageBox.Show(ErreursEntrees, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        decimal plafondMecenat = decimal.Parse(txtSommeMax.Text);
                        Pays newPays = new Pays((int)cbxPays.SelectedValue, cbxPays.SelectedText);
                        Annee newAnnee = new Annee((int)cbxAnnee.SelectedValue);
                        Pays ancienPays = new Pays(idPays);
                        Annee ancienneAnnee = new Annee(idAnnee);

                        int nb = AvoirPourLimiteDeMecenatManager.GetInstance().ModifLimiteMecenat(plafondMecenat, newPays, newAnnee, ancienPays, ancienneAnnee);
                        if (nb == -1)
                        {
                            MessageBox.Show("Modification réussie", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La modification n'a pas fonctionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception uneException)
                    {
                        MessageBox.Show("Problème au niveau de la modification : " + uneException.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                majCbx();
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtSommeMax.Text = "";

            cbxAnnee.SelectedIndex = -1;
            cbxPays.SelectedIndex = -1;
        }

    }
}
