using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class MemberBLL
    {
        public static List<Member> GetAllMembers()
        {
            return CustomerDAL.GetAllMembers();
        }
        public static List<Member> SearchMember(string str)
        {
            return CustomerDAL.SearchMember(str);
        }
    }
}
