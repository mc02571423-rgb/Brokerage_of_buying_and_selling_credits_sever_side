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
    public class StoresBll:IStoresBll
    {
        IMapper map;
        IStoreDal stDal;
        public StoresBll(IStoreDal sd)
        {
            stDal = sd;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.myMapper>();
            });
            map = config.CreateMapper();
        }

        public List<StoresDTO> GetAllStores()
        {
            return map.Map<List<StoresTbl>, List<StoresDTO>>(
                stDal.GetAllStores());
        }
    }
}
