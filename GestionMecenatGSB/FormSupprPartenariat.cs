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
    public partial class FormSupprPartenariat : Form
    {
        int idActionMenee = 0;
        int idAssoChoisie = 0;
        public FormSupprPartenariat()
        {
            InitializeComponent();

            dtgPartenariatChoisi.Columns.Add("id", "ID");
            dtgPartenariatChoisi.Columns.Add("budgetPrevisionnel", "Budget Prévisionnel");
            dtgPartenariatChoisi.Columns.Add("coutPartenariat", "Cout du partenariat");
            dtgPartenariatChoisi.Columns.Add("Action menée", "Action menée");
            dtgPartenariatChoisi.Columns.Add("Association liée", "Association liée");

            majCbx();
        }

        private void majCbx() //Mise à jour des deux combobox
        {
            dtgPartenariats.DataSource = PartenariatManager.GetInstance().GetLesPartenariats();
            dtgPartenariats.Columns[3].Visible = false;
            dtgPartenariats.Columns[3].Visible = false;
            dtgPartenariats.Columns[7].Visible = false;
            dtgPartenariats.Columns[8].Visible = false;

            dtgPartenariatChoisi.Rows[0].Cells[0].Value = "";
            dtgPartenariatChoisi.Rows[0].Cells[1].Value = "";
            dtgPartenariatChoisi.Rows[0].Cells[2].Value = "";
            dtgPartenariatChoisi.Rows[0].Cells[3].Value = "";
            dtgPartenariatChoisi.Rows[0].Cells[4].Value = "";
        }


        private void btnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes-vous sur de vouloir supprimer ce partenariat ?", "Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try { 
                    int nb = PartenariatManager.GetInstance().SupprPartenariat(
                    (int)dtgPartenariatChoisi.Rows[0].Cells[0].Value,
                    (decimal)dtgPartenariatChoisi.Rows[0].Cells[1].Value,
                    (decimal)dtgPartenariatChoisi.Rows[0].Cells[2].Value,
                    new ActionMenee(idActionMenee),
                    new Association(idAssoChoisie)
                    );

                    if(nb == -1)
                    {
                        MessageBox.Show("Suppression réussie", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La suppression n'a pas fonctionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception uneException)
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

        private void dtgPartenariats_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtgPartenariatChoisi.Rows[0].Cells[0].Value = dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;
            dtgPartenariatChoisi.Rows[0].Cells[1].Value = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value;
            dtgPartenariatChoisi.Rows[0].Cells[2].Value = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value;
            dtgPartenariatChoisi.Rows[0].Cells[3].Value = dtgPartenariats.Rows[e.RowIndex].Cells[5].Value;
            dtgPartenariatChoisi.Rows[0].Cells[4].Value = dtgPartenariats.Rows[e.RowIndex].Cells[6].Value;

            idActionMenee = (int)dtgPartenariats.Rows[e.RowIndex].Cells[7].Value;
            idAssoChoisie = (int)dtgPartenariats.Rows[e.RowIndex].Cells[8].Value;
        }
    }


}
