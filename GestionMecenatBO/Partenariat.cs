﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    /// <summary>
    /// Classe Partenariat en référence à la table Partenariat de la base de données
    /// 
    /// 5 attributs : 
    /// int id : l'id du partenariat
    /// float budgetPrevisionel : le budget prévu au départ pour le partenariat
    /// float coutPartenariat : le coût réel du partenariat
    /// ActionMenee actionMenee : l'action menée par l'équipe en charge du partenariat
    /// Association associationLiee : l'association avec laquelle GSB est liée pour ce partenariat 
    /// 
    /// deux constructeurs : 
    /// Un constructeur avec tous les attributs : utilisé pour récuperer les informations dans la base de données
    /// un constructeur avec tous les attributs sauf l'id : utilisé pour insérer les informations dans la base de données
    /// </summary>
    public class Partenariat
    {
        //Déclaration des variables
        private int id;
        private int idActionMennee;
        private int idAssociationLiee;
        private decimal budgetPrevisionnel;
        private decimal coutPartenariat;
        private ActionMenee actionMennee;
        private Association associationLiee;

        //Accesseurs en lecture et en écriture
        public int Id { get => id; set => id = value; }
        public decimal BudgetPrevisionnel { get => budgetPrevisionnel; set => budgetPrevisionnel = value; }
        public decimal CoutPartenariat { get => coutPartenariat; set => coutPartenariat = value; }

        public ActionMenee ActionMennee { get => actionMennee; set => actionMennee = value; }
        public Association AssociationLiee { get => associationLiee; set => associationLiee = value; }
        public string LibelleActionMenee { get => ActionMennee.Libelle; }
        public string LibelleAssociationLiee { get => AssociationLiee.NomAssociation; }
        public int IdActionMenee { get => ActionMennee.Id; }
        public int IdAssociationLiee { get => AssociationLiee.Id; }

        //Constructeur avec id
        public Partenariat(int id, decimal budgetPrevisionnel, decimal coutPartenariat, ActionMenee actionMennee, Association uneAssociation)
        {
            this.id = id;
            this.budgetPrevisionnel = budgetPrevisionnel;
            this.coutPartenariat = coutPartenariat;

            this.actionMennee = actionMennee;
            this.associationLiee = uneAssociation;
        }

        //Constructeur sans id
        public Partenariat(decimal budgetPrevisionnel, decimal coutPartenariat, ActionMenee actionMennee, Association uneAssociation)
        {
            this.budgetPrevisionnel = budgetPrevisionnel;
            this.coutPartenariat = coutPartenariat;

            this.actionMennee = actionMennee;
            this.associationLiee = uneAssociation;
        }

        //Constructeur avec un id à la place des objets ActionMenee et Association
        public Partenariat(int id, decimal budgetPrevisionnel, decimal coutPartenariat, int idActionMennee, int idAssociation)
        {
            this.id = id;

            this.budgetPrevisionnel = budgetPrevisionnel;
            this.coutPartenariat = coutPartenariat;

            this.idActionMennee = idActionMennee;
            this.idAssociationLiee = idAssociation;
        }
    }
}
