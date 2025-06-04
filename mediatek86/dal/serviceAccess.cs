using mediatek86.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.dal
{
    public class serviceAccess
    {
        private readonly Access access;

        public serviceAccess()
        {
            access = Access.GetInstance();
        }

        public List<service> Getservice()
        {
            List<service> services = new List<service>();
            if (access.Manager != null)
            {
                string req = "SELECT idservice,nom FROM service";
                try
                {
                    
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    foreach (Object[] record in records)
                    {
                        if (records != null)
                        {
                            service ser = new service((int)record[0], (string)record[1]);
                            services.Add(ser);
                        }
                    }
                    return services;
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
