using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class responsable
    {
        /// <summary>
        /// constructeur de la classe responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public responsable(string login,string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
        public string login { get; set; }

        public string pwd { get; set; }
    }
}
