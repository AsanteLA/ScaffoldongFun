﻿using System;
using System.Collections.Generic;

namespace ScaffoldongFun.Models;

public partial class Manager
{
    public string? PlayerId { get; set; }

    public int? YearId { get; set; }

    public string? TeamId { get; set; }

    public string? LgId { get; set; }

    public int? Inseason { get; set; }

    public int? G { get; set; }

    public int? W { get; set; }

    public int? L { get; set; }

    public int? Rank { get; set; }

    public string? PlyrMgr { get; set; }
}
