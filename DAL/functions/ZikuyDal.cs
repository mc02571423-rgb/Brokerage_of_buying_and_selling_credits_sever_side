using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class ZikuyDal : IZikuyDal
    {

        CreditContext credit;
        public ZikuyDal(CreditContext credit)
        {
            this.credit = credit;
        }

        public List<ZikuyTbl> GetCreditsForSale()
        {
            return credit.ZikuyTbls.Where(z=> z.StatusCredit == 2).ToList();   
        }

        public List<ZikuyTbl> GetCreditsByUser(string tz)
        {
            return credit.ZikuyTbls.Where(z => z.OwnerTz == tz).ToList();
        }

        public bool SaleCredit(string creditCode, string tz, double sum)
        {
            try { 
            ZikuyTbl? z = credit.ZikuyTbls.FirstOrDefault(z => z.CreditCode == creditCode);
            z.OwnerTz=tz;
            z.AmountOfCredit=sum;
            z.StatusCredit = 3;
            credit.SaveChanges();
            return true;
            }
            catch { return false; }
        }

        public bool UpdateCreditForSale(string creditCode, int sum)
        {
            try { 
            ZikuyTbl? z = credit.ZikuyTbls.FirstOrDefault(z => z.CreditCode == creditCode);
            z.StatusCredit = 2;
           // z.SaleSum=sum;
           credit.SaveChanges();
            return true;
            } catch { return false; }
        }
    }
}
