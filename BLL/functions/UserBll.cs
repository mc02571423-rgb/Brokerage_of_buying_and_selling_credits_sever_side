using AutoMapper;
using BLL.DTO;
using BLL.interfaces;
using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                cfg.AddProfile<DTO.myMapper>();
            });
            map = config.CreateMapper();
        }

        public bool AddUser(UsersDTO user)
        {

          return uDal.AddUser(map.Map<UsersDTO, UsersTbl>(user));
           
        }

        public UsersDTO? GetUserByTz(string tz, string sisma)
        {
            try
            {
                UsersTbl user = uDal.GetUserByTz(tz, sisma);
                if(user == null)
                {
                    return null;
                }
                UsersDTO u = map.Map<UsersTbl, UsersDTO>(user);
                
                return u;
            }
            catch (Exception e)
            {
                //איך אםשר להחזיר הודעת שגיאה
                 return  new UsersDTO();
            }


            //else
            //{
            //    return new UsersDTO();
            //}
        }
        }
    }

