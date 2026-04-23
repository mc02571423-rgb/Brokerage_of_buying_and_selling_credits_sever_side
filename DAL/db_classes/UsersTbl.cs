using System;
using System.Collections.Generic;

namespace DAL.db_classes;

public partial class UsersTbl
{
    public string Tz { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserSisma { get; set; } = null!;

    public string? BankNum { get; set; }

    public string? SnifNum { get; set; }

    public string? CheshbonNum { get; set; }
}
