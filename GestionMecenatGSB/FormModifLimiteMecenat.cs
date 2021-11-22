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
        private int idLimiteMecanatChoisi;
        public FormModifLimiteMecenat()
        {
            InitializeComponent();
            majDonnees();
        }
        private void majDonnees()
        {
            dtgInfosLimiteMecenat.DataSource = AvoirPourLimiteDeMecenatManager.GetInstance().GetLimiteDeMecenat();

            dtgInfosLimiteMecenat.Columns[1].Visible = false;
            dtgInfosLimiteMecenat.Columns[2].Visible = false;

            dtgInfosLimiteMecenat.Columns[0].HeaderText = "Plafond de mécénat";
            dtgInfosLimiteMecenat.Columns[3].HeaderText = "Année";
            dtgInfosLimiteMecenat.Columns[4].HeaderText = "Pays";
        }

    }
}
