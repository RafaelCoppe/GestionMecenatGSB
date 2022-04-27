using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    /// <summary>
    /// Classe Pays qui réfère à la table pays de la base de données Mecenat
    /// int id : l'id du partenariat
    /// string libelle : le libelle de l'action
    /// 
    /// Deux constructeurs : 
    /// Un constructeur avec avec l'id et le libelle : utilisé pour récuperer les informations dans la base de données
    /// un constructeur avec seulement le libelle : utilisé pour insérer les informations dans la base de données
    /// </summary>
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
