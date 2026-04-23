using AutoMapper;
using DAL.db_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class myMapper: Profile
    {
        public myMapper()
        {
            CreateMap<StoresTbl, StoresDTO>();
            CreateMap<UsersTbl, UsersDTO>();
            CreateMap<UsersDTO, UsersTbl>();
            CreateMap<CategoriesTbl, CategoriesDTO>();
            CreateMap<ZikuyTbl, ZikuyDTO>()
                 .ForMember(
                 x => x.priceAfterMinusPercent,
                y => y.MapFrom(
                    z => z.AmountOfCredit* (100-z.StoreCodeNavigation.MinusPercent)/100)); ;


        }
    }
}
