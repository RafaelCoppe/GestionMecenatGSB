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
    public partial class FormModifPartenariats : Form
    {
        private int idPartenariatChoisi = 0;
        bool partenariatChoisi = false;
        public FormModifPartenariats()
        {
            InitializeComponent();
            majCbx();
        }

        private void majCbx() //Mise à jour des deux combobox
        {
            dtgPartenariats.DataSource = PartenariatManager.GetInstance().GetLesPartenariats();
            dtgPartenariats.Columns[3].Visible = false;
            dtgPartenariats.Columns[4].Visible = false;
            dtgPartenariats.Columns[7].Visible = false;
            dtgPartenariats.Columns[8].Visible = false;

            cbxActionMenee.DisplayMember = "libelle";
            cbxActionMenee.ValueMember = "id";
            cbxActionMenee.DataSource = ActionMeneeManager.GetInstance().GetLesActionsMenees(); //Récupération des Actions

            cbxAssoLiee.DisplayMember = "NomAssociation";
            cbxAssoLiee.ValueMember = "id";
            cbxAssoLiee.DataSource = AssociationManager.GetInstance().GetAssociations(); //Récupération des Actions

            cbxActionMenee.SelectedItem = null;
            cbxAssoLiee.SelectedItem = null;
        }

        private void dtgPartenariats_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            partenariatChoisi = true;
            idPartenariatChoisi = (int)dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;
            string budgetPrev = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value.ToString();
            string coutReel = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value.ToString();

            int lenBudgetPrev = budgetPrev.Length;
            while (lenBudgetPrev < 7) 
            {
                budgetPrev = " " + budgetPrev;
                lenBudgetPrev = budgetPrev.Length;
            }
            txtBudgetPrev.Text = budgetPrev;

            int lenCoutReel = coutReel.Length;
            while (lenCoutReel < 7)
            {
                coutReel = " " + coutReel;
                lenCoutReel = coutReel.Length;
            }
            txtCoutReel.Text = coutReel;

            cbxActionMenee.SelectedValue = (int)dtgPartenariats.Rows[e.RowIndex].Cells[7].Value;
            cbxAssoLiee.SelectedValue = (int)dtgPartenariats.Rows[e.RowIndex].Cells[8].Value;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (partenariatChoisi == false)
            {
                MessageBox.Show("Choisissez un partenariat en double-cliquant sur une cellule", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    string ErreursEntrees = ""; //Liste des erreurs
                    if (txtBudgetPrev.Text.Trim() == "," || txtBudgetPrev.Text.Trim() == "0,") //Si il n'y a pas de budget prévu
                    {
                        ErreursEntrees += "Veuillez entrer le budget prévu !\n";
                        txtBudgetPrev.Focus(); //Curseur sur le champ qui pose problème
                    }

                    if (txtCoutReel.Text.Trim() == "," || txtCoutReel.Text.Trim() == "0,") //Si il n'y a pas de cout du partenariat
                    {
                        ErreursEntrees += "Veuillez entrer le cout du partenariat !\n";
                        if (txtBudgetPrev.Focused == false) txtCoutReel.Focus();//Si le premier champ n'est pas focus, on met le curseur sur celui-ci
                    }

                    if (cbxActionMenee.SelectedItem == null) //Si il n'y a pas de cout du partenariat
                    {
                        ErreursEntrees += "Veuillez sélectionner une action dans la liste déroulante !\n";
                        if (txtBudgetPrev.Focused == false && txtCoutReel.Focused == false) cbxActionMenee.Focus();//Si aucun champ n'est focus, on met le curseur sur celui-ci
                    }

                    if (cbxAssoLiee.SelectedItem == null) //Si il n'y a pas de cout du partenariat
                    {
                        ErreursEntrees += "Veuillez sélectionner une association dans la liste déroulante !";
                        if (txtBudgetPrev.Focused == false && txtCoutReel.Focused == false && cbxActionMenee.Focused == false) cbxAssoLiee.Focus();//Si aucun champ n'est focus, on met le curseur sur celui-ci
                    }


                    if (ErreursEntrees != "") //Si erreurs, on affiche une messageBox
                    {
                        MessageBox.Show(ErreursEntrees, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            decimal budgetPrev = decimal.Parse(txtBudgetPrev.Text);
                            decimal coutReel = decimal.Parse(txtCoutReel.Text);
                            ActionMenee newActionMenee = new ActionMenee((int)cbxActionMenee.SelectedValue, cbxActionMenee.SelectedText);
                            Association newAssoLiee = new Association((int)cbxAssoLiee.SelectedValue);

                            int nb = PartenariatManager.GetInstance().ModifPartenariat(idPartenariatChoisi, budgetPrev, coutReel, newActionMenee, newAssoLiee);
                        
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
            txtBudgetPrev.Text = "";
            txtCoutReel.Text = "";

            cbxAssoLiee.SelectedIndex = -1;
            cbxActionMenee.SelectedIndex = -1;
        }
    }
}
