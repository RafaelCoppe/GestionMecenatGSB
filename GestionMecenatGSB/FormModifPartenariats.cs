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
            idPartenariatChoisi = (int)dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;

            txtBudgetPrev.Text = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCoutReel.Text = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(idPartenariatChoisi != 0)
            {
            decimal budgetPrev = decimal.Parse(txtBudgetPrev.Text);
            decimal coutReel = decimal.Parse(txtCoutReel.Text);
            ActionMenee newActionMenee = new ActionMenee((int)cbxActionMenee.SelectedValue, cbxActionMenee.SelectedText);
            Association newAssoLiee = new Association((int)cbxAssoLiee.SelectedValue);

            int nb = PartenariatManager.GetInstance().ModifPartenariat(idPartenariatChoisi, budgetPrev, coutReel, newActionMenee, newAssoLiee);
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
