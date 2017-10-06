using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_login_learn
{
    class CUser
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        string _password;
        string _Email;

        public CUser(string user,string pass ,string email)
        {
            _userName = user;
            _password = pass;
            _Email = email;
        }
    }
}
