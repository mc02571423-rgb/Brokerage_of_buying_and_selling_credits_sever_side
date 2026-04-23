using BLL.DTO;
//using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IUserBll
    {
        public UsersDTO? GetUserByTz (string tz, string sisma);
        public bool AddUser (UsersDTO user);
    }
}
