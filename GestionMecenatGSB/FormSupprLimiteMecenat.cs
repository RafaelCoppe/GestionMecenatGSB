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
    public partial class FormSupprLimiteMecenat : Form
    {
        int idPays = 0;
        int idAnnee = 0;
        public FormSupprLimiteMecenat()
        {
            InitializeComponent();
            dtgLimiteChoisi.Columns.Add("plafondMecenat", "Plafond de mécénat");
            dtgLimiteChoisi.Columns.Add("idAnnee", "Année");
            dtgLimiteChoisi.Columns.Add("idPays", "Pays");
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

            dtgLimiteChoisi.Rows[0].Cells[0].Value = "";
            dtgLimiteChoisi.Rows[0].Cells[1].Value = "";
            dtgLimiteChoisi.Rows[0].Cells[2].Value = "";
        }

            private void dtgConsultLimiteMecenat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgLimiteChoisi.Rows[0].Cells[0].Value = dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[0].Value;
            dtgLimiteChoisi.Rows[0].Cells[1].Value = dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[3].Value;
            dtgLimiteChoisi.Rows[0].Cells[2].Value = dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[4].Value;

            idPays = (int)dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[5].Value;
            idAnnee = (int)dtgConsultLimiteMecenat.Rows[e.RowIndex].Cells[3].Value;
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cette limite de mecenat ?", "Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int nb = AvoirPourLimiteDeMecenatManager.GetInstance().SupprLimiteMecenat(
                    (decimal)dtgLimiteChoisi.Rows[0].Cells[0].Value,
                    new Pays(idPays),
                    new Annee(idAnnee)
                    );

                    if (nb == -1)
                    {
                        MessageBox.Show("Suppression réussie", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La suppression n'a pas fonctionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception uneException)
                {
                    MessageBox.Show("Problème au niveau de la suppression : " + uneException.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                majCbx();
            }
            else if (dialogResult == DialogResult.No)
            {
                majCbx();
            }
        }
    }
}
