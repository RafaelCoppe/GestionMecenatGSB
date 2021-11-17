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
            int idPartenariatChoisi = (int)dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;

            txtBudgetPrev.Text = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCoutReel.Text = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value.ToString();

            /*cbxAssoLiee.SelectedIndex = dtgPartenariats.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxActionMenee.SelectedText = dtgPartenariats.Rows[e.RowIndex].Cells[4].Value.ToString();*/
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Partenariat lePartenariatModifie = new Partenariat(decimal.Parse(txtBudgetPrev.Text), decimal.Parse(txtCoutReel.Text), (int)cbxActionMenee.SelectedValue, (int)cbxAssoLiee.SelectedValue);
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
