using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.bddManager;
using mediatek86.Model;

namespace mediatek86.dal
{
    
    public class absenceAccess
    {
        private readonly Access access;

        public absenceAccess()
        {
            access = Access.GetInstance();
        }

        public List<absence> GetAbsence(personnel personnel)
        {
           int idpersonnel = personnel.idpersonnel;
            List<absence> absences = new List<absence>();
            if (access.Manager != null)
            {
                string req = $"SELECT absence.idpersonnel, absence.datedebut, absence.datefin, absence.idmotif FROM absence JOIN personnel ON absence.idpersonnel = personnel.idpersonnel WHERE personnel.idpersonnel = {idpersonnel};";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    foreach (Object[] record in records)
                    {
                        if (records != null)
                        {
                            absence abs = new absence((int)record[0], (DateTime)record[1], (DateTime)record[2],(int)record[3]);
                            absences.Add(abs);
                        }
                    }
                    return absences;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return null;
        }

        public void DelAbsence(absence absence)
        {
            if (access.Manager != null)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                parameters.Add("@datedebut", absence.datedebut);
                parameters.Add("@datefin", absence.datefin);
                string req = $"DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin;";
               
                try
                {
                    access.Manager.ReqSelect(req,parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void AddAbsence(absence absence)
        {
            if(access.Manager != null)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                parameters.Add("@datedebut", absence.datedebut);
                parameters.Add("@datefin", absence.datefin);
                parameters.Add("@idmotif", absence.idmotif);
                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin,idmotif) Values (@idpersonnel, @datedebut, @datefin, @idmotif);";

                try
                {
                    access.Manager.ReqSelect(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void UpdateAbsence(absence absence)
        {
            if(access.Manager != null)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                parameters.Add("@datedebut", absence.datedebut);
                parameters.Add("@datefin", absence.datefin);
                parameters.Add("@idmotif", absence.idmotif);
                string req = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel;";
                try
                {
                    access.Manager.ReqSelect(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
