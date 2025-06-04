using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class personnel
    {
        public personnel(int idpersonnel, string nom, string prenom, string adresse, string telephone, string email,int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.email = email;
            this.idservice = idservice;
        }

        public int idpersonnel { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string adresse { get; set; }

        public string telephone { get; set; }

        public string email { get; set; }

        public int idservice { get; set; }
    }
}
