using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FGPrenotazioni.Models
{
    [Serializable]

    public class Employee 
    {
        private string _username;
        private string _password;
        private readonly string _code;

    

        public Employee(string _username, string _password, string _code)
        {
            if (String.IsNullOrWhiteSpace(_username))
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_password) || _password.Length < 5)
                throw new ArgumentNullException();
            if (String.IsNullOrWhiteSpace(_code))
                throw new ArgumentNullException();
            this._username = _username;
            this._password = _password;
            this._code = _code;
        }

        public Employee(string _code)
        {
            if (String.IsNullOrWhiteSpace(_code))
                throw new ArgumentNullException();
            _username = "";
            _password = "";
            this._code = _code;
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
               
            }
        }
        public string Code
        {
            get
            {
                return _code;
            }
        }

    }
}
