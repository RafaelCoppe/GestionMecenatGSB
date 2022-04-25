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
    public partial class FormSupprPartenariat : Form
    {
        public FormSupprPartenariat()
        {
            InitializeComponent();
            majCbx();
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
            dtgPartenariatChoisi.DataSource = PartenariatManager.GetInstance().GetLePartenariat((int)dtgPartenariats.Rows[e.RowIndex].Cells[0].Value);
        }
    }


}
