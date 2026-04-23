using System;
using System.Collections.Generic;

namespace BLL.DTO;

public  class StoresDTO
{
    public string StoreCode { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string StoreAdress { get; set; } = null!;

    public string? CategoryCode { get; set; }

    public int MinusPercent { get; set; }

    public string? StoreLogo { get; set; }

    public string? StoreImage { get; set; }

   
}
