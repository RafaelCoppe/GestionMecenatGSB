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
    public partial class FormAjoutAssociation : Form
    {
        public FormAjoutAssociation()
        {
            InitializeComponent();
            cbxMission.DisplayMember = "libelle";
            cbxMission.ValueMember = "id";
            cbxMission.DataSource = MissionManager.GetInstance().GetlesMissions();

            cbxPays.DisplayMember = "libelle";
            cbxPays.ValueMember = "id";
            cbxPays.DataSource = PaysManager.GetInstance().GetLesPays();
        }

        private void btnAjoutAssoc_Click(object sender, EventArgs e)
        {
            string msgErr = "";
            if (txtNomAssoc.Text == "")
            {
                msgErr += "Ajouter un nom d'association \n";
            }

            if (txtNomResponsable.Text == "")
            {
                msgErr += "Ajouter un nom de responsable \n";
            }

            if (cbxMission.SelectedIndex == 0)
            {
                msgErr += "Veuillez sélectionner une mission \n";
            }

            if (cbxPays.SelectedIndex == 0)
            {
                msgErr += "Veuillez sélectionner un pays \n";
            }

            if (msgErr != "")
            {
                MessageBox.Show(msgErr);
            }
            else
            {

                Mission laMission = new Mission((int)cbxMission.SelectedValue, cbxMission.SelectedText);
                Pays lePays = new Pays((int)cbxPays.SelectedValue, cbxPays.SelectedText);

                try
                {
                    AssociationManager.GetInstance().CreerAssociation(txtNomAssoc.Text, txtNomResponsable.Text, lePays, laMission);
                    MessageBox.Show("L'association a bien été ajoutée");

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
