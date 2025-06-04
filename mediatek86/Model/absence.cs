using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class absence
    {

        /// <summary>
        /// constrcteur de la classe absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
        }

        public int idpersonnel { get; set; }
        public DateTime datedebut { get; set; }
        public DateTime datefin { get; set; }
        public int idmotif { get; set; }

    }
}
