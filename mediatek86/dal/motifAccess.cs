using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.Model;


namespace mediatek86.dal
{
    public class motifAccess
    {
        private readonly Access access;

        public motifAccess()
        {
            access = Access.GetInstance();
        }

        public List<motif> GetMotifs()
        {
            List<motif> motifs = new List<motif>();
            if (access.Manager != null)
            {
                string req = "SELECT idmotif, libelle FROM motif";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    foreach (Object[] record in records)
                    {
                        if (records != null)
                        {
                            motif mot = new motif((int)record[0], (string)record[1]);
                            motifs.Add(mot);
                        }
                    }
                    return motifs;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return null;
        }
    }
}
