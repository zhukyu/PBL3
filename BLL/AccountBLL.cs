using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.DAL;
using Gym.DTO;

namespace Gym.BLL
{
    internal class AccountBLL
    {
        public static bool Login(Account account)
        {
            return AccountDAL.Login(account);
        }
        public static bool CreateAccount(Account account)
        {
            return AccountDAL.CreateAccount(account);
        }
        public static bool UpdateAccount(Account account)
        {
            return AccountDAL.UpdateAccount(account);
        }
        public static Account GetAccount(string userID)
        {
            return AccountDAL.GetAccount(userID);
        }
    }
}
