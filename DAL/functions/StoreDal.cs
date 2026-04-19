using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class StoreDal : IStoreDal
    {
        CreditContext credit;
        public StoreDal(CreditContext credit)
        {
            this.credit = credit;
        }

        public List<StoresTbl> GetAllStores()
        {
            try
            {
                return credit.StoresTbls.ToList();
            }
            catch { return null; }
        }
    }
}
