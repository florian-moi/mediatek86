using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{

    public class motif
    {
        /// <summary>
        /// constructeur de la classe motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int idmotif { get; set; }

        public string libelle { get; set; }

        public override string ToString()
        {
            return libelle;
        }
    }
}
