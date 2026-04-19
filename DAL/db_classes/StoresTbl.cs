using System;
using System.Collections.Generic;

namespace DAL.db_classes;

public partial class StoresTbl
{
    public string StoreCode { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string StoreAdress { get; set; } = null!;

    public string? CategoryCode { get; set; }

    public int MinusPercent { get; set; }

    public string? StoreLogo { get; set; }

    public string? StoreImage { get; set; }

    public virtual CategoriesTbl? CategoryCodeNavigation { get; set; }

    public virtual ICollection<ZikuyTbl> ZikuyTbls { get; set; } = new List<ZikuyTbl>();
}
