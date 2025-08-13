using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class MissingDeathClaim
{
    public int Sl { get; set; }

    public int? Fprid { get; set; }

    public double? PaidAmount { get; set; }

    public DateOnly? PaidDate { get; set; }
}
