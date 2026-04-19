using AutoMapper;
using BLL.DTO;
using BLL.interfaces;
using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.functions
{
    public class UserBll:IUserBll
    {
        IMapper map;
        IUserDal uDal;
        public UserBll(IUserDal ud)
        {
            uDal = ud;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            map = config.CreateMapper();
        }

        public bool AddUser(UsersDTO user)
        {
          return uDal.AddUser(map.Map<UsersDTO, UsersTbl>(user));
           
        }

        public UsersDTO GetUserByTz(string tz)
        {
            return map.Map<UsersTbl, UsersDTO>(uDal.GetUserByTz(tz));
        }
    }
}
