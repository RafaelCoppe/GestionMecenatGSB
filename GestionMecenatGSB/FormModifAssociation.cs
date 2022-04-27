using GestionMecenatBLL;
using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMecenatGSB
{
    public partial class FormModifAssociation : Form
    {
        public FormModifAssociation()
        {
            InitializeComponent();
            cbxModifMission.DisplayMember = "libelle";
            cbxModifMission.ValueMember = "id";
            cbxModifMission.DataSource = MissionManager.GetInstance().GetlesMissions();

            cbxModifPays.DisplayMember = "libelle";
            cbxModifPays.ValueMember = "id";
            cbxModifPays.DataSource = PaysManager.GetInstance().GetLesPays();

            cbxModifAssoc.DisplayMember = "nomAssociation";
            cbxModifAssoc.ValueMember = "id";
            cbxModifAssoc.DataSource = AssociationManager.GetInstance().GetAssociations();
        }

        /*/private void cbxModifAssoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idAssoc = (int)cbxModifAssoc.SelectedValue;
            Association uneAssociation = AssociationManager.GetInstance().RecupererAssociation(idAssoc);

            txtBoxModifNom.Text = uneAssociation.NomAssociation;
            txtModifResp.Text = uneAssociation.NomResponsbale;
        }/*/

        private void btnModifAssoc_Click(object sender, EventArgs e)
        {
            Mission laMission = new Mission((int)cbxModifMission.SelectedValue, cbxModifMission.SelectedText);
            Pays lePays = new Pays((int)cbxModifPays.SelectedValue, cbxModifPays.SelectedText);
            try
            {
                int idAssoc = (int)cbxModifAssoc.SelectedValue;
                
                AssociationManager.GetInstance().ModifAssociation(txtBoxModifNom.Text, txtModifResp.Text, lePays.Id, laMission.Id);
                MessageBox.Show("L'association a bien été modifié");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
