using System;
using System.Collections.Generic;

namespace DAL.db_classes;

public partial class CategoriesTbl
{
    public string CategoryCode { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<StoresTbl> StoresTbls { get; set; } = new List<StoresTbl>();
}
