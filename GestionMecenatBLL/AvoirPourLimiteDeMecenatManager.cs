﻿using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class AvoirPourLimiteDeMecenatManager
    {
        private static AvoirPourLimiteDeMecenatManager uneInstance;

        //Création d'une instance du Manager
        public static AvoirPourLimiteDeMecenatManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AvoirPourLimiteDeMecenatManager();
            }
            return uneInstance;
        }

        private AvoirPourLimiteDeMecenatManager()
        {
        }

        // Appel de la méthode AjoutLimiteDeMecenat de la DAO
        public int AjoutLimiteMecenat(decimal SommeMaximum, int idPays, string libellePays, int idAnnee)
        {
            Pays unPays = new Pays(idPays, libellePays);
            Annee uneAnnee = new Annee(idAnnee);
            AvoirPourLimiteDeMecenat uneLimiteMecenat = new AvoirPourLimiteDeMecenat(SommeMaximum, unPays, uneAnnee);
            return AvoirPourLimiteDeMecenatDAO.GetInstance().AjoutLimiteDeMecenat(uneLimiteMecenat);
        }

        // Appel de la méthode GetLimiteDeMecenat de la DAO
        public List<AvoirPourLimiteDeMecenat> GetLimiteDeMecenat()
        {
            return AvoirPourLimiteDeMecenatDAO.GetInstance().GetLimiteDeMecenat();
        }
        //Appel de la méthode ModifLimiteMecenat de la DAO
        public int ModifLimiteMecenat(Decimal plafondMecenat, Pays newPays, Annee newAnnee, Pays ancienPays, Annee ancienneAnnee)
        {
            AvoirPourLimiteDeMecenat uneLimiteMecenatModifie = new AvoirPourLimiteDeMecenat(plafondMecenat, newPays, newAnnee);
            AvoirPourLimiteDeMecenat uneLimiteMecenatAncien = new AvoirPourLimiteDeMecenat(ancienPays, ancienneAnnee);
            return AvoirPourLimiteDeMecenatDAO.GetInstance().ModifLimiteMecenat(uneLimiteMecenatModifie, uneLimiteMecenatAncien);
        }

        public int SupprLimiteMecenat(Decimal plafondMecenat, Pays newPays, Annee newAnnee)
        {
            AvoirPourLimiteDeMecenat uneLimiteMecenatModifie = new AvoirPourLimiteDeMecenat(plafondMecenat, newPays, newAnnee);
            return AvoirPourLimiteDeMecenatDAO.GetInstance().SupprLimiteMecenat(uneLimiteMecenatModifie);
        }
    }
}