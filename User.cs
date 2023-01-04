using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_App_WPF
{
    class User
    {
        private int id { get; set; }
        private string login, email, pass;

        public User () { }

        public User (string login, string email, string pass)
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }
    }
}
