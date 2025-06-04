using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.Model;

namespace mediatek86.dal
{
    public class responsableAccess
    {
        private readonly Access access;

        public responsableAccess()
        {
            access = Access.GetInstance();
        }

        public bool ControleConnection(responsable responsable)
        {
            if(access.Manager != null)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                string req = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@pwd,256);";
                parameters.Add("@login", responsable.login);
                parameters.Add("@pwd", responsable.pwd);


                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    
                    
                    if (records != null && records.Count > 0 && records[0] != null)
                    {
                       
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                    
                }
                
            }
            return false;
        }
    }
}
