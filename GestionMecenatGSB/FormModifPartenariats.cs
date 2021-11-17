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

            cbxActionMenee.DisplayMember = "libelle";
            cbxActionMenee.ValueMember = "id";
            cbxActionMenee.DataSource = ActionMeneeManager.GetInstance().GetLesActionsMenees(); //Récupération des Actions

            cbxAssoLiee.DisplayMember = "NomAssociation";
            cbxAssoLiee.ValueMember = "id";
            cbxAssoLiee.DataSource = AssociationManager.GetInstance().GetAssociations(); //Récupération des Actions

            cbxActionMenee.SelectedItem = null;
            cbxAssoLiee.SelectedItem = null;
        }
    }
}
