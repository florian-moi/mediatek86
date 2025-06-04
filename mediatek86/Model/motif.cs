using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    
    public class motif
    {
        public motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int idmotif { get; set; }

        public string libelle { get; set; }
    }
}
