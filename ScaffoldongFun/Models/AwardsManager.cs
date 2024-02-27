using System;
using System.Collections.Generic;

namespace ScaffoldongFun.Models;

public partial class AwardsManager
{
    public string? PlayerId { get; set; }

    public string? AwardId { get; set; }

    public int? YearId { get; set; }

    public string? LgId { get; set; }

    public string? Tie { get; set; }

    public string? Notes { get; set; }
}
