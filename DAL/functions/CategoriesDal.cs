using DAL.db_classes;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.functions
{
    public class CategoriesDal : ICategoriesDal
    {
        CreditContext credit;
        public CategoriesDal(CreditContext credit)
        {
            this.credit = credit;
        }

        public List<CategoriesTbl> GetCategories()
        {
         return credit.CategoriesTbls.ToList();
        }
    }
}
