using AutoMapper;
using BLL.DTO;
using BLL.interfaces;
using DAL.db_classes;
using DAL.functions;
using DAL.interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.functions
{
    public class CategoriesBll : ICategoriesBll
    {
        IMapper map;
        ICategoriesDal catDal;
        public CategoriesBll(ICategoriesDal cd)
        {
            catDal = cd;
            var config = new MapperConfiguration(cfg =>
           { 
                cfg.AddProfile<myMapper>();
            });
            map=config.CreateMapper();
        }
        public List<CategoriesDTO> GetCategories()
        {
            return map.Map<List<CategoriesTbl>, List<CategoriesDTO>>( 
                catDal.GetCategories());
        }
    }
}
