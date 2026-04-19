
using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICategoriesDal
    {
        public List<CategoriesTbl> GetCategories();
    }
}
