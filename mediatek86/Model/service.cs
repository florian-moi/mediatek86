using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class service
    {
        /// <summary>
        /// constructeur de la classe service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int idservice { get; set; }

        public string nom { get; set; }

        public override string ToString()
        {
            return nom;
        }
    }
}
