using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.Model
{
    public class responsable
    {
        public responsable(string login,string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
        public string login { get; set; }

        public string pwd { get; set; }
    }
}
