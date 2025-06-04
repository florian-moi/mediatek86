using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.bddManager;

namespace mediatek86.dal
{
    public class Access
    {
        private static readonly String connection = "Server=localhost;DataBase=mediatek;User=root;PassWord=";

        private static Access instance = null;

        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connection);
            }
            catch (Exception)
            {
                Environment.Exit(0);

            }
        }

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
