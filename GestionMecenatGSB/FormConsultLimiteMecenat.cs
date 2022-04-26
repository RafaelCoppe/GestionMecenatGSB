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
    public partial class FormConsultLimiteMecenat : Form
    {
        public FormConsultLimiteMecenat()
        {
            InitializeComponent();
            dtgConsultLimiteMecenat.DataSource = AvoirPourLimiteDeMecenatManager.GetInstance().GetLimiteDeMecenat();

            dtgConsultLimiteMecenat.Columns[1].Visible = false;
            dtgConsultLimiteMecenat.Columns[2].Visible = false;
            dtgConsultLimiteMecenat.Columns[5].Visible = false;

            dtgConsultLimiteMecenat.Columns[0].HeaderText = "Plafond de mécénat";
            dtgConsultLimiteMecenat.Columns[3].HeaderText = "Année";
            dtgConsultLimiteMecenat.Columns[4].HeaderText = "Pays";
        }

    }
}
