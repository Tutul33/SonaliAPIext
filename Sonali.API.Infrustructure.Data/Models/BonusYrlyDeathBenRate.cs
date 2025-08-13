﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class BonusYrlyDeathBenRate
{
    public int Sl { get; set; }

    public int? Age { get; set; }

    public double? Rate { get; set; }

    public int? Status { get; set; }

    public int? RelationId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
