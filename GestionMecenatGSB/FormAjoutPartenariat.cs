using GestionMecenatBLL;
using GestionMecenatBO;
using System;
using System.Windows.Forms;

namespace GestionMecenatGSB
{
    public partial class FormAjoutPartenariat : Form
    {
        public FormAjoutPartenariat()
        {
            InitializeComponent();
            majCbx();
        }

        private void majCbx() //Mise à jour des deux combobox
        {
            cbxActionMenee.DisplayMember = "libelle";
            cbxActionMenee.ValueMember = "id";
            cbxActionMenee.DataSource = ActionMeneeManager.GetInstance().GetLesActionsMenees(); //Récupération des Actions

            cbxAssoLiee.DisplayMember = "NomAssociation";
            cbxAssoLiee.ValueMember = "id";
            cbxAssoLiee.DataSource = AssociationManager.GetInstance().GetAssociations(); //Récupération des Actions

            cbxActionMenee.SelectedItem = null;
            cbxAssoLiee.SelectedItem = null;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e) //Appui sur le bouton enregistrer
        {
            string ErreursEntrees = ""; //Liste des erreurs
            if (txtBudgetPrevu.Text.Trim() == "," || txtBudgetPrevu.Text.Trim() == "0,") //Si il n'y a pas de budget prévu
            {
                ErreursEntrees += "Veuillez entrer le budget prévu !\n";
                txtBudgetPrevu.Focus(); //Curseur sur le champ qui pose problème
            }
            
            if (txtCoutPartenariat.Text.Trim() == "," || txtCoutPartenariat.Text.Trim() == "0,") //Si il n'y a pas de cout du partenariat
            {
                ErreursEntrees += "Veuillez entrer le cout du partenariat !\n";
                if (txtBudgetPrevu.Focused == false) txtCoutPartenariat.Focus();//Si le premier champ n'est pas focus, on met le urseur sur celui-ci
            }

            if (cbxActionMenee.SelectedItem == null) //Si il n'y a pas de cout du partenariat
            {
                ErreursEntrees += "Veuillez sélectionner une action dans la liste déroulante !\n";
                if (txtBudgetPrevu.Focused == false && txtCoutPartenariat.Focused == false) cbxActionMenee.Focus();//Si le premier champ n'est pas focus, on met le urseur sur celui-ci
            }

            if (cbxAssoLiee.SelectedItem == null) //Si il n'y a pas de cout du partenariat
            {
                ErreursEntrees += "Veuillez sélectionner une association dans la liste déroulante !";
                if (txtBudgetPrevu.Focused == false && txtCoutPartenariat.Focused == false && cbxActionMenee.Focused == false) cbxAssoLiee.Focus();//Si le premier champ n'est pas focus, on met le urseur sur celui-ci
            }


            if (ErreursEntrees != "") //Si erreurs, on affiche une messageBox
            {
                MessageBox.Show(ErreursEntrees, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Sinon on continue le programme
            {
                int nbAjouts;

                //On récupère les deux valeurs budget et coût réel
                float budgetPrevu = float.Parse(txtBudgetPrevu.Text);
                float coutPartenariat = float.Parse(txtCoutPartenariat.Text);

                //On crée deux objets ActionMenee et Association
                int choixActionMenee = (int)cbxActionMenee.SelectedValue;
                int choixAssociation = (int)cbxAssoLiee.SelectedValue;

                //Appel de la méthode AjoutPartenariat
                try
                {
                    nbAjouts = PartenariatManager.GetInstance().AjoutPartenariat(budgetPrevu, coutPartenariat, choixActionMenee, choixAssociation);
                    if (nbAjouts == 1)
                    {
                        MessageBox.Show("Insertion réussie", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception uneException)
                {

                    MessageBox.Show("Problème au niveau de l'insertion : " + uneException.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                majCbx();
                txtBudgetPrevu.Text = "";
                txtCoutPartenariat.Text = "";
            }
            
        }
    }
}
