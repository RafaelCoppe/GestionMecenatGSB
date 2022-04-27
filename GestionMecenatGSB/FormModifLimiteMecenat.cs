
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

        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

    }
}