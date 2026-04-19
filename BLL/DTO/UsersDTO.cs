using System;
using System.Collections.Generic;

namespace BLL.DTO;

public  class UsersDTO
{
    public string Tz { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserSisma { get; set; } = null!;

    public string? BankNum { get; set; }

    public string? SnifNum { get; set; }

    public string? CheshbonNum { get; set; }
}
