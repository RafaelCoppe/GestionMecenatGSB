using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    public class Association
    {
        private int id;
        private string nomAssociation;
        private string nomResponsable;
        private Mission laMission;
        private Pays lePays;

        public int Id { get => id; set => id = value; }
        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string NomResponsbale { get => nomResponsable; set => nomResponsable = value; }
        public Mission LaMission { get => laMission; set => laMission = value; }
        public Pays LePays { get => lePays; set => lePays = value; }

        //POUR RENDRE VISIBLE LA MISSION ET LE PAYS
        public string libMission { get => laMission.Libelle; }
        public string libPays { get => lePays.Libelle; }
      

        public Association(int id, string nomAssociation, string nomResponsable, Mission laMission, Pays lePays)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.laMission = laMission;
            this.lePays = lePays;
        }

        public Association(int id)
        {
            this.id = id;
        }

        public Association(string nomAssociation, string nomResponsable, Mission laMission, Pays lePays)
        {
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.laMission = laMission;
            this.lePays = lePays;
        }

    }

}
