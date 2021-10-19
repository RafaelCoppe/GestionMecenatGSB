using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBO
{
    public class Mission
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Mission(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Mission(int id)
        {
            this.id = id;            
        }
    }
}