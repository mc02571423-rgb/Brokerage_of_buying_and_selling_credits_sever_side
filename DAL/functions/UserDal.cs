using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class UserDal : IUserDal
    {

        CreditContext credit;
        public UserDal(CreditContext c)
        {
            credit = c;
        }

        public bool AddUser(UsersTbl u)
        {
            try { 
            credit.UsersTbls.Add(u);
                credit.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public UsersTbl? GetUserByTz(string tz, string sisma)
        {
            try { 
            return credit.UsersTbls.FirstOrDefault(u => u.Tz == tz && u.UserSisma == sisma);
            } 
            catch { return null; }
        }
    }
}
