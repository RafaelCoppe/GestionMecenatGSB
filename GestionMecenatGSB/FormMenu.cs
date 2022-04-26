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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void partenariatsToolStripMenuItem_Click(object sender, EventArgs e)//Ajout d'un partenariats
        {
            FormAjoutPartenariat lePartenariatAjout = new FormAjoutPartenariat();
            lePartenariatAjout.Show();
        }

        private void partenariatsToolStripMenuItem2_Click(object sender, EventArgs e)//Consultation des partenariats
        {
            FormConsultPartenariat lePartenariatConsult = new FormConsultPartenariat();
            lePartenariatConsult.Show();
        }

        private void associationsToolStripMenuItem_Click(object sender, EventArgs e)//Ajout d'une association
        {
            FormAjoutAssociation lAssociationAjout = new FormAjoutAssociation();
            lAssociationAjout.Show();
        }

        private void limitesDeMécénatToolStripMenuItem_Click(object sender, EventArgs e)//Ajout d'une limite de mécénat
        {
            FormAjoutLimiteMecenat laLimiteMecenatAjout = new FormAjoutLimiteMecenat();
            laLimiteMecenatAjout.Show();
        }

        private void associationsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormConsultAssoc leFormConsultAssoc = new FormConsultAssoc();
            leFormConsultAssoc.Show();
        }
        private void limiteDeMécénatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultLimiteMecenat laLimiteMecenatConsult = new FormConsultLimiteMecenat();
            laLimiteMecenatConsult.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifPartenariats lePartenariatModif = new FormModifPartenariats();
            lePartenariatModif.Show();
        }

        private void partenariatsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSupprPartenariat lePartenariatSuppr = new FormSupprPartenariat();
            lePartenariatSuppr.Show();
        }
    }
}
