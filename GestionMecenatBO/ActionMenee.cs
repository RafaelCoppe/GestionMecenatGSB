using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    /// <summary>
    /// Classe actionMenee qui réfère à la table actionMenee de la base de données Mecenat
    /// int id : l'id du partenariat
    /// string libelle : le libelle de l'action
    /// 
    /// Deux constructeurs : 
    /// Un constructeur avec avec l'id et le libelle : utilisé pour récuperer les informations dans la base de données
    /// un constructeur avec seulement le libelle : utilisé pour insérer les informations dans la base de données
    /// </summary>
    public class ActionMenee
    {
        //Déclaration des variables
        private int id;
        private string libelle;

        //Accesseurs en lecture et en écriture
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        //Constructeur avec id
        public ActionMenee(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        //Constructeur sans id
        public ActionMenee(string libelle)
        {
            this.libelle = libelle;
        }

        public ActionMenee(int id)
        {
            this.id = id;
        }
    }
}
