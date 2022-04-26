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
    public partial class FormConsultPartenariatParAction : Form
    {
        public FormConsultPartenariatParAction()
        {
            InitializeComponent();

            majCbx();
        }

        private void majCbx()
        {
            cbxActionMenee.DisplayMember = "libelle";
            cbxActionMenee.ValueMember = "id";
            cbxActionMenee.DataSource = ActionMeneeManager.GetInstance().GetLesActionsMenees();
        }


        private void cbxActionMenee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtgPartenariats.DataSource = PartenariatManager.GetInstance().GetLesPartenariatsParAction((int)cbxActionMenee.SelectedValue);
            if(dtgPartenariats.RowCount == 0)
            {
                MessageBox.Show("Aucune entrée pour l'action '" + cbxActionMenee.SelectedText + "'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            dtgPartenariats.Columns[3].Visible = false;
            dtgPartenariats.Columns[4].Visible = false;
            dtgPartenariats.Columns[5].Visible = false;
            dtgPartenariats.Columns[7].Visible = false;
            dtgPartenariats.Columns[8].Visible = false;

            dtgPartenariats.Columns[1].HeaderText = "Budget Prévisionnel";
            dtgPartenariats.Columns[2].HeaderText = "Cout réel";
            dtgPartenariats.Columns[6].HeaderText = "Nom de l'association";
        }
    }
}
