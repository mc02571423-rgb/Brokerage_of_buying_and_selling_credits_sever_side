using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IZikuyDal
    {
        public List<ZikuyTbl> GetCreditsByUser (string tz);
        public List<ZikuyTbl> GetCreditsByStore (string storeCode);
        public bool UpdateCreditForSale (string creditCode, int sum);
        public bool SaleCredit(string creditCode, string tz, double sum);
    }
}
