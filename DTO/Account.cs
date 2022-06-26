using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Account
    {
        internal string _userID { get; set; }
        internal string _password { get; set; }

        public Account(string userID, string password)
        {
            _userID = userID;
            _password = password;
        }
    }
}
