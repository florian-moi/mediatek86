using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class personnel
    {
        /// <summary>
        /// constructeur de la classe personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="service"></param>
        public personnel(int idpersonnel, string nom, string prenom,string telephone, string email,service service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.service = service;
        }

        public int idpersonnel { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string telephone { get; set; }

        public string email { get; set; }

        public service service { get; set; }

        public override string ToString()
        {
            return $"{prenom} {nom} ({service.nom})";
        }
    }
}
