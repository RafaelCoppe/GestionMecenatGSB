﻿using GestionMecenatBLL;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMecenatGSB
{
    public partial class FormModifAssociation : Form
    {
        public FormModifAssociation()
        {
            InitializeComponent();
            cbxModifMission.DisplayMember = "libelle";
            cbxModifMission.ValueMember = "id";
            cbxModifMission.DataSource = MissionManager.GetInstance().GetlesMissions();

            cbxModifPays.DisplayMember = "libelle";
            cbxModifPays.ValueMember = "id";
            cbxModifPays.DataSource = PaysManager.GetInstance().GetLesPays();

            cbxModifAssoc.DisplayMember = "nomAssociation";
            cbxModifAssoc.ValueMember = "id";
            cbxModifAssoc.DataSource = AssociationManager.GetInstance().GetAssociations();
        }

        //private void cbxModifAssoc_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    int idAssoc = (int)cbxModifAssoc.SelectedValue;
        //    AssociationDAO uneAssociation = AssociationManager.GetInstance().CreerAssociation();

        //}
    }
}