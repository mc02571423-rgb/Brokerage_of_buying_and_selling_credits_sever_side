using System;
using System.Collections.Generic;

namespace BLL.DTO;

public  class ZikuyDTO
{
    public string CreditCode { get; set; } = null!;

    public string? StoreCode { get; set; }

    public string OwnerTz { get; set; } = null!;

    public int AmountOfCredit { get; set; }

    public DateTime UseBefore { get; set; }

    public string? Picture { get; set; }

    public int StatusCredit { get; set; }

    
    public double priceAfterMinusPercent { get; set; }

}
