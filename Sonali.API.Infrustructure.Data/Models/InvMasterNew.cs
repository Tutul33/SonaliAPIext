﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class InvMasterNew
{
    public decimal Sl { get; set; }

    public int NameId { get; set; }

    public int Quantity { get; set; }

    public double CostPrice { get; set; }

    public double MarketPrice { get; set; }

    public double? Commission { get; set; }

    public double? CommissionAmt { get; set; }

    public decimal? ProfitLoss { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
