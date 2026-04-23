using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.db_classes;

namespace DAL.interfaces
{
    public interface IUserDal
    {
        public UsersTbl? GetUserByTz (string tz,string sisma);
        public bool AddUser (UsersTbl u);
    }
}
