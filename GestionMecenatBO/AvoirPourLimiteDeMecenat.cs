using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    public class AvoirPourLimiteDeMecenat
    {
        // Attributs
        private float plafondMecenat;
        private Pays lePays;
        private Annee uneAnnee;

        // Ascesseur en lecture et en ecriture
        public float PlafondMecenat { get => plafondMecenat; set => plafondMecenat = value; }
        public Pays LePays { get => lePays; set => lePays = value; }
        public Annee UneAnnee { get => uneAnnee; set => uneAnnee = value; }
        public int libAnnee { get => UneAnnee.NumAnnee; }
        public string libPays { get => lePays.Libelle;  }
        // Constructeur 
        public AvoirPourLimiteDeMecenat(float plafondMecenat, Pays lePays, Annee uneAnnee)
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
        public AvoirPourLimiteDeMecenat(float plafondMecenat, int idPays, int idAnnee, Pays lePays, Annee uneAnnee)
        {
            this.plafondMecenat = plafondMecenat;
            this.lePays = lePays;
            this.uneAnnee = uneAnnee;
        }
    }
}
