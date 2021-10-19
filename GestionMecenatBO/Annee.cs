using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    public class Annee
    {
        // Attributs
        private int numAnnee;

        // Ascesseur en lecture et en ecriture
        public int NumAnnee { get => numAnnee; set => numAnnee = value; }

        // Constructeur 
        public Annee(int numAnnee)
        {
            this.NumAnnee = numAnnee;
        }
    }
}
