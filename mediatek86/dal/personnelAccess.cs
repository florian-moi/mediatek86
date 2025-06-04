using mediatek86.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.dal
{
    public class personnelAccess
    {
        private readonly Access access;

        public personnelAccess()
        {
            access = Access.GetInstance();
        }

        public List<personnel> Getpersonnel()
        {
            List<personnel> personnels = new List<personnel>();
            if (access.Manager != null)
            {
                try
                {
                    string req = "SELECT personnel.idpersonnel,personnel.nom,personnel.prenom,personnel.tel,personnel.mail,personnel.idservice, service.nom FROM personnel JOIN service ON personnel.idservice = service.idservice;";
                    List<Object[]> records = access.Manager.ReqSelect(req);

                    foreach (Object[] record in records)
                    {
                        if (records != null)
                        {
                            service ser = new service((int)record[5], (string)record[6]);
                            personnel perso = new personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], ser);
                            personnels.Add(perso);
                        }
                    }
                    return personnels;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return null;
        }
        
        public void Delpersonnel(personnel personnel)
        {
            if (access.Manager != null)
            {
                int id = personnel.idpersonnel;
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                string req = $"DELETE FROM personnel WHERE idpersonnel = {id}";
                try
                {
                    access.Manager.ReqSelect(req);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
        }

        public void Addpersonnel(personnel personnel)
        {
            if ((access.Manager !=  null))
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Nom", personnel.nom);
                parameters.Add("@Prenom", personnel.prenom);
                parameters.Add("@tel", personnel.telephone);
                parameters.Add("@mail", personnel.email);
                parameters.Add("@idprofil", personnel.service.idservice);
                string req = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@Nom, @Prenom, @tel, @mail, @idprofil)";
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
        }

        public void Updatepersonnel(personnel personnel)
        {
            if ((access.Manager != null))
            {
                string req = "UPDATE personnel SET nom = @nom,prenom = @prenom,tel = @tel,mail = @mail,idservice = @idservice WHERE idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
                parameters.Add("@nom", personnel.nom);
                parameters.Add("@prenom", personnel.prenom);
                parameters.Add("@tel", personnel.telephone);
                parameters.Add("@mail", personnel.email);
                parameters.Add("@idservice", personnel.service.idservice);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
