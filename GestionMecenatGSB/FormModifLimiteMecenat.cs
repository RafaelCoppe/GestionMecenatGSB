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
    public partial class FormModifLimiteMecenat : Form
    {
        public FormModifLimiteMecenat()
        {
            InitializeComponent();
            cbxLimiteMecenat.DisplayMember = "Identite";
            cbxLimiteMecenat.ValueMember = "id";
            cbxLimiteMecenat.DataSource = AvoirPourLimiteDeMecenatManager.GetInstance().GetLesLimitesDeMecenat();
        }

        private void btnAnnulLimiteMecenat_Click(object sender, EventArgs e)
        {
            pnlLimiteMecenat.Visible = false;
            lblLimiteMecenat.Visible = true;
            cbxLimiteMecenat.Visible = true;
        }
    }
}
