
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
    public class ZikuyBll : IZikuyBll
    {

        IMapper map;
        IZikuyDal zDal;
        public ZikuyBll(IZikuyDal zd)
        {
            zDal = zd;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            map = config.CreateMapper();
        }



        public List<ZikuyDTO> GetCreditsByStore(string codeS)
        {
            return map.Map<List<ZikuyTbl>, List<ZikuyDTO>>(
                zDal.GetCreditsByStore(codeS));
        }

        public List<ZikuyDTO> GetCreditsByUser(string tz)
        {
            return map.Map<List<ZikuyTbl>, List<ZikuyDTO>>(
                zDal.GetCreditsByUser(tz));
        }

        public bool saleCredit(string codeZ, string tz, double sum)
        {
            return zDal.SaleCredit(codeZ, tz, sum);
        }

        public bool UpdateCreditForSale(string codeZ,  int sum)
        {
            return zDal.UpdateCreditForSale(codeZ, sum);
        }
    }
}
