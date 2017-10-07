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
        /// <summary>
        /// الأمة العربية المتحدة !!
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public CUser(string user,string pass ,string email)
        {
            _userName = user;
            _password = pass;
            _Email = email;
        }
    }
}
