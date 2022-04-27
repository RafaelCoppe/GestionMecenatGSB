using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    /// <summary>
    /// Classe AvoirPourLimiteDeMecenat qui réfère à la table avoirPourLimiteDeMecenat de la base de données Mecenat
    /// decimal plafondMecenat : la valeur decimal du plafond de mecenat
    /// 
    /// Deux constructeurs : 
    /// Un constructeur complet 
    /// un constructeur avec seulement les objets 
    /// </summary>
    public class AvoirPourLimiteDeMecenat
    {
        // Attributs
        private decimal plafondMecenat;
        private Pays lePays;
        private Annee uneAnnee;

        // Ascesseur en lecture et en ecriture
        public decimal PlafondMecenat { get => plafondMecenat; set => plafondMecenat = value; }
        public Pays LePays { get => lePays; set => lePays = value; }
        public Annee UneAnnee { get => uneAnnee; set => uneAnnee = value; }
        public int idAnnee { get => UneAnnee.NumAnnee; }
        public string libPays { get => lePays.Libelle; }
        public int idPays { get => lePays.Id; }

        // Constructeur 
        public AvoirPourLimiteDeMecenat(decimal plafondMecenat, Pays lePays, Annee uneAnnee)
        {
            this.plafondMecenat = plafondMecenat;
            this.lePays = lePays;
            this.uneAnnee = uneAnnee;
        }
        public AvoirPourLimiteDeMecenat(Pays lePays, Annee uneAnnee)
        {
            this.lePays = lePays;
            this.uneAnnee = uneAnnee;
        }
        public AvoirPourLimiteDeMecenat(decimal plafondMecenat, int idPays, int idAnnee, Pays lePays, Annee uneAnnee)
        {
            this.plafondMecenat = plafondMecenat;
            this.lePays = lePays;
            this.uneAnnee = uneAnnee;
        }
    }
}