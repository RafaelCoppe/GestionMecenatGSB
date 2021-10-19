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
    public partial class FormConsultAssoc : Form
    {
        public FormConsultAssoc()
        {
            InitializeComponent();

            try
            {
                dtgConsultAssoc.Visible = true;
                dtgConsultAssoc.DataSource = AssociationManager.GetInstance().GetAssociations();
                dtgConsultAssoc.Columns[3].Visible = false;
                dtgConsultAssoc.Columns[4].Visible = false;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bonsoir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
