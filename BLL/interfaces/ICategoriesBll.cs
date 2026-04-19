using BLL.DTO;
using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface ICategoriesBll
    {
        public List<CategoriesDTO> GetCategories();
    }
}
