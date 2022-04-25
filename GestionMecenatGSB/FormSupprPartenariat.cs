﻿using GestionMecenatBLL;
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
            majCbx();

            dtgPartenariatChoisi.Columns.Add("id", "ID");
            dtgPartenariatChoisi.Columns.Add("budgetPrevisionnel", "Budget Prévisionnel");
            dtgPartenariatChoisi.Columns.Add("coutPartenariat", "Cout du partenariat");
            dtgPartenariatChoisi.Columns.Add("Action menée", "Action menée");
            dtgPartenariatChoisi.Columns.Add("Association liée", "Association liée");
        }

        private void majCbx() //Mise à jour des deux combobox
        {
            dtgPartenariats.DataSource = PartenariatManager.GetInstance().GetLesPartenariats();
            dtgPartenariats.Columns[3].Visible = false;
            dtgPartenariats.Columns[4].Visible = false;
            dtgPartenariats.Columns[7].Visible = false;
            dtgPartenariats.Columns[8].Visible = false;
        }

        private void dtgPartenariats_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgPartenariatChoisi.Rows[0].Cells[0].Value = dtgPartenariats.Rows[e.RowIndex].Cells[0].Value;
            dtgPartenariatChoisi.Rows[0].Cells[1].Value = dtgPartenariats.Rows[e.RowIndex].Cells[1].Value;
            dtgPartenariatChoisi.Rows[0].Cells[2].Value = dtgPartenariats.Rows[e.RowIndex].Cells[2].Value;
            dtgPartenariatChoisi.Rows[0].Cells[3].Value = dtgPartenariats.Rows[e.RowIndex].Cells[5].Value;
            dtgPartenariatChoisi.Rows[0].Cells[4].Value = dtgPartenariats.Rows[e.RowIndex].Cells[6].Value;
        }
    }


}
