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
    public partial class FormConsultPartenariat : Form
    {
        public FormConsultPartenariat()
        {
            InitializeComponent();
        }

        private void btnAfficherPartenariats_Click(object sender, EventArgs e)
        {
            dtgAfficherPartenariats.DataSource = PartenariatManager.GetInstance().GetLesPartenariats();
            dtgAfficherPartenariats.Columns[3].Visible = false;
            dtgAfficherPartenariats.Columns[4].Visible = false;
            dtgAfficherPartenariats.Columns[7].Visible = false;
            dtgAfficherPartenariats.Columns[8].Visible = false;
        }
    }
}
