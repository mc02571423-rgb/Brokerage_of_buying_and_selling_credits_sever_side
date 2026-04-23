using System;
using System.Collections.Generic;

namespace DAL.db_classes;

public partial class ZikuyTbl
{
    public string CreditCode { get; set; } = null!;

    public string? StoreCode { get; set; }

    public string OwnerTz { get; set; } = null!;

    public double AmountOfCredit { get; set; }

    public DateTime UseBefore { get; set; }

    public double? SaleSum { get; set; }

    public string? Picture { get; set; }

    public int StatusCredit { get; set; }

    public virtual StoresTbl? StoreCodeNavigation { get; set; }
}
