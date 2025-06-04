using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.bddManager;

namespace mediatek86.dal
{
    ///<summary>
    /// Classe d'accès aux données, Singleton pour la gestion de la connexion à la base de données.
    /// </summary>
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
        /// <summary>
        /// Retourne l'instance unique de la classe Access (Singleton).
        /// </summary>
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
