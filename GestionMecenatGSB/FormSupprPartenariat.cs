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
            dtgPartenariats.Columns[4].Visible = false;
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
            int nb = PartenariatManager.GetInstance().SupprPartenariat(
                (int)dtgPartenariatChoisi.Rows[0].Cells[0].Value,
                (decimal)dtgPartenariatChoisi.Rows[0].Cells[1].Value,
                (decimal)dtgPartenariatChoisi.Rows[0].Cells[2].Value,
                new ActionMenee(dtgPartenariatChoisi.Rows[0].Cells[3].Value.ToString()),
                new Association(dtgPartenariatChoisi.Rows[0].Cells[4].Value.ToString())
                );

            majCbx();
        }

        private void dtgPartenariats_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtgPartenariatChoisi.Rows[0].Cells[0].Value = dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;
            dtgPartenariatChoisi.Rows[0].Cells[1].Value = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value;
            dtgPartenariatChoisi.Rows[0].Cells[2].Value = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value;
            dtgPartenariatChoisi.Rows[0].Cells[3].Value = dtgPartenariats.Rows[e.RowIndex].Cells[5].Value;
            dtgPartenariatChoisi.Rows[0].Cells[4].Value = dtgPartenariats.Rows[e.RowIndex].Cells[6].Value;
        }
    }


}
