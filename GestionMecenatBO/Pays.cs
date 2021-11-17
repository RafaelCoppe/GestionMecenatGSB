using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    public class Pays
    {
        // Attributs
        private int id;
        private string libelle;
        private AvoirPourLimiteDeMecenat laLimiteDeMecenat;

        // Ascesseur en lecture et en ecriture
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public AvoirPourLimiteDeMecenat LaLimiteDeMecenat { get => laLimiteDeMecenat; set => laLimiteDeMecenat = value; }

        // Constructeur pour valoriser les 2 attributs
        public Pays(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        // Constructeur pour valoriser le libelle
        public Pays(string libelle)
        {
            this.libelle = libelle;
        }

        public Pays(int id)
        {
            this.id = id;
        }
    }
}
