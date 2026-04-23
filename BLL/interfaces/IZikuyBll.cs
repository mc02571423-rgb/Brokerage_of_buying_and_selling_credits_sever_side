using BLL.DTO;
using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IZikuyBll
    {
        public List<ZikuyDTO> GetCreditsByUser(string tz);
        public List<ZikuyDTO> GetCreditsForSale();
        public bool UpdateCreditForSale(string codeZ, int sum);
        public bool saleCredit (string codeZ, string tz, double sum );
    }
}
